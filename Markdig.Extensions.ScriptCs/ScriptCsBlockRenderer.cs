using Markdig.Renderers;
using Markdig.Renderers.Html;
using Markdig.Syntax;
using ScriptCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsBlockRenderer : HtmlObjectRenderer<ScriptCsBlock>
    {
        private ScriptCsRenderer scriptCsRenderer;

        public ScriptCsBlockRenderer(ScriptExecutor scriptExecutor, MarkdownPipeline pipeline, ScriptCsOptions options)
        {
            scriptCsRenderer = new ScriptCsRenderer(scriptExecutor, pipeline, options);
        }

        protected override void Write(HtmlRenderer renderer, ScriptCsBlock obj)
        {
            scriptCsRenderer.Write(renderer, obj.GetScript(), false);
        }
    }
}
