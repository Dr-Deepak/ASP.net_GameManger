using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApplication.Models
{


    public partial class Rating
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string RatingId { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "User")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]     
     
        public virtual ApplicationUser User { get; set; }

        [Required]
        [StringLength(128)]
        [Display(Name = "Game")]
        public string GameId { get; set; }
        [ForeignKey("GameId")]

        public Game Game { get; set; }

        [Display(Name = "Create Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; } 

        [Display(Name = "Edit Date")]
        public DateTime EditDate { get; set; } = DateTime.UtcNow;
        
      
    }
}
