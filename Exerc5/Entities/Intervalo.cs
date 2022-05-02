using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5.Entities
{
    internal class Intervalo
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
        public TimeSpan Duracao { get; set; }

        public Intervalo(DateTime dataInicial, DateTime dataFinal)
        {
            if(dataInicial >= dataFinal)
            {
                Console.WriteLine();
                throw new Exception("A data final não pode ser menor que a data inicial! ");
            }
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Duracao = dataFinal.Subtract(dataInicial);
        }

        public bool TemIntersecao(Intervalo d)
        {
            if (DataInicial < d.DataInicial && DataFinal < d.DataInicial)
            {
                Console.WriteLine("As datas não possuem interseções");
                return false;
            }
            else if(DataInicial > d.DataFinal && DataFinal > d.DataFinal)
            {
                Console.WriteLine("As datas não possuem interseções");
                return false;
            }
            else
            {
                Console.WriteLine("As datas possuem interseções");
                return true;
            }

        }
        public override bool Equals(object obj)
        {
            if(obj is Intervalo other)
            {
                if(DataInicial == other.DataInicial && DataFinal == other.DataFinal)
                {
                    Console.WriteLine("Os intervalos são iguais! ");
                    return true;
                }
                Console.WriteLine("os intervalos não são iguais!");
                return false;

            }
            return false;
        }
        public override string ToString()
        {
            return $"duração do intervalo: {Duracao}";
        }
    }
}
