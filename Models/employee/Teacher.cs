using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models.employee
{
    public class Teacher : Employees
    {


        public override  double tax(double nsalary)
        {
            if (nsalary  < 500)
            {
                return 0;
            }
            else
            {
                if (nsalary< 750)
                {
                    double newtax = nsalary * 0.03;
                    return newtax;
                }
                else
                {
                    double newtax = salary * 0.05;
                    return newtax;
                }


            }

        }


        public override double social( double netsalary)
        {
            if (gender == "MR")
            {

                if (netsalary < 500)
                {
                    double social = 10;
                    return social;
                }
                else
                {
                    double social = 20;
                    return social;

                }
            }
            else
            {

                if (netsalary < 500)
                {
                    double social = 20;
                    return social;
                }
                else
                {
                    double social = 40;
                    return social;

                }


            }

        }
    }
}