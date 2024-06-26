﻿/*
 
Task bruges til CPU bound operationer. Dvs. operationer der er beregningstunge

*/

Console.WriteLine("Appen starter");

// Taks t1-t3 oprettes og assignes ny Task, med forskellige Id, OG FORSKELLIGE SLEEP intervaller
Task t1 = Task.Factory.StartNew(() => DoSomething(1, 2000));
Task t2 = Task.Factory.StartNew(() => DoSomething(2, 500));
Task t3 = Task.Factory.StartNew(() => DoSomething(3, 1500));

/* Der er nu ikke behov for at starte trådene, da StartNew() gør det for os
t1.Start();
t2.Start();
t3.Start();
*/

Console.WriteLine("App end");
Console.ReadLine();


void DoSomething(int id, int sleep)
{
    Thread.Sleep(sleep);
    Console.WriteLine($"Task med id: {id} er færdig");
}

