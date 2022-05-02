using Exerc5.Entities;
using Exerc6.Entities;

try
{
    Console.WriteLine("Quantos intervalos serão criados? ");
    int n = int.Parse(Console.ReadLine());
    ListaIntervalo l = new ListaIntervalo();

    for(int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite a data inicial DD/MM/AAAA: ");
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Digite a data final DD/MM/AAAA: ");
        DateTime d2 = DateTime.Parse(Console.ReadLine());
        Intervalo i1 = new Intervalo(d1, d2);
        l.Add(i1);
        
    }
    l.ImprimeLista();
    
    
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
