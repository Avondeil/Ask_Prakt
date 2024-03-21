using System.Reflection.Metadata;



var rnd = new MyRandom();
var res = rnd.NextDate(DateTime.Parse("01.01.2000"), DateTime.Parse("01.01.2010")).ToString("dd/MM/yyyy");
Console.WriteLine(res);


class MyRandom : Random
{
    public DateTime NextDate(DateTime min, DateTime max)
    {
        TimeSpan dif = max - min;
       return min.AddDays(Next(0, dif.Days));
    }
}