using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markdig.Extensions.ScriptCs
{
    public class ScriptCsOptions
    {
        public bool ExceptionStackTrace { get; set; }

        public ScriptCsOptions()
        {
            ExceptionStackTrace = true;
        }
    }
}
