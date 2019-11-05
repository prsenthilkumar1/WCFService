using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAssignment1.Models
{
    public class ServiceModel
    {
        public MessageModel MessageModel { get; set; }
        public JobModel JobModel { get; set; }
        public CalculatorModel CalculatorModel { get; set; }

    }
}