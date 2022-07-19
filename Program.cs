namespace EjemploDeClase
{
    public class ProbarObjetos
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> menuPorSecciones
                = new Dictionary<string, Dictionary<string, double>>();

            menuPorSecciones.Add("Bebidas sin alcohol", new Dictionary<string, double>
            {
                {"Jugos   ", 90 },
                {"Gaseosas", 85 },
                {"Agua    ", 95 }
            });

            menuPorSecciones.Add("Bebidas aclholicas", new Dictionary<string, double>
            {
                {"Daikiris", 91 },
                {"Vinos   ", 86 },
                {"Cerveza ", 96 }
            });

            Console.WriteLine("Seccion\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in menuPorSecciones)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYPrecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYPrecio.Key.ToUpper(), productoYPrecio.Value);
                }
            }
        }
    }
}
