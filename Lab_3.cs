

// start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumReccomendation(enjoymentLevel);
string game = GetGameReccomendation(stadium);
System.Console.WriteLine("Your reccommended game is "+(stadium,game));


//end main 

//code for enjoyment level
static string GetEnjoymentLevel()
{
        Console.WriteLine("What is your preferred level of enjoyment? Choose either Boring, Average, Fun, or Epic: ");
        string enjoymentLevel = Console.ReadLine();
        return enjoymentLevel;
}

static string GetStadiumReccomendation(string enjoymentLevel) //calling enjoyment level to determine stadium 
{
    switch (enjoymentLevel) //allows for computer to select which code block to execute. multiple ifs doesnt allow for this*
    {
        case "Boring": //basicalls saying "in the case of" instead of "if"
            return ("Neyland Stadium");
        case "Average":
             return ( "Jordan-Hare Stadium" );
        case "Fun":
             return ( "Tiger Stadium" );
        case "Epic":
             return ( "Saban Field at Bryant-Denny Stadium" );
        default:
             return ( "Unknown Stadium" );
    }            
}

static string GetGameReccomendation(string stadium)
{
    switch (stadium)
    {
        case "Neyland Stadium":
                return ("vs Kent State");
        case "Jordan-Hare Stadium":
                return ("vs Kentucky");
        case "Tiger Stadium":
                return ("vs Alabama");
        case "Saban Field at Bryant-Denny Stadium":
                return ("vs Auburn");
        default:
                return ("Unknown Game");
    }
 }
