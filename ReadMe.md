# Staff Directory Project

The purpose of this project is to demonstrate some of the ASP.Net and C# knowledge I have gained thus far.
The project is a staff directory I made that is a CRUD application. This means that is will allow the user
to create,Read, Update, and Delete information. The information will be persistent through a SQL database.
I came up with the idea because the Accessibility Committee at the American Printing House for the Blind, 
where I currently work, is currently exploring options for a staff directory where internal users could
search for which employees have particular Accessibility skills they need help with.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development 
and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

* LocaldB (included with Visual Studio Community 2017)
* Visual Studio Community 2017
* A browser (tested with Google Chrome, IE, Edge and FireFox)

### Installing
1. Install Visual Studio Community 2017.
2. Update Visual Studio Community 2017.
3. Open the Solution file, StaffDirectoryProject.sln, for the program.
4. Click "Tools" from the top menu bar.
5. Select "Nuget Package Manager" and then "Package Manager Console".
6. In "Package Manager Console", type "update-database", minus the quote marks.This will inject the initial seed data into the database to get you started.
7. You will be able to tell it is done when the console displays "Running the Seed Method" and then returns to saying "PM>". 
8. Select the browser you wish to run the program with.
9. Click Start or press F5 to run the program.
10. Close the browser once you are done to close out the program.

## Built With
* [.Net Framework](https://docs.microsoft.com/en-us/dotnet/) - The web framework used to develop this project with C#.
* [ASP.Net Framework](https://blogs.msdn.microsoft.com/webdev/2017/02/07/asp-net-documentation-now-on-docs-microsoft-com/) - The web framework used
* [Entity Framework](https://docs.microsoft.com/en-us/ef/ef6/) - Used for handling the database connection.

## Notes
Edge for some reason does not like to close out projects when you close the browser. You have to go into Visual Studio and click the stop button to stop the project running.

## Authors

* **[EGrayTech](https://github.com/EGrayTech)** - *Initial work*

## Acknowledgments

* Used [JQuery](http://api.jquery.com) for form validation along with Microsoft's Unobtrusive JavaScript.
* Used [Bootstrap](https://v4-alpha.getbootstrap.com/getting-started/introduction/) for styling, parimarily of buttons and forms.
* Inspired by a mixture of the Treehouse Fitness Frog app built as part of the [MVC Basics Course](https://teamtreehouse.com/library/aspnet-mvc-basics) 
	and the [MVC Forms Course](https://teamtreehouse.com/library/aspnet-mvc-forms).