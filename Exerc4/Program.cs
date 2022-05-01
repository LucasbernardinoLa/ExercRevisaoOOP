using System.Globalization;
using Exerc2.Entities;
using Exerc4.Entities;

try
{
    Console.WriteLine("Digite os valores iniciais dos 3 primeiros vértices: ");
    double v1 = double.Parse(Console.ReadLine());
    double v2 = double.Parse(Console.ReadLine());
    double v3 = double.Parse(Console.ReadLine());

    Poligono p = new Poligono(new Vertice(v1), new Vertice(v2), new Vertice(v3));

    Console.Write("Digite o número de vértices adicionados ao polígono: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {

        Console.Write("Digite o valor do vértice: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Vertice v = new Vertice(valor);
        p.AddVertice(v);
        Console.WriteLine();
    }

    Console.WriteLine(p.Perimetro());
    p.NumeroVertices();
}
catch(SystemException ex)
{
    Console.WriteLine(ex.Message);
}
