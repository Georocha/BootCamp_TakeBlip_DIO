using System;

namespace Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[4];
            var indiceAluno = 0;
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");

                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        var numeroAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroAlunos++;
                            }
                        }

                        decimal mediaGeral = notaTotal / numeroAlunos;
                        Nivel nivelGeral;

                        if (mediaGeral < 2)
                        {
                            nivelGeral = Nivel.d;
                        }
                        else if (mediaGeral < 5)
                        {
                            nivelGeral = Nivel.c;
                        }
                        else if (mediaGeral < 7)
                        {
                            nivelGeral = Nivel.b;
                        }
                        else
                        {
                            nivelGeral = Nivel.a;
                        }

                        Console.WriteLine($"Média Geral: {mediaGeral} - Nível: {nivelGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3-  Calcular média geral");
            Console.WriteLine("x - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
