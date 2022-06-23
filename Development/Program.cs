using DiscordRPC;
using System.Text.Json;

namespace NaoRPC
{

    public class PresenceData
    {
        public string? Id { get; set; }

        public string? Details { get; set; }
        public string? State { get; set; }

        public string? LargeImageKey { get; set; }
        public string? LargeImageText { get; set; }

        public string? SmallImageKey { get; set; }
        public string? SmallImageText { get; set; }

        public string? ButtonOneLabel { get; set; }
        public string? ButtonOneUrl { get; set; }

        public string? ButtonTwoLabel { get; set; }
        public string? ButtonTwoUrl { get; set; }
    }

    public class Program
    {
        public static void ConsoleTitle()
        {
            Console.Title = "Nao_RPC";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please view 'README.md' before using.\n\n\n");
            Console.ResetColor();
            Console.Write("    (@@@@ @@@@@@@@@@*       @@@@@@@@@@@#@@@@@      @@@@@@@@@@@@@       \n");
            Console.Write("    (@@@@@@     @@@@@@    @@@@@@     ,@@@@@@@    @@@@@&     @@@@@@     \n");
            Console.Write("    (@@@@        %@@@@   @@@@@          @@@@@   @@@@%         @@@@@    \n");
            Console.Write("    (@@@@         @@@@   @@@@#          @@@@@   @@@@           @@@@    \n");
            Console.Write("    (@@@@         @@@@   @@@@@          @@@@@   @@@@@         @@@@@    \n");
            Console.Write("    (@@@@         @@@@    @@@@@@@   .@@@@@@@@    @@@@@@#   @@@@@@@     \n");
            Console.Write("    (@@@@         @@@@      (@@@@@@@@@@ @@@@@      %@@@@@@@@@@@        \n\n");
            Console.Write("            Nao_RPC - Rich Presence Custom for Discord!                \n\n\n");
        }

