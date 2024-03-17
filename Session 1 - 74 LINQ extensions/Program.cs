IEnumerable<int> myList = new List<int>() { 1,2,3,4,5,6,7,8,9 };


// Større end
var greaterThanTwo = myList.Where(x => x > 2);
greaterThanTwo.ToList().ForEach(item => Console.WriteLine(item));


// TypeOf - find en specefik datatype
// var specificDataType = myList.OfType<int>();


// Spring første 3 elementer over
var skipFirstThreeElements = myList.Skip(3);
skipFirstThreeElements.ToList().ForEach(item => Console.WriteLine(item));


// Brug KUN 3 første elementer
var useOnlyFirstThreeElements = myList.Take(3);
useOnlyFirstThreeElements.ToList().ForEach(item => Console.WriteLine(item));


// Sprig sidste 3 elementer over
var skipLastThreeElements = myList.SkipLast(3);
skipFirstThreeElements.ToList().ForEach((item) => Console.WriteLine(item));


// Spring over elementer der er mindre end 2
var skipLesserThanTwo = myList.SkipWhile(x => x < 2);
skipLesserThanTwo.ToList().ForEach(p => Console.WriteLine(p));


// Brug elementer der er mindre end 2
var useLesserThantwo = myList.TakeWhile(x => x < 2);
useLesserThantwo.ToList().ForEach(p => Console.WriteLine(p));


// Select - bruges til at udvælge elementer (her selectes alle int elementer og printes som sting)
var selectAll = myList.Select(x => x.ToString());
selectAll.ToList().ForEach(x => Console.WriteLine(x));


// Select og print index OG element værdi
var selectIndexAndValue = myList.Select((x,i) => $"Index:{i}.Value:{x}".ToString());
selectIndexAndValue.ToList().ForEach(x => Console.WriteLine(x));

