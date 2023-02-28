//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber>secondNumber)
    Console.WriteLine($"max = {firstNumber}");
else
    Console.WriteLine($"max = {secondNumber}");