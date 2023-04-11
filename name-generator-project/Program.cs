using System;

string[][] firstNames =
{
    new[] { "Adam", "Ben", "Charlie", "David", "Edward", "Frank", "George", "Henry", "Isaac", "Jack" }, // angol
    new[] { "Louis", "Pierre", "Charles", "Jacques", "Gabriel", "Lucas", "Nathan", "Thomas", "Simon", "Antoine" }, // francia
    new[] { "Antonio", "Juan", "Pedro", "Francisco", "Luis", "Miguel", "Carlos", "Javier", "David", "Jose" }, // spanyol
    new[] { "Hans", "Johann", "Heinrich", "Friedrich", "Karl", "Ludwig", "Otto", "Wilhelm", "Max", "Ernst" } // német
};

string[][] lastNames =
{
    new[] { "Anderson", "Baker", "Carter", "Davis", "Edwards", "Ford", "Garcia", "Harris", "Irwin", "Johnson" }, // angol
    new[] { "Dupont", "Martin", "Dubois", "Laurent", "Lefevre", "Girard", "Moreau", "Roux", "Fournier", "Berger" }, // francia
    new[] { "Garcia", "Martinez", "Lopez", "Rodriguez", "Gonzalez", "Hernandez", "Perez", "Sanchez", "Ramirez", "Torres" }, // spanyol
    new[] { "Schmidt", "Müller", "Fischer", "Weber", "Meyer", "Wagner", "Becker", "Schulz", "Hoffmann", "Koch" } // német
};

Random rand = new();

Console.WriteLine("Milyen nemzetiségű nevet szeretne generálni?");
Console.WriteLine("Írja be az 1 - angol, 2 - francia, 3 - spanyol, 4 - német lehetőségek közül az egyiket: ");

int langChoice = int.Parse(Console.ReadLine());

if (langChoice < 1 || langChoice > 4)
{
    Console.WriteLine("Érvénytelen választás. Kérjük, adjon meg egy számot 1 és 4 között.");
    return;
}

string[] selectedFirstNames = firstNames[langChoice - 1];
string[] selectedLastNames = lastNames[langChoice - 1];

Console.WriteLine($"Generált név: {selectedFirstNames[rand.Next(selectedFirstNames.Length)]} {selectedLastNames[rand.Next(selectedLastNames.Length)]}");
