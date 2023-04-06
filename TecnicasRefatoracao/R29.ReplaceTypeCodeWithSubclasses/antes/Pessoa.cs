using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao.R29.ReplaceTypeCodeWithSubclasses.antes
{
    class program
    {
        void main()
        {
            Pessoa pessoa = new Pessoa();
            PessoaFisica pf = new PessoaFisica();


            

        }

    }

    public class Pessoa
    {
        public string nome { get; set; }  
        public DateTime nascimento{ get; set; }   

    }

    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; } 
        public string rg { get; set; }  

    }

    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        public string ie { get; set; }
    }

}
