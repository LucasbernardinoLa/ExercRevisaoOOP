using Exerc5.Entities;
try
{
    Console.WriteLine("Digite a data inicial DD/MM/AAAA: ");
    DateTime d1 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Digite a data final DD/MM/AAAA: ");
    DateTime d2 = DateTime.Parse(Console.ReadLine());
    Intervalo i1 = new Intervalo(d1, d2);

    Console.WriteLine("Digite a data inicial do novo intervalo: ");
    d1 = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Digite a data final do novo intervalo: ");
    d2 = DateTime.Parse(Console.ReadLine());
    Intervalo i2 = new Intervalo(d1, d2);

    Console.WriteLine();
    i1.TemIntersecao(i2);

    Console.WriteLine();    
    i1.Equals(i2);

    Console.WriteLine();
    Console.WriteLine(i1);
}
catch (SystemException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}