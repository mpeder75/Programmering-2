
Console.WriteLine("App start");

int ReturnSomething(int a, int b, int sleep)
{
    Thread.Sleep(sleep);
    return a + b;
}

Task<int>.Run(() => ReturnSomething(10, 10, 2000)).ContinueWith(t => { Console.WriteLine(t.Result); });

Console.WriteLine("App end");
Console.ReadLine();

