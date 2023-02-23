using RefatorandoCodigo.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefatorandoCodigo.Format
{
    public class TituloEleitoralFormatter : BaseFormatter
    {
        public TituloEleitoralFormatter()
            : base(DocumentFormats.TituloEleitoral, "$1/$2", DocumentFormats.TituloEleitoralUnformatted, "$1$2")
        {
        }
    }
}
