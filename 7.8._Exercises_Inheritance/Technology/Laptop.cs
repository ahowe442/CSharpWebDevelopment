namespace Technology
{
    public class Laptop : Computer
    {
        public bool isPortable { get; set; }

        public Laptop(string make, string model, int serialNumber, bool isPortable) : base(make, model, serialNumber)
        {

        }

        public string submitInput()
        {
            return "input submitted!";
        }



    }
}
