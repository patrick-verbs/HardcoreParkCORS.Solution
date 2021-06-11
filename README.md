# Hardcore ParkCORS 🏞

#### _Basic API implementation in ASP.NET Core_ | Patrick Lee

## Description

This project was made to demonstrate building out a backend API using an ASP.NET Core workflow.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these pinned installation instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
- A web browser to view and interact with the project

### Installation

1. Clone the repository: `$ git clone https://github.com/patrick-verbs/HardcoreParkCORS.Solution`
2. Navigate to the `HardcoreParkCORS.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup the SQL database using MySQL:
   - You ___do not___ need to create an `appsettings.json` file manually; the program will check for this file on startup, and create the file for you based on prompts
   - If you opt to create `appsettings.json` manually:
      - Create an `appsettings.json` file in the `ParkAPI directory
      - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
      ```
      {
         "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=patrick_lee_park_api;uid=root;pwd=<password>;"
            }
      }
      ```
      - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) to launch MySQL server
5. To create and run the database, navigate back to the root of the repository (`HardcoreParkCORS.Solution`) and enter the command `dotnet tool install --global dotnet-ef` in the terminal; this will enable EF Core migrations if they are not already set
    * If you make any changes to the controller or model files, be sure to run the command `dotnet ef migrations add [DescriptiveNameOfYourMigration]` within the project directory (`ParkAPI`) to add a current migration and ensure the database updates correctly
    * Run the command `dotnet ef database update` within the project directory (`ParkAPI`); you should now be able to view a database named `patrick_lee_park_api` within MySQL Workbench that contains the project's correct table entries
6. Finally, enter command `dotnet run` or `dotnet watch run` to run the API service

### Full API Documentation
1. If interested in viewing HardcoreParkCORS endpoints, you can use Postman like so:
    - Start by running the command `dotnet run` in the `ParkAPI` project folder if you haven't already to get a server up and running. 
    - Then, navigate to https://www.postman.com and make an account if you haven't already. Once signed in,press "Launch Postman". On the left-hand side, look for the "Workspaces" tab, and select it. Once inside, select "My Workspace". 
    - Once you are inside of your workspace, look almost directly under the search bar on the top- there will be an "Overview" and a "+" Tab. Navigate over to the "+" Tab. 
    - For GET requests: to get all the parks in this API, enter http://localhost:5000/api/Parks into the "GET" search bar and select send. Then, the correct response should appear in the "Pretty" Tab as a JSON response exactly like this:
    [
    {
        "parkId": 1,
        "name": "Agate Beach",
        "type": "State",
        "location: "Near Newport, Oregon, United States",
        "description": "(text courtesy of stateparks.oregon.gov) Diggers, this park's for you! Razor clamming is a favorite activity as well as surfing. If you plan to visit prime Newport attractions like the Oregon Coast Aquarium and Hatfield Marine Science Center, you must stop in for a refreshing picnic at Agate Beach.",
        "url": "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=152",
        "phone": "541-265-4560"
    },
    {
        "parkId": 2,
        "name": "Alderwood",
        "type": "State",
        "location: "Near Eugene, Oregon, United States",
        "description": "(text courtesy of stateparks.oregon.gov) Large trees characterize this forested park along Hwy 36 between Junction City and Triangle Lake. There's a picnic area, restroom, and short trail along the Long Tom River. Bring a lunch and relax!",
        "url": "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=59",
        "phone": "541-937-1173"
    }
    ]
    - To GET by querying the ID: simply enter http://localhost:5000/api/Parks?ParkID=[ENTER-ID-NUMBER-HERE] into that same GET search bar and replace the [ENTER-ID-NUMBER-HERE] with the ID number of the park would like to query. For Example, http://localhost:5000/api/Parks?ParkID=1 will return the following response:
    {
        "parkId": 1,
        "name": "Agate Beach",
        "type": "State",
        "location": "Near Newport, Oregon, United States",
        "description": "(text courtesy of stateparks.oregon.gov) Diggers, this park's for you! Razor clamming is a favorite activity as well as surfing. If you plan to visit prime Newport attractions like the Oregon Coast Aquarium and Hatfield Marine Science Center, you must stop in for a refreshing picnic at Agate Beach.",
        "url": "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=152",
        "phone": "541-265-4560"
    }
    - Note: You can also GET responses by querying by Type (such as http://localhost:5000/api/Parks/?type=National), by Name (http://localhost:5000/api/Parks/?name=Agate Beach), as well as other, less-practical properties (such as by Description or Phone). Finally, you may switch out the specific parameters to retrieve whichever specific park data you want (e.g., switching [?name=Agate Beach] into [?name=Alderwood] and so forth)
    - For POST requests: If you would like to add some parks to this API, Switch the request in the dropdown to the left from GET to POST. Next, deselect the "Params" tab underneath and switch to the "Body" tab. Then, select the radio button that says "Raw" and paste this into the body, replacing all values with the values you want:
    {
    "parkId": 0,
    "name": "string",
    "type": "string",
    "location": "string",
    "description": "string",
    "url": "string",
    "phone": "string"
    }
    - Finally, after filling out your preferred values, enter in http://localhost5000/api/Parks into the search bar and press "Send".
    - For PUT requests: To edit an exsisting entry with a PUT request, select the dropdown from GET or POST to PUT instead. Again, select the "Body" tab, and select the "raw" radio button. Post the following into the body and replace the values as you would like just as you would in the POST request:
    {
    "parkId": 0,
    "name": "string",
    "type": "string",
    "location": "string",
    "description": "string",
    "url": "string",
    "phone": "string"
    }
    - Finally, after filling out your preffered values, enter in http://localhost5000/api/Parks/[THE-ID-NUMBER-YOU-WANT-TO-EDIT/REPLACE] Ex: If you wanted to replace Agate Beach (which has the id of `1`), you'd put http://localhost5000/api/Parks/1.
    - For DELETE requests: To delete one of the parks from this API, select GET in the searchbar drop down and select DELETE instead. Then, paste in http://localhost5000/api/Parks/[THE-ID-NUMBER-YOU-WANT-TO-DELETE] Ex: If you wanted to delete Alderwood (which has the id of `2`), you'd put http://localhost5000/api/Parks/2. 
    - Finally, hit Send to delete the specific entry.
2. To view Swagger documentation: Run `dotnet run` in the ParkAPI project folder to open up a local server, then paste the address http://localhost:5000/swagger in your URL bar to see the Swagger documentation for the HardcoreParkCORS API. Once the Swagger UI is accessed, you can experiment with the "Try out" and "Execute" buttons to see how each of the endpoints work!

## Known Bugs

_No known bugs_ :bug:

## Technologies Used

- This [ASP.NET Core API README](https://github.com/Knutsenjamie/CatKingdom.Solution/blob/main/README.md) by __[Jamie Knutsen](https://github.com/Knutsenjamie)__ as a template for this documentation
- MySQL Server 8.0.19 and MySQL Workbench 8.0.19
- C#
- .NET 5 SDK
- ASP.NET Core MVC with CORS
- Entity Framework Core
- HTML5 with Razor syntax
- CSS3 with Bootstrap 4.5.0 framework
- VS Code
- Postman

### License

<details>
<summary><a href="https://opensource.org/licenses/MIT"><strong>MIT</strong></a></summary>
<pre>
MIT License

Copyright (c) 2021 Patrick Lee

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</pre>
</details>

Copyright © 2021 Patrick Lee