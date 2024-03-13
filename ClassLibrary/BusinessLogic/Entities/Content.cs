using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content()
        {
            Visualizations = new List<Visualization>();
            Comments = new List<Comment>();
            Subjects = new List<Subject>();
        }

        public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadtime, Member owner) : this()
        {
            ContentURI = contentURI;
            Description = description;
            IsPublic = isPublic;
            Title = title;
            UploadDate = uploadtime;
            Owner = owner;
        }
    }
}
