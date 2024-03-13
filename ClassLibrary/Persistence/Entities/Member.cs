using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Member
    {
        
        public string Email { get; set; }
        
        public string FullName { get; set; }
        public DateTime LastAccessDate { get; set; }
        [Key]
        public string Nick { get; set; }
        
        public string Password { get; set; }

        public virtual ICollection<Member> Subscriptors { get; set; }
        public virtual ICollection<Member> SubscribedTo { get; set; }
        public virtual ICollection<Visualization> Visualizations { get; set; }
        public virtual ICollection<Content> Contents { get; set; }  
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
