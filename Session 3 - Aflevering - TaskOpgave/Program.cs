/*
Lav en metode der tager imod tre int, et id, et sleep interval og en counter. 

Counter er antal gange metoden skal udskrive. 
Sleep angiver hvor længe metoden skal sleepe mellem hver iteration og id er det der udskrives. 

Kald metoden 5 gange fra Program.cs. Afprøv denne sync metode og følg 
programforløb... 

Lav 5 task der kalder metoden. 
Kald Wait() for hver Task, prøv en af gangen og se hvilken forskel det gør. Afprøv 
denne og følg programforløb... 
Brug Task.Waitall til at afvente at alle task afslutter. Afprøv denne og følg 
programforløb...
*/


//TaskOpgave(1, 1000, 2);
//TaskOpgave(2, 500, 3);
//TaskOpgave(3, 1500, 1);
//TaskOpgave(4, 250, 4);
//TaskOpgave(5, 100, 5);


Task t1 = Task.Factory.StartNew(() => TaskOpgave(1, 2500, 5));
Task t2 = Task.Factory.StartNew(() => TaskOpgave(2, 2000, 5));
Task t3 = Task.Factory.StartNew(() => TaskOpgave(3, 1500, 5));
Task t4 = Task.Factory.StartNew(() => TaskOpgave(4, 1000, 5));
Task t5 = Task.Factory.StartNew(() => TaskOpgave(5, 500, 5));

Task.WaitAll(t1, t2, t3, t4, t5);

void TaskOpgave(int id, int sleep, int counter)
{

	for (int i = 0; i < counter; i++)
	{
		Thread.Sleep(sleep);
        Console.WriteLine(id);       
    }
    // Man kan se Thread Id 
    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} er færdig ");
}
