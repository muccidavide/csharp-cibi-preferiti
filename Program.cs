// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "pizza", "pasta", "lasagna", "cioccolato", "gelato", "hamburger"};

// lunghezza classifica
Console.WriteLine(cibiPreferiti.Length);

// classifica
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(i + " " + cibiPreferiti[i]);
}

// Cibo Top
Console.WriteLine("Top: " + cibiPreferiti[0]);

// Cibo notTop
int posizioneUltimoCibo = cibiPreferiti.Length - 1;
Console.WriteLine("Last: " + cibiPreferiti[posizioneUltimoCibo]);

// BONUS: mediana
double mediana = cibiPreferiti.Length % 2;


if(mediana == 0)
{
    int posizione1 = (cibiPreferiti.Length + 1)/ 2; // 3
    int posizione2 = posizione1 + 1; // 4
    
    Console.WriteLine(cibiPreferiti[posizione1]);
    Console.WriteLine(cibiPreferiti[posizione2]);
}
else
{
    int posizione1 = (cibiPreferiti.Length - 1) / 2;
    Console.WriteLine(cibiPreferiti[posizione1]);

}