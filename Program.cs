Console.Write("1-7 arasında sayı gir");
int s = Convert.ToInt32(Console.ReadLine());
switch (s)
{
    case 1: Console.WriteLine("pazartesi"); break;
    case 2: Console.WriteLine("salı"); break;
    case 3: Console.WriteLine("çarşamba"); break;
    case 4: Console.WriteLine("perşembe"); break;
    case 5: Console.WriteLine("cuma"); break;
    case 6: Console.WriteLine("cumartesi"); break;
    case 7: Console.WriteLine("pazar"); break;
}
