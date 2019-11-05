using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFAssignment1.ViewModel
{
    public class ServiceViewModel
    {
        public MessageViewModel MessageModel { get; set; }
        public JobViewModel JobModel { get; set; }
        public CalculatorViewModel CalculatorModel { get; set; }

    }
}