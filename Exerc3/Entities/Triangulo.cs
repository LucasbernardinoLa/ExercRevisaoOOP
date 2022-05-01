using Exerc2.Entities;
using Exerc3.Entities.Enums;
using System.Globalization;

namespace Exerc3.Entities
{
    internal class Triangulo
    {
        public Vertice V1 { get; private set; }
        public Vertice V2 { get; private set; }
        public Vertice V3 { get; private set; }
        public double Perimetro { get; private set; }
        public Tipo Tipo { get; private set;}
        public double Area { get; set; }


        public Triangulo(Vertice v1, Vertice v2, Vertice v3, Tipo tipo
            )
        {
            if(v1 == null || v2 == null || v3 == null)
            {
                throw new ArgumentException("Esses valores são nulos! ");
            }
            else if(v1.X <= 0 || v2.X <= 0 || v3.X <= 0)
            {
                throw new ArgumentException("Os valores do vértice precisam ser maiores do que zero!");
            }
            else
            {
                V1 = v1;
                V2 = v2;
                V3 = v3;
                Perimetro = V1.X + V2.X + V3.X;
                Tipo = tipo;
                double s = Perimetro / 2;
                Area = Math.Sqrt(s *(s - V1.X) * (s - V2.X) * (s - V3.X));
            }
        }


        public override bool Equals(object obj)
        {
            if (obj is Triangulo other)
            {
                if (V1.X == other.V1.X && V2.X == other.V2.X && V3.X == other.V3.X)
                {
                    Console.WriteLine("Os triângulos são iguais!");
                    return true;
                }
                Console.WriteLine("Os triângulos são diferentes! ");
                return false;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void MostraPerimetro()
        {

           Console.WriteLine($"Valor do perímetro: {Perimetro} ");
        }

        public override string ToString()
        {
            return $"Perímetro: {Perimetro}, Tipo: {Tipo}, Area: {Area.ToString("F2")}";
        }

    }
}
