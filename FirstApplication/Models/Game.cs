namespace FirstApplication.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Game
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string GameId { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Game Name")]
        public string Name { get; set; }

        [Display(Name= "Is Multiplayer")]
        public bool IsMultiplayer { get; set; }

        [Display(Name = "Create Date")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Edit Date")]
        public DateTime EditDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Genres")]
        [InverseProperty("Game")]
        public virtual ICollection<GameGenre> Genres { get; set; } = new HashSet<GameGenre>();

        [Display(Name = "Rating")]
        [InverseProperty("Game")]
        public virtual ICollection<Rating> Rating { get; set; } = new HashSet<Rating>();

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