        public static void SetupData()
        {
            string? userId = null;

            string? userDetails = null;
            string? userState = null;

            string? userLargeImageAnswer = null;
            string? userLargeImageKey = null;
            string? userLargeImageText = null;

            string? userSmallImageAnswer = null;
            string? userSmallImageKey = null;
            string? userSmallImageText = null;

            string? userButtonOneAnswer = null;
            string? userButtonOneLabel = null;
            string? userButtonOneUrl = null;

            string? userButtonTwoAnswer = null;
            string? userButtonTwoLabel = null;
            string? userButtonTwoUrl = null;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("What is your Application Id? (Required) ");
            Console.ResetColor();
            userId = Console.ReadLine();

            if (userId == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Please input a valid answer\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("What is your Presence's Details? ");
            Console.ResetColor();
            userDetails = Console.ReadLine();

            if (userDetails == "")
            {
                userDetails = null;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("What is your Presence's State? ");
            Console.ResetColor();
            userState = Console.ReadLine();

            if (userState == "")
            {
                userState = null;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Do you want an Large Image? (y / n) ");
            Console.ResetColor();
            userLargeImageAnswer = Console.ReadLine();

            if (userLargeImageAnswer == "y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What is your Large Image's Key? (Required) ");
                Console.ResetColor();
                userLargeImageKey = Console.ReadLine();

                if (userLargeImageKey == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Please input a valid answer\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What is your Large Image's Text? ");
                Console.ResetColor();
                userLargeImageText = Console.ReadLine();
                if (userLargeImageText == "")
                {
                    userLargeImageText = null;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Do you want a Small Image? (y / n) ");
                Console.ResetColor();
                userSmallImageAnswer = Console.ReadLine();

                if (userSmallImageAnswer == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("What is your Small Image's Key? (Required) ");
                    Console.ResetColor();
                    userSmallImageKey = Console.ReadLine();

                    if (userSmallImageKey == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Please input a valid answer\n");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("What is your Small Image's Text? ");
                    Console.ResetColor();
                    userSmallImageText = Console.ReadLine();

                    if (userSmallImageText == "")
                    {
                        userLargeImageText = null;
                    }
                }
                else if (userSmallImageAnswer != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Please input a valid answer\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else if (userLargeImageAnswer == "n")
            {
                userLargeImageKey = null;
                userLargeImageText = null;

                userSmallImageKey = null;
                userSmallImageText = null;
            }
            else if (userLargeImageAnswer != "n")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Please input a valid answer\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Do you want an Button? (y / n) ");
            Console.ResetColor();
            userButtonOneAnswer = Console.ReadLine();

            if (userButtonOneAnswer == "y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What is your Button's Label? (Required) ");
                Console.ResetColor();
                userButtonOneLabel = Console.ReadLine();

                if (userButtonOneLabel == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Please input a valid answer\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What is your Button's Url? (Required) ");
                Console.ResetColor();
                userButtonOneUrl = Console.ReadLine();

                if (userButtonOneUrl == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Please input a valid answer\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Do you want another Button? (y / n) ");
                Console.ResetColor();
                userButtonTwoAnswer = Console.ReadLine();

                if (userButtonTwoAnswer == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("What is your Button's Label? (Required) ");
                    Console.ResetColor();
                    userButtonTwoLabel = Console.ReadLine();

                    if (userButtonTwoLabel == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Please input a valid answer\n");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("What is your Button's Url? ");
                    Console.ResetColor();
                    userButtonTwoUrl = Console.ReadLine();

                    if (userButtonTwoUrl == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Please input a valid answer\n");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                }
                else if (userButtonTwoAnswer != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Please input a valid answer\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else if (userButtonOneAnswer != "n")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Please input a valid answer\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            var presenceData = new PresenceData()
            {
                Id = userId,
                Details = userDetails,
                State = userState,
                LargeImageKey = userLargeImageKey,
                LargeImageText = userLargeImageText,
                SmallImageKey = userSmallImageKey,
                SmallImageText = userSmallImageText,
                ButtonOneLabel = userButtonOneLabel,
                ButtonOneUrl = userButtonOneUrl,
                ButtonTwoLabel = userButtonTwoLabel,
                ButtonTwoUrl = userButtonTwoUrl
            };

            string fileName = "PresenceData.json";
            string jsonString = JsonSerializer.Serialize(presenceData);
            File.WriteAllText(fileName, jsonString);
        }

        public static PresenceData? GetJsonData()
        {
            string fileName = "PresenceData.json";
            string jsonString = File.ReadAllText(fileName);
            PresenceData? presenceData = JsonSerializer.Deserialize<PresenceData>(jsonString);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(File.ReadAllText(fileName));
            Console.ResetColor();

            return presenceData;
        }

        public static void UpdatePresence(PresenceData? presenceData, DiscordRpcClient client)
        {
            if (presenceData?.ButtonOneLabel != null & presenceData?.ButtonOneUrl != null & presenceData?.ButtonTwoLabel != null & presenceData?.ButtonTwoUrl != null)
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = presenceData?.Details,
                        State = presenceData?.State,
                        Assets = new Assets()
                        {
                            LargeImageKey = presenceData?.LargeImageKey,
                            LargeImageText = presenceData?.LargeImageText,

                            SmallImageKey = presenceData?.SmallImageKey,
                            SmallImageText = presenceData?.SmallImageText
                        },
                        Buttons = new Button[]
                        {
                            new Button() { Label = presenceData?.ButtonOneLabel, Url = presenceData?.ButtonOneUrl },
                            new Button() { Label = presenceData?.ButtonTwoLabel, Url = presenceData?.ButtonTwoUrl }
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ex}\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else if (presenceData?.ButtonOneLabel != null & presenceData?.ButtonOneUrl != null & presenceData?.ButtonTwoLabel == null & presenceData?.ButtonTwoUrl == null)
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = presenceData?.Details,
                        State = presenceData?.State,
                        Assets = new Assets()
                        {
                            LargeImageKey = presenceData?.LargeImageKey,
                            LargeImageText = presenceData?.LargeImageText,

                            SmallImageKey = presenceData?.SmallImageKey,
                            SmallImageText = presenceData?.SmallImageText
                        },
                        Buttons = new Button[]
                        {
                            new Button() { Label = presenceData?.ButtonOneLabel, Url = presenceData?.ButtonOneUrl }
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ex}\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else if (presenceData?.ButtonOneLabel == null & presenceData?.ButtonOneUrl == null & presenceData?.ButtonTwoLabel != null & presenceData?.ButtonTwoUrl != null)
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = presenceData?.Details,
                        State = presenceData?.State,
                        Assets = new Assets()
                        {
                            LargeImageKey = presenceData?.LargeImageKey,
                            LargeImageText = presenceData?.LargeImageText,

                            SmallImageKey = presenceData?.SmallImageKey,
                            SmallImageText = presenceData?.SmallImageText
                        },
                        Buttons = new Button[]
                        {
                            new Button() { Label = presenceData?.ButtonTwoLabel, Url = presenceData?.ButtonTwoUrl }
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ex}\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = presenceData?.Details,
                        State = presenceData?.State,
                        Assets = new Assets()
                        {
                            LargeImageKey = presenceData?.LargeImageKey,
                            LargeImageText = presenceData?.LargeImageText,

                            SmallImageKey = presenceData?.SmallImageKey,
                            SmallImageText = presenceData?.SmallImageText
                        }
                    });
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{ex}\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }

        public static void Main()
        {
            ConsoleTitle();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Have you set your data? (y / n) ");
            Console.ResetColor();
            string? userDataAnswer = Console.ReadLine();

            if (userDataAnswer == "n")
            {
                try
                {
                    SetupData();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Initialised user data\n");
                    Console.ResetColor();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Failed to initialise user data\n");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            else if (userDataAnswer != "y")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Please input a valid answer\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            PresenceData? presenceData = null;

            try
            {
                presenceData = GetJsonData();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Fetched user data\n");
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Failed to fetch user data\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            DiscordRpcClient client = new(presenceData?.Id);

            client.OnConnectionEstablished += (sender, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Connected to Discord\n");
                Console.ResetColor();
            };

            client.OnConnectionFailed += (sender, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Failed to connect to Discord\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            };

            client.OnError += (sender, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{args.Code}\n");
                Console.ResetColor();
                Thread.Sleep(2000);
                Environment.Exit(0);
            };

            client.OnReady += (sender, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Connected to the Discord Application: {client.ApplicationID}\n");
                Console.Write($"Connected to the Discord user: {args.User.Username}\n");
                Console.ResetColor();
            };

            client.OnPresenceUpdate += (sender, args) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Updated Rich Presence for the user\n");
                Console.ResetColor();
            };

            client.Initialize();

            UpdatePresence(presenceData, client);

            Console.ReadKey(true);
        }
    }
}