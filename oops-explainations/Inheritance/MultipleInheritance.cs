using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_explainations.MultipleInheritance
{
    /*
     C# does not support multiple inheritance. 
     However, you can use interfaces to implement multiple inheritance. 
     The following program demonstrates this:
     */
    public class Customer
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
    }

    /**
     * Created 2 interfaces ICanUpdateName and ICanIssueCoupons
     */

    public interface ICanUpdateName
    {
        void UpdateName(string firstName, string lastName);
    }

    public interface ICanIssueCoupons
    {
        void GetCoupons();
    }


    public class RegularCustomer : Customer, ICanUpdateName
    {
        //derive class can access the protected properties of the base class
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }


    /*
     Platinum customer can do 2 things it can update name and also issue coupon. 
     Therefore, we can use 2 interfaces and such that multiple inheritance is poosible. 
    */
    public class GoldCustomer : Customer, ICanUpdateName, ICanIssueCoupons
    {
        //derive class can access the protected properties of the base class
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void GetCoupons()
        {
            Console.WriteLine("Coupon issued to platinum customer");
        }
    }


}
