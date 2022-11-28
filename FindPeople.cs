using Microsoft.EntityFrameworkCore;
using TicketSalesCurs.interfaces;

namespace TicketSalesCurs
{
    public class FindPeople : IFind
    {
       public void Find(int numberFilm)
        {
            using (DataBaseContext context = new DataBaseContext())
            {
                MovieViewed movie = (MovieViewed)context.Vieweds.Include(item => item.Users)
                                                   .Include(element => element.Films)
                                                   .Where(find => find.FilmsId == 3);
                                                  




                foreach (var item in movie.Users)
                {
                    Console.WriteLine($"Name - {item.Name} , Surname - {item.Surname}");
                }
            }
        }
    }
}
