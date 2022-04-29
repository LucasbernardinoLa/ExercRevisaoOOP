using System.Globalization;

namespace Exerc2
{
    internal class Vertice
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }


        public double Distancia()
        {
            double resultado = X - Y;

            double DEuclidian = Math.Sqrt(Math.Pow(resultado, 2));

            return DEuclidian;
        }

        public void Move()
        {
            Console.WriteLine("Escolha a posição desejada para mover os pontos ");
            Console.Write("Ponto X: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Ponto Y: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X =  x;
            Y =  y;

        }

        public void VerificaVertice()
        {
            if (X == Y || Y == X)
            {
                 Console.WriteLine("Os vértices são iguais!");
                
            }
            else
            {
                 Console.WriteLine("Os vértices não são iguais!");
              
            }
        }

    }
}
