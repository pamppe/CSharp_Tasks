//My name
Console.WriteLine("I'm Emil.L and and i like programming! \n");

//Your name
Console.WriteLine("Whats your name?");
string nimi = Console.ReadLine();
Console.WriteLine("Hi " + nimi + "\n");

//Age diffrence
int ika;
int ika2;

Console.WriteLine("Insert name: ");
ika = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert your moms name: ");
ika2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Age difference is: " + (ika2 - ika) + " years" + "\n");

//The area of square
double sivu;
Console.WriteLine("Enter square side lenght");
sivu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another square side lenght");
sivu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Square area is: " + (sivu * sivu) + "\n");

//The area of circle
Console.WriteLine("Enter the radius of the circle: ");
double sade = Convert.ToDouble(Console.ReadLine());
double pinta_ala = Math.PI * sade * sade;
Console.WriteLine("The area of the circle is: " + pinta_ala + "\n");

//Calories to joules
double joule = 4.184;
double kalorit;
Console.WriteLine("Enter the number of calories in the dinner: ");
kalorit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The number of joulies from dinner is: " + kalorit * joule + " Joule" + "\n");
