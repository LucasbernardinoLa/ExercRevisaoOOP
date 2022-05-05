using Exerc2.Entities;

namespace Exerc4.Entities
{
    internal class Poligono
    {
        public Vertice V1 { get; private set; }
        public Vertice V2 { get; private set; }
        public Vertice V3 { get; private set; }
        public List<Vertice> Vertices { get; set; } = new List<Vertice> ();

        public Poligono(Vertice v1, Vertice v2, Vertice v3)
        {
            if (v1 == null || v2 == null || v3 == null)
            {
                throw new ArgumentException("Um polígono deve ter 3 ou mais vértices! ");
            }
            else if (v1.X <= 0 || v2.X <= 0 || v3.X <= 0)
            {
                throw new ArgumentException("Os valores do vértice precisam ser maiores do que zero!");
            }
            else
            {
                V1 = v1;
                V2 = v2;
                V3 = v3;
                Vertices = new List<Vertice> { v1, v2, v3 };
            }
        }
        public  bool AddVertice(Vertice v)
        {
            if(Vertices.Contains(v))
            {
                return false;
            }
            else
            {
                Vertices.Add(v);
                return true;
            }
        }

        public void RemoveVertice(int i)
        {
            if( Vertices.Count <= 3)
            {
                throw new Exception("Um poligono deve ter 3 ou mais vértices! ");
            }
            else
            {
                Vertices.RemoveAt(i);
            }
        }
        public double Perimetro()
        {
            double sum = 0;

            foreach (Vertice v in Vertices)
            {
                sum += v.X;
            }
            return sum;
        }
        public void NumeroVertices()
        {
            Console.WriteLine($"número de vértices do polígono: { Vertices.Count}");
        }

        public override string ToString()
        {
            return $"Valor do perímetro: {Perimetro()}";
        }
    }
}
