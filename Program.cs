// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "pizza", "pasta", "lasagna", "cioccolato", "gelato", "hamburger", "carne", "fagioli"};

// lunghezza classifica
Console.WriteLine("numero totale: " + cibiPreferiti.Length);

// classifica
Console.WriteLine("Classifica:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(i + " " + cibiPreferiti[i]);
}

// Cibo Top
Console.WriteLine("Cibo primo posto: " + cibiPreferiti[0]);

// Cibo notTop
int posizioneUltimoCibo = cibiPreferiti.Length - 1;
Console.WriteLine("Cibo ultimo posto: " + cibiPreferiti[posizioneUltimoCibo]);

// BONUS: mediana
double mediana = cibiPreferiti.Length % 2;


if(mediana == 0)
{
    int posizione1 = ((cibiPreferiti.Length + 1)/ 2) - 1; 
    int posizione2 = posizione1 + 1; 
    
    Console.WriteLine("Mediana: " + cibiPreferiti[posizione1] + " e " + cibiPreferiti[posizione2]);
}
else
{
    int posizione1 = ((cibiPreferiti.Length + 2) / 2) - 1;
    Console.WriteLine("Mediana: " + cibiPreferiti[posizione1]);

}