using Markdig.Helpers;
using Markdig.Parsers;
using Markdig.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsBlockParser : FencedBlockParserBase<ScriptCsBlock>
    {
        public ScriptCsBlockParser()
        {
            OpeningCharacters = new[] { '`' };
            InfoPrefix = "ScriptCs";
            InfoParser = ScriptCsInfoParser;
        }

        protected override ScriptCsBlock CreateFencedBlock(BlockProcessor processor)
        {
            var block = new ScriptCsBlock(this);
            return block;
        }

        public static bool ScriptCsInfoParser(BlockProcessor state, ref StringSlice line, IFencedBlock fenced)
        {
            string infoString;
            string argString = null;

            var c = line.CurrentChar;
            // An info string cannot contain any backsticks
            int firstSpace = -1;
            for (int i = line.Start; i <= line.End; i++)
            {
                c = line.Text[i];
                if (c == '`')
                {
                    return false;
                }

                if (firstSpace < 0 && c.IsSpaceOrTab())
                {
                    firstSpace = i;
                }
            }

            if (firstSpace > 0)
            {
                infoString = line.Text.Substring(line.Start, firstSpace - line.Start).Trim();

                // Skip any spaces after info string
                firstSpace++;
                while (true)
                {
                    c = line[firstSpace];
                    if (c.IsSpaceOrTab())
                    {
                        firstSpace++;
                    }
                    else
                    {
                        break;
                    }
                }

                argString = line.Text.Substring(firstSpace, line.End - firstSpace + 1).Trim();
            }
            else
            {
                infoString = line.ToString().Trim();
            }

            if (infoString != "ScriptCs")
                return false;

            fenced.Info = HtmlHelper.Unescape(infoString);
            fenced.Arguments = HtmlHelper.Unescape(argString);

            return true;
        }
    }
}
