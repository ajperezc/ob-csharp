// Exercise 1 - While

Console.Write("Insert a int number to calculate its multiplication table: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n-----" + number + " MULTIPLICATION TABLE ----- \n");
int num = 1;
while (num <= 10)
{
    int result = num * number;
    Console.WriteLine(num + " x " + number + " = " + result);
    num++;
}

// Exercise 2 - Do While

int count = 1, countNegative = 0, countPositive = 0, countZero = 0;
do
{
    Console.Write("\nInsert a int number to count (negative, zero or positive): ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 < 0)
    {
        countNegative++;
        count++;
    }
    else if (number2 > 0)
    {
        countPositive++;
        count++;
    }
    else
    {
        countZero++;
        count++;
    }
    Console.WriteLine("Counter: Negative: " + countNegative + " Positive: " + countPositive + " Zero: " + countZero);
} while (count <= 10);

// Exercise 3 For

Console.WriteLine("\n-----Drawing a rectangle-----\n");
Console.Write("Insert the height (number): ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the width (number): ");
int width = Convert.ToInt32(Console.ReadLine());
        
Console.Write("With filling? (Y/N): ");
string withFilling = Console.ReadLine();
Console.Write("How much filling? (number): ");
int qFilling = Convert.ToInt32(Console.ReadLine());

string filling = new string('*', qFilling);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        if ((withFilling == "N") && (i > 0 && i < height -1) && (j > 0 && j < width -1))
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write(filling);
        }
    }
    Console.Write("\n");
};
