//Tehtävä.1
Console.WriteLine("Olen Emil.L ja tykkään koodata! \n");

//Tehtävä.2
Console.WriteLine("Mikä on nimesi?");
string nimi = Console.ReadLine();
Console.WriteLine("Moi " + nimi + "\n");

//Tehtävä.3
int ika;
int ika2;

Console.WriteLine("Anna ikäsi: "); 
ika = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Anna äitisi ikä: ");
ika2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ikä ero on: " + (ika2 - ika) + " vuotta" + "\n");

//Tehtävä.4
double sivu;
Console.WriteLine("Anna neliön sivu pituus");
sivu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Anna neliön toisen kulman pituus");
sivu = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Neliön pinta-ala on: " + (sivu * sivu) + "\n");

//Tehtävä.5
Console.WriteLine("Anna ympyrän säde: ");
double sade = Convert.ToDouble(Console.ReadLine());
double pinta_ala = Math.PI * sade * sade;
Console.WriteLine("Ympyrän pinta-ala on: " + pinta_ala + "\n");

//Tehtävä.6
double joule = 4.184;
double kalorit;
Console.WriteLine("Anna illallisen kalorien määrä: ");
kalorit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Joulien määrä illallisesta on: " + kalorit * joule + " Joulea" + "\n");






