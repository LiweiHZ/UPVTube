using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public DateTime EvaluationDate { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None), Key()]
        public int Id { get; set; }
        public string RejectionReason { get; set; }
        [Required]
        public virtual Member Censor { get; set; }
        [Required]
        public virtual Content Content { get; set; }
    }
}
