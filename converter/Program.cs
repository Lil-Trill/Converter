
internal class Program
{
    public static string[] PlacesName = new string[3];
    private static void Main(string[] args)
    {
        int[] nums = PlacesNumbers(3454);
        for (int i = 0; i < nums.Length; i++) 
        { 
            Console.WriteLine(nums[i]);
        }
    }
    private static int[] PlacesNumbers(int num)
    {
        int[] places = new int[num.ToString().Length];
        int lenght = num.ToString().Length;
        for (int i = 0; i < lenght; i++)
        {
            if(num.ToString().Length == 1) places[i] = num;
            int place = num % 10;
            num = num / 10;
            places[i] = place;
        }
        return places;
    }
}   