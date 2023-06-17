//Задача 2. Напишите программу, которая на вход принимает два числа
//и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3
/*
Console.WriteLine("Enter first number: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if (num_a > num_b)
{
    Console.WriteLine("first number " + num_a + " more than the second " + num_b );
}
else
{
    Console.WriteLine("second number" + num_b + " more than the first " + num_a );    
}
*/
//Задача 4. Напишите программу, которая принимает на вход три числа
//и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44, 5, 78 -> 78
//22, 3, 9 -> 22
/*
Console.WriteLine("Enter three numbers:");
int num_1 = Convert.ToInt32(Console.ReadLine()); 
int num_2 = Convert.ToInt32(Console.ReadLine()); 
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("The largest of the entered numbers -> " + max);
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдает,
//является ли число четным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == -1)
{
    Console.WriteLine("number " + number + " constitute: odd integer");
}
else
{
    Console.WriteLine("number " + number + " constitute: even integer");
}
*/
//Задача 8. Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все четные числа от 1 до N.
//5 -> 2, 4.
//8 -> 2, 4, 6, 8.

int i = 1;
bool not = true;

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Even numbers from 1 to " + number);
while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("There are no even numbers!");
}


