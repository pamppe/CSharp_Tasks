//Tehtävä.1 ja tehtävä.2
int ika;
string vastaus;
Console.WriteLine("Poke kysyy, mikä on sinun ikäsi?");
ika = Convert.ToInt32(Console.ReadLine());

if (ika >= 20)
{
    Console.WriteLine("Tervetuloa ravintolaan!" + "\n");
}
else if (ika < 18)
{
    Console.WriteLine("Mene kotiin kasvaan ja karvottuun!" + "\n");
}
else if (ika >= 18)
{
    Console.WriteLine("Onko papereita kyllä/ei?");
    vastaus = Console.ReadLine();
    if (vastaus == "kyllä")
    {
        Console.WriteLine("Tervetuloa!" + "\n");
    }
   else if (vastaus == "ei") {
        Console.WriteLine("Hyvä yritys!" + "\n");
    }      
}

//Tehtävä.3
Console.WriteLine("Anna luku: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("{0} on parillinen luku", num);
}
else
    Console.WriteLine("{0} on pariton luku", num);


//Tehtävä.4
Console.WriteLine("Kerro ekan vuoden opintopistemääräsi: ");
int piste = Convert.ToInt32(Console.ReadLine());

if (piste < 45)
{
    Console.WriteLine("Kela ja opet ei tykkää");
}
else if (piste < 55)
{
    Console.WriteLine("Opet ei tykkää");
}
else
    Console.WriteLine("Onittelut onnistuneesta ensimmäisestä opiskeluvuodesta! :)");


//Tehtävä.5
int eka, toka, kolmas;
Console.WriteLine("Anna eka numero: ");
eka = int.Parse(Console.ReadLine());

Console.WriteLine("Anna toka numero: ");
toka = int.Parse(Console.ReadLine());

Console.WriteLine("Anna komas numero: ");
kolmas = int.Parse(Console.ReadLine());

if (eka > toka)
{
    if (eka > kolmas) 
{
    Console.WriteLine("Suurin luku: " + eka);
}
else
{
    Console.WriteLine("Suurin luku: " + kolmas);
}
}

else
    {
        if (toka > kolmas)
        {
            Console.WriteLine("Suurinn luku: " + toka);
        }
        else
        {
            Console.WriteLine("Suurin luku: " + kolmas);
        }
    }


//Tehtävä.6
Console.WriteLine("Syötä ohjelmointi kurssin arvosanasi (0-5): ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 0:
        Console.WriteLine("{0} -hylätty", x);
        break;
    case 1:
        Console.WriteLine("{0} -tyydyttävä" ,x);
        break;
    case 2:
        Console.WriteLine("{0} -tyydyttävä", x);
        break;
    case 3:
        Console.WriteLine("{0} -hyvä", x);
        break;
    case 4:
        Console.WriteLine("{0} -hyvä", x);
        break;
    case 5:
        Console.WriteLine("{0} -kiitettävä", x);
        break;

}
