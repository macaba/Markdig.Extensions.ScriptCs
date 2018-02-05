using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Syntax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsInlineParser : InlineParser
    {
        public ScriptCsInlineParser()
        {
            OpeningCharacters = "`".ToCharArray();
        }


        public override bool Match(InlineProcessor processor, ref StringSlice slice)
        {
            if (slice.PeekCharExtra(1) != 'S' ||
                slice.PeekCharExtra(2) != 'c' ||
                slice.PeekCharExtra(3) != 'r' ||
                slice.PeekCharExtra(4) != 'i' ||
                slice.PeekCharExtra(5) != 'p' ||
                slice.PeekCharExtra(6) != 't' ||
                slice.PeekCharExtra(7) != 'C' ||
                slice.PeekCharExtra(8) != 's' ||
                slice.PeekCharExtra(9) != ' ')
            {
                return false;
            }

            var content = String.Empty;
            var issue = String.Empty;
            char current;
            int counter = 1;    //Account for the `
            bool loop = true;

            for (int i = 0; i < slice.End && loop; i++)
            {
                current = slice.NextChar();
                counter++;

                if (current == '`')
                {
                    loop = false;
                }
                else
                {
                    content += current;
                }
            }
            slice.NextChar();
            counter++;
            int line;
            int column;
            processor.Inline = new ScriptCsInline() { Script = content.Substring(9) };
            processor.Inline.Span = new SourceSpan() { Start = processor.GetSourcePosition(slice.Start, out line, out column) };
            processor.Inline.Line = line;
            processor.Inline.Span.End = processor.Inline.Span.Start + counter;
            return true;
        }
    }
}
