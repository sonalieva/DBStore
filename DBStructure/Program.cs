using System;
using DBStructure.Data.Exceptions;
using DBStructure.Data.Models;
using DBStructure.Data.Metods;
using DBStructure.Data.DAL;
namespace DBStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductMet productsMet = new ProductMet();
            UserMet userMet = new UserMet();
            CommentMet commentsMet = new CommentMet();
            StoreDbContext storeDbContext = new StoreDbContext();
            string answer;
            do
            {
                Console.WriteLine("========M E N U========");
                Console.WriteLine("1. Product elave et\n2. Productlar uzre axtaris et\n3. Secilmis productin commentlerine bax(productİd ile)\n4. User elave et\n5. Secilmis userin commentlerine bax(userİd ile)");
                Console.WriteLine("6. Comment elave et\n7. Commenti sil(id ile)\n8. Productlarin ortalama qiymetine bax\n9. Verilmis 2 tarix araligindaki Commentlere bax\n0. programi bitir");
                Console.WriteLine("seciminizi edin");
                answer = Console.ReadLine();
                int prId;
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Zehmet olmasa prodoctun adini daxil edin");
                        string prname = Console.ReadLine();
                        Console.WriteLine("Zehmet olmasa productun qiymetini daxil edin ");
                        string prprice = Convert.ToInt32(Console.ReadLine());
                        Products product = new Products
                        {
                            Name = prname,
                            Price = prprice,
                            CreatedAt = DateTime.Now
                        };
                        try
                        {
                            commentsMet.CheckCommentForProductId(prId);
                        }
                        catch (NotFoundException)
                        {

                            Console.WriteLine(" Mehsulun commenti yoxdur"); ;
                        };
                        break;
                    case "2":
                        Console.WriteLine( "Axtaris datasini daxil ediniz");
                        string smth = Console.ReadLine();

                        try
                        {
                            productsMet.CheckSearchData(smth);
                        }
                        catch (NotFoundException)
                        {

                            Console.WriteLine("Bele bir mehsul yoxdur!"); ;
                        };
                        break;

                }
            }
    }   }
}
