# COVID-19 Web & Mobile-Responsive App

---
## Deployed to AWS Elastic Beanstalk
[http://covid19webapp-dev.us-west-2.elasticbeanstalk.com/](http://covid19webapp-dev.us-west-2.elasticbeanstalk.com/)

---
## Web Application
This is a full stack C#, HTML5, CSS/Bootstrap web application that connects to an external API providing world and country COVID-19 data. The application was written using ASP.NET Core and Entity Framework. The app follows MVC architecture and also utilizes Razor Pages and ASP Helper Tags. The application is deployed to AWS Elastic Beanstalk.

--------------------------- 

## Tools Used
Microsoft Visual Studio Community 2019
Version 16.7.3

- C#
- ASP.Net Core
- Entity Framework
- MVC
- Razor Pages
- Bootstrap
- AWS Elastic Beanstalk
- https://2019ncov.asia/api/cdr API
- https://2019ncov.asia/api/country_region API_

---

## Recent Updates

#### V 1.1
Original API used was https://corona-virus-stats.herokuapp.com/api/v1, however this API was taken down my its owner. 

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/suetarazi/COVID19WebApp
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. 
```
cd YourRepo/YourProject
dotnet run
```

---

## Usage

The following information can be retrived from the APIs:
### World Results:
* Total Cases
* Total Deaths
* Total Recovered

### Country Results:
* Country Name
* Confirmed Total Cases
* Confirmed Deaths
* Confirmed Recovered


### Home Page 
COVID-19 World Data is presented on load
![Home Page](https://i.imgur.com/vKTaEMz.png)

### Home Page
Country search
![Home Page - country search](https://i.imgur.com/W7M9Dqr.png)

### Results 
COVID-19 Data for a given country is given based on the country entered by the user 
![Country Data](https://i.imgur.com/JADAxxY.png)

### Privacy Page
![Privacy Data](https://i.imgur.com/FAMeCnB.png)

---
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---
## Data Model


---

## Change Log
1.1: *Original API was taken down by its owner. Changed to a working API  

---

## Authors
Sue Tarazi

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet


