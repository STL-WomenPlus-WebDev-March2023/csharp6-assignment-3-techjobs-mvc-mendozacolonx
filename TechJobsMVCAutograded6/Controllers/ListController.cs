using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Data;
using TechJobsMVCAutograded6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVCAutograded6.Controllers;

public class ListController : Controller
{
    internal static Dictionary<string, string> ColumnChoices = new Dictionary<string, string>()
        {
            {"all", "All"},
            {"employer", "Employer"},
            {"location", "Location"},
            {"positionType", "Position Type"},
            {"coreCompetency", "Skill"}
        };
    internal static Dictionary<string, List<JobField>> TableChoices = new Dictionary<string, List<JobField>>()
        {
            //{"all", "View All"},
            {"employer", JobData.GetAllEmployers()},
            {"location", JobData.GetAllLocations()},
            {"positionType", JobData.GetAllPositionTypes()},
            {"coreCompetency", JobData.GetAllCoreCompetencies()}
        };

    public IActionResult Index()
    {
        ViewBag.columns = ColumnChoices;
        ViewBag.tableChoices = TableChoices;
        ViewBag.employers = JobData.GetAllEmployers();
        ViewBag.locations = JobData.GetAllLocations();
        ViewBag.positionTypes = JobData.GetAllPositionTypes();
        ViewBag.skills = JobData.GetAllCoreCompetencies();
        //trying to fix the search by instantiating viewbag.jobs here.
        ViewBag.jobs = JobData.FindAll();
        return View();
    }

    // TODO #2 - Complete the Jobs action method
    public IActionResult Jobs(string column, string value)
    {
        //The view relies on ViewBag.jobs, so to start create a list in the action method called jobs.
        List<Job> jobs = new List<Job>();
        //If the user selects “View All”, you should use JobData.FindAll() to populate jobs with all the jobs
        //and update ViewBag.title.
        if (column.Equals("all"))
        {
            jobs = JobData.FindAll();

        }
        //If the user selects something specific, you should use JobData.FindJobsByColumnAndValue() to populate jobs
        //with jobs that only match that criteria
        //and update ViewBag.title to include the criteria the user chose.
        else
        {
            jobs = JobData.FindByColumnAndValue(column, value);
        }
        ViewBag.title = value;
        //Make sure to set ViewBag.jobs equal to jobs and run the program to see how it is working now!
        ViewBag.jobs = jobs;
        return View();
    }
}

