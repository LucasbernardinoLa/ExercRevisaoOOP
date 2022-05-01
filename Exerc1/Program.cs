using Exerc1.Entities;

Console.WriteLine("Digite o valor de linhas da pirâmide: ");
    int n = int.Parse(Console.ReadLine());

try
{
    Piramide p = new Piramide(n);
    p.desenha();
}
catch (SystemException)
{
    Console.WriteLine("o valor precisa ser maior que 1! ");
}