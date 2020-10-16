using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class NobodyHomeException : Exception
    {
        public NobodyHomeException(string reason) : base(reason) { 
        }
      
    }
}
