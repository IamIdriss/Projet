using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Shared
{
    public class Agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Le nom d'agent")]
        public string LastName { get; set; }=String.Empty;

        [Required]
        [Display(Name = "Le prenom nom d'agent")]

        public string FirstName { get; set; } = String.Empty;

        [Required]
        [ForeignKey("Position")]
        [Display(Name = "Id de sa position")]
        public int PositionId { get; set; }
        public Position? Position { get; set; }

    }
}
