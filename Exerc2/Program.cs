using Exerc2.Entities;

Vertice v = new Vertice(5, 5);
try
{
    Console.WriteLine(v.Distancia());
    v.VerificaVertice();
    v.Move();
    v.VerificaVertice();

}
catch (Exception e)
{
    throw new Exception(e.Message);
}
