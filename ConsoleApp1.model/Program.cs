using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.model;
namespace ConsoleApp1.model
{
    class Program
    {
        static void Main(string[] args)
        {
           ServiceUser s=new ServiceUser("https://randomuser.me/api?results=1");

            Console.WriteLine( s.GetJsonUser());


        }
     
        }
    }
   

