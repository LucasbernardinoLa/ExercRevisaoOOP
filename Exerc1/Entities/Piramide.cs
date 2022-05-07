namespace Exerc1.Entities
{
    internal class Piramide
    {
        private int n; 

        public int N
        {
            get
            {
                return n;
            }
            set
            {
                if (value <= 0)
                {
                    throw new SystemException();
                }
                else
                {
                    n = value;
                }
            }
        }

        public Piramide(int n)
        {

            this.N = n;

        }

        public void desenha()
        {
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


