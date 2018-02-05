using Markdig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markdig.Renderers;
using Markdig.Syntax;
using Markdig.Renderers.Html;

using ScriptCs;
using ScriptCs.Contracts;
using ScriptCs.Hosting;
//using ScriptCs.Engine.Mono;
using ScriptCs.Engine.Roslyn;
using Markdig.Parsers;
using Markdig.Helpers;
using Markdig.Extensions.GenericAttributes;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsExtension : IMarkdownExtension
    {
        private readonly ScriptCsOptions options;
        private readonly ScriptServices scriptServices;
        private readonly ScriptExecutor scriptExecutor;

        public ScriptCsExtension(ScriptCsOptions options)
        {
            this.options = options;

            var console = (IConsole)new ScriptConsole();
            var logProvider = new ColoredConsoleLogProvider(LogLevel.Info, console);

            var builder = new ScriptServicesBuilder(console, logProvider);

            //var useMono = Type.GetType("Mono.Runtime") != null;
            //if (useMono)
            //{
            //    builder.ScriptEngine<MonoScriptEngine>();
            //}
            //else {
                builder.ScriptEngine<CSharpScriptEngine>();
            //}

            scriptServices = builder.Build();

            scriptExecutor = (ScriptExecutor)scriptServices.Executor;
            scriptExecutor.Initialize(Enumerable.Empty<string>(), Enumerable.Empty<IScriptPack>());
        }

        public void Setup(MarkdownPipelineBuilder pipeline)
        {
            // Adds the inline parser
            if (!pipeline.InlineParsers.Contains<ScriptCsInlineParser>())
            {
                pipeline.InlineParsers.Insert(0, new ScriptCsInlineParser());
            }

            // Adds the block parser
            if (!pipeline.BlockParsers.Contains<ScriptCsBlockParser>())
            {
                pipeline.BlockParsers.Insert(0, new ScriptCsBlockParser());
            }
        }

        public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
        {
            HtmlRenderer htmlRenderer;
            ObjectRendererCollection renderers;

            htmlRenderer = renderer as HtmlRenderer;
            renderers = htmlRenderer?.ObjectRenderers;

            if (renderers != null && !renderers.Contains<ScriptCsInlineRenderer>())
            {
                renderers.Insert(0, new ScriptCsInlineRenderer(scriptExecutor, pipeline, options));
            }

            if (renderers != null && !renderers.Contains<ScriptCsBlockRenderer>())
            {
                renderers.Insert(0, new ScriptCsBlockRenderer(scriptExecutor, pipeline, options));
            }
        }
    }

    /// <summary>
    /// Add a extension method to add the extension to the pipeline
    /// </summary>
    public static class ScriptCsExtensionFunctions
    {
        public static MarkdownPipelineBuilder UseScriptCs(this MarkdownPipelineBuilder pipeline, ScriptCsOptions options)
        {
            if (!pipeline.Extensions.Contains<ScriptCsExtension>())
            {
                pipeline.Extensions.Add(new ScriptCsExtension(options));
            }
            return pipeline;
        }
    }
}