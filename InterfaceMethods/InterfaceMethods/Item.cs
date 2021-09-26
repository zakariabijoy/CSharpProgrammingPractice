using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethods
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

       
    }
}
