using System.ComponentModel.DataAnnotations;

namespace CarService.Data.Entities
{
    public class AutoParts
    {
        [Key]

        public int id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Price{ get; set; }
        [Required]
        public int Stock{ get; set; }

        public int CategoryId {  get; set; }

        public AutoParts(string name , int price , int stock)
        {
             Name = name;
            Price = price;
            Stock = stock;

        }
    }
}
