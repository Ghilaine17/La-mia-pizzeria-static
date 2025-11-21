using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeriaStatic.Models
{
    public class Pizza
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        public string UrlPhoto { get; set; }
        [Required] public double Price { get; set; } 

        public Pizza(string name, string description, string urlPhoto, double price)
        {
            this.Name = name;
            this.Description = description;
            this.UrlPhoto = urlPhoto;
            this.Price = price;
        }
    }

}
