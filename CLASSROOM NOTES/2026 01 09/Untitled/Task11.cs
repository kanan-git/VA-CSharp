// TASK: istifadeciden iki eded al, o araqlida olan cut ededleri tap

Console.WriteLine("Birinci ededi daxil edin: ");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Ikinci ededi daxil edin: ");
int SecondNumber = int.Parse(Console.ReadLine());

EvenNumbersBetween(FirstNumber, SecondNumber);

static void EvenNumbersBetween(int StartNumber, int FinishNumber)
{
    if(StartNumber > FinishNumber)
    {
        int temp = StartNumber;
        StartNumber = FinishNumber;
        FinishNumber = temp;
    };

    Console.Write("Netice (ededler arasindaki cut ededler): ");

    for(int i=StartNumber; i<=FinishNumber; i++)
    {
        if(i % 2 == 0)
        {
            Console.Write(i + " ");
        };
    };
};
