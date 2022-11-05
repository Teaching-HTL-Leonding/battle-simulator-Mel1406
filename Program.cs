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

    int pirate_won = 0;
    int stonechewer_won = 0;
    int ghostwarrior_won = 0;
    int outworlder_won = 0;
    int monsterknight_won = 0;
    int darkgoblin_won = 0;

    int pirate_taken = 0;
    int stonechewer_taken = 0;
    int ghostwarrior_taken = 0;
    int outworlder_taken = 0;
    int monsterknight_taken = 0;
    int darkgoblin_taken = 0;

    int pirate_win_rate = 0;
    int stonechewer_win_rate = 0;
    int ghostwarrior_win_rate = 0;
    int outlander_win_rate = 0;
    int monsterknight_win_rate = 0;
    int darkgoblin_win_rate = 0;
    
for (int i = 0; i < 10_000; i++)
{
    int player1 = Random.Shared.Next(1, 7);
    int player2 = Random.Shared.Next(1, 7);
    switch (player1)
    {
        case 1:
            pirate_taken++;
            player1_health = PIRATE_HEALTH;
            player1_attack = PIRATE_ATTRIBUTE;
            player1_armor = PIRATE_ATTRIBUTE;
            player1_speed = PIRATE_ATTRIBUTE;
            break;
        case 2:
            stonechewer_taken++;
            player1_health = STONECHEWER_HEALTH;
            player1_attack = STONECHEWER_ATTACK;
            player1_armor = STONECHEWER_ARMOR;
            player1_speed = STONECHEWER_SPEED;
            break;
        case 3:
            ghostwarrior_taken++;
            player1_health = GHOSTWARRIOR_HEALTH;
            player1_attack = GHOSTWARRIOR_ATTACK;
            player1_armor = GHOSTWARRIOR_ARMOR;
            player1_speed = GHOSTWARRIOR_SPEED;
            break;
        case 4:
            outworlder_taken++;
            player1_health = OUTWORLDER_HEALTH;
            player1_attack = OUTWORLDER_ATTACK;
            player1_armor = OUTWORLDER_ARMOR;
            player1_speed = OUTWORLDER_SPEED;
            break;
        case 5:
            monsterknight_taken++;
            player1_health = MONSTERKNIGHT_HEALTH;
            player1_attack = MONSTERKNIGHT_ATTACK;
            player1_armor = MONSTERKNIGHT_ARMOR;
            player1_speed = MONSTERKNIGHT_SPEED;
            break;
        case 6:
            darkgoblin_taken++;
            player1_health = DARKGOBLIN_HEALTH;
            player1_attack = DARKGOBLIN_ATTACK;
            player1_armor = DARKGOBLIN_ARMOR;
            player1_speed = DARKGOBLIN_SPEED;
            break;
    }
    switch (player2)
    {
        case 1:
            pirate_taken++;
            player2_health = PIRATE_HEALTH;
            player2_attack = PIRATE_ATTRIBUTE;
            player2_armor = PIRATE_ATTRIBUTE;
            player2_speed = PIRATE_ATTRIBUTE;
            break;
        case 2:
            stonechewer_taken++;
            player2_health = STONECHEWER_HEALTH;
            player2_attack = STONECHEWER_ATTACK;
            player2_armor = STONECHEWER_ARMOR;
            player2_speed = STONECHEWER_SPEED;
            break;
        case 3:
            ghostwarrior_taken++;
            player2_health = GHOSTWARRIOR_HEALTH;
            player2_attack = GHOSTWARRIOR_ATTACK;
            player2_armor = GHOSTWARRIOR_ARMOR;
            player2_speed = GHOSTWARRIOR_SPEED;
            break;
        case 4:
            outworlder_taken++;
            player2_health = OUTWORLDER_HEALTH;
            player2_attack = OUTWORLDER_ATTACK;
            player2_armor = OUTWORLDER_ARMOR;
            player2_speed = OUTWORLDER_SPEED;
            break;
        case 5:
            monsterknight_taken++;
            player2_health = MONSTERKNIGHT_HEALTH;
            player2_attack = MONSTERKNIGHT_ATTACK;
            player2_armor = MONSTERKNIGHT_ARMOR;
            player2_speed = MONSTERKNIGHT_SPEED;
            break;
        case 6:
            darkgoblin_taken++;
            player2_health = DARKGOBLIN_HEALTH;
            player2_attack = DARKGOBLIN_ATTACK;
            player2_armor = DARKGOBLIN_ARMOR;
            player2_speed = DARKGOBLIN_SPEED;
            break;
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
    }
    if (player1_damage_taken <= 0 && player2_damage_taken <= 0)
    {

    }
    else if (player1_damage_taken <= 0)
    {
        switch (player2)
        {
            case 1:
                pirate_won++;
                break;
            case 2:
                stonechewer_won++;
                break;
            case 3:
                ghostwarrior_won++;
                break;
            case 4:
                outworlder_won++;
                break;
            case 5:
                monsterknight_won++;
                break;
            case 6:
                darkgoblin_won++;
                break;
        }
    }
    else if (player2_damage_taken <= 0)
    {
        switch (player1)
        {
            case 1:
                pirate_won++;
                break;
            case 2:
                stonechewer_won++;
                break;
            case 3:
                ghostwarrior_won++;
                break;
            case 4:
                outworlder_won++;
                break;
            case 5:
                monsterknight_won++;
                break;
            case 6:
                darkgoblin_won++;
                break;
        }
    }
}

if (pirate_taken == 0){}
else{pirate_win_rate = 100 * pirate_won / pirate_taken;}
if (stonechewer_taken == 0){}
else{stonechewer_win_rate = 100 * stonechewer_won / stonechewer_taken;}
if (ghostwarrior_taken == 0){}
else{ghostwarrior_win_rate = 100 * ghostwarrior_won / ghostwarrior_taken;}
if (outworlder_taken == 0){}
else{outlander_win_rate = 100 * outworlder_won / outworlder_taken;}
if (monsterknight_taken == 0){}
else{monsterknight_win_rate = 100 * monsterknight_won / monsterknight_taken;}
if (darkgoblin_taken == 0){}
else{darkgoblin_win_rate = 100 * darkgoblin_won / darkgoblin_taken;}

int best_character = Math.Max(pirate_win_rate, stonechewer_win_rate);
best_character = Math.Max(best_character, ghostwarrior_win_rate);
best_character = Math.Max(best_character, outlander_win_rate);
best_character = Math.Max(best_character, monsterknight_win_rate);
best_character = Math.Max(best_character, darkgoblin_win_rate);

if (best_character == pirate_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Pirate. He has a win rate of {pirate_win_rate}%.");
}
else if (best_character == stonechewer_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Stone Chewer. He has a win rate of {stonechewer_win_rate}%.");
}
else if (best_character == ghostwarrior_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Ghost Warrior. He has a win rate of {ghostwarrior_win_rate}%.");
}
else if (best_character == outlander_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Outlander. He has a win rate of {outlander_win_rate}%.");
}
else if (best_character == monsterknight_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Monster Knight. He has a win rate of {monsterknight_win_rate}%.");
}
else if (best_character == darkgoblin_win_rate)
{
    Console.WriteLine($"The character with the most wins is the Dark Goblin. He has a win rate of {darkgoblin_win_rate}%.");
}