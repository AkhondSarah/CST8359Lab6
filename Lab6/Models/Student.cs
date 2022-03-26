using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [SwaggerSchema(ReadOnly = true)]
        [Display(Name = "Number")]
        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        [Display(Name = "Program")]
        public string Program
        {
            get;
            set;
        }
    }
}
