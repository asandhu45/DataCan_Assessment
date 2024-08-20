# DataCan Developer Assignment - Currency Conversion and Account Management

## Overview

This Windows Forms application, developed for the DataCan Developer Assignment, allows users to manage an account balance with multi-currency support. Users can deposit and withdraw funds in different currencies, which are automatically converted to CAD (Canadian Dollars).

## Features

- Deposit and withdraw funds in multiple currencies
- Automatic currency conversion to CAD
- Real-time account balance display
- Reset functionality to return to the initial balance of CAD 1000
- Multi-tiered architecture with separation of concerns

## Technology Stack

- C# and .NET Framework
- Windows Forms (WinForms)
- Object-Oriented Design

## Project Structure

The application is composed of three main classes:

### 1. Form1 (Main Form)

Handles the user interface and interactions.

Key Methods:
- `depositButton_Click`: Processes deposits
- `withdrawButton_Click`: Processes withdrawals
- `resetButton_Click`: Resets the account to the initial balance
- `UpdateUI`: Refreshes the UI with the current balance

### 2. Account

Manages the user's account and balance.

Key Features:
- `Balance` property to store and retrieve the account balance
- `Withdraw` method to handle fund withdrawals
- `Deposit` method to handle fund deposits

### 3. CurrencyConverter

Handles currency conversion operations.

Key Features:
- Maintains a dictionary of currency conversion rates
- `ConvertToCAD` method to convert foreign currencies to CAD

## Supported Currencies

- CAD (Canadian Dollar)
- USD (US Dollar)
- MXN (Mexican Peso)
- EURO (Euro)

## How to Run the Application

### Via Visual Studio

1. Clone the repository: git clone https://github.com/yourusername/DataCan_Assignment.git
2. Open the `.sln` file in Visual Studio.
3. Build the solution (Ctrl + Shift + B).
4. Run the application (F5).

### Via Executable (.exe) File

1. Build the project in Visual Studio.
2. Navigate to `bin/Debug` or `bin/Release` in the project folder.
3. Run `DataCan_Assessment.exe`.

## Usage Instructions

1. Select the desired currency from the dropdown menu.
2. Enter the amount to deposit or withdraw.
3. Click the "Deposit" or "Withdraw" button.
4. The balance will update automatically.
5. Use the "Reset" button to return to the initial balance of $1000 CAD.

## Notes

- Initial account balance is set to $1000 CAD.
- Withdrawals exceeding the current balance are prevented.
- $0 deposits and withdrawals are not allowed.

## Future Enhancements

- Additional currency conversion methods can be easily added to the `CurrencyConverter` class.
- For more complex conversions, a separate class could be created.

## Requirements

- .NET Framework
- Visual Studio or compatible IDE for development

## Author

Amanjot Sandhu
