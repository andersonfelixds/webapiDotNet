namespace webapi.Models
{
    public class CalculaJuros
    {
        public double ValorInicial { get; set; }
        public TaxaJuros Juros { get; set; }
        public double ValorFinal { get; set; }
    }
}