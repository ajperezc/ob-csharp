// Exercise 1 - While

Console.Write("Insert a int number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n-----" + number + " MULTIPLICATION TABLE ----- \n");
int i = 1;
while (i <= 10)
{
    int result = i * number;
    Console.WriteLine(i + " x " + number + " = " + result);
    i++;
}

// Exercise 2 - Do While

int j = 1, countNegative = 0, countPositive = 0, countZero = 0;
do
{
    Console.Write("\nInsert a int number: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 < 0)
    {
        countNegative++;
        j++;
    }
    else if (number2 > 0)
    {
        countPositive++;
        j++;
    }
    else
    {
        countZero++;
        j++;
    }
    Console.WriteLine("Counter: Negative: " + countNegative + " Positive: " + countPositive + " Zero: " + countZero);
} while (j <= 10);

// Exercise 3 For

     
     
