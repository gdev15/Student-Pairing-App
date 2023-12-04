using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoin_Converter
{
    public class Users : Currency
    {
        public string Name { get; set; }
        public int UserId { get; set; }

        public Users () { }
        public Users(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }
    }
}
