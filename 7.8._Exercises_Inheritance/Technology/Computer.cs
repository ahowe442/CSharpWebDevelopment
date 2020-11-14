namespace Technology
{
    public class Computer
    {
        //3 fields, 2 methods, and a constructor.
        public string Make { get; set; }
        public string Model { get; set; }
        static int SerialNumber { get; set; }

        public Computer(string make, string model, int serialNumber)
        {
            Make = make;
            Model = model;
            SerialNumber = serialNumber;
        }

        public string TakeInput(string input)
        {
            return "This computer took the following input: " + input;
        }

        public string ComputeData(int data1, int data2)
        {
            return $"Data 1: plus Data 2: equals" + data1 + data2;
        }

        public string WelcomeNewUser(string newUserName)
        {
            return $"Hi {newUserName}!";
        }

        public string PowerOn()
        {
            return "The Computer is on!";
        }

    }
}
