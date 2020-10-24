using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Entities
{
    public class Vehicle
    {
        [Key]
        public int ID { get; set; }
        
        public string OwnerName { get; set; }
        public int ManufacturerId { get; set; }
        public int YearOfManufactue { get; set; }
        public decimal WeightInKilo{get;set;}
    }
}
