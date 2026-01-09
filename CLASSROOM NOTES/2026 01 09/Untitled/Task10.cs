// TASK: istifadeciden iki eded alin, I ededin reqemlerinin cemi, II ededin reqemleri cemi, hansi boyukdur
class Comparison
{
    static void Main(string[] args)
    {
        Console.Write("Birinci ededi daxil edin: ");
        int Input1 = int.Parse(Console.ReadLine());
        Console.Write("\nIkinci ededi daxil edin: ");
        int Input2 = int.Parse(Console.ReadLine());
        Console.WriteLine("-----------------------------");

        int FirstValue = SumDigits(Input1);
        int SecondValue = SumDigits(Input2);

        if(FirstValue > SecondValue)
        {
            Console.WriteLine(FirstValue + " > " + SecondValue);
        }
        else if(FirstValue < SecondValue)
        {
            Console.WriteLine(FirstValue + " < " + SecondValue);
        }
        else
        {
            Console.WriteLine(FirstValue + " = " + SecondValue);
        };
    }

    static int SumDigits(int number)
    {
        int sum = 0;
        while(true)
        {
            if(number / 10 < 1)
            {
                sum += number;
                break;
            };
            sum = sum + (number % 10);
            number /= 10;
        };
        return sum;
    }
};
