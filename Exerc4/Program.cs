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
    Console.Write("Deseja remover algum vértice? S/N ");
    char c = char.Parse(Console.ReadLine());
    if(c == 'S' || c == 's')
    {
        Console.WriteLine();
        Console.Write("Digite o número de vértices que irão ser removidos: ");
        n = int.Parse(Console.ReadLine());
        
        for(int i = 0; i< n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Digite o índice do vértice que sera removido(lembrando que a contagem começa a partir de 0): ");
            Console.WriteLine();
            p.NumeroVertices();
            Console.WriteLine();
            int index = int.Parse(Console.ReadLine());
            p.RemoveVertice(index);
            Console.WriteLine();

        }
    }
    Console.WriteLine();
    Console.WriteLine(p);
    p.NumeroVertices();

}
catch(SystemException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
