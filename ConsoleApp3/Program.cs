using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime yearofBirth = new DateTime(1995, 2, 22, 23, 30, 45);
        DateTime yearofGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
        DateTime timeNow = DateTime.Now;

        TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;
        TimeSpan ageNow = timeNow - yearofBirth;
        int timeinMinutes = ageNow.Minutes;
        Console.WriteLine(ageNow);


        Console.WriteLine("Input any number");
        string number = Console.ReadLine();

        File.WriteAllText(@"C:\Users\keyes\Desktop\log.txt", number);

        //This gets rid and erases memory
        using (StreamWriter file = new StreamWriter(@"C:\Users\keyes\Desktop\log.txt", true))
        {
            file.WriteLine(number);
            file.WriteLine(timeNow);
        }

        List<string> names = new List<string>();
        names.Add("Benjamin Button");
        names.Add("Hotel Moon");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}