using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Entities
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        
        public string IconPath { get; set; }

    }
}
