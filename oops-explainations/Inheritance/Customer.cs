﻿namespace oops_explainations.Inheritance
{
    /*
     Inheritance allows us to define a class in terms of another class, 
     which makes it easier to create and maintain an application. 
     This also provides an opportunity to reuse the code functionality and speeds up implementation time.

     When creating a class, instead of writing completely new data members and member functions, 
     the programmer can designate that the new class should inherit the members of an existing class. 
     This existing class is called the base class, and the new class is referred to as the derived class.

    The idea of inheritance implements the IS-A relationship. 
    For example, mammal IS A animal, dog IS-A mammal hence dog IS-A animal as well, and so on.
    */

    public class Customer
    {

        protected string FirstName { get; set; }
        protected string LastName { get; set; }
    }

    public class SilverCustomer : Customer
    {
        //derive class can access the protected properties of the base class
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class PlatinumCustomer : Customer
    {
        //derive class can access the protected properties of the base class
        public void UpdateName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
