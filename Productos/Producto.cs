using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase
{
    public class Producto
    {
        // sin getters o setters

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
}
