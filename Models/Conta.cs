
namespace QBankApi.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int Saldo { get; set;}
        public string Name { get; set; } = null;
        public string email { get; set; } = null;
    }
}