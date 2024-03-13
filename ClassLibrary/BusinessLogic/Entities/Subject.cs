using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Subject
    {
        public Subject() {
            
            this.Contents = new List<Content>();
        }

        public Subject(int code, string fullName, string name) : this()
        {
            this.Code = code;
            this.FullName = fullName;
            this.Name = name;

        }

    }
}
