using RefatorandoCodigo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefatorandoCodigo.Format
{
    public class CEPFormatter : BaseFormatter
    {
        public CEPFormatter() 
            : base(DocumentFormats.CEP, "$1-$2", DocumentFormats.CEPUnformatted, "$1$2")
        {
        }
    }
}
