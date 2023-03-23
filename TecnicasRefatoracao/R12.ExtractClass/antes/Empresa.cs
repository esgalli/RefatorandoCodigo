using refatoracao.R13.InlineClass.antes;
using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R12.ExtractClass.antes
{
    class Empresa
    {
        public Empresa(RazaoSocial razaoSocial, CNPJ cnpj, string endEntregaLogradouro, string endEntregaNumero, string endEntregaComplemento, string endEntregaBairro, string endEntregaCEP, string endEntregaMunicipio, string endEntregaUF, string endComercialLogradouro, string endComercialNumero, string endComercialComplemento, string endComercialBairro, string endComercialCEP, string endComercialMunicipio, string endComercialUF)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            EndEntregaLogradouro = endEntregaLogradouro;
            EndEntregaNumero = endEntregaNumero;
            EndEntregaComplemento = endEntregaComplemento;
            EndEntregaBairro = endEntregaBairro;
            EndEntregaCEP = endEntregaCEP;
            EndEntregaMunicipio = endEntregaMunicipio;
            EndEntregaUF = endEntregaUF;
            EndComercialLogradouro = endComercialLogradouro;
            EndComercialNumero = endComercialNumero;
            EndComercialComplemento = endComercialComplemento;
            EndComercialBairro = endComercialBairro;
            EndComercialCEP = endComercialCEP;
            EndComercialMunicipio = endComercialMunicipio;
            EndComercialUF = endComercialUF;
        }

        public RazaoSocial RazaoSocial { get; private set; }

        public CNPJ CNPJ { get; private set; }

        public string EndEntregaLogradouro { get; private set; }
        public string EndEntregaNumero { get; private set; }
        public string EndEntregaComplemento { get; private set; }
        public string EndEntregaBairro { get; private set; }
        public string EndEntregaCEP { get; private set; }
        public string EndEntregaMunicipio { get; private set; }
        public string EndEntregaUF { get; private set; }

        public string EndComercialLogradouro { get; private set; }
        public string EndComercialNumero { get; private set; }
        public string EndComercialComplemento { get; private set; }
        public string EndComercialBairro { get; private set; }
        public string EndComercialCEP { get; private set; }
        public string EndComercialMunicipio { get; private set; }
        public string EndComercialUF { get; private set; }

        public string GetTextoEnderecoComercial()
        {
            return $"Endereço: {EndComercialLogradouro} {EndComercialNumero} {EndComercialComplemento} - {EndComercialBairro} - CEP {EndComercialCEP} - {EndComercialMunicipio} - {EndComercialUF}";
        }

        public string GetTextoEnderecoEntrega()
        {
            return $"Endereço: {EndEntregaLogradouro} {EndEntregaNumero} {EndEntregaComplemento} - {EndEntregaBairro} - CEP {EndEntregaCEP} - {EndEntregaMunicipio} - {EndEntregaUF}";
        }

        public void UpdateEnderecoEntrega(string endEntregaLogradouro, string endEntregaNumero, string endEntregaComplemento, string endEntregaBairro, string endEntregaCEP, string endEntregaMunicipio, string endEntregaUF)
        {
            EndEntregaLogradouro = endEntregaLogradouro;
            EndEntregaNumero = endEntregaNumero;
            EndEntregaComplemento = endEntregaComplemento;
            EndEntregaBairro = endEntregaBairro;
            EndEntregaCEP = endEntregaCEP;
            EndEntregaMunicipio = endEntregaMunicipio;
            EndEntregaUF = endEntregaUF;
        }

        public void UpdateEnderecoComercial(string endComercialLogradouro, string endComercialNumero, string endComercialComplemento, string endComercialBairro, string endComercialCEP, string endComercialMunicipio, string endComercialUF)
        {
            EndComercialLogradouro = endComercialLogradouro;
            EndComercialNumero = endComercialNumero;
            EndComercialComplemento = endComercialComplemento;
            EndComercialBairro = endComercialBairro;
            EndComercialCEP = endComercialCEP;
            EndComercialMunicipio = endComercialMunicipio;
            EndComercialUF = endComercialUF;
        }
    }
    class CNPJ
    {
        public string Codigo { get; private set; }

        public CNPJ(string codigo)
        {
            this.Codigo = codigo;
        }
    }

    class RazaoSocial
    {
        public string Nome { get; private set; }

        public RazaoSocial(string nome)
        {
            Nome = nome;
        }
    }
}
