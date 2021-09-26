using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Commands
{
    public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
