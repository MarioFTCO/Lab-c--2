internal static class MethodsHelpers
{
    public static List<Factura.Factura> LeerArchivo(string nombreArchivo)
    {
        List<Factura.Factura> facturas = new List<Factura.Factura>();
        string[] lineas = nombreArchivo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        //crea una matriz de cadenas que contiene el carácter de nueva línea
        //Esto se utiliza como el delimitador para el método Split.
        foreach (string linea in lineas)
        {
            string[] datos = linea.Split(';');
            Factura.Factura factura = new Factura.Factura
            {
                Numero = datos[0],
                Subtotal = decimal.Parse(datos[1]),
                IVA = decimal.Parse(datos[2]),
                Total = decimal.Parse(datos[3]),
                Mes = datos[4],
                Pagada = datos[5]
            };
            facturas.Add(factura);
        }
        return facturas;
    }
}