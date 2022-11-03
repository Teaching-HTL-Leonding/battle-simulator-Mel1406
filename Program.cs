Console.Clear();

//pirate
const int PIRATE_HEALTH = 20;
const int PIRATE_ATTRIBUTE = 3;
//stone chewer
const int STONECHEWER_HEALTH = 50;
const int STONECHEWER_ATTACK = 8;
const int STONECHEWER_ARMOR = 10;
const int STONECHEWER_SPEED = 1;
//ghost warrior
const int GHOSTWARRIOR_HEALTH = 20;
const int GHOSTWARRIOR_ATTACK = 2;
const int GHOSTWARRIOR_ARMOR = 2;
const int GHOSTWARRIOR_SPEED = 5;
//outworlder
const int OUTWORLDER_HEALTH = 15;
const int OUTWORLDER_ATTACK = 1;
const int OUTWORLDER_ARMOR = 2;
const int OUTWORLDER_SPEED = 10;
//monster knight
const int MONSTERKNIGHT_HEALTH = 15;
const int MONSTERKNIGHT_ATTACK = 4;
const int MONSTERKNIGHT_ARMOR = 3;
const int MONSTERKNIGHT_SPEED = 3;
//dark goblin
const int DARKGOBLIN_HEALTH = 10;
const int DARKGOBLIN_ATTACK = 1;
const int DARKGOBLIN_ARMOR = 8;
const int DARKGOBLIN_SPEED = 3;

double player1_health = 0;
double player1_attack = 0;
double player1_armor = 0;
double player1_speed = 0;
double player2_health = 0;
double player2_attack = 0;
double player2_armor = 0;
double player2_speed = 0;
int round = 0;
int winner = 0;

Console.Write("Player 1: Enter your character: ");
string player1 = Console.ReadLine()!;
Console.Clear();
Console.Write("Player 2: Enter your character: ");
string player2 = Console.ReadLine()!;
switch (player1)
{
    case "pirate" or "Pirate":
        player1_health = PIRATE_HEALTH;
        player1_attack = PIRATE_ATTRIBUTE;
        player1_armor = PIRATE_ATTRIBUTE;
        player1_speed = PIRATE_ATTRIBUTE;
        break;
    case "stone chewer" or "Stone Chewer":
        player1_health = STONECHEWER_HEALTH;
        player1_attack = STONECHEWER_ATTACK;
        player1_armor = STONECHEWER_ARMOR;
        player1_speed = STONECHEWER_SPEED;
        break;
    case "ghost warrior" or "Ghost Warrior":
        player1_health = GHOSTWARRIOR_HEALTH;
        player1_attack = GHOSTWARRIOR_ATTACK;
        player1_armor = GHOSTWARRIOR_ARMOR;
        player1_speed = GHOSTWARRIOR_SPEED;
        break;
    case "outworlder" or "Outworlder":
        player1_health = OUTWORLDER_HEALTH;
        player1_attack = OUTWORLDER_ATTACK;
        player1_armor = OUTWORLDER_ARMOR;
        player1_speed = OUTWORLDER_SPEED;
        break;
    case "monster knight" or "Monster Knight":
        player1_health = MONSTERKNIGHT_HEALTH;
        player1_attack = MONSTERKNIGHT_ATTACK;
        player1_armor = MONSTERKNIGHT_ARMOR;
        player1_speed = MONSTERKNIGHT_SPEED;
        break;
    case "dark goblin" or "Dark Goblin":
        player1_health = DARKGOBLIN_HEALTH;
        player1_attack = DARKGOBLIN_ATTACK;
        player1_armor = DARKGOBLIN_ARMOR;
        player1_speed = DARKGOBLIN_SPEED;
        break;
    default:
        Console.WriteLine("No valid entry for player 1! Please restart the game!");
        return;
}
switch (player2)
{
    case "pirate" or "Pirate":
        player2_health = PIRATE_HEALTH;
        player2_attack = PIRATE_ATTRIBUTE;
        player2_armor = PIRATE_ATTRIBUTE;
        player2_speed = PIRATE_ATTRIBUTE;
        break;
    case "stone chewer" or "Stone Chewer":
        player2_health = STONECHEWER_HEALTH;
        player2_attack = STONECHEWER_ATTACK;
        player2_armor = STONECHEWER_ARMOR;
        player2_speed = STONECHEWER_SPEED;
        break;
    case "ghost warrior" or "Ghost Warrior":
        player2_health = GHOSTWARRIOR_HEALTH;
        player2_attack = GHOSTWARRIOR_ATTACK;
        player2_armor = GHOSTWARRIOR_ARMOR;
        player2_speed = GHOSTWARRIOR_SPEED;
        break;
    case "outworlder" or "Outworlder":
        player2_health = OUTWORLDER_HEALTH;
        player2_attack = OUTWORLDER_ATTACK;
        player2_armor = OUTWORLDER_ARMOR;
        player2_speed = OUTWORLDER_SPEED;
        break;
    case "monster knight" or "Monster Knight":
        player2_health = MONSTERKNIGHT_HEALTH;
        player2_attack = MONSTERKNIGHT_ATTACK;
        player2_armor = MONSTERKNIGHT_ARMOR;
        player2_speed = MONSTERKNIGHT_SPEED;
        break;
    case "dark goblin" or "Dark Goblin":
        player2_health = DARKGOBLIN_HEALTH;
        player2_attack = DARKGOBLIN_ATTACK;
        player2_armor = DARKGOBLIN_ARMOR;
        player2_speed = DARKGOBLIN_SPEED;
        break;
    default:
        Console.WriteLine("No valid entry for player 2! Please restart the game!");
        return;
}

double player1_damage_taken = player1_health + player1_armor;
double player2_damage_taken = player2_health + player2_armor;

while (player1_damage_taken > 0 && player2_damage_taken > 0)
{
    for (int j = 0; j < player1_speed; j++)
    {
        double factor = Random.Shared.Next(-15, 16) / 100d;
        player2_damage_taken -= player1_attack * (1 + factor); 
    }
    for (int j = 0; j < player2_speed; j++)
    {
        double factor = Random.Shared.Next(-15, 16) / 100d;
        player1_damage_taken -= player2_attack * (1 + factor);
    }
    round++;
    Console.WriteLine("round: " + round);
}
if (player1_damage_taken <= 0 && player2_damage_taken <= 0)
{
    Console.WriteLine("Draw! There is no winner!");
}
else if (player1_damage_taken <= 0)
{
    winner = 2;
    Console.WriteLine($"{player2}(player {winner}) has won after {round} rounds!");
}
else if (player2_damage_taken <= 0)
{
    winner = 1;
    Console.WriteLine($"{player1}(player {winner}) has won after {round} rounds!");
}


