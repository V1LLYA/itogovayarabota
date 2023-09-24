class Program
{
    static void Main()
    {

        string[] originalArray = {"Russia", "Denmark", "Kazan"};
        
        int count = 0;
        foreach (var str in originalArray)
        {
            if (str.Length <= 3)
                count++;
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (var str in originalArray)
        {
            if (str.Length <= 3)
                newArray[index++] = str;
        }

        Console.WriteLine("Новый массив:");
        foreach (var str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}