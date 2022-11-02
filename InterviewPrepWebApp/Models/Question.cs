using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepWebApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string InterviewQuestion { get; set; }
        public string InterviewAnswer { get; set; }

        public Question()
        {

        }
    }
}
