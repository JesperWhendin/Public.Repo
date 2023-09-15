Console.WriteLine("Jespers övningskompendium i C# 2023.");

void Övningsuppgift1()
{
    // 1.
    //
    // Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
    // Om namnet är "David" ska det skriva ut "Hej David!"

    int age = 29;
    string name = "Jesper";
    if (name == "Jesper")
    {
        Console.WriteLine("Du är {0} år gammal och heter {1}.", age, name);
        Console.WriteLine("Du heter " + name + " och du är " + age + " år gammal.");
    }
    else if (age > 25)
    {
        Console.WriteLine("Yikes");
    }
    else
    {
        Console.WriteLine("Vem är du?");
    }
    int counter = 0;
    while (counter == 10)
    {

        if (counter >= 10)
        {
            break;
        }
        Console.WriteLine("Loopen har körts {0} gånger.", counter);
        counter = counter + 1;
    }
    Console.WriteLine("----------------------------");

    for (int i = 0; i < 10; i++)
    {
        if (name != "Jesper")
        {
            break;
        }
        Console.WriteLine("Loopen har körts {0} gånger.", i);
    }
} // Simpel Read/Write-Line övning, spårade ur.

void Övningsuppgift2()
{
    // 2.

    // Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord
    // och spara det i en variabel. När användaren har skrivit in ett lösenord ska programmet jämföra
    // med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.

    string password = "asd123";
    string passwordEntry = null;

    Console.WriteLine("Skriv in ditt lösenord: ");
    passwordEntry = Console.ReadLine();

    if (password == passwordEntry)
    {
        Console.WriteLine("Du har skrivit in rätt lösenord.");
    }
    else
    {
        Console.WriteLine("Du har skrivit in fel lösenord.");
    }
} // Simpel if-sats

void Övningsuppgift3()
{
    // 3.

    // Skriv ett program som frågar användaren efter ett tal. Det ska 
    // skriva ut om talet är mindre än 100, lika med 100 eller större.

    int correctNumber = 100;
    int guessNumber = 0;
    bool correctGuess = false;

    while (correctGuess == false)
    {
        try
        {
            Console.Write("Skriv in ett tal: ");
            guessNumber = Convert.ToInt32(Console.ReadLine());

            if (guessNumber == correctNumber)
            {
                Console.WriteLine("Du har skrivit in rätt nummer.");
                correctGuess = true;
            }
            else if (guessNumber < correctNumber)
            {
                Console.WriteLine("Du har skrivit in ett för lågt nummer.");
                Console.WriteLine("Tryck på en tangent för att försöka igen.");
                Console.ReadKey();
            }
            else if (guessNumber > correctNumber)
            {
                Console.WriteLine("Du har skrivit in ett för högt nummer.");
                Console.WriteLine("Tryck på en tangent för att försöka igen.");
                Console.ReadKey();
            }
        }
        catch
        {
            guessNumber = 0;
            Console.WriteLine("Felaktig inmatning.");
            Console.WriteLine("Tryck på en tangent för att försöka igen.");
            Console.ReadKey();
        }
    }
} // Gissa nummret, simpel.

void Övningsuppgift4()
{
    // 4.

    // 1:
    // Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
    // Om namnet är "David" ska det skriva ut "Hej David!"
    //
    // 4:
    // Uppdatera programmet i uppgift 1 så att det även frågar efter ett tal.
    // Skriv hälsningen så många gånger som användaren anger.

    string nameEntry;
    int greetCounter;

    Console.WriteLine("Skriv ditt namn:");
    nameEntry = Console.ReadLine();


    Console.WriteLine("Skriv in ett tal mellan 0 och 10:");
    greetCounter = Convert.ToInt32(Console.ReadLine());

    while (greetCounter <= 10)
    {
        if (greetCounter <= 0)
        {
            break;
        }
        Console.WriteLine("Hej {0}.", nameEntry);
        greetCounter--;
    }

    // Vet inte vad jag ska med denna for loopen till.

    //for (int i = 0; i > greetCounter; i++)
    //{
    //    Console.WriteLine("Hej {0}", nameInitial);
    //}
} // Simpel whileloop på övning 1.

