using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Subject
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None),Key()]
        public int Code { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Content> Contents { get; set; }

    }
}
