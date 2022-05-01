using Exerc3.Entities;
using Exerc2.Entities;
using Exerc3.Entities.Enums;

try
{
    Triangulo t1 = new Triangulo(new Vertice(5), new Vertice(5), new Vertice(5), Tipo.Isoceles);
    Triangulo t2 = new Triangulo(new Vertice(1), new Vertice(5), new Vertice(5), Tipo.Escaleno);
    t1.Equals(t2);
    t1.MostraPerimetro();
    Console.WriteLine(t1);

}
catch (ArgumentException e)
{
    throw new ArgumentException(e.Message);
}
