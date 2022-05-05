using Exerc3.Entities;
using Exerc2.Entities;
using Exerc3.Entities.Enums;

try
{
    Console.WriteLine("Digite a medida dos 3 vértices do triângulo: ");
    double v1 = double.Parse(Console.ReadLine());
    double v2 = double.Parse(Console.ReadLine());
    double v3 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Digite o tipo do triângulo: (Equilatero,Isoceles ou Escaleno) ");
    Tipo tipo1 = Enum.Parse<Tipo>(Console.ReadLine());

    Triangulo t1 = new Triangulo(new Vertice(v1), new Vertice(v2), new Vertice(v3), tipo1);
    Console.WriteLine();

    Console.WriteLine("Digite a dos 3 vértices de um novo triãngulo: ");
    v1 = double.Parse(Console.ReadLine());
    v2 = double.Parse(Console.ReadLine());
    v3 = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Digite o tipo do triângulo: (Equilatero,Isoceles ou Escaleno) ");
    Tipo tipo2 = Enum.Parse<Tipo>(Console.ReadLine());

    Console.WriteLine();
    Triangulo t2 = new Triangulo(new Vertice(v1), new Vertice(v2), new Vertice(v3), tipo2);
    t1.Equals(t2);
    Console.WriteLine(t1);
    Console.WriteLine(t2);

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}