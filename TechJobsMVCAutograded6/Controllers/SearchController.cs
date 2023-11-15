using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Data;
using TechJobsMVCAutograded6.Models;
using static System.Collections.Specialized.BitVector32;

namespace TechJobsMVCAutograded6.Controllers;

public class SearchController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        ViewBag.columns = ListController.ColumnChoices;
        return View();
    }

    // TODO #3 - Create an action method to process a search request and render the updated search views.

    //The Results() method should take in two parameters.
    //Both parameters must be strings
        //the first one should be called “searchType”
        //the second one should be called “searchTerm”.
    public IActionResult Results(string searchType, string searchTerm)
    {
        //First, you need to create a local variable called “jobs” that is of type List<Job>.
        List<Job> jobs = new List<Job>();
        //If the user enters “all” in the search box, or if they leave the box empty, call the FindAll() method from JobData.
        if (searchTerm.Equals("all") || searchTerm.Equals(""))
        {
            jobs = JobData.FindAll();
        }
        //Otherwise, send the search information to FindByColumnAndValue.
        else
        {
            jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
        }
        //In either case, store the results in a jobs List.
        ViewBag.jobs = jobs;
        //Pass ListController.ColumnChoices into the view, as the existing Index() action method does.
        ViewBag.Columns = ListController.ColumnChoices;
        //Pass jobs into the Index.cshtml view.
        return View("Index");

    }


}

