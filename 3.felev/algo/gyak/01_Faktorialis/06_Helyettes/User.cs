using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Helyettes
{
    class User
    {
        public User(int Id, string Name, string Email, int DeputyId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.DeputyId = DeputyId;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DeputyId { get; set; }
    }
}
