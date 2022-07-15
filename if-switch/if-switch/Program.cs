// Exercise 1
Console.WriteLine("-----Discount Calculator-----\n");
Console.Write("Insert your name: ");
string name = Console.ReadLine();
Console.Write("Insert your email address: ");
string email = Console.ReadLine();
Console.Write("Insert your coupon code: ");
string couponCode = Console.ReadLine();

float price = 149.90f;

if (couponCode == null)
{
    Console.WriteLine("The price of the item is: " + Math.Round(price, 2) + "$");
}
else
{
    Console.WriteLine("The price of the item is: " + Math.Round(price * 0.70, 2) + "$");

}

// Exercise 2
Console.WriteLine("\n-----Programming Languages-----\n");
List<string> languages = new List<string>{"Python", "JavaScript", "C#", "Java"};
for (int i = 0; i < languages.Count; i++)
{
    Console.WriteLine("Language {0}# = {1}", i, languages[i]);
}

Console.Write("\nWhat is your favourite? (insert the number position): ");
int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        Console.WriteLine($"Your favourite language is: {languages[choice]}");
        break;
    case 2:
        Console.WriteLine($"Your favourite language is: {languages[choice]}");
        break;
    case 3:
        Console.WriteLine($"Your favourite language is: {languages[choice]}");
        break;
    case 4:
        Console.WriteLine($"Your favourite language is: {languages[choice]}");
        break;
}