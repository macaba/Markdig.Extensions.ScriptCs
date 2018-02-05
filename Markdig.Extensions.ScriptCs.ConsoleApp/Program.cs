using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Markdig;
using Markdig.Extensions.ScriptCs;
using Markdig.SyntaxHighlighting;

namespace Markdig.Extensions.ScriptCs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string markdownText = System.IO.File.ReadAllText("input.md");
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().UseSyntaxHighlighting().UseScriptCs(new ScriptCsOptions() { ExceptionStackTrace = false }).Build();
            string html = Markdown.ToHtml(markdownText, pipeline);
            System.IO.File.WriteAllText("output.htm", StringConstants.Header + html + StringConstants.Footer);
        }
    }
}
