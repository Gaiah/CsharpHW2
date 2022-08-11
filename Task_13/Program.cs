Console.WriteLine("Enter some number: ");
int usersNumber = Convert.ToInt32(Console.ReadLine());
int cycle = 0;

while (cycle < usersNumber) {
    if (usersNumber > 999) 
    {
        usersNumber = usersNumber / 10;
    }
    cycle++;
}

if (usersNumber > 99 && usersNumber < 1000) 
{
    Console.Write("The third digit is: ");
    Console.WriteLine(usersNumber % 10);
}

else 
{
 Console.WriteLine("There's no third digit in your number.");
}