void Övningsuppgift5()
{
    // 5.

    //Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver
    //något som inte är ett tal (t.ex bara trycker enter). Efter varje inmatning ska summan av alla
    //tal som matats in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska
    //man även skriva ut medelvärde av de inmatade talen. Hint: TryParse()

    string stringInput;
    int numOutput = 0;
    int numEntry = 0;
    int numSum = 0;
    int whileIterations = 0;
    double meanSum;
    bool bengt;

    while (true) //Valde genvägen att sätta detta till true och break genom if-satsen
    {
        Console.WriteLine("Skriv in ett tal: ");
        stringInput = Console.ReadLine();
        int.TryParse(stringInput, out numOutput);
        numEntry = numOutput;

        if (numEntry > 0)
        {
            Console.WriteLine("Du skrev in talet: " + numEntry);
            numSum = numSum + numEntry;
            Console.WriteLine("Nu är summan av de inmatade talen: " + numSum);
            whileIterations++;
        }
        else if (whileIterations > 0)
        {
            Console.WriteLine("Summan av talen är: " + numSum);
            meanSum = (double)numSum / whileIterations;
            Console.WriteLine("Medelvärdet av talen är: " + meanSum);
            // Just nu tar programmet inte hänsyn till decimaler.
            break;
        }
        else
        {
            Console.WriteLine("Du har inte skrivit in något godkänt tal.");
            break;
        }
    }
} // TryParse övning.

void Övningsuppgift6()
{
    //6.

    //Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande
    //tecken: +, -, *eller /.Därefter ska ytterligare ett tal efterfrågas. Programmet ska
    //fungera som en simpel miniräknare. Om man t.ex matat in först 3, sedan *, och sist 5, så
    //ska programmet skriva ut: 3 * 5 = 15.

    double inputOne;
    double inputTwo;
    double outputSum;
    string calculatingChoice;

    Console.WriteLine("Hallå och välkommen till miniräknarjeppler!");

    try
    {
        Console.Write("Skriv in ett tal: ");
        inputOne = Convert.ToDouble(Console.ReadLine());
        Console.Write("Välj operator: ");
        calculatingChoice = Console.ReadLine();
        Console.Write("Skriv in ett tal: ");
        inputTwo = Convert.ToDouble(Console.ReadLine());

        if (calculatingChoice == "*")
        {
            outputSum = inputOne * inputTwo;
            Console.WriteLine(inputOne + " " + calculatingChoice + " " + inputTwo + " = " + outputSum);
            Console.WriteLine("Produkten av dina tal är: " + outputSum);
        }
        else if (calculatingChoice == "/")
        {
            outputSum = inputOne / inputTwo;
            Console.WriteLine(inputOne + " " + calculatingChoice + " " + inputTwo + " = " + outputSum);
            Console.WriteLine("Kvoten av dina tal är: " + outputSum);
        }
        else if (calculatingChoice == "+")
        {
            outputSum = inputOne + inputTwo;
            Console.WriteLine(inputOne + " " + calculatingChoice + " " + inputTwo + " = " + outputSum);
            Console.WriteLine("Summan av dina tal är: " + outputSum);
        }
        else if (calculatingChoice == "-")
        {
            outputSum = inputOne - inputTwo;
            Console.WriteLine(inputOne + " " + calculatingChoice + " " + inputTwo + " = " + outputSum);
            Console.WriteLine("Differensen av dina tal är: " + outputSum);
        }
        else
        {
            Console.WriteLine("Du har inte valt en godkänd operator.");
        }
    }
    catch
    {
        Console.WriteLine("Du har inte skrivit in ett godkänt tal.");
    }
} // Miniräknare med en enkel try/catch-sats som felhanterare.

void Övningsuppgift7()
{
    //7.

    //Skriv ett program som ber användaren skriva in en månad. Programmet ska göra om månaden till
    //månadens siffervärde. T.ex. ska januari bli 1 och december 12. Använd switch.'
    //Alternativ: Prova även att lösa uppgiften med array och/eller enum.

    //Extra utmaning: Be användaren om två månader och räkna sedan ut hur många månader som
    //skiljer mellan dem. Tänk på att ett månaderna upprepas till nästa år. Skriver man mars
    //och maj bör man få 2. Likaså om man skriver november och januari.


    //string monthInput;
    //int monthNumberOutput;



    //Console.WriteLine("Skriv in en månad:");
    //string monthInputString = Console.ReadLine();

    //GetMonthNumber(monthInputString);


    //// Metod som tar in strängen "Månad" och returnerar motsvarande nummer som en sträng.
    //int GetMonthNumber(int monthNumberOutput)
    //{
    //    int monthNumberOutput;
    //    switch (monthInput)
    //    {
    //        case "Januari":
    //            monthNumberOutput = 1;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Februari":
    //            monthNumberOutput = 2;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Mars":
    //            monthNumberOutput = 3;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "April":
    //            monthNumberOutput = 4;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Maj":
    //            monthNumberOutput = 5;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Juni":
    //            monthNumberOutput = 6;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Juli":
    //            monthNumberOutput = 7;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Augusti":
    //            monthNumberOutput = 8;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "September":
    //            monthNumberOutput = 9;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "Oktober":
    //            monthNumberOutput = 10;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "November":
    //            monthNumberOutput = 11;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        case "December":
    //            monthNumberOutput = 12;
    //            // Console.WriteLine(monthNumberOutput);
    //            break;
    //        default:
    //            Console.WriteLine("Du skrev in något tokigt.");
    //            break;
    //    }
    //    return monthNumberOutput;
    //}
} // Switch, försöker inkludera methodanrop  ---> FUNGERAR INTE <---

