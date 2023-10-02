using System.Threading;

namespace Multithread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            var t1 = new Thread(ProgressaoAritmetica);
            var t2 = new Thread(ProgressaoGeometrica);
            var t3 = new Thread(LocalizarPrimos);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }

        static void ProgressaoAritmetica()
        {
            var val = 1;
            do
            {
                Console.WriteLine(val);
                val += 2;
            } while (val <= 1000);
        }
        static void ProgressaoGeometrica()
        {
            var val = 1;
            do
            {
                Console.WriteLine(val);
                val = val * 2;
            } while (val <= 1000);
        }
        static void LocalizarPrimos()
        {
            //Começa testando com 2. (1 não é primo)
            for (int i = 2; i < 1000; i++)
            {
                //Só testar os ímpares depois do número 2. (2 é o único primo par)
                if (i == 2 || i % 2 > 0)
                {
                    var primo = true;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i != 2 && i % j == 0 && j > 1 && j < i)
                        {
                            primo = false;
                            //Se identificou que não é primo já interrompe o looping
                            break;
                        }
                    }
                    //Se for primo imprime no console
                    if (primo)
                        Console.WriteLine($"{i} é primo");
                }
            }
        }
    }
}