
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string number1 = number.ToString();

if (number1.Length != 5)
{
    Console.WriteLine("Такое значение не правильное!");
}
else
{
    if (number1[0] == number1[4] && number1[1] == number1[3]){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }
}