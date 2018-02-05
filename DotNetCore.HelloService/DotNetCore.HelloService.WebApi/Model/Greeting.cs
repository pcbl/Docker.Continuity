using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.HelloService.WebApi.Model
{
    public class Greeting
    {
        public string Name { get; set; }

        public string Salutation => $"Hello, {Name}!";
    }
}
