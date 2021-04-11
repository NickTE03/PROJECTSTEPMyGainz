
using System.ComponentModel.DataAnnotations;


namespace PROJECTSTEP101010.Models
{
    public class LiftMax
    {
        // Fields & Properties
        [Required(ErrorMessage = "Enter your Id!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your Date!")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Enter Name of Lift!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Weight Lifted!")]
        public int Weight { get; set; }

        // Constructors

        // Methods
    }
}