void Övningsuppgift8()
{
    // 4.

    //Skapa ett program som skriver ut 1 på första raden, 2 på nästa, sedan 4, o.s.v
    //(dubbelt så hög siffra för varje rad).Fortsätt till du skrivit ut 16 rader.

    int numSq = 1;

    for (int i = 0; i < 16; i++)
    {
        Console.WriteLine(numSq);
        numSq = numSq * 2;
    }
} // Simpel for-loop. Ej nedbruten som öupg10.

void Övningsuppgift9()
{
    // 9.

    //Skriv ett program som frågar användaren efter ett tal mellan 1 och 100.
    //Programmet ska ha ett hemligt tal lagrat i en variabel. Det ska fortsätta
    //fråga användaren till dess att användaren gissar det hemliga talet. Om man
    //gissade för högt eller för lågt så ska det skrivas ut, så att användaren
    //har en rimlig chans att klara det. Exempel: programmet har det hemliga talet
    //27. Användaren gissar på 50. Programmet skriver ut att användaren gissade för
    //högt. Användaren gissar på 20. Programmet skriver ut att det var för lågt.
    //Användaren gissar på 27.Programmet skriver ut att det var rätt och avslutas.

    //Extra utmaning: slumpa det hemliga talet med hjälp av Random (kolla upp på
    //google hur det fungerar). Spara antalet gissningar i en variabel och skriv ut
    //det när användaren gissat rätt.

    int guessNumber = 0;
    int guessCounter = 0;
    bool correctGuess = false;

    var rnd = new Random();
    long correctNumber = rnd.Next(1, 100);

    while (correctGuess == false)
    {
        try
        {
            Console.Write("Skriv in ett tal: ");
            guessNumber = Convert.ToInt32(Console.ReadLine());
            guessCounter++;
            if (guessNumber == correctNumber)
            {
                Console.WriteLine("Du har skrivit in rätt nummer.");
                Console.WriteLine("Du gissade {0} antal gånger.", guessCounter);
                correctGuess = true;
            }
            else if (guessNumber < correctNumber)
            {
                Console.WriteLine("Du har skrivit in ett för lågt nummer.");
                //Console.WriteLine("Tryck på en tangent för att försöka igen.");
                //Console.ReadKey();
            }
            else if (guessNumber > correctNumber)
            {
                Console.WriteLine("Du har skrivit in ett för högt nummer.");
                //Console.WriteLine("Tryck på en tangent för att försöka igen.");
                //Console.ReadKey();
            }
        }
        catch
        {
            guessNumber = 0;
            Console.WriteLine("Felaktig inmatning.");
            Console.WriteLine("Tryck på en tangent för att försöka igen.");
            Console.ReadKey();
        }
    }
} // Inte gjort sten-, sax-, påse- delen.

void Övningsuppgift10()
{
    // 10.

    //Be användaren mata in en sträng. Skriv ut varje tecken i
    //strängen på en egen rad. Ex:

    //Inmatning: Hej
    //H
    //e
    //j

    Console.WriteLine("Skriv in ett ord: ");
    string inputString = Console.ReadLine();

    //foreach (ex. för varje tecken i ordet - händer det inom curly brackets)
    //char        - är datatyp, som int eller string
    //sign        - är lokalt deklarerad variabel av typ char (i detta fall)
    //in          - det (datatyp + variabel) som _återfinns_ i inputString (stringen)
    //inputString - är min egna deklarerade sträng som jag sätter in
    //              i foreach-loopen och som även finns utanför.

    //foreach är i stort sett en forloop utan synlig iterator.

    foreach (char sign in inputString)
    {
        Console.WriteLine(sign);
    }
} // foreach - nedbrutet, kolla här om du glömt.

