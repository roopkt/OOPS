namespace oops_explainations.Polymorphism.StaticPolymorphism
{
    /*
     * The following example shows using function Create() to create new customer object with different data types:
     */
    public class Customer
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public static Customer Create(string firstName)
        {
            return new Customer {FirstName = firstName, LastName = string.Empty};
        }

        public static Customer Create(string firstName,string lastName)
        {
            return new Customer {FirstName = firstName, LastName = lastName};
        }
    }

   
}
