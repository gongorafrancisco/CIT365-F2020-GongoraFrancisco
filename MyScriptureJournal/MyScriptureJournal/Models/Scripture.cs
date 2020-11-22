using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Display(Name = "Date Added"), DataType(DataType.Date), Required(ErrorMessage = "Date is required!")]
        public DateTime DateAdded { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimum of 3 characters and maximum of 60 characters."),
         Required(ErrorMessage = "Book field must be provided!")]
        [Column(TypeName = "varchar(60)")]
        public string Book { get; set; }

        [Range(1, 200), Required(ErrorMessage ="Chapter field is required!")]
        public int Chapter { get; set; }

        [RegularExpression(@"^[0-9]{1,3}(?:\-[0-9]{1,3})?(?:,\s?[0-9]{1,3}(?:\-[0-9]{1,3})?)*$",
        ErrorMessage = "Only numbers, dashes (-) and whitespaces allowed"), Required(ErrorMessage = "Verse is required!")]
        public string Verse { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,200}$",
        ErrorMessage = "Only leters are accepted, upto 200 characters."), Required(ErrorMessage = "Note is required!")]
        public string Note { get; set; }

    }
}





