Console.WriteLine("Enter a number 1-7. A little hint bellow: Monday - 1; Tuesday - 2; Wednesday - 3; Thursday - 4; Friday - 5; Saturday - 6; Sunday - 7.");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8) 
{
 if ( day == 6 || day == 7)
 {
  Console.WriteLine("Yaay! Enjoy Your weekend!");
 }
 else 
 {
  Console.Write("Sorry, it's not a weekend yet.");
 }
}

else 
{
 Console.WriteLine("Incorrect number!");
}