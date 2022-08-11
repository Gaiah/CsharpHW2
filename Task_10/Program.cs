Console.WriteLine("Enter a three-digit number");
int usersNumber = Convert.ToInt32(Console.ReadLine());

if (1000 > usersNumber && usersNumber > 99)
{
 Console.Write("The entered number's second digit is: ");
 Console.WriteLine(usersNumber / 10 % 10);
}

else 
{
 Console.WriteLine("Entered number isn't a three-digit number.");
}