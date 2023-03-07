using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kassa.Classes
{
    internal class Item
    {
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public string ProducerName { get; set; }
        public Item(string name)
        {
            Random random = new Random();
            ItemCode = name[0] + random.Next(9).ToString() + random.Next(3).ToString() + name[name.Length - 1] + name[name.Length - 2];
            Name = name;
            ProducerName = "Plus Quaedvlieg";
        }   
    }
}
