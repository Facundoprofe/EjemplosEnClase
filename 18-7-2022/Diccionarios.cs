using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase
{
    public class Arrays
    {
        void Ejemplo()
        {
            // ejemplo de array de strings

            string[] razasDePerrosArray = { "Bulldog", "Pequines", "Pastor Aleman", "Salchicha", "Caniche" };

            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                string perroAMostrar = razasDePerrosArray[i];
                Console.WriteLine(perroAMostrar);
            }
            // ejemplo de arrays
            //EjemploDeProducto[] bebidasGaseosas = {
            //    new EjemploDeProducto(1,"Coca-cola", 23, 32, "Gaseosa"),
            //    new EjemploDeProducto(2,"7UP", 26, 31, "Gaseosa"),
            //    new EjemploDeProducto(3,"Manaos-cola", 24, 17, "Gaseosa"),
            //    new EjemploDeProducto(4,"Paso de los toros", 25, 30, "Gaseosa"),
            //};

            //EjemploDeProducto bebidaMasCara = new EjemploDeProducto();

            //foreach (EjemploDeProducto bebida in bebidasGaseosas)
            //{
            //    if (bebida.PrecioDeCompra > bebidaMasCara.PrecioDeCompra)
            //    {
            //        bebidaMasCara = bebida;
            //    }
            //}

            //Console.WriteLine("La bebida comprada mas cara es:{0}", bebidaMasCara.Descripcion);
        }
    }

    public class Diccionarios
    {
        void Ejemplo()
        {
            //ejemplo de diccionario
            Dictionary<string, string> ciudadesXPaises = new Dictionary<string, string>();
            Dictionary<string, string[]> diccionarioConMasDeUnValue = new Dictionary<string, string[]>();

            ciudadesXPaises.Add("Bucaramanga", "Chile");
            ciudadesXPaises.Add("Bogota", "Colombia");
            ciudadesXPaises.Add("Sucre", "Bolivia");
            ciudadesXPaises.Add("Lima", "Bolivia");
            ciudadesXPaises.Add("Mexico DF", "Mexico");
            ciudadesXPaises.Add("Montevideo", "Uruguay");
            ciudadesXPaises.Add("Asuncion", "Paraguay");

            Console.WriteLine("Las ciudades por paises antes del uso de propiedades son:");
            foreach (KeyValuePair<string, string> ciudadYPais in ciudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYPais.Key, ciudadYPais.Value);
            }

            ciudadesXPaises.Remove("Buenos Aires");
            ciudadesXPaises["Lima"] = "Peru";

            Console.WriteLine("Las ciudades por paises Despues del uso de propiedades son:");
            foreach (KeyValuePair<string, string> ciudadYPais in ciudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYPais.Key, ciudadYPais.Value);
            }


            // ejemplo diccionario dentro de un diccionario
            Dictionary<string, Dictionary<string, double>> catologoPetShop
                = new Dictionary<string, Dictionary<string, double>>();

            catologoPetShop.Add("Alimentos para Gatos Adultos", new Dictionary<string, double>
            {
                {"Cat chow", 90 },
                {"Whiskas ", 85 },
                {"Pedigree", 95 }
            });

            catologoPetShop.Add("Alimentos para Gatos Cachorro", new Dictionary<string, double>
            {
                {"Cat chow", 88 },
                {"Whiskas ", 83 },
                {"Pedigree", 93 }
            });

            catologoPetShop.Add("Alimentos para Perros Cachorros", new Dictionary<string, double>
            {
                {"Dog chow", 84 },
                {"Pro plan", 81 },
                {"Pedigree", 93 }
            });

            catologoPetShop.Add("Alimentos para Perros Adultos", new Dictionary<string, double>
            {
                {"Dog chow", 88 },
                {"Pro plan", 83 },
                {"Pedigree", 95 }
            });

            Console.WriteLine("Seccion\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in catologoPetShop)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYPrecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYPrecio.Key, productoYPrecio.Value);
                }
            }


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

    public class TryCatch
    {
        void Ejemplo()
        {
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                decimal division = 25 / numero;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
