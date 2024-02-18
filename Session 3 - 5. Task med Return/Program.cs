/*
// --------- Regulær Task der returnere en beregning -------- //
Console.WriteLine("App start");

// Her returneres der beregningen af 10*10
Task<int> t = Task<int>.Run(() => { return 10*10; });

Console.WriteLine(t.Result);

Console.WriteLine("App end");
*/


// ------ Task med ContinueWith -------- //

// Continue with gør at når Task er færdig, kan der YDERLIGER gøre noget

// Hvorfor ikke få Task til også at printe sit resultat

Console.WriteLine("App start");

Task<int>.Run(() => { return 10 * 10; }).ContinueWith(t => { Console.WriteLine(t.Result); });

Console.WriteLine("App end");
