namespace EjemploDeClase
{
    public class ProbarObjetos
    {
        static void Main(string[] args)
        {
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
    }
}
