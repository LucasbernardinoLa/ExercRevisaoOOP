using Exerc7.Entities;
using System.Globalization;


Console.WriteLine("Digite os dados de cadastro do cliente: ");
Client c = new Client();
int i = 0;

while (i == 0)
{
    Console.WriteLine();
    Console.Write("Digite o nome do usuário: ");
    string nome = Console.ReadLine();

    if (c.VerificaNome(nome) == false)
    {
        continue;
    }
    try
    {
        while (i == 0)
        {
            Console.Write("Cpf: ");
            string cpf = Console.ReadLine();

            if (c.VerficaCpf(cpf) == false)
            {
                continue;
            }

            long num_cpf = long.Parse(cpf);

            while (i == 0)
            {
                Console.Write("Data de nascimento (DD/MM/AAAA): ");
                string data = Console.ReadLine();

                DateTime d_data = DateTime.Parse(data);
                if (c.VerificaIdade(d_data) == false)
                {
                    continue;
                }

                while (i == 0)
                {
                    Console.Write("Renda mensal: ");
                    string renda = Console.ReadLine();
                    
                    float f_renda = float.Parse(renda);
                    if (c.VerificaRenda(f_renda) == false)
                    {
                        continue;
                    }

                    while (i == 0)
                    {
                        Console.Write("Estado civil (C, S, D ou V): ");
                        string estado = Console.ReadLine();

                        if (c.VerificaChar(estado) == false)
                        {
                            continue;
                        }

                        char c_estado = char.Parse(estado);

                        while (i == 0)
                        {
                            Console.Write("Número de dependentes: ");
                            string dependentes = Console.ReadLine();

                            int i_denpendentes = int.Parse(dependentes);
                            if (c.VerificaDepen(i_denpendentes) == false)
                            {
                                continue;
                            }

                            Client c1 = new Client(nome, num_cpf, d_data, f_renda, c_estado, i_denpendentes);
                            Console.WriteLine();
                            Console.WriteLine(c1);
                            i++;
                        }
                    }
                }
            }

        }
    }
    catch (Exception)
    {
        Console.WriteLine("Digite todos os dados novamente em um formato válido! ");
        continue;
    }
}

