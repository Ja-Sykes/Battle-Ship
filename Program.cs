class program
{
    static void Main()
    {
        //Makes Game view larger
        Console.WindowHeight = 50;
        Console.WindowWidth = 150;

        string[,] p1OceanBoard = {
                    {"  ",  " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J \n" }  ,
                    {"1", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"2", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"3", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"4", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"5", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"6", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"7", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"8", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"9", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"10", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},         };

        string[,] p1TargetBoard = {
                    {"  ",  " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J \n" }  ,
                    {"1", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"2", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"3", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"4", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"5", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"6", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"7", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"8", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"9", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"10", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},         };

        ///
        ///

        string[,] p2OceanBoard = {
                    {"  ",  " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J \n" },
                    {"1", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"2", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"3", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"4", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"5", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"6", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"7", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"8", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"9", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"10", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                                                                                                    };
        string[,] p2TargetBoard = {
                    {"  ",  " A ", " B ", " C ", " D ", " E ", " F ", " G ", " H ", " I ", " J \n" }  ,
                    {"1", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"2", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"3", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"4", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"5", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"6", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"7", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"8", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"9", " [ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},
                    {"10", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]\n"},         };

        ///
        ///

        ///Where I will store the user's ship's coords and use if a user guesses one, i.e - Guessed A1, can update boards accordingly. Also the win condition if it's empty.
        List<string> p1ShipStorage = new List<string>();
        List<string> p2ShipStorage = new List<string>();
        List<string> aiShipStorage = new List<string>();

        ///Ask's if player is playing an AI or another player
        bool isPlayingAI = false;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.WriteLine("Please enter '1' for Player or '2' for AI:");
            string playerOrAi = Console.ReadLine();

            if (playerOrAi == "1")
            {
                isPlayingAI = false;
                isValidInput = true;
            }
            else if (playerOrAi == "2")
            {
                isPlayingAI = true;
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter '1' or '2'.");
                PrintBoard(p2OceanBoard);
            }
        }

        ///Player 1 will always place ships. AI will too, but it will just be generated.
        placeShips(p1OceanBoard, p1ShipStorage);
        Console.Clear();

        if (isPlayingAI == false)
        {
            Console.WriteLine("Player 2 is up!");
            placeShips(p2OceanBoard, p2ShipStorage);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("AI Is placing ships.");
            Thread.Sleep(5000);
            Console.Clear();
            placeAIShips(p2OceanBoard, p2ShipStorage);
        }


        // Prints the needed Boards
        static void PrintBoard(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 0 || j == 0)
                    {
                        Console.Write(board[i, j]);
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

        }

        // Got this from help of ChatGPT, must admit. No way I could have done this in such a simple way...
        // I am using my function from PrintBoard to make it so you can place ships on needed board.
        static void placeShips(string[,] board, List<string> shipStorage)
        {
            for (int count = 0; count < 17; count++)
            {
                // Get user input for the placement coordinates
                Console.WriteLine("You have 5 ships. One is 5 blocks long, one is 4 long, two are 3 long, and One is 2 long.");
                Console.WriteLine();
                Console.Write("Enter placement coordinates (e.g., A1 to J10): ");

                string placer = Console.ReadLine();

                if (placer.Length >= 2)
                {
                    char colChar = Char.ToUpper(placer[0]);
                    int row;

                    if (int.TryParse(placer.Substring(1), out row) && colChar >= 'A' && colChar <= 'J' && row >= 1 && row <= 10)
                    {
                        // Convert the column character to a column index
                        int col = colChar - 'A' + 1;

                        // Update the corresponding cell in the array
                        board[row, col] = "[O]";

                        // Add the valid placement coordinates to the ship storage
                        shipStorage.Add(placer);

                        // Print the updated board
                        Console.Clear();
                        for (int i = 0; i < board.GetLength(0); i++)
                        {
                            for (int j = 0; j < board.GetLength(1); j++)
                            {
                                Console.Write(board[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Coordinates must be in the format A1 to J10.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Coordinates must be in the format A1 to J10.");
                }
            }
        }


        static void placeAIShips(string[,] board, List<string> shipStorage)
        {
            Random random = new Random();

            // Define ship lengths
            int[] shipLengths = { 5, 4, 3, 3, 2 };

            // Define directions (0 for horizontal, 1 for vertical)
            int[] directions = { 0, 1 };

            foreach (int shipLength in shipLengths)
            {
                bool shipPlaced = false;

                while (!shipPlaced)
                {
                    int direction = directions[random.Next(2)]; // Randomly choose direction
                    int col, row;

                    if (direction == 0)
                    {
                        // Horizontal placement
                        col = random.Next(1, 11 - shipLength); // Random column
                        row = random.Next(1, 11); // Random row
                    }
                    else
                    {
                        // Vertical placement
                        col = random.Next(1, 11);
                        row = random.Next(1, 11 - shipLength);
                    }

                    // Check if the chosen coordinates are valid
                    bool isValidPlacement = true;
                    for (int i = 0; i < shipLength; i++)
                    {
                        int checkRow = direction == 1 ? row + i : row;
                        int checkCol = direction == 0 ? col + i : col;
                        if (board[checkRow, checkCol] != "[ ]")
                        {
                            isValidPlacement = false;
                            break;
                        }
                    }

                    if (isValidPlacement)
                    {
                        // Place the ship on the board
                        for (int i = 0; i < shipLength; i++)
                        {
                            int placeRow = direction == 1 ? row + i : row;
                            int placeCol = direction == 0 ? col + i : col;
                            board[placeRow, placeCol] = "[O]";
                            shipStorage.Add($"{(char)('A' + placeCol - 1)}{placeRow}");
                        }

                        shipPlaced = true;
                    }
                }
            }
        }




        /// Each Player will place their ships Then set the oceanboard as each other's targetboads?? Maybe create a spereate array so if a player
        /// guess one of the ship placements then check if it's hit
        /// 
        ///IDEA!!: CREATE a function that will auto index into each coord? 
        /// Like A1 would be p2OceanBoard[0,1] and so on... Use that function to help the fire one?
        /// then when I Get fire one, put that function in a while loop then print each board depending on which player's turn is up...
        /// 
        int playerScore = 1;

        static void fire(string[,] oceanBoard, string[,] targetBoard, string[,] opponentOceanBoard, string[,] opponentTargetBoard, List<string> shipStorage, ref int playerScore)
        {
            Console.WriteLine("Guess a coordinate, A1 - J10.");
            // Guesser will just read what the player inputs and update the board from there.
            string guesser = Console.ReadLine();

            // Convert the guessed coordinate to row and column indices
            int col = guesser[0] - 'A' + 1; // Convert the column character to a column index

            if (int.TryParse(guesser.Substring(1), out int row) && col >= 1 && col <= 10 && row >= 1 && row <= 10)
            {
                // Check if the guessed coordinate is in the shipStorage
                if (shipStorage.Contains(guesser))
                {
                    Console.WriteLine("Yes, " + guesser + " was hit! Go again: ");

                    // Update the targetBoard with the hit indication. Also removes the "coordinate" from shipStorage (So I can use that as a win condition.)
                    shipStorage.Remove(guesser);
                    targetBoard[row, col] = "[X]";
                    opponentOceanBoard[row, col] = "[X]";
                    //oceanBoard[row, col] = "[X]"; // Update the player's ocean board

                    playerScore++;
                }
                else
                {
                    targetBoard[row, col] = "[-]";
                    opponentOceanBoard[row, col] = "[-]";
                    //oceanBoard[row, col] = "[-]"; // Update the player's ocean board
                    Console.Clear();
                    Console.WriteLine("Miss! Switch players. Press enter to continue!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Coordinates must be in the format A1 to J10.");
            }
        }

        static string GenerateAIGuess(string[,] targetBoard)
        {

            string xAxis = "ABCDEFGHIJ";
            Random random = new Random();

            int length = xAxis.Length;
            int randomX = random.Next(0, length);

            char randomChoice = xAxis[randomX];
            int col = random.Next(1, 11);
            int row = random.Next(1, 11);

            string aiGuess = randomChoice.ToString() + col.ToString();

            return aiGuess;

        }

        bool isGamePlaying = true;

        while (isGamePlaying)
        {
            if (playerScore % 2 != 0)
            {
                Console.WriteLine("Player 1, you are up!");
                PrintBoard(p1OceanBoard);
                PrintBoard(p1TargetBoard);

                fire(p1OceanBoard, p1TargetBoard, p2OceanBoard, p2TargetBoard, p2ShipStorage, ref playerScore);
            }
            else
            {
                if (isPlayingAI)
                {
                    Console.WriteLine("AI is up!");

                    // Generate AI's guess
                    string aiGuess = GenerateAIGuess(p2TargetBoard);
                    Console.WriteLine("AI guessed: " + aiGuess);

                    // Fire the AI's guess
                    fire(p1OceanBoard, p1TargetBoard, p2OceanBoard, p2TargetBoard, p2ShipStorage, ref playerScore);
                }
                else
                {
                    Console.WriteLine("Player 2, you are up!");
                    PrintBoard(p2OceanBoard);
                    PrintBoard(p2TargetBoard);

                    fire(p2OceanBoard, p2TargetBoard, p1OceanBoard, p1TargetBoard, p1ShipStorage, ref playerScore);
                }
            }

            // Switch to the next player's turn
            playerScore++;
            Console.Clear();

            // Check for game-ending conditions
            if (p1ShipStorage.Count == 0)
            {
                isGamePlaying = false;
                Console.WriteLine("Player 2 Wins!");
            }
            else if (p2ShipStorage.Count == 0)
            {
                isGamePlaying = false;
                Console.WriteLine(isPlayingAI ? "AI Wins!" : "Player 1 Wins!");
            }
        }

    }

}