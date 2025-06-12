using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker_Capstone.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Expense Amount is Required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount should be greater than zero")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Category is Required")]
        public string Category { get; set; }

        [Display(Name = "Expense Date")]
        [DataType(DataType.Date)]
        public DateTime ExpenseDate { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }
    }
}
