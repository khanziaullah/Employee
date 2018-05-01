# Employee
Service Oriented Application

The application is a working model of a service oriented architecture that's depicted in this diagram here.

Chapter 5: Layered Application Guidelines

https://i-msdn.sec.s-msft.com/dynimg/IC351012.png

It refers to the Microsoft Application Architecture Guide, 2nd Edition found here (https://msdn.microsoft.com/en-us/library/ff650706.aspx)

The application has two solutions in it.

1. Employee.sln
  This solution deals with the UI concerns of the application. It is a ASP.Net WebForms application. By design of the web forms
  and the programming model it offer I started using an MVP (Model-View-Presenter) Pattern.
  
  The Application refers to the Presentation Layer from the from the first diagram link.
  
  The UI itself is the web project.
  
2. Employee.Services.sln.
  This solution deals with the three layers
    Service Layer
    Business Layer
    Data Layer

This application has a project called Employee.CrossCutting. This project takes care of cross-cutting concern. The 
current solution has code for logging.

