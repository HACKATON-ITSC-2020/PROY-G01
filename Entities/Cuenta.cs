namespace Entities
{
    public class Cuenta
    {
        public int Id { get; set; }
        public int NroCuenta { get; set; }
        public int CVU { get; set; }
        public string Alias { get; set; }
        public int TitularId { get; set; }
        public decimal SaldoCC { get; set; }
        public decimal SaldoCH { get; set; }
        public decimal LimiteDescubierto { get; set; }
    }
}