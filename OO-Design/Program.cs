using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Design
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonalAccount myAccount = new PersonalAccount
            {
                FirstName = "Bryce",
                LastName = "Perez",
                Address = "456 E. Charter rd",
                AmountDue = 24.23,
                InvoiceDate = DateTime.Now,
                DueDate = DateTime.Now.AddMonths(1)

            };

            BusinessAccount myBiz = new BusinessAccount
            {
                BusinessName = "Big Biz Studios",
                BusinessAddress = "123 W. Charter rd",
                AmountDue = 9857.87,
                InvoiceDate = DateTime.Today,
                DueDate = DateTime.Today.AddMonths(1)
            };

            Console.WriteLine($"Name:{myAccount.Name} AmountDue: ${myAccount.AmountDue} Due: {myAccount.DueDate.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"Name:{myBiz.Name} AmountDue: ${myBiz.AmountDue} Due: {myBiz.DueDate.ToString("MM/dd/yyyy")}");
            Console.ReadKey();
        }

        class Account
        {
            public virtual string Name { get; set; }
            public virtual string Address { get; set; }
            public  double AmountDue { get; set; }
            public DateTime InvoiceDate { get; set; }
            public DateTime DueDate { get; set; }

        }

        class PersonalAccount : Account
        {
           public string FirstName { get; set; }
           public string LastName { get; set; }

            public override string Name { get => FirstName + " " + LastName;}

        }

        class BusinessAccount : Account
        {
            public string BusinessName { get; set; }
            public string BusinessAddress { get; set; }

            public override string Name { get => BusinessName; }
            public override string Address { get => BusinessAddress; }
        }
    }
}
