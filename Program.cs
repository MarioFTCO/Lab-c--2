namespace Factura;
internal class Program
{
    private static void Main(string[] args)
    {
        static List<Factura> LeerArchivo(string nombreArchivo)
        {
            List<Factura> facturas = new List<Factura>();
            string[] lineas = nombreArchivo.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            //crea una matriz de cadenas que contiene el carácter de nueva línea
            //Esto se utiliza como el delimitador para el método Split.
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');
                Factura factura = new Factura
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
        string txt = File.ReadAllText(@"C:\Users\USER\OneDrive\Documentos\Visual Studio 2022\Proyectos\Taller3 c#\Taller3 c#\bin\Debug\net8.0\Laboratorio.txt");
        List<Factura> facturas = LeerArchivo(txt);

        // 1. ¿Cuáles son las facturas que fueron pagadas en el mes de Enero?
        Console.WriteLine("Facturas pagadas en Enero:");
        foreach (Factura factura in facturas)
        {
            if (factura.Mes == "Enero" && factura.Pagada == "SI")
            {
                Console.WriteLine($"Número: {factura.Numero}");
            }
        }

        // 2. ¿Cuál es el total de Facturas pagadas?
        int totalFacturasPagadas = 0;
        foreach (Factura factura in facturas)
        {
            if (factura.Pagada == "SI")
            {
                totalFacturasPagadas++;
            }
        }
        Console.WriteLine($"Total de Facturas pagadas: {totalFacturasPagadas}");

        // 3. ¿Cuál es el total de Facturas NO pagadas?
        int totalFacturasNoPagadas = facturas.Count - totalFacturasPagadas;
        Console.WriteLine($"Total de Facturas NO pagadas: {totalFacturasNoPagadas}");

        // 4. ¿Cuáles fueron las facturas pagadas en el primer semestre (enero, febrero, marzo, abril, mayo, junio)?
        Console.WriteLine("Facturas pagadas en el primer semestre:");
        foreach (Factura factura in facturas)
        {
            if (factura.Pagada == "SI" && (factura.Mes == "Enero" || factura.Mes == "Febrero" || factura.Mes == "Marzo" || factura.Mes == "Abril" || factura.Mes == "Mayo" || factura.Mes == "Junio"))
            {
                Console.WriteLine($"Número: {factura.Numero}");
            }
        }

        // 5. ¿Cuáles fueron las facturas pagadas en el segundo semestre (julio, agosto, septiembre, octubre, noviembre, diciembre)?
        Console.WriteLine("Facturas pagadas en el segundo semestre:");
        foreach (Factura factura in facturas)
        {
            if (factura.Pagada == "SI" && (factura.Mes == "Julio" || factura.Mes == "Agosto" || factura.Mes == "Septiembre" || factura.Mes == "Octubre" || factura.Mes == "Noviembre" || factura.Mes == "Diciembre"))
            {
                Console.WriteLine($"Número: {factura.Numero}");
            }
        }
    }

}      