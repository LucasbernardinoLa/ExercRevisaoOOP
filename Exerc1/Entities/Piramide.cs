namespace Exerc1.Entities
{
    internal class Piramide
    {
        public int N { get; set; }

        public Piramide(int n)
        {
            if (n <= 0)
            {
                throw new SystemException();
            }
            else
            {
                N = n;
            }


        }

        public void desenha()
        {

            ;

            for (int i = 1; i <= N; i++)
            {

                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }

        }

    }
}


