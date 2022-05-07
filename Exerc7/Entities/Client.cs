using System.Globalization;

namespace Exerc7.Entities
{
    internal class Client
    {
        public string Nome { get; private set; }
        public long Cpf { get; private set; }
        public DateTime Data { get; private  set;}
        public float Renda { get; private set; }
        public Char EstadoCivil { get; set; }
        public int Dependente { get; set; }

        public Client(string nome,long cpf, DateTime data, float renda, char estadoCivil, int dependente)
        {   
            Nome = nome;
            Cpf = cpf;
            Data = data;
            Renda = renda;
            EstadoCivil = estadoCivil;
            Dependente = dependente;
        }

        public Client()
        {
        }

        public bool VerificaNome(string nome)
        {
            if(nome.Length < 5)
            {
                Console.WriteLine();
                Console.WriteLine("O nome deve ter ao menos 5 caracteres");
                Console.WriteLine();
                return false;
            }
            return true;
        }
        public bool VerficaCpf(string cpf)
        {   
            if(cpf.Length != 11)
            {
                Console.WriteLine();
                Console.WriteLine("O cpf deve ter exatamente 11 dígitos! ");
                Console.WriteLine();
                return false;
            }
            return true;
        }
        public bool VerificaRenda(float renda)
        {
            if (renda < 0.0)
            {
                Console.WriteLine();
                Console.WriteLine("A renda de ser um número maior que zero");
                Console.WriteLine();
                return false;

            }
            return true;
        }
        public bool VerificaIdade(DateTime data)
        {
            var idade = DateTime.Today.Year - data.Year;
            if(idade < 18)
            {
                Console.WriteLine();
                Console.WriteLine("o usuário precisa ter no minimo 18 anos! ");
                Console.WriteLine();
                return false;
            }
            return true;
        }
        public bool VerificaChar(string ecivil)
        {
            if(ecivil.Length > 1)
            {
                Console.WriteLine();
                Console.WriteLine("Deve ser somente um dígito!");
                Console.WriteLine();
                return false;
            }
            else
            {
               
                if (ecivil == "C" || ecivil == "c")
                {
                    return true;
                }
                if (ecivil == "S" || ecivil == "s")
                {
                    return true;
                }
                if (ecivil == "D" || ecivil == "d")
                {
                    return true;
                }
                if (ecivil == "V" || ecivil == "v")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Digite somente uma das letras listadas acima! ");
                    return false;
                }
            }
        }
        public bool VerificaDepen(int d)
        {
            if(d < 11 && d >= 0)
            {
                return true;
            }
            Console.WriteLine("Só podem ser aceitos os números de 0 a 10!");
            return false;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} \n" +
                   $"Cpf: {Cpf} \n " +
                   $"Data de nascimento: {Data.ToString("dd/MM/yyyy")}\n " +
                   $"Renda: {Renda.ToString("F2")}\n " +
                   $"Estado civil: {EstadoCivil.ToString().ToUpperInvariant()}\n " +
                   $"Dependentes: {Dependente}\n ";
        }
    }
}
