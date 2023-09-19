using OOPintro_C__2023;
using System.Net.Security;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Intro och grunder inom OOP.");
Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("---------------------------"); Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Test av instansiering utan hjälp av konstruktor / ctor");

Pokemon abra = new Pokemon(); // Instansierar ett nytt objekt av klassen/typen Pokemon
// Denna instansen av klassen/typen är döpt till abra och här deklarerar jag namn, type och level.
abra._name = "Abra";
abra._type = "Psychic";
abra._level = 10;

Console.WriteLine(abra); // Skriver ut "OOPintro_C__2023.Pokemon", vilket är typen på detta objektet.
// Typen är Pokemon och Pokemon ligger i namespace OOPintro_C__2023
Console.WriteLine(abra._name); // Skriver ut det deklarerade namnet för abra
Console.WriteLine(abra._type); // Skriver ut den deklarerade pokeTypen för abra
Console.WriteLine(abra._level); // Skriver ut den deklarerade leveln för abra

Console.WriteLine(); // Radbrytning.

Pokemon pidgey = new Pokemon(); // Ny instans av klassen/typen Pokemon i form av pidgey
pidgey._name = "Pidgey";
pidgey._type = "Flying";
pidgey._level = 5;

Console.WriteLine(pidgey); // Skriver fortfarande ut "OOPintro_C__2023.Pokemon" då
// pidgey och abra är instanser av samma typ.
Console.WriteLine(pidgey._name);
Console.WriteLine(pidgey._type);
Console.WriteLine(pidgey._level);

Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("---------------------------"); Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Test av instansiering med hjälp av ctor.");

Pokemon machop = new Pokemon("Machop", "Fighting", 15);
// Exempel på hur en klass instansieras med hjälp av en ctor.

Console.WriteLine(machop); // För att belysa ny instans av samma klass/typ.
Console.WriteLine(machop._name);
Console.WriteLine(machop._type);
Console.WriteLine(machop._level);
// Enbart machop.name går inte då name är en lokal variabel för klassen.
// Därför använder man sig här av fält (ex: _name) för att beropa detta objektets specifika variabel.
Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("---------------------------"); Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Test av instansiering med hjälp av properties.");

Pokemon scyther = new Pokemon("Scyther", "Bug", 20);

Console.WriteLine(scyther); // Belyser ny instans av samma klass/typ - "OOPintro_... "
Console.WriteLine(scyther._name);
Console.WriteLine(scyther._type);
Console.WriteLine(scyther._level);
// Console.WriteLine(scyther.Level); - Level i det här fallet är en lokal variabel i Pokemon.cs.
scyther.CharacterTrait = "defensive";
// scyther._characterTrait = "Aggressive"; - Inaccessible due to protectionlevel (private).
// Här förändrar vi alltså värdet på _characterTrait, även om det ligger som private.
// Detta på grund av propertyn och dess get-/set- metoder.
Console.WriteLine(scyther.CharacterTrait);
// Console.WriteLine(scyther._characterTrait); - Går heller inte att nå likt exemplet någon rad ovan.

Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine("---------------------------"); Console.ForegroundColor = ConsoleColor.White;

