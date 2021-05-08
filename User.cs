using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    [Table("Users")]
    public class User
    {
        [Key, Column("Id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required, StringLength(50, MinimumLength = 3)]
        public string Login { get; set; }
        [Required, StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
        [DefaultValue(false)]
        public bool IsAdmin { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

    }
}
