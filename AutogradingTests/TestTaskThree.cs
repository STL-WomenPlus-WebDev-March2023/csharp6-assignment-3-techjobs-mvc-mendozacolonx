using System;
using System.Reflection;
using TechJobsMVCAutograded6.Controllers;

namespace AutogradingTests;

[TestClass]
public class TestTaskThree
{
    private readonly SearchController _controller;

    public TestTaskThree()
    {
        _controller = new SearchController();
    }

    // Test that Results method exists and contains the correct parameters
    [TestMethod]
    public void TestResultsExistsAndHasCorrectParameters()
    {
        MethodInfo methodInfo = typeof(SearchController).GetMethod("Results");
        ParameterInfo[] parameters = methodInfo.GetParameters();
        Assert.AreEqual(2, parameters.Length);
        Assert.AreEqual("System.String", parameters[0].ParameterType.FullName);
        Assert.AreEqual("System.String", parameters[1].ParameterType.FullName);
        Assert.AreEqual("searchType", parameters[0].Name);
        Assert.AreEqual("searchTerm", parameters[1].Name);
    }

    // Test that Results method includes appropriate local variables
    [TestMethod]
    public void TestResultsUsesAppropriateLocalVariables()
    {
        MethodBody methodBody = typeof(SearchController).GetMethod("Results").GetMethodBody();
        var locals = methodBody.LocalVariables;
        Assert.IsTrue(locals.Count > 1);
    }
}

