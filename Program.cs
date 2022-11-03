Console.Clear();
const string Pirate = "P";
const string StoneChewer = "S";
const string GhostWarrior = "G";

int Player1health = 0;
int Player1damage = 0;
int Player1speed = 0;
int Player2health = 0;
int Player2damage = 0;
int Player2speed = 0;

Console.Write("Write (P) fort Pirate, Enter (S) for StoneChewer or enter (G)   for GhostWarrior");

Console.WriteLine();

Console.Write("Player1, choose a charakter");
string Player1 = Console.ReadLine()!;

Console.Write("Player2, choose a charakter");
string Player2 = Console.ReadLine()!;

switch (Player1)
{
    case Pirate:
        Player1health = 20;
        Player1damage = 3;
        Player1speed = 3;
        break;

    case StoneChewer:
        Player1health = 50;
        Player1damage = 8;
        Player1speed = 1;
        break;


    case GhostWarrior:
        Player1health = 20;
        Player1damage = 2;
        Player1speed = 5;
        break;

    default:
        System.Console.WriteLine("invalid input");
        return;
}

switch (Player2)
{
    case Pirate:
        Player2health = 20;
        Player2damage = 3;
        Player2speed = 3;
        break;

    case StoneChewer:
        Player2health = 50;
        Player2damage = 8;
        Player2speed = 1;
        break;


    case GhostWarrior:
        Player2health = 20;
        Player2damage = 2;
        Player2speed = 5;
        break;

    default:
        System.Console.WriteLine("invalid input");
        break;
}



while (Player1health > 0 && Player2health > 0)
{
    Player2health = Player2health - (Player1damage * Player1speed);
    Player1health = Player1health - (Player2damage * Player2speed);
}


if (Player1health > 0) { Console.WriteLine("Player1 wins"); }
else if (Player2health > 0) { Console.WriteLine("Player2 wins"); }
else if (Player1health <= 0 && Player2health <=0 ) { Console.WriteLine("no winner"); } 
