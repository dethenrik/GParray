namespace GParray
{
    class Program
    {
        //field
        //string[] arrangements = {"justin bieber", "kim larsen" };
        static string[] arrangements = new string[100];// gør det muligt at tilføje op til 100 "produkter"
        static int[,] tickets = new int[1000, 2]; //[antal billeter, pris]



        static void Main(string[] args)
        {
            AddToArray();
            Menu();
        }






        //_____________________METODER______________________\\










        static void Menu()
        {
            Console.WriteLine("1. vis arrangementer \n2. Køb billeter \n ");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowALLArrangements();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Arrangements();
                    BuyTicket();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    BackSpace();
                    break;
            }
        }


        //________________________________________\\

        static void ShowALLArrangements()// string er lavet inde i foreach, det vil sige den KUN bruges i koden her og den bruges til at bestemme hvilken ting der skal udskrives.
        {
            foreach (string arr in arrangements)
            {
                Arrangements();

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Backspace:
                        if (true)
                        {
                            Console.Clear();
                            Console.WriteLine("1. vis arrangementer \n2. Køb billeter \n ");
                            
                        }
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ShowALLArrangements();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Arrangements();
                        BuyTicket();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        BackSpace();
                        break;

                }
            }
        }


        static void Arrangements()
        {
            foreach (string arr in arrangements)
            {
                int i = Array.IndexOf(arrangements, arr);
                if (arr != null && arr != "")
                {
                    Console.WriteLine(arr);
                }
            }
        }

        //______________________________________\\


        static void AddToArray() //tilføjer information til Array
        {
            arrangements[0] = "Lil Johan - den grå hal";
            arrangements[1] = "Deagle - TEC kantinen";
            arrangements[2] = "DJ Toenail - Parken";
            arrangements[3] = "TEC lærerband - Amager Plads";
        }



        //_____________________________________________\\
        static void BuyTicket()
        {
            Console.WriteLine("indtast");
            string input = Console.ReadLine();
            int.TryParse(input, out int arrangementNumber);
            input = Console.ReadLine();
            int.TryParse(input, out int amountOfTickets);
            int freeSpot = GetNextFreeUserSpotInTicketsArray();
            tickets[freeSpot, 1] = amountOfTickets;
            tickets[freeSpot, 2] = arrangementNumber;
            return freeSpot;
        }
        static void ShowTicketsBought()
        {
            for (int i = 0; i < length; i++)
            {
                if (tickets[i, 0] == 0) return;
                Console.WriteLine(tickets[i, 0] + tickets[i + 1]);
                
            }
        }
        static void BackSpace()
        {

            Menu();
        }
    }
}