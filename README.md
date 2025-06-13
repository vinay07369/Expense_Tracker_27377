# Expense Tracker: Personal Finance Web Application

Overview

The Expense Tracker is a personal finance web application designed to empower users to efficiently manage their daily spending. It provides a straightforward and intuitive platform to record, view, edit, and delete expenses, featuring a clean and minimal interface for an effortless user experience.

Features

The Expense Tracker offers the following core functionalities:

1. Add a new expense: Easily input new spending details, including title, amount, category, date, and optional notes.

2. View all expenses: See a comprehensive list of all recorded expenses.

3. Edit an expense: Modify existing expense entries to correct information or update details.

4. Delete an expense: Remove unwanted or erroneous expense records permanently.

5. Filter expenses: Efficiently search and organize expenses by specific criteria, specifically by category and Daterange.

Project Setup Steps

1. Initial Project Setup

   - Open Visual Studio 2022.
   
   - Select "Create a New Project".
   
   - Choose the Template as "ASP.NET Core Web App (Model-View-Controller)" and click "Next".
   
   - Name the Project as "Expense_Tracker" and proceed to create it.
  
2. Model Class

   1. Create Expense.cs Model:
      
      - In the Models folder, create a new C# class named Expense.cs.
        
      - Define the properties as per the schema.

3. Controller and Views

   1. MVC Controller with Views:

      - Right-click on the Controllers folder in Solution Explorer.
        
      - Select Add > New Scaffolded Item...
        
      - Choose "MVC Controller with views, using Entity Framework" and click "Add".
     
      - In the configuration dialog:
        
          --> Model Class: Select Expense.cs.
            
          --> Data Context Class: Select the newly generated or existing ExpenseTrackerContext (or ApplicationDbContext).
            
          --> Controller name: Enter ExpensesController.

      - Click "Add". This action will generate ExpensesController.cs and the associated views (Create.cshtml, Delete.cshtml, Details.cshtml, Edit.cshtml, Index.cshtml) in Views/Expenses/.
        
4. Database Migration

   1. Open Package Manager Console:
      
      - Go to Tools > NuGet Package Manager > Package Manager Console.
     
   2. Execute Migrations:
      
      - Run the following commands in sequence:
     
           --> Add-Migration InitialCreate
        
           --> Update-Database
        
      - These commands create an initial database migration based on your Expense model and then apply it to your local SQL Server database, creating the dbo.Expense table.

5. Verify Database Setup
   1. Open SQL Server Object Explorer:
     
      - In Visual Studio, go to View > SQL Server Object Explorer.
        
   2. Browse Database:
      - Expand SQL Server > (localdb)\MSSQLLocalDB > Databases > ExpenseTrackerContext > Tables.
        
      - Right-click on dbo.Expense and select "View Data" to confirm the table has been created successfully.
     
6. Run the Application
   
   1. Press F5 in Visual Studio to build and run the application.
      
   2. Your browser should open to the application's home page. Navigate to the "View Expense" or "Add Expense" links in the navbar to start using the application.  

User Manual

The Expense Tracker provides a simple interface to manage your expenses.

1. Add Expense
  
   1. Click on the "Add Expense" link in the navigation bar or the "Add New Expense" button on the "List of Expenses" page.
   
   2. Fill out the form fields:
      
      - Title: A brief description of the expense (e.g., "Groceries", "Dinner with friends").
        
      - Amount: The monetary value of the expense.
        
      - Category: The category of the expense (e.g., "Food", "Transport", "Entertainment").
        
      - ExpenseDate: The date the expense occurred.
        
      - Notes: Any additional details (optional).
        
   3. Click the "Add" button to save your expense.
  
2. View Expenses
   
   1. Click on the "View Expense" link in the navigation bar.
      
   2. The "List of Expenses" page will display all your recorded expenses in a table format. Each row shows the Title, Amount, Category, Date, and Notes.
  
3. Edit Expense
   
   1. On the "List of Expenses" page, locate the expense you wish to modify.
      
   2. Click the "Edit" button next to that expense's row.
      
   3. The form will be pre-filled with the current expense details. Make your desired changes.
      
   4. Click the "Save" button to update the expense.
      
4. Delete Expense
   
   1. On the "List of Expenses" page, locate the expense you wish to remove.
      
   2. Click the "Delete" button next to that expense's row.
      
   3. A confirmation page will appear, showing the details of the expense to be deleted.
      
   4. Click the "Yes" button again on this confirmation page to permanently remove the expense.
      
5. Filter Expenses
   
   1. On the "List of Expenses" page, locate the "Filter Expenses" section.
      
   2. Use the Category textbox to give any category name. (e.g., "Transport").
      
   3. Click the "Filter" button. The list of expenses will update to show only those belonging to the selected category.
      
   4. To view all expenses again, select "All" from the dropdown and click "Filter".

