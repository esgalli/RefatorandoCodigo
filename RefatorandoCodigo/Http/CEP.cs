using RefatorandoCodigo.Http.Exceptions;
using RefatorandoCodigo.Validation;
using System;
using System.Text.RegularExpressions;

namespace RefatorandoCodigo.Http
{
    public class CEP : IComparable<CEP>, IEquatable<CEP>
    {
        protected static string RegexFormatted => DocumentFormats.CEP;
        protected static string RegexUnformatted => DocumentFormats.CEPDigitsOnly;

        private readonly string cepAsString;

        public CEP() : this(null) { }

        public CEP(string cepAsString)
        {
            string unformatCEP = cepAsString.Replace("-", "");

            if (cepAsString == null)
                this.cepAsString = null;
            else if (Regex.IsMatch(cepAsString, RegexFormatted))
                this.cepAsString = unformatCEP;
            else if (new Regex(RegexUnformatted).IsMatch(cepAsString))
                this.cepAsString = cepAsString;
            else
                throw new InvalidZipCodeFormat();
        }
                
        public bool IsNull => string.IsNullOrEmpty(cepAsString);

        public int CompareTo(CEP other)
        {
            return this.cepAsString.CompareTo(other);
        }

        public override int GetHashCode()
        {
            return cepAsString.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.cepAsString.Equals((CEP)obj);
        }

        public bool Equals(CEP other)
        {
            return this.cepAsString.Equals(other);
        }

        public static implicit operator string(CEP cep) => cep.cepAsString;
        public static implicit operator CEP(string cepAsString) => new CEP(cepAsString);
    }
}
