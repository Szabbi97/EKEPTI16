using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Helyettes
{
    class Program
    {
        static List<User> users;

        static User Deputy(User user)
        {
            if (user.DeputyId == 0) 
                return user;
            else return Deputy(users.Where(u => u.Id == user.DeputyId).First());
            //else return Deputy(GetUserById(user.DeputyId));
        }

        static User GetUserById(int Id)
        {
            for (int i = 0; i < users.Count; i++)
                if (users[i].Id == Id) 
                    return users[i];
            return null;
        }

        static void Main(string[] args)
        {
            users = new List<User>()
            {
                new User(1, "Troll Ede", "troll.ede@uni-eszterhazy.hu", 3),
                new User(2, "Geda Gábor", "geda.gabor@uni-eszterhazy.hu", 4),
                new User(3, "Király Sándor", "kiraly.sandor@uni-eszterhazy.hu", 2),
                new User(4, "Balla Tamás", "balla.tamas@uni-eszterhazy.hu", 0),
                new User(5, "Juhász Máté", "juhasz.mate@uni-eszterhazy.hu", 0)
            };

            User ede = users.First();
            User deputy = Deputy(ede);

            Console.WriteLine("{0} levelét a(z) {1} címre kell küldeni.",
                ede.Name, deputy.Email);

            Console.ReadLine();
        }
    }
}
