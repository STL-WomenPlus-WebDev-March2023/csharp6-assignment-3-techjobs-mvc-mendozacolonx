using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Controllers;
using TechJobsMVCAutograded6.Models;

namespace AutogradingTests;

[TestClass]
public class TestTaskTwo
{
    [TestMethod]
    // Testing that the Index view loads when called from ListController.
    public void TestListIndexLoads()
    {
        ListController _controller = new ListController();
        var result = _controller.Index();
        var typeCheck = result as ViewResult;
        Assert.IsNotNull(typeCheck);
    }

    // Testing that the Jobs view loads when called from ListController.
    [TestMethod]
    public void TestJobListingLoads()
    {
        ListController _controller = new ListController();
        var result = _controller.Jobs("coreCompetency", "Ruby");
        var typeCheck = result as ViewResult;
        Assert.IsNotNull(typeCheck);
    }

    // Testing that the job listing has all of the appropriate fields and the correct number of jobs.
    [TestMethod]
    public void TestJobListingDisplaysAllJobFields()
    {
        ListController _controller = new ListController();
        var result = _controller.Jobs("coreCompetency", "Ruby") as ViewResult;
        var jobs = (List<Job>)result.ViewData["jobs"];
        Assert.AreEqual(3, jobs.Count);
        Assert.AreEqual(3, jobs[0].Id);
        Assert.AreEqual("Junior Web Developer", jobs[0].Name.ToString());
        Assert.AreEqual("Cozy", jobs[0].Employer.ToString());
        Assert.AreEqual("Portland", jobs[0].Location.ToString());
        Assert.AreEqual("Web - Front End", jobs[0].PositionType.ToString());
        Assert.AreEqual("Ruby", jobs[0].CoreCompetency.ToString());
    }
}
