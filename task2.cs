//Teht�v�.1 ja teht�v�.2
int ika;
string vastaus;
Console.WriteLine("Poke kysyy, mik� on sinun ik�si?");
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
    Console.WriteLine("Onko papereita kyll�/ei?");
    vastaus = Console.ReadLine();
    if (vastaus == "kyll�")
    {
        Console.WriteLine("Tervetuloa!" + "\n");
    }
    else if (vastaus == "ei")
    {
        Console.WriteLine("Hyv� yritys!" + "\n");
    }
}

//Teht�v�.3
Console.WriteLine("Anna luku: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("{0} on parillinen luku", num);
}
else
    Console.WriteLine("{0} on pariton luku", num);


//Teht�v�.4
Console.WriteLine("Kerro ekan vuoden opintopistem��r�si: ");
int piste = Convert.ToInt32(Console.ReadLine());

if (piste < 45)
{
    Console.WriteLine("Kela ja opet ei tykk��");
}
else if (piste < 55)
{
    Console.WriteLine("Opet ei tykk��");
}
else
    Console.WriteLine("Onittelut onnistuneesta ensimm�isest� opiskeluvuodesta! :)");


//Teht�v�.5
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


//Teht�v�.6
Console.WriteLine("Sy�t� ohjelmointi kurssin arvosanasi (0-5): ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 0:
        Console.WriteLine("{0} -hyl�tty", x);
        break;
    case 1:
        Console.WriteLine("{0} -tyydytt�v�", x);
        break;
    case 2:
        Console.WriteLine("{0} -tyydytt�v�", x);
        break;
    case 3:
        Console.WriteLine("{0} -hyv�", x);
        break;
    case 4:
        Console.WriteLine("{0} -hyv�", x);
        break;
    case 5:
        Console.WriteLine("{0} -kiitett�v�", x);
        break;

}