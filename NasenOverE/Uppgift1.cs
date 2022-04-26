using System;

public static class Uppgift1{

    static void Continue(string str = "forsätta."){ //Kommer behöva den del kod många gånger med små till inga förändringar
        Console.WriteLine("Tryck \"Enter\" för att " + str);
        Console.ReadLine();
        Console.WriteLine();
    }

    public static void DelUppgift1(){
        Console.Clear(); //tömmer konsollen

        //Skriver de här instrucktionena som går igenom enkelt hur processen gick för att göra uppgifterna om man kör programmet.
        //Kan även bara lässa koden om du vill men jag ville ha lite roligt när jag skrev programmet.
        Console.WriteLine("Del-Uppgift 1:");
        Console.WriteLine("Skapa en if-sats som skriver ut \"Hello, World!\" ifall 6 är större än eller lika med 3.");
        Continue();

        Console.WriteLine("Då kan vi skriva denna kod för att åstakomma det.");
        Console.WriteLine();
        Console.WriteLine("if(6 >= 3){");
        Console.WriteLine("    Console.WriteLine(\"Hello World!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        if(6 >= 3){
            Console.WriteLine("Hello World!");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsulta Del-Uppgift 1.");

    }

    public static void DelUppgift2(){
        Console.Clear();
        Console.WriteLine("Del-uppgift 2:");
        Console.WriteLine("Skapa en kod som först hämtar in ett användarnamn från användaren via Console.ReadLine.");
        Console.WriteLine("Gör sedan en if-sats som skriver ut \"Welcome!\" Ifall användarnamnet är lika med \"noname\".");
        Continue();

        Console.WriteLine("Ett sätt att göra denna uppgift är så här.");
        Console.WriteLine("Först tar vi en input från användaren med functionen \"Console.ReadLine\".");
        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Username: \");        //Lite stilat för att användaren ska veta vad de ska göra");
        Console.WriteLine("string user = Console.ReadLine();   //skapar ny variabel tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("Glöm inte att kommentera din kod så att du vet vad den gör senare!");
        Continue();
        
        Console.WriteLine("Efter det skriver vi en bit kod som kollar om inputen från användaren är lika med \"noname\".");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\"){");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("En simpel if-sats är allt som behövs för det.");
        Continue();
        Console.WriteLine("I slutet får vi:");
        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Username: \");        //Lite stilat för att användaren ska veta vad de ska göra");
        Console.WriteLine("string user = Console.ReadLine();   //skapar ny variabel tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\"){");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.Write("Username: ");        //Lite stilat för att användaren ska veta vad de ska göra.
        string user = Console.ReadLine();   //skapar ny variabel tar inputen och sparar den i variabeln

        if(user == "noname"){
            Console.WriteLine("Welcome!");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 2");

    }

