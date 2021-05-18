using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrapeCityBlogging.Data.Entities
{
    [Table("tbl_users")]
    public class tbl_users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("User_Id")] public int UserId { get; set; }
        [Column("User_First_Name")] public string FirstName { get; set; }
        [Column("User_Last_Name")] public string LastName { get; set; }
        [Column("User_Gender")] public string Gender { get; set; }
        [Column("User_Address")] public string Address { get; set; }
    }
}
