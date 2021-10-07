using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models.employee
{
    public class Doctor : Employees
    {
        public override double tax(double nsalary)
        {
            if (nsalary < 500)
            {
                double newtax = nsalary *( 5 / 100);
                return newtax;
            }
            else
            {
                if (nsalary < 750)
                {
                    double newtax = nsalary*( 7.5 / 100);
                    return newtax;
                }
                else
                {
                    double newtax =nsalary *( 10 / 100);
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
                    double social = 30;
                    return social;
                }
                else
                {
                    double social = 45;
                    return social;

                }
            }
            else
            {

                if (netsalary < 500)
                {
                    double social = 35;
                    return social;
                }
                else
                {
                    double social = 50;
                    return social;

                }


            }

        }
    }

}