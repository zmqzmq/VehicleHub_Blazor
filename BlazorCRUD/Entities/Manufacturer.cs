using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Entities
{
    public class Manufacturer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}