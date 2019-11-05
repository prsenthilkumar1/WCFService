using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAssignment1.ViewModel
{
    public class JobViewModel
    {
        public string JobRole { get; set; }
        public List<JobDetailViewModel> JobDetailList { get; set; }

    }

    public class JobDetailViewModel
    {
        public string JobID { get; set; }
        public string JobRole { get; set; }
        public string JobDescription { get; set; }
    }

}