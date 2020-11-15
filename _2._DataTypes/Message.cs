namespace _2._DataTypes
{
    class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else
            {
                return "Hello World";
            }
        }


        private static string GetPrivateMessage(string hi)
        {
            return "Secret message: " + hi;
        }
    }
}
