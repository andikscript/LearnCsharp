using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProject.Class
{
    class User
    {
        private string name;

        // constructor dieksekusi diawal pembuatan object
        public User(string name)
        {
            this.name = name;
        }
        
        // destructor di eksekusi diakhir object yang di hapus
        ~User()
        {
            Console.WriteLine("Object is being deleted");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        // destructor
        
    }
}
