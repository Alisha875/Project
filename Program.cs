using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter 1: To Add Player 2: To Remove Player by Id 3: Get Player By Id 4: Get Player by Name 5: Get All Players");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player Id:");
                        int playerId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        int playerAge = int.Parse(Console.ReadLine());

                        Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        team.Add(newPlayer);
                        break;

                    case 2:
                        Console.WriteLine("Enter Player Id to remove:");
                        int removePlayerId = int.Parse(Console.ReadLine());
                        team.Remove(removePlayerId);
                        break;

                    case 3:
                        Console.WriteLine("Enter Player Id to get details:");
                        int getPlayerId = int.Parse(Console.ReadLine());
                        Player playerById = team.GetPlayerById(getPlayerId);
                        if (playerById != null)
                        {
                            Console.WriteLine($"Player Id: {playerById.PlayerId}, Player Name: {playerById.PlayerName}, Player Age: {playerById.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Player Name to get details:");
                        string getPlayerName = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(getPlayerName);
                        if (playerByName != null)
                        {
                            Console.WriteLine($"Player Id: {playerByName.PlayerId}, Player Name: {playerByName.PlayerName}, Player Age: {playerByName.PlayerAge}");
                        }
                        else
                        {
                            Console.WriteLine("Player not found!");
                        }
                        break;

                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Player Id: {player.PlayerId}, Player Name: {player.PlayerName}, Player Age: {player.PlayerAge}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice != "yes" && continueChoice != "y")
                {
                    break;
                }
            }
        }
    }
}
