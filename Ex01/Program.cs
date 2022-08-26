using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, double> contaBancariaClientes = new Dictionary<string, double>()
   {
       {"Murilo Fillo", 2300.38},
       {"João Pereira", 4850.50},
       {"Marcos Peixada", 865.45},
       {"Irineu Lottus", 100},
       {"Maria Lina", 26450.89}
   };

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        ParallelOptions op = new();
        op.MaxDegreeOfParallelism = 5;


        Parallel.For(0, 100, op, i =>
        {
            GetBalance(PegarNomeAleatorio(contaBancariaClientes), contaBancariaClientes);
        });

        stopwatch.Stop();

        ImprimirTempoEmSegundos(stopwatch);

    }
    static void GetBalance(string name_customer, Dictionary<string, double> database)
    {
        Thread.Sleep(2000);

        double balance = 0;
        balance = database[name_customer];

        if (balance > 0)
            Console.WriteLine($"Cliente {name_customer} possui R${balance}: - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        else
            Console.WriteLine($"Cliente não encontrado. - Thread ID: {Thread.CurrentThread.ManagedThreadId}");
    }

    static void ImprimirTempoEmSegundos(Stopwatch stopwatch)
    {
        var tempoSegundos = stopwatch.ElapsedMilliseconds/1000;


        Console.WriteLine($"Levou {tempoSegundos} segundos para a execução");
    }

    static string PegarNomeAleatorio(Dictionary<string, double> dicionario)
    {
        List<string> clientes = new List<string>();

        foreach (var item in dicionario)
        {
            clientes.Add(item.Key);
        }

        string resultado = "";
        Random rnd = new Random();
        resultado = clientes[rnd.Next(clientes.Count)];

        return resultado;
    }



}