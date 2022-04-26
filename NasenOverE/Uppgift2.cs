using System;
using System.Collections.Generic;

public static class Uppgift2{

    static void Continue(string str = "forsätta."){ //Kommer behöva den del kod många gånger med små till inga förändringar
        Console.WriteLine("Tryck \"Enter\" för att " + str);
        Console.ReadLine();
        Console.WriteLine();
    }
    //alla arrays och listor som behöver initsialiseras görs så här uppe så att det inte behöver göras i varje met om och om igen.
    static string[] leksaker = {"Bayblade", "Barbie", "Pokemon-Kort", "Xbox", "Ordbok"};
    static string[] namn = {"Micke", "Vera", "Tu", "Linda", "Karim"};
    static int[] betyg = {3, 5, 7, 8, 10};
    static List<string> cities = new List<string>();

    static public void Steg1(){
        Console.Clear();
        Console.WriteLine("Eftersom Uppgift 2 & 3 är struktuerade annorlunda från den första kommer detta avsnitt ochså vara det.");
        Console.WriteLine();
        Console.WriteLine("Steg 1:");
        Console.WriteLine("Skapa en string-array med namnen på fem olika leksaker.");
        Continue();

        Console.WriteLine("Det som skilje gör arrays från vanliga variablar är att de kan ha flera av sin givana datatyp samtidigt.");
        Console.WriteLine("Tänk dig att en vanlig variabel är ett ark av papper, då är en array en bok. Där varje sida är sin egna variabel.");
        Console.WriteLine();
        Console.WriteLine("Man skapar arrays igenom att först specifiera en datatyp, som t.ex int. Sen lägger man till [] på slutet.");
        Console.WriteLine("Och sist måste man specifier hur lång arrayen är. Det måste man göra när man initialiserar den. Listor behöver inte det dock.");
        Continue();

        Console.WriteLine("Vi skriver alltså \"int[] arrayI = new int[3];\" för att få en 3 variabler lång int array.");
        Console.WriteLine("Det går även att initialisera en array med värden redan satta på variablerna.");
        Console.WriteLine("Då skriver man istället\"int[] arrayI = {3, 6, 2};\" för att få en 3 variabler lång array med värderna \"3\", \"6\", och \"2\" i sig.");
        Console.WriteLine("Notera även att arrays och det mästa innom programmering börjar räkna på 0 istället för 1. Varför är inte viktigt.");
        Console.WriteLine();
        Console.WriteLine("Då skriver vi \"string[] leksaker = {\"Bayblade\", \"Barbie\", \"Pokemon-Kort\", \"Xbox\", \"Ordbok\"}; för att klara av detta steg.");
        Continue("gå till nästa steg."); 
    }

