namespace EjemploDeClase
{
    public class ProbarObjetos
    {
        static void Main(string[] args)
        {
            // ejemlpo de figuras geometricas del 13-7-2022
            Cubo cubo = new Cubo(5);
            Rectangulo rectangulo = new Rectangulo(3, 6);
            Circulo circulo = new Circulo(6);


            Console.WriteLine("volumen cubo:" + cubo.Volumen());


            // ejemlpo de jugadores del 14-7-2022
            Ronaldo ronaldo = new Ronaldo(90, 30, 95, 15, 90, 50);
            Messi messi = new Messi(88, 95, 89, 20, 90, 70);
            Console.WriteLine(messi.DevolverVelocidad());
            Console.WriteLine(ronaldo.DevolverVelocidad());
        }
    }
}
