// TASK: istifadeciden 3 eded al, ucbucagin terefleri, hamisi beraberdirse "beraberterefli", 2 si beraberdirse "beraberyanli", hamisi ferqlidirse "muxtelif terefli"

Console.WriteLine("Birinci bucaq: ");
int Angle1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ikinci bucaq: ");
int Angle2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ucuncu bucaq: ");
int Angle3 = int.Parse(Console.ReadLine());

if(Angle1 + Angle2 + Angle3 != 180)
{
    Console.WriteLine("Ucbucagin daxili bucaqlarinin cemi 180 dereceye beraber olmalidir!");
}
else
{
    if(Angle1 == Angle2 && Angle1 == Angle3)
    {
        Console.WriteLine("Ucbucaq berabertereflidir");
    }
    else if(Angle1 == Angle2 || Angle1 == Angle3 || Angle2 == Angle3)
    {
        Console.WriteLine("Ucbucaq beraberyanlidir");
    }
    else
    {
        Console.WriteLine("Ucbucaq muxtelif tereflidir");
    };
};
