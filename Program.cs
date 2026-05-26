using Newtonsoft.Json.Linq;
using JsonAssignment.Models;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "usertypes.json";

        string jsonData = File.ReadAllText(filePath);

        JArray usersArray = JArray.Parse(jsonData);

        foreach (var item in usersArray)
        {
            string type = item["Type"].ToString();

            if (type == "Admin")
            {
                Admin admin = item.ToObject<Admin>();

                Console.WriteLine("ADMIN USER");
                Console.WriteLine($"Name: {admin.Name}");
                Console.WriteLine($"Age: {admin.Age}");
                Console.WriteLine($"City: {admin.City}");
                Console.WriteLine($"Admin Level: {admin.AdminLevel}");
            }
            else
            {
                RegularUser user = item.ToObject<RegularUser>();

                Console.WriteLine("REGULAR USER");
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Age: {user.Age}");
                Console.WriteLine($"City: {user.City}");
                Console.WriteLine($"Membership Type: {user.MembershipType}");
            }

            Console.WriteLine();
        }
    }
}