using Markdig.Syntax.Inlines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsInline : LeafInline
    {
        public string Script { get; set; }
    }
}
