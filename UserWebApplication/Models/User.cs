using System.ComponentModel.DataAnnotations;

namespace UserWebApplication.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Age { get; set; }
        public string Email { get; set; }

        public DateTime DateCreated { get; set; }

        public User(string Username, string Name,double Age, string Surname, string Email)
        {
            this.Username = Username;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Email = Email;
            this.DateCreated = DateTime.Now;
        }
    }
}
