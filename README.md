# Expense Tracker: Personal Finance Web Application

Overview

The Expense Tracker is a personal finance web application designed to help users efficiently manage and monitor their daily expenses. With a clean and minimal interface, this application offers intuitive features for recording, viewing, editing, deleting, and filtering expenses. It empowers users to maintain better control over their spending habits and budgeting.

Features

1. Add Expense: Quickly log new expenses with details like title, amount, category, date, and optional notes.

2. View Expenses: Display all recorded expenses in a structured table view.

3. Edit Expense: Modify details of existing expenses.

4. Delete Expense: Permanently remove unwanted or incorrect entries.

5. Filter Expenses: Filter expenses based on specific categories or date ranges to gain better financial insights.

Technologies Used

1. Frontend: ASP.NET Core MVC, Razor Views, Bootstrap

2. Backend: ASP.NET Core MVC

3. Database: SQL Server with Entity Framework Core

4. Hosting: Azure App Services (for deployment)

User Manual

➕ Add Expense
   
  1. Navigate to "Add Expense" via the navigation bar or use the "Add New Expense" button on the expenses page.

  2. Fill in the form:

    - Title: e.g., "Groceries", "Dinner with friends"

    - Amount: e.g., 500

    - Category: e.g., Food, Transport, Entertainment

    - Expense Date: Date when the expense occurred

    - Notes: (Optional) Add any additional information

    - Click "Add" to save the expense.
    
👁️ View Expenses

  1. Go to "View Expense" from the navbar.

  2. The page displays a list of all expenses in tabular format with columns for Title, Amount, Category, Date, and Notes.

✏️ Edit Expense

  1. On the list page, find the expense to update and click "Edit".

  2. A pre-filled form will appear with the current details.

  3. Make the necessary changes and click "Save" to update the record.

🗑️ Delete Expense

  1. On the list page, click "Delete" next to the desired expense.

  2. A confirmation screen will appear showing the expense details.

  3. Click "Yes" to confirm and permanently delete the expense.

🔍 Filter Expenses

  1. On the list page, use the Filter Expenses section.

  2. Enter a Category name and specify the startDate abd endDate.

  3. Click "Filter" to view specific results.

  4. To reset the view, click "Reset" button.

