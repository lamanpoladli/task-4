float muddet = 9;
float birinci = muddet * 1;
float ilk_pul = 3;
float first = (((muddet - ilk_pul) * 80) / 100) + ilk_pul;
float second = (((muddet - 5) * 50) / 100) + ((2 * 80) / 100) + ilk_pul;
float third = (((muddet - 8) * 25) / 100) + ((2 * 80) / 100) + ilk_pul + ((3 * 50) / 100);
if (muddet >= 1 && muddet <= 3)
{
    Console.WriteLine(birinci);
}
else if (muddet == 4 || muddet == 5)
{
    Console.WriteLine(first);
}
else if (muddet == 6 || muddet == 7 || muddet == 8)
{
    Console.WriteLine(second);
}
else
{
    Console.WriteLine(third);
}
