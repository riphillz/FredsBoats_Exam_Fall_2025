using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("comment")]
    public class Comment
    {
        //Comment Class
        [Key]
        [Column("commentid")]
        public int CommentId { get; set; }

        [Column("content")]
        [StringLength(70)]
        public string Content { get; set; } = string.Empty;

        [Column("author")]
        [StringLength(50)]
        public string Author { get; set; } = string.Empty;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [ForeignKey("Boat_Id")]
        public Boat? boatid { get; set; }

        // Navigation
        public ICollection<Boat> Boat { get; set; } = new List<Boat>();
    }
}