    static public void Steg2(){
        Console.Clear();
        Console.WriteLine("Steg 2:");
        Console.WriteLine("Skriv en for-loop (eller foreach-loop) som skriver ut namnet på varje leksak på en egen rad.");
        Continue();

        Console.WriteLine("Vi kommer att använda en foreach-loop, eftersom vi är lata och den gör hälften av arbetet för oss.");
        Console.WriteLine("Så en hur foreach-loop fungerar är att den går igenom varje variabel i en array, och sen utör den loopen för det värdet.");
        Console.WriteLine("Då om vi har en array som är {4, 8} och kör den igenom denna loop:");
        Console.WriteLine();
        Console.WriteLine("int[] x = {4, 8};");
        Console.WriteLine("foreach(int i in x){");
        Console.WriteLine("    Console.WriteLine(10-i);");
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("Bör vi först få 10-4, som är 6, och sen vör vi få 10-8 som är 2.");
        Continue("köra koden.");

        int[] x = {4, 8};
        foreach(int i in x){
            Console.WriteLine(10-i);
        }
        
        Console.WriteLine();
        Console.WriteLine("Och det är exakt vad vi får.");
        Continue();

        Console.WriteLine("Då för att uföra detta steg behöver vi göra en loop som bara skriver ut varje string i terminalen.");
        Console.WriteLine("Den loopen vi använde nyss går att använda igen med små ändringar. Då får vi:");
        Console.WriteLine();
        Console.WriteLine("foreach(string str in leksaker){");
        Console.WriteLine("    Console.WriteLine(str);");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
        ///////////////////////////////////////////////////////////////////////////////////////////
        foreach(string str in leksaker){
            Console.WriteLine(str);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("gå till nästa steg.");
    }

    static public void Steg3(){
        Console.Clear();
        Console.WriteLine("Steg 3:");
        Console.WriteLine("Skapa en string-array med namnen på fem av dina klasskamrater.");
        Console.WriteLine("Vi kommer dock använda lärares namn.");
        Continue();

        Console.WriteLine("I detta steg är det ända vi gör att initialisera en array med 5 namn.");
        Console.WriteLine("Allt du behöver skriva är \"string[] namn = {\"Micke\", \"Vera\", \"Tu\", \"Linda\", \"Karim\"};");
        Console.WriteLine("Enkelt som det.");
        Continue("gå till nästa steg.");
    }

    static public void Steg4(){
        Console.Clear();
        Console.WriteLine("Steg 4:");
        Console.WriteLine("Skapa en integer-array med fem värden mellan 0 och 10.");
        Continue();

        Console.WriteLine("Detta steg är identiskt till steg 3, förutom att vi använder intst stället för strings.");
        Console.WriteLine("Bara skriv \"int[] betyg = {3, 5, 7, 8, 10};\" och var klar med det");
        Continue("gå till nästa steg.");
    }

    static public void Steg5(){
        Console.Clear();
        Console.WriteLine("Steg 5:");
        Console.WriteLine("Komplettera for-loopen så att den på varje rad skriver ut något liknande \"Pelle ger Barbie betyget 5\".");
        Console.WriteLine("Använd dina klasskamraters namn, leksakernas namn och värdena från int-arrayen.");
        Continue();

        Console.WriteLine("Här kom vårat val att göra en foreach-loop och bet oss i foten. Det är enklare att använda en for loop nu.");
        Console.WriteLine("Dock är det inte mycket vi behöver göra om.");
        Console.WriteLine();
        Console.WriteLine("Först gör vi en for-loop som repeteras 5 gånger.");
        Console.WriteLine();
        Console.WriteLine("for(int i = 0; i < 5; i++){");
        Console.WriteLine();
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Sen skapar vi biten som skriver ut texten.");
        Console.WriteLine("Det gör vi igenom att säga åt Console.WriteLine() att skriva ut både text och variabler.");
        Console.WriteLine();
        Console.WriteLine("t.ex: Console.WriteLine(str + \" kostar 5 öre!\").");
        Console.WriteLine();
        Console.WriteLine("I vårat fall skriver vi:");
        Console.WriteLine();
        Console.WriteLine("Console.WriteLine(namn[i] + \" tyckte att \" + leksaker[i] + \" är värd en \" + \"kr.\");");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Tillslut får vi:");
        Console.WriteLine("for(int i = 0; i < 5; i++){");
        Console.WriteLine("    Console.WriteLine(namn[i] + \" tyckte att \" + leksaker[i] + \" är värd en \" + betyg + \"kr.\");");
        Console.WriteLine("}");
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        for(int i = 0; i < 5; i++){
            Console.WriteLine(namn[i] + " tyckte att " + leksaker[i] + " är värd en " + betyg + "kr.");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("gå till nästa steg.");
    }

    static public void Steg6(){
        Console.Clear();
        Console.WriteLine("Steg 6:");
        Console.WriteLine("Skapa en tom string-lista som heter \"cities\".");
        Continue();

        Console.WriteLine("Skillnaden mellan arrays och listor är inte stor, de är mer eller mindre exakt likadana.");
        Console.WriteLine("Den största skillnaden mellan dem är att man kan ändra på en listas storlek efter man har skapat den.");
        Console.WriteLine();
        Console.WriteLine("Den andra största skillnade är ur man skriver och läser till listan. Man kan lägga till saker i listan igenom att skriva:");
        Console.WriteLine("\"[lsit-name].Add(xyzz);\", t.ex: \"cities.Add(\"Malmö\"); eller \"nummer.Add(2);\".");
        Console.WriteLine("Att läsa från listan gör man på samma sätt, bara säg \"[list-name][int]\", t.ex: \"cities[3]\"");
        Console.WriteLine("Förutom det finns det små skillnader mellan dem, men inget vi behöver just nu.");
        Continue();

        Console.WriteLine("För att initialisera en lista behöver man först säga åt Visual Studio Code att listor finns.");
        Console.WriteLine("Det gör man igenom att lägga till \"using System.Collection.Generic;\" i början av sin .cs fil. Precis efter \"using System;\".");
        Console.WriteLine("Efter det kan man skriva \"List<[datatyp]> [list-name] = new List<[datatyp]>();\" för att skapa den.");
        Console.WriteLine("För oss skulle det vara \"List<string> cities = new List<string>();\".");
        Continue("gå till nästa steg.");
    }

    static public void Steg7(){
        Console.Clear();
        Console.WriteLine("Steg 7:");
        Console.WriteLine("Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine.");
        Console.WriteLine("Lägg till den string du får från användaren till cities-listan. Avbryt loopen om användaren skriver \"exit\".");
        Continue();

        Console.WriteLine("Eftersom vi inte vet innan vi kör koden hur många gånger loopen ska repeteras bör vi använda en while loop.");
        Console.WriteLine("Vi skapar en sådan på samma sätt som vi har gjort förut.");
        Console.WriteLine();
        Console.WriteLine("bool ongoing = true;");
        Console.WriteLine("while(ongoing){");
        Console.WriteLine("");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Efter det borde en simpel nog if-sats kunna sortera om användaren skrive \"exit\"eller inte.");
        Console.WriteLine("Först tar vi in input från användaren med \"string str = Console.ReadLine();\" och sparar den i en vairabel kallad str");
        Console.WriteLine("Sen kan vi kolla om str *inte* är \"exit\" med if(str != \"exit\")");
        Console.WriteLine();
        Console.WriteLine("Men varför skulle vi vilja det? Blir det inte baklänges då?");
        Console.WriteLine("Jo, men det ser bättre ut i kode strukturen och jag säger så, derför gör vi så.");
        Console.WriteLine("Dessutom blir det ingen skillnad funktionsmässigt.");
        Continue();

        Console.WriteLine("Men tänk om man vilj kunna gå ut med att skriva \"Exit\" eller \"EXIT\" också?");
        Console.WriteLine("För att täcka alla sorters av uppercase och lowercase stavningar av \"exit\" kan man köra metoden \"string.ToLower\" på str.");
        Console.WriteLine("Då blir alla karaktärer i texten lowercase och vi behöver inte bry oss om uppercase.");
        Console.WriteLine();
        Console.WriteLine("Då blir if-satsen istället det här: \"if(str.ToLower() != \"exit\").");
        Console.WriteLine("Inte mycket skillnad i kode men en stor skillnad för användare.");
        Continue();

        Console.WriteLine("Sen ska vi ståppa in det som anändaren inputtar till listan, och det gör man med .Add(); som sagt.");
        Console.WriteLine("För oss blir det \"cities.Add(str);\".");
        Console.WriteLine();
        Console.WriteLine("Och sist men inte minst behöver vi bryta loopen om de skriver \"exit\"");
        Console.WriteLine("Eftesom vi använde en if-sats som fångar allt förutom exit, kan vi bara slänga på en eles-sats efter");
        Console.WriteLine("och däri sätta \"ongoing = false\".");
        Continue();

        Console.WriteLine("Då får vi den här biten kod tillslut:");
        Console.WriteLine();
        Console.WriteLine("bool ongoing = true;");
        Console.WriteLine("while(ongoing){");
        Console.WriteLine("    string str = Console.ReadLine();");
        Console.WriteLine("    if(str.ToLower() != \"exit\"){");
        Console.WriteLine("        cities.Add(str);");
        Console.WriteLine("    } else {");
        Console.WriteLine("        ongoing = false;");
        Console.WriteLine("    }");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        bool ongoing = true;
        while(ongoing){
            string str = Console.ReadLine();
            if(str.ToLower() != "exit"){
                cities.Add(str);
            } else {
                ongoing = false;
            }
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("gå till nästa steg.");
    }

    static public void Steg8(){
        Console.Clear();
        Console.WriteLine("Steg 8");
        Console.WriteLine("Skapa en loop som ligger efter den ovanstående. Den här loopen ska skriva ut alla strings som finns sparade i cities-listan.");
        Continue();

        Console.WriteLine("Här behöver vi bara skriva ut allt i listan. Vi har gjort dethör förut och kan bara kopiera koden.");
        Console.WriteLine("Gå tillbaka till steg 2 och kopiera koden hit. Sen byter du ut \"leksaker\" till \"cities\".");
        Console.WriteLine("Så att du har \"foreach(string str in cites)\" istället.");
        Console.WriteLine("Koden bör se ut såhär då:");
        Console.WriteLine();
        Console.WriteLine("foreach(string str in cities){");
        Console.WriteLine("    Console.WriteLine(str)");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        foreach(string str in cities){
            Console.WriteLine(str);
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Continue("avsluta Uppgift 2");
    }
}