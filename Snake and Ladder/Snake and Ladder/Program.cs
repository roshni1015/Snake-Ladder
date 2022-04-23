// See https://aka.ms/new-console-template for more information
using SnakAndLadder;
Console.WriteLine("Welcome to Snake and Ladder");
snakeAndladder player1 = new snakeAndladder();
snakeAndladder player2 = new snakeAndladder();
Console.WriteLine("Player 1: ");
player1.Describe();
Console.WriteLine("Player 2: ");
player2.Describe();
player1.PlayTillEnd(player2);
//int playerPosition = 0;
//Console.WriteLine(playerPosition);
//Random random = new Random();
//int isWin = 100;
//int count = 0;
//while (playerPosition <= isWin)
//{
//    int rollDie = random.Next(1, 7);
//    count++;
//    Console.WriteLine(rollDie);
//    int options = random.Next(0, 3);
//    switch (options)
//{
//    case 0:
//        Console.WriteLine("NO_PLAY");
//        playerPosition = 0;
//        break;
//    case 1:
//        Console.WriteLine("LADDER");
//        playerPosition += rollDie;
//        break;
//    case 2:
//        Console.WriteLine("SNAKE");
//        playerPosition -= rollDie;
//        if (playerPosition < 0)
//        {
//            playerPosition = 0;
//        }
//        break;
//    default:
//        break;
//}
//Console.WriteLine(playerPosition);
//}
//Console.WriteLine(playerPosition);
//if (playerPosition == isWin)
//{
//    Console.WriteLine("You Won!!");
//    Console.WriteLine("Number of times the dice was rolled to win the game", count);

//}


