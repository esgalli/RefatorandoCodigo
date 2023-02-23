using System.Threading.Tasks;

namespace RefatorandoCodigo.Http
{
    public interface IViaCEPClient
    {
        string GetEndereco(string cep, string outputType);
        Task<string> GetEnderecoAsync(string cep, string outputType);
    }
}