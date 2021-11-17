using System.ComponentModel.DataAnnotations;

namespace financial_chat.Models
{
    public class Room
    {
        [Key]
        public int IdRoom { get; set; }
        public string Nombre { get; set; }

        public Room()
        {
        }

        public Room(string nombre)
        {
            Nombre = nombre;
        }
    }
}
