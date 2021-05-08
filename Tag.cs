using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key, Column("Id")]
        public int TagId { get; set; }
        [Required, StringLength(50, MinimumLength =3)]
        public string TagName { get; set; }
        public List<Post> Posts { get; set; }


}
}
