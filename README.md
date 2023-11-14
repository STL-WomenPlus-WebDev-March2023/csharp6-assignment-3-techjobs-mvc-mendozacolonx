# TechJobs, MVC Edition

For this assignment, you are asked to once again refactor a TechJobs application, this time using an MVC 
design pattern.

## Assignment Requirements

1. Review Starter Code
2. Complete `ListController`
3. Complete `SearchController`
4. Display Search Results

## Unit Tests

The starter code contains 4 unit test classes.  As with previous graded assignments, each test class was created for a specific task in the instructions.

`TestTaskTwo` verifies the work done to complete the List Views.  This includes displaying a list of jobs.

`TestTaskThree` verifies work done to complete the `SearchController`.  This includes verifying how the `Results()` method was created and making sure that the method uses local variables. This test class focuses on checking your implementation.

`TestTaskFour` verifies the behaviors required for `Results()` to pass accurate data to a view.
 
### Appearance and Code Check:
 
Before you start, check out our [working demo app](https://csharp-mvc.launchcodetechnicaltraining.org/). Please note that the app has to restart occasionally. When you click on it, if it does not work, the app is likely in the middle of restarting. Please give it some time before refreshing the page and you should see the working app.

1. Start the application.
1. Test the search functionality of the project:

    a. Initiate a search by location, using the search term "new york". Only 1 result should be returned on the page. The result may vary in appearance, but make sure it contains the job data organized similar to this image:

    ![Search result](searchByLocation.png "Search Result Sample")  

    b. Initiate another search by location, this time using the search term "chicago". Check that no results are returned.

    c. Search by employer this time, using the search term "equifax". 1 job should be returned.
    
    d. Search by `all` for the term "Ruby". 4 results should be returned.
    
    e. Search for the same term, "Ruby" with the "Skill" category checked. This time, only 3 results should be returned.

1. View the method for displaying the search results tested above.

    a. Be sure you can point to the method within `SearchController`.
    
    b. Is that method posting to `"results"`?
    
    c. Does it make use of `findAll()` and `findByColumnAndValue()` appropriately?
    
    d. What strategy did you use to display the jobs. Did you create one table for all of the jobs displayed or one table per job?
 
1. Back in the running app, navigate to the ``List`` view and select *View All*.

    a. A view of all 98 jobs should be returned.

## Submitting Your Work

To submit your work please following the Submission Instructions.