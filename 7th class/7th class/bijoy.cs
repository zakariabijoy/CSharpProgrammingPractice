using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7th_class
{
     class bijoy
    {
        string name;
        string add;
        String prilvl;
      private  int _balance;

         public int Balance
         {
             get
             {
                 return _balance;
             }
             set
             {
                 if (value > 1000)
                 { 
                  _balance = value;

                 }
             }
         }
    }
     
}

