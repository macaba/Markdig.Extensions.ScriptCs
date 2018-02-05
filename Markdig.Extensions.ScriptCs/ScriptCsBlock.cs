using Markdig.Parsers;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsBlock : FencedCodeBlock
    {
        public ScriptCsBlock(BlockParser parser) : base(parser)
        {
        }

        public string GetScript()
        {
            if (Lines.Count > 0)
            {
                return string.Join(Environment.NewLine, Lines);
            }
            else
                return "";
        }
    }
}
