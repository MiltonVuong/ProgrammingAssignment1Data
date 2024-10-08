/*********************************************************************
* Course: PROG 110
* Instructor: Phil Duncan
* Term: Fall 2024
*
* Programmer: Milton Vuong
* Assignment: Programming Assignment 1 - Data
*
* Description:
* This program takes orders for ACME Advils
* It takes user input for customer shipping information,
* the number of anvils they wish to purchase,
* and calculates the cost of their order.
* Then it diplays their invoice. 
*
* Revision   Date         Release Comment
* --------   ----------   --------------------------
* 1.0        10/03/2024   Initial Release
* 
*/

using System;
using static System.Console;

namespace ProgrammingAssignment1Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare constants and variables
            decimal anvilCost = 88.50m;
            double taxRate = .095;

            int numberOfAnvils;
            string customerName;
            string customerAddress;
            string customerCity;
            string customerState;
            string customerZipCode;

            decimal subtotal;
            decimal salesTax;
            decimal grandTotal;

            //Display welcome message
            WriteLine(
                "==========================================================\n" +
                "=           Welcome to Acme Anvils Corporation,          =\n" +
                "=     Supporting the animation industry since 1949!!     =\n" +
                "==========================================================\n");

            //Prompt user for customer information
            Write("How many anvils would the customer like to order? ");
            numberOfAnvils = int.Parse(ReadLine());
            Write("What is the customer's name? ");
            customerName = ReadLine();
            Write("What is the customer's street address? ");
            customerAddress = ReadLine();
            Write("What is the customer's city? ");
            customerCity = ReadLine();
            Write("What is the customer's state? ");
            customerState = ReadLine();
            Write("What is the customer's zip code? ");
            customerZipCode = ReadLine();

            //Calculate invoice amounts
            subtotal = numberOfAnvils * anvilCost;
            salesTax = subtotal * (decimal)taxRate;
            grandTotal = subtotal + salesTax;

            //Pause for confirmation to proceed with invoice
            WriteLine("\nPress any key to display invoice...\n");
            ReadKey();

            //Display invoice welcome message, customer information, invoice details, thankyou message, and slogan
            WriteLine(
                "==========================================================\n" +
                "=           Welcome to Acme Anvils Corporation,          =\n" +
                "=     Supporting the animation industry since 1949!!     =\n" +
                "==========================================================\n");

            WriteLine("\tCustomer Invoice\n");

            WriteLine("\tSHIP TO:\n\n\t\t" +
                customerName + "\n\t\t" +
                customerAddress + ",\n\t\t" +
                customerCity + ", " +
                customerState + " " +
                customerZipCode + "\n");

            WriteLine("\t{0,-20}{1,22}", "Quantity Ordered:", numberOfAnvils);
            WriteLine("\t{0,-20}{1,22:C}", "Cost Per Anvil:", anvilCost);
            WriteLine("\t{0,-20}{1,22:C}", "Subtotal:", subtotal);
            WriteLine("\t{0,-20}{1,22:C}", "Sales Tax:", salesTax);
            WriteLine("\t{0,-20}{1,22}", " ", "---------------");
            WriteLine("\t{0,-20}{1,22:C}", "Grand Total:", grandTotal);
            WriteLine("\n\tYour total today is {0:C}.\n\tThanks for shopping with Acme!", grandTotal);
            WriteLine("\n" +
                "==========================================================\n" +
                "=  Don't forget: Acme anvils fly farther, drop faster,   =\n" +
                "=   and land harder than any other anvil on the market!  =\n" +
                "==========================================================\n");

            //Pause for exit confirmation
            WriteLine("Press any key to end the program...");
            ReadKey();
        }
    }
}
