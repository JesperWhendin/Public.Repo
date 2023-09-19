using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintro_C__2023
{
    internal class Pokemon
    {
        // Dessa variabler är deklarerade med _ i början av namnen för att de
        // symboliserar fields/fält. De deklareras på det här sättet för att
        // de finns för hela klassen och inte är lokala varabler.Fält kan också
        // ha access modifiers* (*AM) (så som public eller private) *AM används
        // för att skydda variabler så att de inte skall kunna ändras hur som helst.

        public string _name;
        public string _type;
        public int _level;

        // Undertill här är en tom konstruktor* (*ctor), den behöver
        // inte skrivas ut då en klass som har en odefinerad ctor alltid
        // har en defaultkonstruktor (vilket är en tom ctor).

        public Pokemon() 
        {
            
        }

        // Detta ovan är en klass med en tom ctor, dvs. den kan instansieras utan
        // att ta in parametrar. Man kan skapa en ny ctor som tvingar intag av parametrar
        // för att instansiera en ny klass. Exempel nedan där field/fält används.

        public Pokemon(string name, string type, int level) 
        {
            _name = name; // Exempel på hur fält används i jämförelse med variabler.
            _type = type;
            _level = level;
        }

        // Ett annat sätt, som verkar säkrare då inte användaren fritt
        // kan ange namn eller andra parametrar när ett objekt instansieras,
        // är med så kallade properties. En property är egentligen bara en 
        // field (fält) och två sammanhängande metoder, get- och set-.
        // Get-metod är till för att kontrollera hur ett värde presenteras.
        // Set-metod är till för att kontrollera hur ett värde sätts.

        private string _characterTrait;
        public string CharacterTrait
        {
            get
            {
                Console.WriteLine(_name + " has a " + _characterTrait + " behaviour.");
                return _characterTrait;
            }
            //  Get-metoden på rad 51 ser egentligen ut som följande:

            // public string get_CharacterTrait()
            // {
            //    return _name;
            // }

            set
            {
                Console.WriteLine(_name + " was given a " + _characterTrait + " behaviour.");
                _characterTrait = value;
            }
            // Set-metoden är på samma sätt som get- också en metod:

            // public void set_CharacterTrait(string value)
            // {
            //     _characterTrait = value;
            // }

            // Den här propertyn låter en nu styra fältet, _characterTrait,
            // även om det ligger som private.
        }

        // Här nedan är ytterligare ett sätt att instansiera en Pokemon med fler parametrar.
        // public Pokemon(string name, string type, int level, string characterTrait)
        // {
        //     _name = name;
        //     _type = type;
        //     _level = level;
        //     _characterTrait = characterTrait;
        // }
        
    }
 }

