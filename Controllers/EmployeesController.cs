using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using oopt1.Models.employee;

namespace oopt1.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View("Employees");
        }

        public IActionResult Index1()
        {
            var select = Request.Form["select"];
            if (select == "Techer")
            {
                Teacher t = new Teacher();
                t._fname = Request.Form["fname"];
                t._lname = Request.Form["lname"];
                t._salary = Convert.ToDouble(Request.Form["ysalary"]);
                t._deduct = Convert.ToDouble(Request.Form["ded"]);
                t._insetive = Convert.ToDouble(Request.Form["ins"]);
                t._gender = Request.Form["radio"];
                bool isvalid = t.check();

                if (isvalid == true)
                {
                    double nsalary = t.newsalary();
                    double salarytax = t.tax(nsalary);
                    double netsalary = t.netsalary(nsalary, salarytax);
                    

                    if (netsalary >= 260)
                    {
                        double salarysocil = t.social(netsalary);
                        double Finalnetsalary= netsalary - salarysocil;
                        String msg = t.print(salarysocil, Finalnetsalary);
                        ViewData["message"] = msg;

                    }
                    else if (netsalary < 260)
                    {
                        
                        String msg = t.print(netsalary);
                        ViewData["message"] = msg;

                    }


                }
                else
                {
                    String msg = t.print();
                    ViewData["message"] = msg;
                }

            }



            else
            {
                if (select == "Engineer")
                {
                    Engineer n = new Engineer();
                    n._fname = Request.Form["fname"];
                    n._lname = Request.Form["lname"];
                    n._salary = Convert.ToDouble(Request.Form["ysalary"]);
                    n._deduct = Convert.ToDouble(Request.Form["ded"]);
                    n._insetive = Convert.ToDouble(Request.Form["ins"]);
                    n._gender = Request.Form["radio"];

                    bool isvalid = n.check();

                    if (isvalid == true)
                    {
                        double nsalary = n.newsalary();
                        double salarytax = n.tax(nsalary);
                        double netsalary = n.netsalary(nsalary, salarytax);


                        if (netsalary >= 260)
                        {
                            double salarysocil = n.social(netsalary);
                            double Finalnetsalary = netsalary - salarysocil;
                            String msg = n.print(salarysocil, Finalnetsalary);
                            ViewData["message"] = msg;

                        }
                        else if (netsalary < 260)
                        {

                            String msg = n.print(netsalary);
                            ViewData["message"] = msg;

                        }


                    }
                    else
                    {
                        String msg = n.print();
                        ViewData["message"] = msg;
                    }

                }



                else
                {
                    Doctor d = new Doctor();
                    d._fname = Request.Form["fname"];
                    d._lname = Request.Form["lname"];
                    d._salary = Convert.ToDouble(Request.Form["ysalary"]);
                    d._deduct = Convert.ToDouble(Request.Form["ded"]);
                    d._insetive = Convert.ToDouble(Request.Form["ins"]);
                    d._gender = Request.Form["radio"];
                    bool isvalid = d.check();
              
                    if (isvalid == true)
                    {
                        double nsalary = d.newsalary();
                        double salarytax = d.tax(nsalary);
                        double netsalary = d.netsalary(nsalary, salarytax);


                        if (netsalary >= 260)
                        {
                            double salarysocil = d.social(netsalary);
                            double Finalnetsalary = netsalary - salarysocil;
                            String msg = d.print(salarysocil, Finalnetsalary);
                            ViewData["message"] = msg;

                        }
                        else if (netsalary < 260)
                        {

                            String msg = d.print(netsalary);
                            ViewData["message"] = msg;

                        }


                    }
                    else
                    {
                        String msg = d.print();
                        ViewData["message"] = msg;
                    }

                }


            } return View("Employees");
        }

    }
}
