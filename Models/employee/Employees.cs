using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oopt1.Models.employee
{
    public abstract class Employees
    {
        protected String fname;
        protected String lname;
        protected double salary;
        protected String gender;
        protected double insetive;
        protected double deduct;


        public String _fname
        {
            set { fname = value; }
            get { return fname; }

        }

        public String _lname
        {
            set { lname = value; }
            get { return lname; }
        }

        public double _salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public String _gender
        {
            set { gender = value; }
            get { return gender; }
        }
        public double _insetive
        {
            set { insetive = value; }
            get { return insetive; }


        }

        public double _deduct
        {
            set { deduct = value; }
            get { return deduct; }

        }



        public bool check()
        {
            if (lname != " " && fname != " " && salary > 200)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double newsalary()
        {
            double nsalary = salary - deduct + insetive;
            return nsalary;
        }

        public abstract double tax(double nsalary);

        public abstract double social(double netsalary);


        public double netsalary(double nsalary, double salarytax)
        {
            double netsal = nsalary - salarytax;
            return netsal;

        }




        public String print()
        {
            String msg = "Please Enter & fill this info: Enter your First Name.. Enter Your Last Name.. Your Salary should more than 200 JD";

            return msg;

        }

        public String print(double social,double netsalary )
        {
            String msg = "Hello, you completed the registration form successfully.," + gender + "." + fname + " " + lname +" "+ "We will deduct from Your Salary:" + social + " JD"+
                 "Your Salary after deduct:" + netsalary + "JD";
            return msg;
        }

        public String print(double salarytax )
        {
            String msg = "Sorry! You cannot Join with Us." +
              "because your salary after tax and deductions: " + salarytax + "JD" + " and it's less than 260 JD";

            return msg;
        }

    }
}