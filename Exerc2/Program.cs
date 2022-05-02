using Exerc2.Entities;

Console.Write("Digite o valor de X: ");
double x = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de Y: ");
double y = int.Parse(Console.ReadLine());

try
{
    Vertice v = new Vertice(x, y);

    Console.WriteLine();
    v.Distancia();
    Console.WriteLine();

    v.VerificaVertice();
    Console.WriteLine();
    
    v.Move();
    Console.WriteLine();

    v.Distancia();
    Console.WriteLine();

    v.VerificaVertice();

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
