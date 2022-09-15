// See https://aka.ms/new-console-template for more information

string[] cibiPreferiti = { "pizza", "pasta", "lasagna", "cioccolato", "gelato", "hamburger", "carne"};

Console.WriteLine(cibiPreferiti.Length);

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine(cibiPreferiti[0]);

int posizioneUltimoCibo = cibiPreferiti.Length - 1;
Console.WriteLine(cibiPreferiti[posizioneUltimoCibo]);

double mediana = cibiPreferiti.Length % 2;
Console.WriteLine(mediana);


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