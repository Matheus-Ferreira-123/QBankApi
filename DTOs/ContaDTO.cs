namespace QBankApi.DTOs
{
    public class ContaDTO
    {
        public int Id { get; set; }
        public int Saldo { get; set;}
        public string Name { get; set; } = null;
        public string email { get; set; } = null;
    }
}