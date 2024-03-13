using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() {
            
        }

        public Visualization(DateTime visualizationDate, Content content, Member member) {
            VisualizationDate = visualizationDate;
            Member = member;
            Content = content;
        }
    }
}
