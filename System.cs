using System.Xml.Linq;

namespace CrudSystem
{
    //public delegate void UpdateDel<T>(T attribute, User user);
    public class System
    {
        private List<User> users = new List<User>();
        private int choice;
        private User user = new User();
        private char ch = 'y';
        private string phone;

        public void RUN()
        {
            while (ch == 'y')
            {
                work();
            }
        }
        private void work()
        {
            Console.WriteLine("1) Add User");
            Console.WriteLine("2) Update data of  User");
            Console.WriteLine("3) Delete User");
            Console.WriteLine("4) Print All User");

            choice = int.Parse(Console.ReadLine());
            manageChoices();
            Continue();
            Console.WriteLine("========================================");
        }
        private void Continue()
        {
            Console.WriteLine("Do You Want To Try Any Thing Else ?\n");
            Console.WriteLine(" Y for Yes || N for No\n");
            ch = char.Parse(Console.ReadLine());
        }
        private void manageChoices()
        {
            if (choice == 1)
            {
                addUser();
            }
            else if (choice == 2)
            {
                updateData();
            }
            else if (choice == 3)
            {
                deleteUser();
            }
            else if (choice == 4)
            {
                printUsers();
            }
            else
            {
                Console.WriteLine("Choice Not Exist !");
            }
        }
        private void printUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine($"===================================================================");

                Console.WriteLine("No users to print");
                return;
            }
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"- User {i + 1}");
                Console.WriteLine(users[i]);
                Console.WriteLine("-----------------");
            }
        }
        private void addUser()
        {
            user = new User();
            users.Add(user.GetUserData());
            Console.WriteLine("================== User Information You Entered ==================");
            Console.WriteLine(user);
            Console.WriteLine("=========================================");   
        }
        private void updateData()
        {

            Console.WriteLine("================== Update Data of User ==================");
            Console.Write("Enter User Phone Number You Want To Edit :");
            phone = Console.ReadLine();

            user = users.FirstOrDefault(x => x.Phone == phone);

            if (user != null)
            {
                user.Edit(phone, users);
            }
            else
            {
                Console.WriteLine("NO Such User ! \n");
            }
        }

        private void deleteUser()
        {
            Console.Write("Enter User Phone Number You Want To Delete :");
            phone = Console.ReadLine();

            user = users.FirstOrDefault(x => x.Phone == phone);
            if(user != null)
            {
                Console.WriteLine($"- YOU DELETE USER : {user.Name}.");
                users.Remove(user);
                
            }
            else
            {
                Console.WriteLine("No Such User");
            }


        }
    }
}