void Övningsuppgift11()
{
    // 11.

    // Skapa ett program med en array som innehåller strängarna “noll”, “ett”, “två”, “tre”,
    // “fyra”, “fem”, “sex”, “sju”, “åtta”, “nio”. Be sedan användaren att mata in en
    // siffra. Använd arrayen för att skriva ut siffrans ord. Ex.Inmatning “3” => “tre”.
    // Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man
    // skriver in t.ex 432 så svarar programmet: “fyra - tre - två”.

    string inputString;
    int outputInteger;

    while (true)
    {
        string[] siffror = new string[10] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

        Console.WriteLine("Skriv in en eller flera siffror mellan 0 och 9.");
        inputString = Console.ReadLine();

        for (int i = 0; i < inputString.Length; i++)
        {
            int siffra = int.Parse(inputString[i] + ""); // Detta är magi
            Console.Write(siffror[siffra]);


            if (i < siffra) //Stämmer inte, vet inte varför
            {
                Console.Write(" - ");
            }

        }
        Console.WriteLine();

        //// Sparar input som sträng, parse genom forloop char sign in inputString
        //foreach (char sign in inputString)
        //{

        //    int.TryParse(inputString, out outputInteger);

        //    //foreach (int digit in outputInteger)
        //    for (int i = 0; i < outputInteger; i++)
        //    {
        //        Console.Write(siffror[i]);
        //        if (outputInteger > i + 1)
        //        {
        //            Console.Write(" - ");
        //        }
        //    }
        //    Console.WriteLine();
        //}
    }
} // Arrayövning med siffror(int) till text(string), ej klar.

void Övningsuppgift12()
{
    // 10.

    // Fråga användaren hur många tal den vill mata in. Fråga sedan efter talen i tur och
    // ordning (“Ange tal 1:” osv). När alla tal är inmatade skriv ut dem i omvänd ordning.

    Console.WriteLine("Hur många tecken vill du skriva in?");
    int numberAmount = Convert.ToInt32(Console.ReadLine());
    int[] numberArray = new int[numberAmount];

    for (int i = 0; i < numberAmount; i++)
    {
        int ii = i;
        ii++;
        Console.WriteLine("Skriv in tal nummer: " + ii);
        numberArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int j = numberArray.Length - 1; j >= 0; j--)
    {
        Console.WriteLine(numberArray[j]);
    }

    // Denna for-loopen undertill skriver ut indexen i numberArray i "vanlig" ordning.
    //for (int j = 0; j < numberAmount; j++)
    //{
    //    Console.WriteLine(numberArray[j]);
    //}
} // Arrayövning, inhämtar tal, sparar i arrray, skriver ut

void Övningsuppgift13()
{
    // 13.

    // Be användaren mata in en text. Skriv sedan ut texten baklänges.

    // Textens längd i tecken = längd på string 

    //string testString1 = "abcde"; // Index: 0=a, 1=b, 2=c, 3=d, 4=e
    //Console.WriteLine(testString1[0]);
    //Console.WriteLine(testString1[1]);
    //Console.WriteLine(testString1[2]);
    //Console.WriteLine(testString1[3]);
    //Console.WriteLine(testString1[4]);

    Console.WriteLine("Skriv in en text: ");
    string inputString1 = Console.ReadLine();

    for (int i = inputString1.Length - 1; i >= 0; i--)
    {
        Console.Write(inputString1[i]);
    }
} // Tar in en sträng som skrivs ut baklänges.

void Övningsuppgift14()
{
    // 14.

    // Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *.
    // Extra utmaning: Skriv ut texten översatt till rövarspråket.

    // a e i o u y å ä ö

    Console.WriteLine("Skriv in en text:");
    string inputString = Console.ReadLine();

    string[] vowels = new string[9] { "a", "e", "i", "o", "u", "y", "å", "ä", "ö" };

    for (int i = 0; i < inputString.Length; i++)
    {
        if (vowels.Contains(inputString[i] + ""))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(inputString[i]);
        }
    }
} // Tar in en sträng som skrivs ut där vokaler ersätts med "*".

