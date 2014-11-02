//Define a class Customer, which contains data about a customer – first name, middle name and last name, ID (EGN), permanent address, 
//mobile phone, e-mail, list of payments and customer type. 
//•	Define a class Payment which holds a product name and price.
//•	Define an enumeration for the customer type, holding the following types of customers: One-time , Regular, Golden, Diamond.
//•	Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//•	Implement the ICloneable interface. 
// The Clone() method should make a deep copy of all object fields into a new object of type Customer.
//•	Implement the IComparable<Customer> interface to compare customers by full name (as first criteria, in lexicographic order) 
// and by ID (as second criteria, in ascending order).

namespace _01.Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<Payment> Payments { get; set; }

        public CustomerType Type { get; set; }

        public override bool Equals(object obj)
        {
            var otherCustomer = obj as Customer;

            //If two persons have same ID, they must be the same person.
            if (this.Id.Equals(otherCustomer.Id))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var hashBase = this.FirstName + this.LastName + this.MiddleName + this.Id;

            return hashBase.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("ID: {0}", this.Id));
            result.AppendLine(string.Format("Permanent address: {0}", this.PermanentAddress));
            result.AppendLine(string.Format("Mobile phone: {0}", this.MobilePhone));
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine("Payments:");

            for (int i = 0; i < this.Payments.Count; i++)
            {
                result.AppendLine(string.Format("{0}. Product name: {1}, Price: {2}", i, this.Payments[i].ProductName, this.Payments[i].Price));
            }

            result.AppendLine(string.Format("Customer type: {0}", this.Type.ToString()));

            return result.ToString();
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer){
            if (firstCustomer.Equals(secondCustomer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            if (firstCustomer.Equals(secondCustomer))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Clone()
        {
            var clonedCustomer = new Customer();

            clonedCustomer.FirstName = this.FirstName;
            clonedCustomer.MiddleName = this.MiddleName;
            clonedCustomer.LastName = this.LastName;
            clonedCustomer.Id = this.Id;
            clonedCustomer.PermanentAddress = this.PermanentAddress;
            clonedCustomer.MobilePhone = this.MobilePhone;
            clonedCustomer.Email = this.Email;
            clonedCustomer.Type = this.Type;

            var newPayments = new List<Payment>();

            foreach (var payment in this.Payments)
            {
                var newPayment = new Payment();
                newPayment.ProductName = payment.ProductName;
                newPayment.Price = payment.Price;
                newPayments.Add(newPayment);
            }

            return clonedCustomer;
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName.CompareTo(other.FirstName) > 0)
            {
                return 1;
            }
            else if (this.FirstName.CompareTo(other.FirstName) < 0)
            {
                return -1;
            }

            if (this.MiddleName.CompareTo(other.MiddleName) > 0)
            {
                return 1;
            }
            else if (this.MiddleName.CompareTo(other.MiddleName) < 0)
            {
                return -1;
            }

            if (this.LastName.CompareTo(other.LastName) > 0)
            {
                return 1;
            }
            else if (this.LastName.CompareTo(other.LastName) < 0)
            {
                return -1;
            }

            if (this.Id.CompareTo(other.Id) < 0)
            {
                return 1;
            }
            else if (this.Id.CompareTo(other.Id) > 0)
            {
                return -1;
            }

            return 0;
        }
    }
}
