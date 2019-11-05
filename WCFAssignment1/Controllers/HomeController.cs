using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFAssignment1.HttpServiceReference;
using WCFAssignment1.TCPServiceReference;
using WCFAssignment1.ViewModel;

namespace WCFAssignment1.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Index()
        {
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            ServiceViewModel ServiceViewModel = new ServiceViewModel();
            ServiceViewModel.MessageModel = new MessageViewModel();
            ServiceViewModel.JobModel = new JobViewModel();
            ServiceViewModel.JobModel.JobDetailList = new List<JobDetailViewModel>();
            ServiceViewModel.CalculatorModel = new CalculatorViewModel();

            var JobModel = basicHttpClient.OpeningJobs();
            if (JobModel != null)
            {
                foreach (var item in JobModel.JobDetailList)
                {
                    JobDetailViewModel JobDetailViewModel = new JobDetailViewModel()
                    {
                        JobID = item.JobID,
                        JobRole = item.JobRole,
                        JobDescription = item.JobDescription
                    };

                    ServiceViewModel.JobModel.JobDetailList.Add(JobDetailViewModel);
                }
            }

            return View(ServiceViewModel);
        }


        public ActionResult GetHelloMessage(string name)
        {
            string message = string.Empty;
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            message = basicHttpClient.SayHello(name);
            return Json(message, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTodayProgram(string User)
        {
            string UserMessage = string.Empty;
            TCPClient tCPClient = new TCPClient();
            UserMessage = tCPClient.TodayProgram(User);
            return Json(UserMessage, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetJobDetailList()
        {
            JobViewModel JobViewModel = new JobViewModel();
            JobViewModel.JobDetailList = new List<JobDetailViewModel>();
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            var JobModel = basicHttpClient.OpeningJobs();
            if (JobModel != null)
            {
                foreach (var item in JobModel.JobDetailList)
                {
                    JobDetailViewModel JobDetailViewModel = new JobDetailViewModel()
                    {
                        JobID = item.JobID,
                        JobRole = item.JobRole,
                        JobDescription = item.JobDescription
                    };

                    JobViewModel.JobDetailList.Add(JobDetailViewModel);
                }
            }
            return Json(JobViewModel, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetJobByRole(string Role)
        {
            JobViewModel JobViewModel = new JobViewModel();
            JobViewModel.JobDetailList = new List<JobDetailViewModel>();
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            var JobModel = basicHttpClient.OpeningJobsByRole(Role);
            if (JobModel != null)
            {
                foreach (var item in JobModel.JobDetailList)
                {
                    JobDetailViewModel JobDetailViewModel = new JobDetailViewModel()
                    {
                        JobID = item.JobID,
                        JobRole = item.JobRole,
                        JobDescription = item.JobDescription
                    };

                    JobViewModel.JobDetailList.Add(JobDetailViewModel);
                }
            }
            return PartialView("JobListByRole", JobViewModel);
        }

        public ActionResult Addition(decimal firstnumber, decimal secondnumber)
        {
            decimal result = 0;
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            result = basicHttpClient.Addition(firstnumber, secondnumber);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Subtraction(decimal firstnumber, decimal secondnumber)
        {
            decimal result = 0;
            BasicHttpClient basicHttpClient = new BasicHttpClient();
            result = basicHttpClient.Subtraction(firstnumber, secondnumber);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}