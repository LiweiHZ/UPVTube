using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key()]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime WritingDate { get; set; }
        [Required]
        public virtual Content Content { get; set; }
        [Required]
        public virtual Member Writer { get; set; }
    }
}
