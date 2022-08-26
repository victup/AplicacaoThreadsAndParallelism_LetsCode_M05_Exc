using System.Diagnostics;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {

        ExecutarTodasAsTarefas(2);

    }

    static void AcertarBaseDeDados()
    {
        Console.WriteLine($"Começando a acertando Base de dados. - Thread ID:{Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(2000);
        Console.WriteLine($"Finalizando o acerto na base de dados. - Thread ID:{Thread.CurrentThread.ManagedThreadId}");
    }

    static void EnviarEmail()
    {
        Console.WriteLine($"Enviando Email. - Thread ID:{Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(4000);
        Console.WriteLine($"Email enviado. - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }

    static void LimparArquivosTemporarios()
    {
        Console.WriteLine($"Iniciando Limpeza de Arquivos Temporarios. - Thread ID:{Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(3000);
        Console.WriteLine($"Finalizando Limpeza de Arquivos Temporários - Thread ID:{Thread.CurrentThread.ManagedThreadId}");
    }

    static void ExecutarTodasAsTarefas(int qtddThreads)
    {
        ParallelOptions op = new();
        op.MaxDegreeOfParallelism = qtddThreads;

        Stopwatch sw = Stopwatch.StartNew();
        sw.Start();

        Parallel.Invoke(op, () => AcertarBaseDeDados(),
                        () => EnviarEmail(),
                        () => LimparArquivosTemporarios()
                       );


        sw.Stop();
        Console.WriteLine($"O processo levou {sw.ElapsedMilliseconds} ms");

    }

}