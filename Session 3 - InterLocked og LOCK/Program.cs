
// object LOCK, tomt objekt, bruges som parameter 
object LOCK = new object();

int total = 0;

Task t1 = new Task(() => AddMillion());
Task t2 = new Task(() => AddMillion());
Task t3 = new Task(() => AddMillion());


t1.Start();
t2.Start();
t3.Start();


Thread.Sleep(100);
Console.WriteLine(total);

/*
void AddMillion()
{
    for (int i = 0; i < 1000000; i++)
    {
        total++;
    }
}
*/

/*
// Løsning 1 : Interlocked.Increment(ref total)

void AddMillion()
{
    for (int i = 0; i < 1000000; i++)
    {
        // Dette vil læse rsace condition, og returnere 3000000
        Interlocked.Increment(ref total);
    }
}
*/

// Løsning 2: LOCK 
void AddMillion()
{
    for (int i = 0; i < 1000000; i++)
    {
        lock (LOCK)
        {
            total++;
        }
    }
}
