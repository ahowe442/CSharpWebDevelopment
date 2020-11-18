using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //Prob don't want to set?? Get only??

        public User()
        {
        }

    }
}
