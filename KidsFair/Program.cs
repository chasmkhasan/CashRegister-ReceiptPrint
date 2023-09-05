namespace KidsFair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pet pet = new Pet();
            pet.Start();

            Console.WriteLine();
            Console.Write("Press <Enter> to start next part");
            Console.ReadKey();
            Console.Clear();

            Album album = new Album();
            album.AlbumStart();

            Console.WriteLine();
            Console.Write("Press <Enter> to start next part");
            Console.ReadKey();
            Console.Clear();

            TicketSeller ticketSeller = new TicketSeller();
            ticketSeller.TicketSellerStart();

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.WriteLine();
            Console.Clear();

        }
    }
}