public static class Program
{

    public static void Main()
    {
        var barbies = new HashSet<string>(new[] {"1995", "2000", "2014", "2013", "2005", "2010", "1999", 
            "1998", "2015", "2011", "2012", "2002", "2006", "2007", "1996", "2018", "2009", "2004", "1992", "2021", 
            "2020", "2019", "1994", "2016", "2001", "2014" });

        // add this year's Barbie
        barbies.Add("2022");
        
        // remove the 2015 doll
        barbies.Remove("2015");

        // find out how many barbies are in the set
        Console.WriteLine($"There are {barbies.Count} Holiday Barbies in the set.");
        
        // determine whether you have the 2016 Special Edition Holiday Barbie
        if (barbies.Contains("2016"))
        {
            Console.WriteLine("You have the 2016 Special Edition Holiday Barbie");
        }
        else
        {
            Console.WriteLine("You need to buy the 2016 Special Edition Holiday Barbie");
        }
    }
}
