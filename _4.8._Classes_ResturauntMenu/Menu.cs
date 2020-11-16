namespace _4._8._Classes_ResturauntMenu
{
    public class Menu
    {
        private double Price { get; set; }
        private string ItemName { get; set; }
        private string ItemDescription { get; set; }
        private string Category { get; set; }
        private bool isNew { get; set; }

        public Menu(double price, string itemName, string itemDescription, string category, bool isNew)
        {
            Price = price;
            ItemName = itemName;
            ItemDescription = itemDescription;
            Category = category;
            isNew = true;

        }


    }
}
