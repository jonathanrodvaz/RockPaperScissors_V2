Console.WriteLine();
Console.WriteLine("\\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/\r\n");
Console.WriteLine("______           _          __ ______                           __  _____      _                        \r\n| ___ \\         | |        / / | ___ \\                         / / /  ___|    (_)                       \r\n| |_/ /___   ___| | __    / /  | |_/ /_ _ _ __   ___ _ __     / /  \\ `--.  ___ _ ___ ___  ___  _ __ ___ \r\n|    // _ \\ / __| |/ /   / /   |  __/ _` | '_ \\ / _ \\ '__|   / /    `--. \\/ __| / __/ __|/ _ \\| '__/ __|\r\n| |\\ \\ (_) | (__|   <   / /    | | | (_| | |_) |  __/ |     / /    /\\__/ / (__| \\__ \\__ \\ (_) | |  \\__ \\\r\n\\_| \\_\\___/ \\___|_|\\_\\ /_/     \\_|  \\__,_| .__/ \\___|_|    /_/     \\____/ \\___|_|___/___/\\___/|_|  |___/\r\n                                         | |                                                            \r\n                                         |_|  ");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Are you ready to rock... and paper... and scissors!?");
    Console.WriteLine();
    Console.WriteLine("Lets Begin!!!");
    Console.WriteLine();
    Console.WriteLine("\\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/\r\n");
    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine();
    Console.WriteLine($"You selected {yourChoice}");

    var opponentChoice = GetOponentChoice();

    Console.WriteLine($"Rockmaster chose {opponentChoice}");
    Console.WriteLine();

    DecideWinner(opponentChoice, yourChoice);
    Console.WriteLine();
    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter Y to play again or any other key to stop...");

    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "y")
        continue;
    else
        Console.WriteLine("Rockmaster laughs and says: 'Guess you had enough of losing at Rock / Paper / Scissors...!'");
    break;

}

string SelectChoice()
{
    Console.WriteLine();
    Console.WriteLine("Choose R, P o S: [R]ock, [P]aper or [S]cissors: ");
    var selectedChoice = Console.ReadLine();

    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please select only one letter: R, P, S");
        selectedChoice = SelectChoice();
    }
    return selectedChoice;
}

char GetOponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S' };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}

void DecideWinner(char opponentChoice, char yourChoice)
{
    if (opponentChoice == yourChoice)
    {
        Console.WriteLine("Tie!");
        return;
    }
    switch (yourChoice)
    {
        case 'R':
        case 'r':
            if (opponentChoice == 'P')
                Console.WriteLine("Paper beats Rock, Rockmaster wins!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Rock beats Scissors, You win!");
            break;

        case 'P':
        case 'p':
            if (opponentChoice == 'R')
                Console.WriteLine("Paper beats Rock, You win!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Scissors beats Paper, Rockmaster wins!");
            break;

        case 'S':
        case 's':
            if (opponentChoice == 'R')
                Console.WriteLine("Rock beats Scissors, Rockmaster wins!");
            else if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats Paper, You win!");
            break;
        default:
            break;

    }


}