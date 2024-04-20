using System.ComponentModel.DataAnnotations;

namespace L02P02_2021GH601_2021BS650.Models
{
    public class categorias
    {
        [Key]
        public int id { get; set; }
        public string categoria { get; set; }
    }
}
