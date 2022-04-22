// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake and Ladder");
int playerPosition = 0;
Console.WriteLine(playerPosition);
Random random = new Random();
int isWin = 100;
while (playerPosition <= isWin)
{
    int rollDie = random.Next(1, 7);
    int options = random.Next(0, 3);
    switch (options)
{
    case 0:
        Console.WriteLine("NO_PLAY");
        playerPosition = 0;
        break;
    case 1:
        Console.WriteLine("LADDER");
        playerPosition += rollDie;
        break;
    case 2:
        Console.WriteLine("SNAKE");
        playerPosition -= rollDie;
        if (playerPosition < 0)
        {
            playerPosition = 0;
        }
        break;
    default:
        break;
}
Console.WriteLine(playerPosition);
}
Console.WriteLine(playerPosition);
if (playerPosition == isWin)
{
    Console.WriteLine("You Won!!");
}


