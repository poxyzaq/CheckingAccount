# Checking Account

## Project

Developed during the Fullstack course at [Academia do Programador](https://www.academiadoprogramador.net) 2026

## Introduction

A checking account is made up of several essential attributes for its operation. 
It has a unique identification number, an available balance, and an established debit limit. 
In addition, the account keeps a record of financial transactions, which encompass all operations carried out.

Each movement recorded in the account corresponds to a financial transaction, 
which can be classified as credit (deposit or incoming funds) or debit (withdrawal or outgoing funds). 
Each transaction has an associated value and directly impacts the account balance.

The available operations for a checking account include:

- Withdrawal: Allows funds to be withdrawn, respecting the maximum permitted limit.
- Deposit: Enables the addition of funds to the account.
- Balance inquiry: Provides up-to-date information about the available amount.
- Statement: Lists all transactions carried out in a specific period.
- Transfer between accounts: Allows funds to be moved between different checking accounts.

Regarding withdrawals, the checking account can only process them if the requested amount 
does not exceed the permitted withdrawal limit, which corresponds to the sum of the available 
balance plus the additional limit granted to the account.

## How to use

1. Clone the repository or download the source code.
2. Open the terminal or command prompt and navigate to the root folder.
3. Use the command below to restore the project dependencies:
```bash
   dotnet restore
```
4. To run the project with real-time compilation:
```bash
   dotnet run --project CheckingAccount.ConsoleApp
```

## Requirements

- .NET 10.0 SDK
