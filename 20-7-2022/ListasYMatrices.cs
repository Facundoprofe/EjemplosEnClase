using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase._20_7_2022
{
    public class ListasYMatrices
    {
        void Ejemplo()
        {
            // Lista de strings
            List<string> nombres = new List<string> { "Roman", "Ana", "Felipe" };

            string[] nombresArray = new string[] { "Roman", "Ana", "Felipe" };

            foreach (var nombre in nombres)
            {
                Console.Write($"Hola... {nombre.ToUpper()}");
            }

            // Manejo de Listas
            ListasMayores mayores = new ListasMayores();
            Cliente[] clientes =
            {
                new Cliente("Juan perez", 34345567, "Av de los corrales", 34),
                new Cliente("Pedro diaz", 34345376, "Av rivadavia 7689", 30),
                new Cliente("Ricardo lopez", 33454765, "Av buenos aires 3434", 18),
                new Cliente("Luis mejia", 34342654, "Constitucion", 34),
                new Cliente("Alberto fernandez", 34234565, "San Pedro 234", 60),
            };

            mayores.InsertarEnLista(clientes);

            mayores.MostrarLista();

            Cliente clienteABorrar = clientes.FirstOrDefault(f => f.Nombre == "Juan perez");

            mayores.BorrarCliente(clienteABorrar);

            mayores.MostrarLista();


            //Ejemplo de matrices
            Matriz ejemploMatriz = new Matriz();

            ejemploMatriz.Ingresar();
            ejemploMatriz.Imprimir();

            // Ejemplo de produjctos con E
            ProductosConE productosConE = new ProductosConE();

            ProductoConPropiedadesPublicas[] productos =
            {
                new ProductoConPropiedadesPublicas(1, "Yogurt descremado"),
                new ProductoConPropiedadesPublicas(2, "Leche"),
                new ProductoConPropiedadesPublicas(3, "Huevos"),
                new ProductoConPropiedadesPublicas(4, "Vino"),
                new ProductoConPropiedadesPublicas(5, "Sal"),
                new ProductoConPropiedadesPublicas(6, "Estufa"),
            };

            productosConE.InsertarProductosConE(productos);
            productosConE.MostrarLista();
            productosConE.LimpiarLista();
            productosConE.MostrarLista();

        }

        public class Cliente
        {
            public string Nombre;
            public long ID;
            public string Direccion;
            public short Edad;

            public Cliente(string nombre, long iD, string direccion, short edad)
            {
                Nombre = nombre;
                ID = iD;
                Direccion = direccion;
                Edad = edad;
            }
        }

        public class ListasMayores
        {
            public List<Cliente> _clientesMayores;

            public ListasMayores()
            {
                _clientesMayores = new List<Cliente>();
            }

            public void InsertarEnLista(Cliente[] clientes)
            {
                Console.WriteLine($"Insertando en lista {clientes.Length} clientes");

                //Uso del AddRange
                //_clientesMayores.AddRange(clientes);

                foreach (Cliente cliente in clientes)
                {
                    _clientesMayores.Add(cliente);
                }
            }

            public void MostrarLista()
            {
                foreach (Cliente cliente in _clientesMayores)
                {
                    Console.WriteLine($"Nombre: {cliente.Nombre} - ID: {cliente.ID} " +
                        $"- Direccion: {cliente.Direccion} - Edad: {cliente.Edad}");
                }
            }

            public bool BorrarCliente(Cliente cliente)
            {
                bool seBorroElCliente = false;

                if (_clientesMayores.Contains(cliente))
                {
                    seBorroElCliente = _clientesMayores.Remove(cliente);
                }

                return seBorroElCliente;
            }
        }

        public class Matriz
        {
            private int[,] _matriz;
            private const int DIMENSION_FILA = 0;
            private const int DIMENSION_COLUMNA = 1;

            public Matriz(int filas, int columnas)
            {
                if (columnas > 0 && filas > 0)
                {
                    _matriz = new int[filas, columnas];
                }
                else
                {
                    new Matriz();
                }
            }

            public Matriz()
            {
                _matriz = new int[2, 3];
            }

            public void Ingresar()
            {
                for (int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
                {
                    for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA); columnas++)
                    {
                        Console.WriteLine("Ingresar valor entero en la posicion ["
                            + $"{filas + 1}" + ", " + $"{columnas + 1}" + "]");

                        string linea;
                        linea = Console.ReadLine();
                        try
                        {
                            _matriz[filas, columnas] = int.Parse(linea);
                        }
                        catch (Exception ex)
                        {
                            columnas = columnas - 1;
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            public void Imprimir()
            {
                for (int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
                {
                    for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA); columnas++)
                    {
                        Console.Write(_matriz[filas, columnas] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
