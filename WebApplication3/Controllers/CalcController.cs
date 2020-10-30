using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index(CalcModel c)
        {
            c.Result = 0;
            switch(c.Op)
            {
                case '+': c.Result = c.Number1 + c.Number2;
                    break;
                case '-':
                    c.Result = c.Number1 - c.Number2;
                    break;
                case '*':
                    c.Result = c.Number1 * c.Number2;
                    break;
                case '/':
                    if(c.Number2 != 0)
                    {
                        c.Result = c.Number1 / c.Number2;
                    }
                    break;
              
            }
            c.Number2 = c.Result;
            c.Number1 = 0;
            return View(c);
        }


    }
}
