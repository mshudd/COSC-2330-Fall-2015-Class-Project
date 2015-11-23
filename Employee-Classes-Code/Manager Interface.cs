using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Manager_I
    {
        //MANAGER INTERFACE
        //Code by Kevin, Danny, and Shane

        //Schedule

         void EditSchedule();     // adjust shifts for all employees
         void ViewSchedule();

        //Employee

        void AddEmployee();     // Add new employee to database
                                       // If the employee

         void ChangeEmployeeInfo(string name, string job, double wage, bool employed, string notes);
        //Will either change the employee’s info, or leave it the same, depending on what the manager
        //types in. 
        //NOTE!!!!!!!: Do not prompt manager to change info in the method, we will have a separate 
        //form in the gui which will ask the manager what info he wants to change.
        //Can change employee’s name, their current job, their wage, and if they are currently employed
        //and any notes the manager wishes to keep about that employee (especially with regards to
        //fired employees).


         void ChangeEmployeePassword(); //Made separate to make security stuff needed for
                                              //changing password easier



        //Menu Stuff

         void AddMenuItem(); //Adds item to the menu

         void RemoveMenuItem(); //Removes item

         void EditMenuItem(); //adjusts menu name, price, portions

        //Inventory
        //NOTE!!!!!!!: We need to automate inventory keeping based on orders made / cooked. May be
        //implemented in the cook’s class. Will subtract used ingredients from the inventory database.

         void AddIngredient();

         void RemoveIngredient();

         void EditIngredient();

        //Tickets and orders

         void EditOrder(); //Edits an order, even if it is already on the queue

         void GiveDiscount(double price); //sets a new price for the ticket, but doesn’t change price 
                                                //for item in menu database
                                                //Manager will inherit ticket methods from waiter 


        //Manager will have methods that can call queries from database, and it will be displayed in the gui. We will do this later.
        /*Method - TrackLaborCost_Rpt() //Tracks by hour. Prompts for report by month, week, day, or hour
        Method - MakeCustom_Rpt() //make custom report
        Method - MenuItemProfits_Rpt()  //Gives money made from every menu item, minus the ingredient cost/waste.
        Method - FoodCost_Rpt()  //Show cost of food, including waste.
        Method- TotalTicketRevenue_Rpt()
        Method - TotalCost_Rpt()
        */

        //Manager should also just be able to view tables from the database in the program.


    }
}
