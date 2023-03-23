using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefatorandoCodigo.Inwords
{
    public class Numeroold
    {

        protected readonly double numeroOrigem;
        public Numeroold(double numeroOrigem)
        {
            this.numeroOrigem = PreparaNumeroOrigem(numeroOrigem);
        }

        /// <summary>
        /// Transforma um número em sua representação por extenso, em português.
        /// </summary>
        /// <param name="numeroOrigem">número a ser transformado</param>
        /// <returns></returns>
        public virtual string Extenso()
        {
            GrupoDe3Digitos grupo = GetGrupoPrincipal(numeroOrigem);

            return grupo.Extenso();
        }

        protected virtual double PreparaNumeroOrigem(double numeroOrigem)
        {
            numeroOrigem = Math.Round(numeroOrigem);
            return numeroOrigem;
        }

        GrupoDe3Digitos GetGrupoPrincipal(double numeroOrigem)
        {
            double numero = numeroOrigem;

            double posicao = 1;
            GrupoDe3Digitos grupo = null;

            while(true)
            {
                grupo = new GrupoDe3Digitos((long)(numero % (double)1000), posicao, grupo);
                posicao++;
                numero /= 1000;
                if (numero <= 0)
                {
                    break;
                }                    
            }
            
            return grupo;
        }
    }
}
