namespace Factura
{
    internal class Factura
    {
        public string Numero { get; set; }
        public decimal Subtotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public string Mes { get; set; }
        public string Pagada { get; set; }
    }
}
