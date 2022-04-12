﻿

Kuwait University

College of Computing Sciences and Engineering

Department of Information Science

COMP 2139

Web Application Development with

C# .NET

Lab 3

Contact Manager Application

Part 1 - Entities and Database





Table of Contents

[Laboratory](#br3)[ ](#br3)[#3](#br3)[ ](#br3)[ꢀ](#br3)[ ](#br3)[Contact](#br3)[ ](#br3)[Manager](#br3)[ ](#br3)[Application](#br3)[ ](#br3)...................................................... [3](#br3)

COMP2139-LAB3

2





Laboratory #3 **ꢀ** Developing a Single Page Web Application

\1. Laboratory Objective

The goal of this lab is to create a Contact Manager Application using C# .NET.

\2. Laboratory Learning Outcomes: After conducting this laboratory students will be able to:

a. Create a Git repository

b. Create a data-drive web application using C#.NET ꢀ Database and Entities

\3. Laboratory Instructions

For this lab, we will build a multi-page, data driven application modeling the wireframes below:

The Home Page

The Details Page

COMP2139-LAB3

3





The Add and Edit Pages (using the same view)

The Delete Page

COMP2139-LAB3

4





Specifications

ꢀ

ꢀ

When the application starts, it should display a list of contacts and a link to add a contact

If the user clicks the first or last name of a contact, the application should display the detail page

for that contact

ꢀ

ꢀ

ꢀ

ꢀ

The Details page should include buttons that allow the user to edit or delete the contact. Before

deleting a contact, the application should display the Delete page to confirm the deletion.

To reduce code duplication, the Add and Edit pages should both use the same view. This view

should include a drop-down for Category values.

ꢁꢂꢃꢄꢅꢆꢆꢄꢇꢈꢆꢄꢉꢆꢊꢋꢄꢌꢇꢍꢃꢎꢄꢎꢂꢏꢐꢑꢆꢄꢈꢏꢋꢄꢊꢈꢒꢑꢐꢆꢃꢄꢋꢂꢃꢄꢓꢇꢋꢃꢄꢅꢆꢆꢃꢆꢄꢔꢊꢃꢑꢆꢄꢋꢂꢇꢋꢕꢎꢄꢆꢊꢎꢌꢑꢇꢖꢃꢆꢄꢗꢖꢄꢋꢂꢃꢄꢓꢃꢋꢇꢊꢑꢎꢄ

page. That field should only be set by code when the user first adds a contact.

If the user enters invalid data on the Add or Edit page, the application should display a summary

of validation errors above the form.

ꢀ

Here are the requirements for valid data:

o The Firstname, Lastname, Phone, Email and CategoryId fields are required

o The Organization field is optional

Note: Since the CategoryId field is likely an int, ꢖꢏꢐꢄꢒꢇꢈꢕꢋꢄꢐꢎꢃꢄꢋꢂꢃꢄꢘꢃꢙꢐꢊꢚꢃꢆꢄꢛꢇꢑꢊꢆꢇꢋꢊꢏꢈꢄ

attribute with it. However, you can use the Range attribute to make sure the value of

CategoryId is greater than zero.

ꢀ

ꢀ

If the user clicks the Cancel button on the Add page, the application should display the Home

page

If the user clicks the Cancel button on the Edit page, the application should display the Details

page for that contact.

ꢀ

ꢀ

The domain model for classes (ex Contact, Categories) should use primary keys that are

generated by the database.

The Contact class, should have a foreign key field that relates it to the Category class. It should

also have a read-ꢏꢈꢑꢖꢄꢌꢚꢏꢌꢃꢚꢋꢖꢄꢋꢂꢇꢋꢄꢒꢚꢃꢇꢋꢃꢎꢄꢇꢄꢎꢑꢐꢍꢄꢊꢔꢄꢋꢂꢃꢄꢒꢏꢈꢋꢇꢒꢋꢕꢎꢄꢔꢊꢚꢎꢋꢄꢇꢈꢆꢄꢑꢇꢎꢋꢈꢇꢜꢃꢄꢋhat can be

added to URLs to make them user friendly.

ꢀ

ꢀ

Use EF Code first to create a database based on your domain model classes. Include seed data for

the categories and one or more contacts.

Use a Razor layout to store the <html>, <head>, and <body> elements.

COMP2139-LAB3

5





ꢀ

ꢀ

Use the default route (/) with an additional route segment that allows an optional slug at the end

of a URL

Make the application URLs lowercase with trailing slashes

Creating the Contact Manager Web Application ꢀ Git Repository (Optional)

a. Log in to your GitHub account and create new project repository.

b. Clone the project (using ssh or https).

c. Launch Visual Studio, FileꢀClone Repository, entering the details for the repository you

creating in the previous step:

d. Click clone and Visual Studio will bring you to the location of your created project. This will

effectively be the environment where your project will be created.

COMP2139-LAB3

6





Creating the Contact Manager Web Application

\1. Within Visual Studio select FileꢀNewꢀProject, select ASP.NET Core Web Application.

\2. Fill in your desired project details for Project Name, and Location, then select create

\3. From the resultant page, select Web-Application (Model-View-Controller), then Create

\4. You should then be presented with your workspace to start creating your project.

\5. Clean-up (delete) all auto-generated controllers, views, models from the project.

COMP2139-LAB3

7





Building the Contact Manager Application Database

\1. Install Microsoft.EntityFrameworkCore.SqlServer and

Microsoft.EntityFrameworkCore.Tools viaꢝ

Toolsꢀ NuGet Package Manager ꢀManage NuGet Packages for Solution

\2. Make sure the connection string to the database is set up (appsettings.json)

"AllowedHosts": "\*",

"ConnectionStrings": {

"ContactContext":

"Server=(localdb)\\mssqllocaldb;Database=Contacts;Trusted\_Connection=Tr

ue;MultipleActiveResultSets=true"

}

\3. Create a model class called Category that

ꢀ

Has the following attributes

i. CategoryId

ii. Name

ꢀ

Has the necessary accessors and mutators

\4. Create a model class called Contact that

ꢀ

Has the following attributes

Property Name

Validation

Details

ContactId

Required

primary key

generated by database

Firstname

Lastname

Phone

Required

Required

Required

Email

Required

Organization

DateAdded

CategoryId

Category

Slug

Optional

n/a

validate greater than 0

Required

n/a readonly

No validation required

Set by application

Foreign key

concatenation of firstname ꢞ-ꢟꢄlastname

ꢚꢃꢌꢑꢇꢒꢃꢄꢞꢄꢟꢄꢠꢊꢋꢂꢄꢞ-ꢟin the names

convert to lowercase only

mutator not required

ꢀ

Has the necessary accessors and mutators

COMP2139-LAB3

8





\5. Within the Model folder create a new class called ContactContext.cs that extends DbContext

ꢀ

The class requires one constructor that take in a DbContextOptions parameter, that

passes the parameter to the base parent constructor.

ꢀ

ꢀ

Has accessor and mutators for a set (DbSet) of Contacts and Categories

Override the OnModelCreating() to construct and seed the ContactManager database

as follows:

\1.

Table: Category

CategoryId

Name

Family

Friend

Work

Other

1

2

3

4

\2. Create some arbitrary Contacts as you see fit also within the OnModelCreating().

\6. Update the services in Program.cs to make sure:

ꢀ

ꢀ

ꢀ

ꢀ

Add the Microsoft.EntityCoreFrameworkCore

Add your project Models folder

Make the application URLs lowercase with trailing slashes

Use the default route (/) with an additional route segment that allows an optional slug at

the end of a URL

\7. Open the Package Manger Console (PMC). Tools ꢀNuGet Package Manager ꢀ Package

Manager Console

\8. ꢡꢎꢎꢐꢃꢄꢇꢄꢞAdd-Migration Initialꢟꢄꢒꢏꢜꢜꢇꢈꢆꢄꢇꢋꢄꢋꢂꢃꢄꢌꢚꢏꢜꢌꢋꢄꢇꢈꢆꢄꢌꢚꢃꢎꢎꢄꢉꢈꢋꢃꢚ

You should now be able to validate that your database migration scripts have been generated.

COMP2139-LAB3

9





\9. Open the SQL Server Object Explorer (View ꢀ SQL Server Object Explorer) and validate that

your Contacts database has been created.

\10. ꢡꢎꢎꢐꢃꢄꢇꢄꢞUpdate-Databaseꢟꢄꢒꢏꢜꢜꢇꢈꢆꢄꢇꢋꢄꢋꢂꢃꢄꢌꢚꢏꢜꢌꢋꢄꢇꢈꢆꢄꢌꢚꢃꢎꢎꢄꢉꢈꢋꢃꢚ

COMP2139-LAB3

10





\11. Commit and push your work to you GitHub code repository.

COMP2139-LAB3

11





Kuwait University

College of Computing Sciences and Engineering

Department of Information Science

COMP 2139

Web Application Development with

C# .NET

Lab 4

Contact Manager Application

Controllers and Views





Table of Contents

[Laboratory](#br14)[ ](#br14)[#4](#br14)[ ](#br14)[ꢀ](#br14)[ ](#br14)[Contact](#br14)[ ](#br14)[Manager](#br14)[ ](#br14)[Application](#br14)........................................................ [3](#br14)

COMP2139-LAB4

2





Laboratory #4 **ꢀ** Developing a Single Page Web Application

\1. Laboratory Objective

The goal of this lab is to create a Contact Manager Application using C# .NET ꢀ Controller and

Views.

\2. Laboratory Learning Outcomes: After conducting this laboratory students will be able to:

a. Create and maintain Git repository project

b. Create a data-drive web application using C#.NET

c. Constructing controllers and Views

\3. Laboratory Instructions

For this lab, we will continue with the implementation of a multi-page, data driven application modeling the

wireframes below:

The Home page

The Details page

COMP2139-LAB4

3





The Add and Edit pages (using the same view)

The Delete page

COMP2139-LAB4

4





Specifications

ꢀ

ꢀ

When the application starts, it should display a list of contacts and a link to add a contact

If the user clicks the first or last name of a contact, the application should display the detail page

for that contact

ꢀ

ꢀ

ꢀ

ꢀ

The Details page should include buttons that allow the user to edit or delete the contact. Before

deleting a contact, the application should display the Delete page to confirm the deletion.

To reduce code duplication, the Add and Edit pages should both use the same view. This view

should include a drop-down for Category values.

ꢁꢂꢃꢄꢅꢆꢆꢄꢇꢈꢆꢄꢉꢆꢊꢋꢄꢌꢇꢍꢃꢎꢄꢎꢂꢏꢐꢑꢆꢄꢈꢏꢋꢄꢊꢈꢒꢑꢐꢆꢃꢄꢋꢂꢃꢄꢓꢇꢋꢃꢄꢅꢆꢆꢃꢆꢄꢔꢊꢃꢑꢆꢄꢋꢂꢇꢋꢕꢎꢄꢆꢊꢎꢌꢑꢇꢖꢃꢆꢄꢗꢖꢄꢋꢂꢃꢄꢓꢃꢋꢇꢊꢑꢎꢄ

page. That field should only be set by code when the user first adds a contact.

If the user enters invalid data on the Add or Edit page, the application should display a summary

of validation errors above the form.

ꢀ

Here are the requirements for valid data:

o The Firstname, Lastname, Phone, Email and CategoryId fields are required

o The Organization field is optional

Note: Since the CategoryId field is likely an int, ꢖꢏꢐꢄꢒꢇꢈꢕꢋꢄꢐꢎꢃꢄꢋꢂꢃꢄꢘꢃꢙꢐꢊꢚꢃꢆꢄꢛꢇꢑꢊꢆꢇꢋꢊꢏꢈꢄ

attribute with it. However, you can use the Range attribute to make sure the value of

CategoryId is greater than zero.

ꢀ

ꢀ

If the user clicks the Cancel button on the Add page, the application should display the Home

page

If the user clicks the Cancel button on the Edit page, the application should display the Details

page for that contact.

ꢀ

ꢀ

The domain model for classes (ex Contacts, Categories) should use primary keys that are

generated by the database.

The Contact class, should have a foreign key field that relates it to the Category class. It should

also have a read-only property that creates a slug if the contacꢋꢕꢎꢄꢔꢊꢚꢎꢋꢄꢇꢈꢆꢄꢑꢇꢎꢋꢈꢇꢜꢃꢄꢋhat can be

added to URLs to make them user friendly.

ꢀ

ꢀ

Use EF Code first to create a database based on your domain model classes. Include seed data for

the categories and one or more contacts.

Use a Razor layout to store the <html>, <head>, and <body> elements.

COMP2139-LAB4

5





ꢀ

ꢀ

Use the default route (/) with an additional route segment that allows an optional slug at the end

of a URL

Make the application URLs lowercase with trailing slashes

Creating the \_Layout.cshtml View

\1. Right-click on the ViewsꢀShared and create a new Razor Layout view

The \_Layout.cshtml file created, will act as a template for the application, one that can be used

repeatedly across all our views to help create a consistent look and feel, why additionally,

reducing the amount of redundancy in our application. ꢝꢃꢃꢑꢄꢔꢚꢃꢃꢄꢋꢏꢄꢇꢆꢆꢄꢇꢈꢖꢄꢒꢎꢎꢞꢟꢇꢛꢇꢎꢒꢚꢊꢌꢋꢄꢃꢋꢒꢠꢄ

here that you want shared across all your application views.

Creating the HomeController

\1. Right-click on the Controllers folder, create an Empty controller (AddꢀControllerꢀMVC

Controller Empty)

COMP2139-LAB4

6





\2. In the resultant controller stub created in the previous set, we need to add a private

ContactContext variable (accessor / mutator) to the HomeController and add a

HomeController that accepts a ContactContext, to calibrate and assign its value.

This code works because of the dependency injection configured in the Startup.cs

\3. Add a new method in the HomeController called Index() that returns the list of contacts (query

Contacts table), include the contact Categories as part of the query, ordering the list by the

contacts firstname.

ASP.NET MVC uses a process called "view discovery" to match views with controller actions. If

you don't pass in a specific view name to look for, it'll look for a view that matches the name of

your controller action. So, in this case, it will look for Index.cshtml under the View/Home folder.

We will create the view, Index.cshtml in the next step.

Creating the Index Page

\1. Right-Click on the View/Home folder an create a new Razor (Empty) view (Add ꢀView).

COMP2139-LAB4

7





\2. In the first line of the view add the @model directive to specify that the model for this view is a

IEnumerable collection of Contacts. The IEnumerable make it possible to use the foreach()

iteration method in the body of the view.

Most of the html in this table displays the list of Contacts.

Within the body of the table, an inline foreach statement loops through the collection of Contact

objects ands and displays each one in a new row.

The following asp directive are also used:

asp-action ꢀ specifies the controller action to invoke

asp-controller ꢀ specifies the controller to invoke

asp-route-idꢀhelper used to pass the id (primary key) of each contact to the controller

asp-route-slugꢀ additional slug parameters to pass to the controller

\3. Above the table add a link, that calls the Contact controller (to be implemented in the next

section) to add a new contact to the application.

\4. Run the application to make sure it renders (as you desire) and without any error(s).

COMP2139-LAB4

8





Creating the ContactController

\1. Create a second controller called ContactController that has:

a. A private ContactContext attribute (setter/getter)

b. A constructor that takes in a ContactContext parameter and set the context attribute.

\2. Create the following IActionResult methods within the ContactController

Method Name

Details()

Add()

GET/POST

Get

Get

Input Parameter

id

none

id

Edit()

Get

Edit()

Delete()

Delete()

Post

Get

Post

Contact

id

Contact

\3. Implement the Details() method that accepts a contact id (int), and forwards the contact

associated with the id to the Details view (Details.cshtml ꢀ to be completed)

\4. Implement the Add() method that forwards a new Contact() ꢋꢏꢄꢋꢂꢃꢄꢡꢉꢆꢊꢋꢢꢄꢛꢊꢃꢣꢄꢤꢋꢂꢃꢄꢇꢆꢆꢄꢇꢈꢆꢄꢃꢆꢊꢋꢄ

view utilize the same view). The Add() method also should set an Action property and

Categories property in the ViewBag of the Model.

\5. Implement the Edit() that accepts the id of the contact to edit, the method then forwards the

Contact ꢋꢏꢄꢗꢃꢄꢃꢆꢊꢋꢃꢆꢄꢋꢏꢄꢋꢂꢃꢄꢡꢉꢆꢊꢋꢢꢄꢛꢊꢃꢣꢥꢄꢁꢂis Edit() method also should set an Action property

and Categories property in the ViewBag of the Model.

COMP2139-LAB4

9





\6. Implement the Edit() method that accepts a Contact object that is to be edited. This Edit()

method should first validate that the data submitted is valid.

ꢀ

ꢀ

ꢀ

Retrieve the contact Id of the contact passed if the value is > 0, then the action is to Edit,

otherwise the action is to Add.

If the action set is to Add, an contact passed, should be added (persisted) to the database

via a call to context.Contact.Add() with the date timestamp first added.

Otherwise if the action set is to Edit, then a call to context.Contacts.Update() should be

called since we do not want to persist a duplicate contact, as we just want to update an

already known contact.

ꢀ

ꢀ

To persist changes (add, or delete) we must make a call to context.SaveChanges().

If we have successfully persisted a new or updated contact we should issue a redirect

(RedirectToAction()) to send the user back to the index (home page).

ꢀ

If any of the contact data passed is missing or not valid, we should set the action and

category in the Model ViewBag, back to their passed value, then forward back to the Edit

view.

\7. Implement the Delete() method that accepts the id of the contact to delete and forwards to the

Delete view (Delete.cshtml ꢀ to be implemented)

COMP2139-LAB4

10





\8. Implement the Delete() method that accepts the contact object to delete and persists the changes,

then redirects back to the home index page.

\9. For each of the methods, verify that you have associated them with the appropriate HttpGet or

HttpPost as specified in the requirements.

Questions

\1. On your own create the following remaining views in the Views/Contact directory of your

project:

i.

ii.

iii.

Delete.cshtml

Details.cshtml

Edit.cshtml

Make sure to implement the view so they match the wireframe provided above.

\2. EXTRA ꢀ Though look and feel is not theme or this course or chapter, try to implement

some styling (css, boostrap etc..) to liven up the user experience of the application.

\*\*\* Make sure to commit your changes if you created a GitHub account \*\*\*

COMP2139-LAB4

11
