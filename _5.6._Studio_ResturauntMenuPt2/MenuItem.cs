namespace _5._6._Studio_ResturauntMenuPt2
{
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

        public string getMenuItem()
        {
            return this.ItemName + "is " + this.Description + "costs: " + this.Price + "category: " + Category + "Date added: " + DateAdded;
        }
    }
}