    public static void DelUppgift3(){
        Console.Clear();
        Console.WriteLine("Del-Uppgift 3:");
        Console.WriteLine("Komplettera föregående kod så att både användarnamn och lösenord efterfrågas.");
        Console.WriteLine("\"Welcome\" ska skrivas ut enbart om användarnamnet är lika med \"noname\" och lösenordet är \"nopass\". ");
        Console.WriteLine("Om någon av dem inte stämmer så ska koden skriva ut \"Wrong username or password\".");
        Continue();

        Console.WriteLine("Vi kan börja med att återanvända koden från förra uppgift.");
        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Username: \");               //Lite stilat för att användaren ska veta vad de ska göra");
        Console.WriteLine("string user = Console.ReadLine();          //skapar ny variabel tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\"){");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Efter det lägger vi till små delar. Nämligen,");
        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Password: \")");
        Console.WriteLine("string password = Console.ReadLine();      //skapar ny variabel som tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("Efter Username delen av koden. Och,");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\" && password == \"nopass\"){ ");
        Console.WriteLine("//kollar om både \"user\" och \"password\" är rätt samtidigt.");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("Vi modifierar if-satsen så att den kollar lösenordet också");
        Console.WriteLine("&& och || används för att kolla flera parametrar samtidigt. && är AND, || är OR. Kolla upp AND OR operationer för mer info.");
        Continue();

        Console.WriteLine("Sedan lägger vi till ett \"else\" statement efter if-satsen för att uppnå andra kravet av uppgiften.");
        Console.WriteLine();
        Console.WriteLine("else { //else körs endast om det föregående if-statementet misslyckades");
        Console.WriteLine("    Console.WriteLine(\"Wrong username or password.\");");
        Console.WriteLine("}");
        Continue();

        Console.WriteLine("I slutet får vi koden:");

        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Username: \");               //Lite stilat för att användaren ska veta vad de ska göra");
        Console.WriteLine("string user = Console.ReadLine();          //skapar ny variabel tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("Console.Write(\"Password: \")");
        Console.WriteLine("string password = Console.ReadLine();      //skapar ny variabel som tar inputen och sparar den i variabeln");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\" && password == \"nopass\"){ ");
        Console.WriteLine("//kollar om både \"user\" och \"password\" är rätt samtidigt.");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("} else { //else körs endast om det föregående if-statementet misslyckades");
        Console.WriteLine("    Console.WriteLine(\"Wrong username or password.\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.Write("Username: ");               //Lite stilat för att användaren ska veta vas de ska göra
        string user = Console.ReadLine();          //tar inputen och sparar den i variabeln "user"
        Console.Write("Password: ");
        string password = Console.ReadLine();      //skapar ny variabel tar inputen och sparar den i variabeln

        if(user == "noname" && password == "nopass"){ 
        //kollar om både "user" och "password" är rätt samtidigt.
        //&& och || används för att kolla flera parametrar samtidigt. && är AND, || är OR. Kolla upp AND OR operationer för mer info.
            Console.WriteLine("Welcome!");
        } else { //else körs endast om det föregående if-statementet misslyckades
            Console.WriteLine("Wrong username or password.");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 3");

    }

    public static void DelUppgift4(){
        Console.Clear();
        Console.WriteLine("Del-Uppgift4");
        Console.WriteLine("Skriv en loop som skriver ut \"Hello, World\" 32 gånger. Välj själv om det ska vara en for-loop eller en while-loop.");
        Continue();

        Console.WriteLine("För denna uppgift behöver vi bara en simpel for-loop.");
        Console.WriteLine("En while-loop skulle också funka men det är tre tecken mer skrivande och vi är lata.");
        Console.WriteLine();
        Console.WriteLine("for(int i = 0; i < 32; i++){");
        Console.WriteLine("    Console.WriteLine(\"Hello World!\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue("kör koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        for(int i = 0; i < 32; i++){
            Console.WriteLine("Hello World!");
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 4");

    }

    public static void DelUppgift5(){
        Console.Clear();
        Console.WriteLine("Del-Uppgift 5:");
        Console.WriteLine("Skriv en loop som fortsätter så länge användaren inte har skrivit in rätt lösenord.");
        Console.WriteLine("Du måste alltså lägga in din Console.ReadLine inuti en while-loop.");
        Continue();

        Console.WriteLine("För denn uppgift ståppar vi bara all kod vi hade i den i en simpel while-loop.");
        Console.WriteLine("För att vi enkelt ska kunna bryta ut ur loopen skapar vi först en boolean för att veta när vi är klara.");
        Console.WriteLine();
        Console.WriteLine("bool ongoing = true;");
        Console.WriteLine("while(ongoing){");
        Console.WriteLine();
        Console.WriteLine("}");
        Console.WriteLine();
        Console.WriteLine("Anledningen varför vi inte har \"ongoing == true\" är för att den operationen returnerar en bool från den");
        Console.WriteLine("och därför kan vi bara använda en bool variabel istället.");
        Continue();

        Console.WriteLine("Efter det behöver vi göra det möjligt att bryta ut ur while-loopen.");
        Console.WriteLine("Det gör vi genom att lägga till där vi vill bryta loopen att \"ongoing\" är false");
        Console.WriteLine();
        Console.WriteLine("if(user == \"noname\" && password == \"nopass\"){ ");
        Console.WriteLine("//kollar om både \"user\" och \"password\" är rätt samtidigt.");
        Console.WriteLine("    Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("    ongoing = false; //bryter loopen eftersom argumentet inte är sant längre");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("I slutet får vi koden:");
        
        Console.WriteLine("bool ongoing = true;");
        Console.WriteLine("while(ongoing){  ");
        Console.WriteLine("    ");
        Console.WriteLine("    Console.Write(\"Username: \");        //Lite stilat för att användaren ska veta vas de ska göra");
        Console.WriteLine("    user = Console.ReadLine();          //tar inputen och sparar den i variabeln \"user\"");
        Console.WriteLine("    Console.Write(\"Password: \");");
        Console.WriteLine("    password = Console.ReadLine();      //tar inputen och sparar den i variabeln \"password\"");
        Console.WriteLine("");
        Console.WriteLine("    if(user == \"noname\" && password == \"nopass\"){ ");
        Console.WriteLine("    //kollar om både \"user\" och \"password\" är rätt samtidigt.");
        Console.WriteLine("Console.WriteLine(\"Welcome!\");");
        Console.WriteLine("        ongoing = false; //bryter loopen eftersom argumentet inte är sant längre");
        Console.WriteLine("    } else { //else körs endast om det föregående if-statementet misslyckades");
        Console.WriteLine("        Console.WriteLine(\"Wrong username or password.\");");
        Console.WriteLine("    }");
        Console.WriteLine("}");
        Console.WriteLine();

        Console.WriteLine("Vi skulle kunna köra en \"while(true)\" istället.");
        Console.WriteLine("Men då behöver vi byta ut \"ongoing = false;\" till \"break;\" för att bryta ut ur loopen.");
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        bool ongoing = true;
        while(ongoing){  
            Console.Write("Username: ");        //Lite stilat för att användaren ska veta vas de ska göra
            string user = Console.ReadLine();          //tar inputen och sparar den i variabeln "user"
            Console.Write("Password: ");
            string password = Console.ReadLine();      //tar inputen och sparar den i variabeln "password"

            if(user == "noname" && password == "nopass"){ 
            //kollar om både "user" och "password" är rätt samtidigt.Console.WriteLine("Welcome!");
                ongoing = false; //bryter loopen eftersom argumentet inte är sant längre
            } else { //else körs endast om det föregående if-statementet misslyckades
                Console.WriteLine("Wrong username or password.");
            }
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 5");
    }

    public static void DelUppgift6(){
        Console.Clear();
        Console.WriteLine("Del-Uppgift 6");
        Console.WriteLine("Skriv en loop som körs 5 gånger. Varje gång loopen körs ska användaren skriva in ett tal. Om talet är högre än 5, skriv ut “högre än 5!”. ");
        Console.WriteLine("Observera att du måste konvertera talet från en string till en int för att kunna göra jämförelsen.");
        Continue();

        Console.WriteLine("Vi börjar med att göra en simpel for-loop som repeteras 5 gånger:");
        Console.WriteLine();
        Console.WriteLine("for(int i = 5; i < 5; i++){");
        Console.WriteLine();
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Efter det skapar vi koden som gämför inputen från användaren");
        Console.WriteLine("Första steget är att skapa en variabel som kan spara inputen, en simpel int räcker till det.");
        Console.WriteLine();
        Console.WriteLine("int resultat;");
        Console.WriteLine();
        Console.WriteLine("Sen skapar vi koden som tar inputen från användaren.");
        Console.WriteLine();
        Console.WriteLine("Console.WriteLine(\"Skriv en siffra!\");          //Instruktioner för använndaren");
        Console.WriteLine("int.TryParse(Console.ReadLine, out resultat);   //konverterar text string till int");
        Console.WriteLine();
        Console.WriteLine("Och sist skriver vi if-satsen som jämför inputen.");
        Console.WriteLine();
        Console.WriteLine("if(resultat < 5){");
        Console.WriteLine("    Console.WriteLine(resultat + \" är större än 5\");");
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Allt illsammans blir:");
        Console.WriteLine("for(int i = 0; i < 5; i++){");
        Console.WriteLine("    int resultat;");
        Console.WriteLine("    Console.WriteLine(\"Skriv en siffra!\");          //Instruktioner för använndaren");
        Console.WriteLine("    int.TryParse(Console.ReadLine, out resultat);   //konverterar text string till int");
        Console.WriteLine("");
        Console.WriteLine("    if(resultat < 5){");
        Console.WriteLine("        Console.WriteLine(resultat + \" är större än 5!\");");
        Console.WriteLine("    };");
        Console.WriteLine("} ");
        Console.WriteLine();
        Continue("köra koden.");
///////////////////////////////////////////////////////////////////////////////////////////////////
        for(int i = 0; i < 5; i++){
            int resultat;
            Console.WriteLine("Skriv en siffra!");          //Instruktioner för använndaren
            int.TryParse(Console.ReadLine(), out resultat);   //konverterar text string till int

            if(resultat < 5){
                Console.WriteLine(resultat + " är större än 5!");
            };
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 6");
    }

    public static void DelUppgift7(){
        Console.Clear();
        Console.WriteLine("Del-Uppgift 7");
        Console.WriteLine("Skriv en loop som körs så länge användaren skriver in en string som inte kan konverteras till en int.");
        Console.WriteLine("Använd All(char.isDigit)-testet eller TryCatch / TryParse.");
        Continue();

        Console.WriteLine("Här kan vi använda en while-loop eftersom vi inte vet hur många gånger kode kommer att köras.");
        Console.WriteLine("Vi gör på samma sätt som förut.");
        Console.WriteLine();
        Console.WriteLine("bool ongoing = true");
        Console.WriteLine("while(ongoing){");
        Console.WriteLine();
        Console.WriteLine("}");
        Console.WriteLine();
        Continue();

        Console.WriteLine("Och det vi ska sätta i loopen är ännu simplare.");
        Console.WriteLine("Vi vet att metoden \"int.TryParse\" returnerar en bool, true/false när den körs och det är den vi kommer att använda.");
        Console.WriteLine();
        Console.WriteLine("int x;");
        Console.WriteLine("ongoing = !int.TryParse(Console.ReadLine(), out x);");
        Console.WriteLine();
        Console.WriteLine("\"!\" som vi skrev före \"int\" betyder att värdet som returneras sa inverteras.");
        Console.WriteLine("true -> flase, 1 -> -1. Detta funkar åt andra hållet också.");
        Continue();

        Console.WriteLine("I slutet får vi:");
        Console.WriteLine();

        Console.WriteLine("bool ongoing = true;");
        Console.WriteLine("while(ongoing){");
        Console.WriteLine("    int x;");
        Console.WriteLine("    ongoing = !int.TryParse(Console.ReadLine(), out Nullable);");
        Console.WriteLine("}");

        Console.WriteLine();
        Continue("köra koden");
///////////////////////////////////////////////////////////////////////////////////////////////////
        bool ongoing = true;
        while(ongoing){
            int x;
            ongoing = !int.TryParse(Console.ReadLine(), out x);
        }
///////////////////////////////////////////////////////////////////////////////////////////////////
        Console.WriteLine();
        Continue("avsluta Del-Uppgift 7");
    }
}