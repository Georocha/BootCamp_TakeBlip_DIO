using System;

namespace instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;

            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo()
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s)) break;

                Console.WriteLine(s);

            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/")) continue;

                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a , int b)
            {
                return a + b;
            }

            console.WriteLine(Somar(1, 2));
            console.WriteLine(Somar(3, 4));
            return;
        }
 
        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try //O que tiver dentro do try o código vai tentar fazer
            {
                if (args.length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);

                console.WriteLine(Dividir(x,y));
            }
            catch (InvalidOperationException e)
            {
                console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.text"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
            }
        }
        static void Main()
        {
            string[] nomes = { "Caio", "Romario", "/Marcia", "Paulo" };

            // Declaracoes();
            // InstrucaoIf(nomes);
            // InstrucaoSwitch(nomes);
            // InstrucaoWhile(nomes);
            // InstrucaoDo();
            // InstrucaoFor(nomes);
            // InstrucaoForeach(nomes);
            // InstrucaoBreak();
            InstrucaoContinue(nomes);

        }

    }
}
