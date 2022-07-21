using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase
{
    public class Producto
    {
        // sin getters ni setters

        public int Codigo;
        public string Descripcion;
        public double PrecioDeCompra;
        public double PrecioDeVenta;
        public string Categoria;

        public Producto()
        {
            Codigo = 0;
            Descripcion = String.Empty;
            PrecioDeCompra = 0;
            PrecioDeVenta = 0;
            Categoria = String.Empty;
        }

        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            PrecioDeCompra = precioDeCompra;
            PrecioDeVenta = precioDeVenta;
            Categoria = categoria;
        }
    }
    public class ProductoConPropiedadesPublicas
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public ProductoConPropiedadesPublicas(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
    }

    public class ProductosConE
    {
        private List<ProductoConPropiedadesPublicas> _productosConE;
        public ProductosConE()
        {
            _productosConE = new List<ProductoConPropiedadesPublicas>();
        }

        public void InsertarProductosConE(ProductoConPropiedadesPublicas[] arrayProductos)
        {
            for (int i = 0; i < arrayProductos.Length; i++)
            {
                ProductoConPropiedadesPublicas producto = arrayProductos[i];

                //if(producto.Descripcion.ToUpper().Contains("E"))
                //{

                //}
                if(producto.Descripcion.Contains("E") || producto.Descripcion.Contains("e"))
                {
                    _productosConE.Add(producto);
                }
            }
        }

        public void MostrarLista()
        {
            if(_productosConE.Count == 0)
            {
                Console.WriteLine("No tiene productos con E");
            }
            else
            {
                Console.WriteLine("Productos con E:");
                foreach (ProductoConPropiedadesPublicas producto in _productosConE)
                {
                    Console.WriteLine($"Codigo: {producto.Codigo} - Descripcion: {producto.Descripcion}");
                }
            }
        }

        public void LimpiarLista()
        {
            _productosConE.Clear();
            Console.WriteLine("Lista limpiada");
        }
    }
}
