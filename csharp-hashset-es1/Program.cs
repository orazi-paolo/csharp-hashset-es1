// dichiaro un HashSet di stringhe
var animals = new HashSet<string>() { "Cane", "Gatto", "Elefante", "Leone" };
// rimuovo un elemento specifico
animals.Remove("Elefante");
// stampo il HashSet aggiornato
Console.WriteLine("HashSet aggiornato:");
foreach (string animal in animals)
{
    Console.WriteLine(animal);
}
