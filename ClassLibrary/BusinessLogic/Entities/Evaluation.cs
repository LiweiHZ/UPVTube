using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public Evaluation() {
            
            
        }
        public Evaluation(DateTime evaluationDatetime, String rejectionReason, Member censor, Content content) {
            EvaluationDate= evaluationDatetime;
            RejectionReason= rejectionReason;
            Content= content;
            Censor= censor;
        }
    }
}
