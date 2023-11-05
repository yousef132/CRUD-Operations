using System.Numerics;

namespace CrudSystem
{
    public class User
    {
        public string  Phone { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public User(string phone, string name, string email)
        {
            Phone = phone;
            Name = name;
            Email = email;
        }

        public User()
        {

        }
        public void Edit(string phone , List<User> users)
        {
            Console.WriteLine("1-Edit Name");
            Console.WriteLine("2-Edit Email");
            Console.WriteLine("3-Edit Phone Number");
              
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter New Name");
                string name = Console.ReadLine();
                Name = name;
                //Updating with generic delegate
                // user.Update(name, (name, user) => user.Name = name);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter New Email");
                string email = Console.ReadLine();
                Email = email;
                //Updating with generic delegate
                //user.Update(email, (email, user) => user.Email = email);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter New Phone");

                //new phone
                phone = Console.ReadLine();                
                Phone = phone;

                //Updating with generic delegate
                //user.Update(phone, (pnone, user) => user.Phone = phone);
            }
        }
        public override string ToString() =>
            $" Name : {Name} \n Email : {Email} \n Phone :{Phone}";

        public User GetUserData()
        {
            Console.WriteLine("================== Add User ==================\n");
            Console.Write("* Name : ");
            Name = Console.ReadLine();
            Console.Write("* Email : ");
            Email = Console.ReadLine();
            Console.Write("* Phone : ");
            Phone = Console.ReadLine();
            return new User(Phone, Name, Email);
        }
    }
}