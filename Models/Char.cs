using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aueba.Models
{
    public class Char
    {
        [Key]
        [Required]
        public int CharID{get; set;}


        [Required]
        [Column(TypeName = "varchar(20")]
        [Display(Name="Name")]
        public string CharName{get; set;}


        [Required]
        [Display(Name="Dextery")]
        public int CharDex {get; set;}

        
        [Required]
        [Display(Name="Health Points")]
        public int CharHP{get; set;}
    }
}