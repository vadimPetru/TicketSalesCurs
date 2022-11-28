using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSalesCurs
{
    public class MovieViewed
    {
        public int Id { get; set; }

        public User? UsersId { get; set; }

        [ForeignKey("infoUser")]
        public List<User> Users { get; set; }

        public int FilmsId { get; set; }
        [ForeignKey("infoFilm")]
        public List<Film> Films { get; set; }
    }
}
