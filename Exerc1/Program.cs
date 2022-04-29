using Exerc1;



    Console.WriteLine("Digite o valor de linhas da pirâmide: ");
    int n = int.Parse(Console.ReadLine());

try
{
    Piramide p = new Piramide(n);
    p.desenha(n);
}

catch (SystemException)
{
    Console.WriteLine("o valor precisa ser maior que 1! ");
}