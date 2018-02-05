using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class HtmlReportObject
    {
        public string Html { get; set; }
    }

    public class MarkdownReportObject
    {
        public string Markdown { get; set; }
    }

    public class MarkdownDocument
    {
        private static readonly Lazy<MarkdownDocument> lazy = new Lazy<MarkdownDocument>(() => new MarkdownDocument());

        public static MarkdownDocument Instance { get { return lazy.Value; } }

        private MarkdownDocument() { }

        public object ReportObject { get; private set; }

        public void InsertHtml(string html)
        {
            ReportObject = new HtmlReportObject() { Html = html };
        }

        public void InsertMarkdown(string markdown)
        {
            ReportObject = new MarkdownReportObject() { Markdown = markdown };
        }

        public void Reset()
        {
            ReportObject = null;
        }
    }
}
