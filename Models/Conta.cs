
namespace QBankApi.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int Saldo { get; set;}
        public string NomeCliente { get; set; } = null;
        public string Cpf { get; set; } = null;
    }
}