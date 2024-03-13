using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public Comment() {
            
        }

        public Comment(String text, DateTime writingDate, Content content, Member writer) {
            Text = text;
            WritingDate = writingDate;
            Content = content;
            Writer = writer;
        }  
    }
}
