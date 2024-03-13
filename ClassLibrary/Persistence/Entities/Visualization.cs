using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        [Key]
        [Column(Order = 0, TypeName = "int")]
        public int Id { get; set; }
        public DateTime VisualizationDate { get; set; }
        [Required]
        public virtual Member Member { get; set; }
        [Required]
        public virtual Content Content { get; set; }
    }
}
