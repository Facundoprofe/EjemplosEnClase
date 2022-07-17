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

    public interface I2DMedidasCalculable
    {
        double Area();
        double Perimetro();
    }

    public interface I3DMedidasCalculable
    {
        double Volumen();
    }

    public abstract class FiguraGeometrica
    {
        public abstract double Area();
    }

    public class Circulo : FiguraGeometrica
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public double Perimetro()
        {
            return 2 * Math.PI * this.radio; 
        }
    }

    public class Rectangulo : I2DMedidasCalculable
    {
        double base_r;
        double altura_r;

        public Rectangulo(double base_r, double altura_r)
        {
            this.base_r = base_r;
            this.altura_r = altura_r;
        }

        public double Area()
        {
            return this.base_r * this.altura_r;
        }

        public double Perimetro()
        {
            return 2 * this.base_r + 2 * this.altura_r;
        }
    }

    public class Cubo : I2DMedidasCalculable, I3DMedidasCalculable
    {
        double lado;
        public Cubo(double lado)
        {
            this.lado = lado;
        }

        public double Area()
        {
            return 6 * Math.Pow(lado, 2);
        }

        public double Perimetro()
        {
            return 12 * lado;
        }

        public double Volumen()
        {
            return Math.Pow(lado, 3);
        }
    }
}
