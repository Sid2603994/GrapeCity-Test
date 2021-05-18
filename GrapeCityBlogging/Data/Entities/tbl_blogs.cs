using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrapeCityBlogging.Data.Entities
{
    [Table("tbl_blogs")]
    public class tbl_blogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Blog_Id")] public int BlogId { get; set; }
        [Column("Blog_User_Id")] public int BlogUserId { get; set; }
        [Column("Blog_Title")] public string Title { get; set; }
        [Column("Blog_Content")] public string Content { get; set; }
        [Column("Blog_Description")] public string Description { get; set; }
    }
}
