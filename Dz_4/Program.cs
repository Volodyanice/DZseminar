//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thrdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (firstNumber>max) max = firstNumber;
if (secondNumber>max) max = secondNumber;
if ( thrdNumber > max) max = thrdNumber;
System.Console.WriteLine(max);