//Teht�v�.1
int i = 1;
while (i < 1000)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Numero " + i + " on jaollinen 3" + "\n");
    }
    i++;
}
//Teht�v�.2
Console.WriteLine("Arvaa numero 1-100 v�lilt�");
Random random = new Random();
int randomNumber = random.Next(1, 100);
int arvaus = Convert.ToInt32(Console.ReadLine());

while (arvaus != randomNumber)
{
    if (arvaus < randomNumber)
    {
        Console.WriteLine("Arvaus liian pieni");
        arvaus = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Arvaus liian suuri");
        arvaus = Convert.ToInt32(Console.ReadLine());

    }
}
Console.WriteLine("Arvasit oikein!" + "\n");

//Teht�v�.3 ja Teht�v�.4 muutin oletus arvo 10 k�ytt�j�n antamaan m��r��n
int sum = 0, value, maara;
float keski;

Console.WriteLine("Anna numeroiden m��r�: ");
maara = Convert.ToInt32(Console.ReadLine());

for (int a = 0; a < maara; a++)
{
    Console.Write("Anna numerot: ");
    value = Convert.ToInt32(Console.ReadLine());
    sum += value;
}

keski = (float)sum / maara;
Console.WriteLine("Yhteens�: " + sum + ", Keskiarvo: " + keski + "\n");


//Teht�v�.5
Console.WriteLine("Montako kaveria sinulla on?: ");
int kaverit = Convert.ToInt32(Console.ReadLine());
string[] nimet = new string[kaverit];

for (int x = 0; x < kaverit; x++)
{
    Console.WriteLine("Anna nimi: ", x + 1 + "\n");
    nimet[x] = Console.ReadLine();
}
Console.Write("Kaverisi: " + "\n");

for (int x = 0; x < kaverit; x++)
{
    Console.WriteLine(nimet[x]);
}


//Teht�v�.6
Console.WriteLine("Anna kymmenen numeroa: ");
int numerot = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
for (int a = 0; a < 10; a++)
{
    Console.WriteLine("Anna numero: ", a + 1);
    array[a] = Convert.ToInt32(numerot);
    array[a] = Convert.ToInt32(Console.ReadLine());
}
Array.Reverse(array);
Console.WriteLine(String.Join(',', array));


//Teht�v�.7
Console.WriteLine("Kuinka monta t�hte� (*) tulostetaan?");
int luku = Convert.ToInt32(Console.ReadLine());
for (int lukum = 0; lukum < luku; lukum++)
{
    Console.Write("#", lukum, "\n");
}

