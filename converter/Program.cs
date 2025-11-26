

using System.ComponentModel;
using System.IO;

internal class Program
{
//    public string[] UnitsName = new string[9]
//    {
//        "один",
//        "два",
//        "три",
//        "четыре",
//        "пять",
//        "шесть",
//        "семь",
//        "восемь",
//        "девять"
//    };
//    public static string[] TenthsName = new string[9]
//    {
//        "десять",
//        "двадцать",
//        "тридцать",
//        "сорок",
//        "пятьдесят",
//        "шестьдесят",
//        "семьдесят",
//        "восемьдесят",
//        "девяносто"
//    };
//    public string[] HundredName = new string[9]
//    {
//        "сто",
//        "двести",
//        "триста",
//        "четыреста",
//        "пятьсот",
//        "шестьсот",
//        "семьсот",
//        "восемьсот",
//        "девятьсот"
//    };
//public string[] PlacesName = new string[4] 
//    {
//        "тысяч",
//        "миллион",
//        "миллиард",
//        "триллион"
//    };
    //public Dictionary<string, string[]> Declination = new Dictionary<string, string[]>()
    //{
    //    { "Иж", ["одна", "две", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять"]},
    //    { }
    //};
    public List<string>placesNumber = new List<string>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целочисленное число, число не должно");
        string number = Console.ReadLine();
        List<string> x = TriplesNumbers(number);
        foreach(string s in x)
        {
            Console.WriteLine(s);
        }
    }
    private static bool CheckNum(int number)
    {
        if (number.ToString()[0] == '0')
        {
            Console.WriteLine("Вы ввели число начинающее с нуля");
            return true;
        }
        return false;
    }

    public  void SplitNumber(int number) 
    {
        if(number.ToString().Length/3 == 0) placesNumber.Add(number.ToString());
    }
    public int[] PlacesNumbers(int num)
    {
        int[] places = new int[num.ToString().Length];
        int lenght = num.ToString().Length;
        for (int i = 0; i < lenght; i++)
        {
            if (num.ToString().Length == 1) places[i] = num;
            int place = num % 10;
            num = num / 10;
            places[i] = place;
        }
        return places;
    }
    private static List<string> TriplesNumbers(string places)
    {
        List<string> triples = new List<string>();
        int endIndex = places.Length; // Начинаем с конца строки

        // Пока индекс больше нуля
        while (endIndex > 0)
        {
            int startIndex = Math.Max(endIndex - 3, 0); // Определяем стартовый индекс подгруппы
            int length = endIndex - startIndex; // Длина текущей подгруппы
            triples.Insert(0, places.Substring(startIndex, length)); // Добавляем новую часть в начало списка
            endIndex -= 3; // Переход к следующей группе
        }

        triples.Reverse();
        //while (startIndex > 0)
        //{
        //    startIndex = Math.Max(0, startIndex - 3);
        //    int length = 3;
        //    triples.Add(places.Substring(startIndex, length));

        //}
        return triples;
    }
}

//разделение строки длинна которой не кратна 3
//string originalString = "abcdefghij";
//List<string> parts = new List<string>();
//int startIndex = 0;

//while (startIndex < originalString.Length)
//{
//    int length = Math.Min(3, originalString.Length - startIndex);
//    parts.Add(originalString.Substring(startIndex, length));
//    startIndex += 3;
//}
