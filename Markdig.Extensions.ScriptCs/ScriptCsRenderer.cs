using Markdig.Renderers;
using ScriptCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsRenderer
    {
        private ScriptExecutor scriptExecutor;
        private MarkdownPipeline pipeline;
        private ScriptCsOptions options;

        public ScriptCsRenderer(ScriptExecutor scriptExecutor, MarkdownPipeline pipeline, ScriptCsOptions options)
        {
            this.scriptExecutor = scriptExecutor;
            this.pipeline = pipeline;
            this.options = options;
        }

        public void Write(HtmlRenderer renderer, string script, bool inline)
        {
            if (!string.IsNullOrWhiteSpace(script))
            {
                if (renderer.EnableHtmlForInline || !inline)
                {
                    var fullScript = script;

                    var result = scriptExecutor.ExecuteScript(fullScript);
                    if (result.CompileExceptionInfo != null)
                    {
                        renderer.Write(Markdown.ToHtml(BuildMarkdownExceptionMessage(result.CompileExceptionInfo.SourceException, options.ExceptionStackTrace), pipeline));
                    }

                    if (MarkdownDocument.Instance.ReportObject != null)
                    {
                        if (MarkdownDocument.Instance.ReportObject is HtmlReportObject)
                        {
                            renderer.Write(((HtmlReportObject)MarkdownDocument.Instance.ReportObject).Html);
                        }
                        else if (MarkdownDocument.Instance.ReportObject is MarkdownReportObject)
                        {
                            var markdown = Markdown.ToHtml(((MarkdownReportObject)MarkdownDocument.Instance.ReportObject).Markdown, pipeline);
                            if (inline)
                            {
                                if (markdown.StartsWith("<p>"))
                                    markdown = markdown.Substring(3);
                                if (markdown.EndsWith("</p>\n"))
                                    markdown = markdown.Substring(0, markdown.Length - 5);
                            }

                            renderer.Write(markdown);
                        }
                    }
                    MarkdownDocument.Instance.Reset();
                }
                else
                {
                    renderer.Write(script);
                }
            }
        }

        public string BuildMarkdownExceptionMessage(Exception exception, bool stackTrace)
        {
            string message = "```" + Environment.NewLine + "ScriptCs exception:" + Environment.NewLine + exception.Message;
            if (stackTrace)
            {
                message = message + Environment.NewLine;
                message = message + exception.StackTrace;
            }
            message = message + Environment.NewLine + "```" + Environment.NewLine;
            return message;
        }
    }
}
