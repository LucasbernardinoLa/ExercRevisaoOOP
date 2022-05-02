using Exerc5.Entities;

namespace Exerc6.Entities
{
    internal class ListaIntervalo
    {
        public List<Intervalo> Intervalos { get; set; } = new List<Intervalo>();

        public ListaIntervalo()
        {
        }

        public bool Add(Intervalo i)
        {
            if(Intervalos.Count <= 0)
            {
                Intervalos.Add(i);
                return true;
            }
            for(int j = 0; j < Intervalos.Count; j++)
            {
                if (i.TemIntersecao(Intervalos[j]) == true)
                {
                    throw new Exception("Não podem haver interseções com outros elementos lista! ");
                }
                                        
            }
            Intervalos.Add(i);
            return true;
        }

       public void ImprimeLista()
        {
            Intervalos.Sort();
            foreach(Intervalo i in Intervalos)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
