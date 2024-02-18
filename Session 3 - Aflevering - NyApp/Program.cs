/*
Ny App 
Lav en metode der tager et tal og returnere en sum. Eks MinMetode(5) 
returnere 1+2+3+4+5. Lad metode sleepe i 2000 millisek. 
Kald metoden med task 5 gange og afvent resultatet fra hver af de fem lige før i 
udskriver. Dvs fem CW(). 
Kald metoden med task 5 gange og afvent alle ved hjælp af WaitAll. 
Kald metoden, udskriv resultatet med ContinueWith. 
*/

// Kald metoden med task 5 gange og afvent resultatet fra hver af de fem lige før i udskriver.Dvs fem CW(). 
Task<int> t1 = Task<int>.Run(() => MinMetode(5));   
Task<int> t2 = Task<int>.Run(() => MinMetode(5));   
Task<int> t3 = Task<int>.Run(() => MinMetode(5));   
Task<int> t4 = Task<int>.Run(() => MinMetode(5));   
Task<int> t5 = Task<int>.Run(() => MinMetode(5));
Console.WriteLine("t1 " + t1.Result);
Console.WriteLine("t2 " + t2.Result);
Console.WriteLine("t3 " + t3.Result);
Console.WriteLine("t4 " + t4.Result);
Console.WriteLine("t5 " + t5.Result);

// Kald metoden med task 5 gange og afvent alle ved hjælp af WaitAll.
Task<int> t6 = Task<int>.Run(() => MinMetode(5));
Task<int> t7 = Task<int>.Run(() => MinMetode(5));
Task<int> t8 = Task<int>.Run(() => MinMetode(5));
Task<int> t9 = Task<int>.Run(() => MinMetode(5));
Task<int> t10 = Task<int>.Run(() => MinMetode(5));
Task.WaitAll(t6, t7, t8, t9, t10);
Console.WriteLine("t6 " + t6.Result);
Console.WriteLine("t7 " + t7.Result);
Console.WriteLine("t8 " + t8.Result);
Console.WriteLine("t9 " + t9.Result);
Console.WriteLine("t10 " + t10.Result);


//Kald metoden, udskriv resultatet med ContinueWith. 
Task<int>.Run(() => MinMetode(5)).ContinueWith(t => { Console.WriteLine(t.Result); });



int MinMetode(int a)
{
    Thread.Sleep(2000);

    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}