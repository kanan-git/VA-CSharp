// TASK: istifadeciden bir eded alin, hem 3 hem 5 e bolunurse true, yanliz 3 - yalniz 3, 5-5, none-none
static void App()
{
    Console.Write("Eded daxil edin: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number%15 == 0)
    {
        Console.WriteLine("Eded hem 3-e, hem de 5-e qaliqsiz bolunur");
    }
    else if(number%3 == 0)
    {
        Console.WriteLine("Eded 3-e qaliqsiz bolunur");
    }
    else if(number%5 == 0)
    {
        Console.WriteLine("Eded 5-e qaliqsiz bolunur");
    }
    else
    {
        Console.WriteLine("Eded ne 3-e, ne de 5-e qaliqsiz bolunmur");
    };
};

App();