void Övningsuppgift15()
{
    // 15.

    // Ett palindrom är ett ord som blir samma framlänges som baklänges. Be användaren
    // skriva in ett ord och ange sedan om det är ett palindrom eller inte.

    {
        //1. Convert the string into an array of characters using the ToCharArray() method.
        //2. Reverse the character array using Array.Reverse method.
        //3. Create a new string from the reversed array.This will result in
        //   reversing the original string.

        //Console.WriteLine("Skriv ett ord: ");
        //string inputString = Console.ReadLine();
        //char[] reversedWordArray = inputString.ToCharArray();
        //Array.Reverse(reversedWordArray);
        //string reversedString = Convert.ToString(reversedWordArray) + "";
        //Console.WriteLine(reversedString);

        //Console.WriteLine("Du skrev in {0}.", inputString);
        //Console.WriteLine("Baklänges blir det {0}", reversedWordArray+"");

        //if (inputString+"" == reversedWordArray+"")
        //{
        //  Console.WriteLine("Palindrom");
        //  Console.WriteLine("Ordet {0} du skrev in är ett palindrom.", inputString);
        //  Console.WriteLine("Ordet blir {0} baklänges.", reversedWordArray);
        //}
    } // Array.Reverse, förstår inte, funkar inte, rör inte, glöm

    {
        //Console.WriteLine("Skriv");
        //string inputString1 = Console.ReadLine();
        //string reverseString1 = new string(inputString1.ToCharArray().Reverse().ToArray());

        //if (inputString1 == reverseString1)//(inputString1.Equals(reverseString1))
        //{
        //    Console.WriteLine("Du har skrivit in {0}", inputString1);
        //    Console.WriteLine("Det är ett palindrom.");
        //}
        //else
        //{
        //    Console.WriteLine("Du har skrivit in {0}, det är inte ett palindrom.", inputString1);
        //}
    } // string.ToCharArray().Reverse().ToArray(), skiljer på A och a.

    Console.WriteLine("15. Skriv något:");
    string inputString = Console.ReadLine();
    string inputReversed = string.Empty;

    for (int i = inputString.Length - 1; i >= 0; i--)
    {
        inputReversed += inputString[i];
        Console.Write(inputString[i]);
    }
    if (inputString == inputReversed)
    {
        Console.WriteLine();
        Console.WriteLine("Du har skrivit in ett palindrom.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Du har inte skrivit in ett palindrom.");
    }
} // Palindrom, som 13. och jämför.

void Övningsuppgift16()
{
    // 16.

    // Gör om uppgift 6 så man kan mata in allt på en rad
    // (första talet, operator, andra talet). Ignorera inmatade
    // mellanslag i strängen. Om man t.ex. matar in strängen “34 - 14”,
    // så ska programmet skriva ut “= 20”.

    // Tips för mellanslagshantering: https://learn.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-7.0





} // Uppdatering av 6. Ej påbörjad.

void Övningsuppgift17()
{
    // 17.

    // Gör ett program som ber användaren mata in en text. Be sedan användaren mata in en sträng
    // som är en del av den första texten. Skriv ut hela texten med den del man angav markerad i
    // en annan färg. Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”.
    // Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz


    Console.WriteLine("Skriv");
    string inputString1 = Console.ReadLine();
    Console.WriteLine("Skriv lite igen");
    string inputString2 = Console.ReadLine();
    string outputString1 = string.Empty;
    int loopComparer = 0;

    for (int i = 0; i < inputString1.Length; i++) 
    {
        Console.WriteLine(i);
        if (inputString1[i] == inputString2[loopComparer])
        {
            outputString1 += inputString1[i];
            loopComparer++;
            if (inputString2 == outputString1)
            {
                break;
            }
        }
    }
    Console.WriteLine(outputString1); // skall stå i inpt1 i annan färg, detta är segment 2
    // gör for loop för segment 1
    // gör for loop för segment 3
} // Inte helt klar, fokuserade på Labb 1 som dessa delmoment är inkluderade i.

void Övningsuppgift18()
{
    // 18.

    // Be användaren mata in en mening. Skriv ut det genomsnittliga antalet bokstäver i orden.

    Console.WriteLine("Skriv något cp utan siffror ditt flane:");
    string stringput = Console.ReadLine(); //megalol
    string[] stringArray = new string[stringput.Length];

    double amountOfLetters = 0;
    double amountOfSpaces = 0;
    double amountOfWords = 0;
    double meanLetterAmount = 0;

    for (int i = 0;i < stringput.Length;i++)
    {
        if (char.IsLetter(stringput[i]))
        {
            amountOfLetters++;
        }
    }

    amountOfSpaces = stringput.Length - amountOfLetters;
    amountOfWords = amountOfSpaces + 1;
    meanLetterAmount = amountOfLetters / amountOfWords;

    Console.WriteLine($"Genomsnittliga antalet bokstäver i strängen du matat in är: {meanLetterAmount}");

    for (int i = 0; i < stringArray.Length;i++)
    {
        Console.WriteLine(stringArray[i]);
    }
} // Räknar ut genomsnittliga mängden bokstäver i en mening (utan .?! eller 123... )

void Övningsuppgift19()
{
    // 19.

    // Skriv en metod DrawBox(int width, int height) När man anropar metoden
    // ska den tömma konsolen och skriva ut en rektangel där de yttre tecknen
    // består av ‘#’ och de inre av ‘-’ Exempel:

    // DrawBox(7, 4);
    // #######
    // #-----#
    // #-----#
    // #######






}






Övningsuppgift18();
Console.ReadKey();