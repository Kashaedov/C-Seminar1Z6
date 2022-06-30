Console.WriteLine ("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());


if  (number1%2 == 0)
{
    Console.WriteLine ($"Введенное Вами число {number1} является четным");
}
else  
{
  Console.WriteLine ($"Введенное Вами число {number1} является нечетным");
}
