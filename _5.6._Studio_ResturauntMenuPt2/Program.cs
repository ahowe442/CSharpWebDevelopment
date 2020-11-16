using System;

namespace _5._6._Studio_ResturauntMenuPt2
{

    class Program
    {

        static void Main(string[] args)
        {
            //Creates instance of MenuItems.
            //MenuItem coke = new MenuItem("Coke", 1.99, "Bubbly cola drink with ice in a glass", "Drinks", "October");
            //MenuItem sirloin10 = new MenuItem("10oz. Sirloin", 14.99, "never frozen","Main Course", "September");
            //MenuItem iceCream = new MenuItem("Vanilla Ice Cream", 3.99, "cold milk treat", "Dessert", "October");
            //Menu.printItem(coke);
            //Menu.printItem(sirloin10);
            //Menu.printItem(iceCream);
        }
    }
    public class MenuItem
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string MonthAdded { get; set; }

        public MenuItem(string itemName, double price, string description, string category, string monthAdded)
        {
            ItemName = itemName;
            Price = price;
            Description = description;
            Category = category;
            MonthAdded = monthAdded;
        }


    }

    public class Menu
    {
        List<MenuItem> menuItems = new List<MenuItem>();

        //add item to menu
        addToMenu()
        {

        }

        //remove item from menu
        removeFromMenu()
        {

        }

        //tell if a menu item is new.
        isNew()
        {

        }

        //tell when the menu was last updated.
        dateLastUpdated()
        {

        }

        // print out a single menu item.
        public static void printItem(MenuItem item)
        {
            Console.WriteLine(item.ItemName + "is " + item.Description + "costs: " + item.Price + "category: " + item.Category + "Date added: " + item.MonthAdded);
        }


        //print out the entire menu.
        printMenu()
        {

        }

        //A way to determine whether or not two menu items are equal.
    }
}
