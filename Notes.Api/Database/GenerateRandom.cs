namespace Notes.Api.Database;

using System;
using System.Linq;
using Notes.Api.Models;

public static class GenerateRandom
{
    public static string Content =>
        new string("Här är lite text som används för att fylla anteckningar med innehåll på svenska språket."
            .Take(Random.Next(5, 100))
            .ToArray());

    public static User User => new User
    {
        Username = Username,
        Password = Password,
    };

    public static string Password => Guid.NewGuid().ToString();

    public static string Username => $"{GivenName} {Surname}";

    public static string GivenName => GivenNames[Random.Next(GivenNames.Length)];

    public static string Surname => Surnames[Random.Next(Surnames.Length)];

    private static readonly Random Random = new Random();

    private static readonly string[] Surnames = new string[]
    {
        "Andersson",
        "Johansson",
        "Karlsson",
        "Nilsson",
        "Eriksson",
        "Larsson",
        "Olsson",
        "Persson",
        "Svensson",
        "Gustafsson",
        "Pettersson",
        "Jonsson",
        "Jansson",
        "Hansson",
        "Bengtsson",
        "Jönsson",
        "Lindberg",
        "Jakobsson",
        "Magnusson",
        "Olofsson",
    };

    private static readonly string[] GivenNames = new string[]
    {
        "Anna",
        "Erik",
        "Maria",
        "Lars",
        "Karin",
        "Nils",
        "Ingrid",
        "Olof",
        "Astrid",
        "Gustav",
        "Margareta",
        "Johan",
        "Birgitta",
        "Karl",
        "Elisabeth",
        "Anders",
        "Gunvor",
        "Per",
        "Barbro",
        "Bengt",
        "Linnéa",
        "Sven",
        "Ulla",
        "Bo",
        "Gunilla",
        "Lennart",
        "Maj",
        "Rolf",
        "Britt",
        "Göran",
        "Marianne",
        "Ulf",
        "Lena",
        "Kjell",
        "Eva",
        "Åke",
        "Annika",
        "Leif",
        "Berit",
        "Mats",
        "Christina",
        "Jan",
        "Inger",
        "Christer",
        "Monica",
        "Stefan",
        "Susanne",
        "Mikael",
        "Agneta",
        "Hans",
        "Carina",
        "Tommy",
        "Helena",
        "Björn",
        "Kristina",
        "Ingemar",
        "Margaretha",
        "Gunnar",
        "Anita",
        "Peter",
        "Catharina",
        "Thomas",
        "Johanna",
        "Kenneth",
        "Camilla",
        "Rickard",
        "Emma",
        "Magnus",
        "Sara",
        "Jonas",
        "Linda",
        "Daniel",
        "Malin",
        "Mattias",
        "Elin",
        "Alexander",
        "Josefin",
        "Fredrik",
        "Hanna",
        "Oscar",
        "Petra",
        "Henrik",
        "Rebecka",
        "Sebastian",
        "Julia",
        "Viktor",
        "Therese",
        "Niklas",
        "Sandra",
        "Marcus",
        "Jenny",
        "Patrik",
        "Caroline",
        "Anton",
        "Sofie",
        "Filip",
        "Marie",
        "Johan",
        "Frida",
        "Emil",
        "Lovisa",
        "Axel",
        "Ida",
        "Adam",
        "Matilda",
        "William",
        "Klara",
        "Hugo",
        "Elsa",
    };
}