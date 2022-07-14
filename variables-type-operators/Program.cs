// Exercise 1

Console.Write("Insert your first name: ");
string firstName = Console.ReadLine();

Console.Write("Insert your last name: ");
string lastName = Console.ReadLine();

Console.Write("Insert your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Do you know how to program in C# (Y/N): ");
string knowToProgram = Console.ReadLine();

Console.WriteLine("Tu nombre es " + firstName + " " + lastName + " and you have " + age + " years");
Console.WriteLine("Do you know how to program in C#: " + knowToProgram + " .");

// Exercise 2
// Car
int doors = 5;
int wheels = 4;
string brand = "Peugeot";
float weight = 1200.5f;
// Table
float length = 1.34f;
string material = "plastic";
string color = "blue";

Console.WriteLine("The " + brand + "'s car has " + doors + " doors, " + wheels + 
                  " wheels and its weight is " + weight + " kilograms." );
Console.WriteLine("The table has " + length + " meters, is made of " + material + " and its color is " + color + "." );

// Exercise 3

Console.Write("Insert your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is your age equal o greater than 18: " + (age >= 18));

Console.Write("Insert a letter: ");
char character = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Is your age equal o greater than 18: " + (character == 'a'));

Console.Write("Are you old? (Y/N): ");
string old = Console.ReadLine();
Console.Write("Are you tall? (Y/N): ");
string tall = Console.ReadLine();
Console.WriteLine("Are the last two question Yes? " + (old == "Y" && tall == "Y"));
Console.WriteLine("Are at least one question Yes? " + (old == "Y" || tall == "Y"));