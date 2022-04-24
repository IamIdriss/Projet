using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Shared
{
    public class Mail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "La date de la creation")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        [Required]
        [Display(Name = "Le nom de courrier")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Le sujet de courrier")]
        public string Body { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Traitee ou NON")]
        public bool IsCompleted { get; set; }

    }
}
