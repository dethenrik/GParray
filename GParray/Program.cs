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
            while (true)
            {
                Menu();
            }
            
        }






        //_____________________METODER______________________\\










        static void Menu()
        {
            Console.WriteLine("\n1. Vis arrangementer \n2. Køb Billet\n3. Vis alle billetter\n\nIndtast valg");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowALLArrangements();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Arrangements();
                    int t = BuyTicket();
                    Console.WriteLine("billet nummer: " + t);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    ShowTicketsBought();
                    break;
            }
        }


        //________________________________________\\

        static void ShowALLArrangements()// string er lavet inde i foreach, det vil sige den KUN bruges i koden her og den bruges til at bestemme hvilken ting der skal udskrives.
        {
            foreach (string arr in arrangements)
            {
                Arrangements();
                int i = Array.IndexOf(arrangements, arr);
                Console.WriteLine(i + " " + arr);


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
        static int BuyTicket()
        {
            Console.WriteLine("indtast nummer på arrangement du ønsker at købe billet til");
            string input = Console.ReadLine();
            int.TryParse(input, out int arrangementNumber);
            Console.WriteLine("indtast det ønskede antal billetter");
            input = Console.ReadLine();
            int.TryParse(input, out int amountOfTickets);

            int freeSpot = GetNextFreeSpotInTicketArray();
            tickets[freeSpot, 0] = amountOfTickets;
            tickets[freeSpot, 1] = arrangementNumber;
            return freeSpot;
        }

        static int GetNextFreeSpotInTicketArray()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) { return i; }
            }
            return 0;
        }


        static void ShowTicketsBought()
        {
            Console.WriteLine("Antal\tArrangement\tLokation");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) return;
                string arr = arrangements[tickets[i, 1]];
                string[] splitArray = arr.Split("- ");
                Console.WriteLine(tickets[i, 0] + "\t" + splitArray[0] + "\t" + splitArray[1]);
            }
        }
    }
}