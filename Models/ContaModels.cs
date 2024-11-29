
namespace QBankApi.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int Saldo { get; set;}
        public string NomeCliente { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
    }   
}