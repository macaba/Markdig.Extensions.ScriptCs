using Markdig.Renderers;
using Markdig.Renderers.Html;
using ScriptCs;
using System;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsInlineRenderer : HtmlObjectRenderer<ScriptCsInline>
    {
        private ScriptCsRenderer scriptCsRenderer;

        public ScriptCsInlineRenderer(ScriptExecutor scriptExecutor, MarkdownPipeline pipeline, ScriptCsOptions options)
        {
            scriptCsRenderer = new ScriptCsRenderer(scriptExecutor, pipeline, options);
        }

        protected override void Write(HtmlRenderer renderer, ScriptCsInline obj)
        {
            scriptCsRenderer.Write(renderer, obj.Script, true);
        }
    }
}
