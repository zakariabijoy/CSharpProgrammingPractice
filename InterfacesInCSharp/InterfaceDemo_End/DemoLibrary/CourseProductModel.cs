﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    // Implement multiple
    public class CourseProductModel : IProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel customer)    // providing the body part of method
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Added the { Title } course to { customer.FirstName }'s account.");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
