namespace Technology
{
    class Smartphone : Computer
    {
        public bool isPocketSize { get; set; }

        public Smartphone(string make, string model, int serialNumber, bool isPocketSize) : base(make, model, serialNumber)
        {

        }

        public bool isRinging()
        {
            return true;
        }

        public string call(long phoneNumber)
        {
            return $"called: {phoneNumber}";
        }
    }
}
