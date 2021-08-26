using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
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
                AmountDue = 24,
                InvoiceDate = DateTime.Today
            };

            BusinessAccount myBiz = new BusinessAccount
            {
                BusinessName = "Big Biz Studios",
                BusinessAddress = "123 W. Charter rd",
                AmountDue = 9857,
                InvoiceDate = DateTime.Today
            };

            Console.WriteLine($"Name:{myAccount.Name} AmountDue: ${myAccount.AmountDue} Due: {myAccount.DueDate()}");
            Console.WriteLine($"Name:{myBiz.Name} AmountDue: ${myBiz.AmountDue} Due: {myBiz.DueDate()}");
            Console.ReadKey();
        }


        interface IPayMyBill
        {
            void Pay();
        }

        abstract class Account : IPayMyBill
        {
            public virtual string Name { get; set; }
            public virtual string Address { get; set; }
            public decimal AmountDue { get; set; }
            public DateTime InvoiceDate { get; set; }

            public abstract string DueDate();

            public void Pay()
            {
                AmountDue = 0;
            }

        }

        class PersonalAccount : Account
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string Name { get => FirstName + " " + LastName; }

            public override string DueDate()
            {
                return InvoiceDate.AddDays(30).ToString("dd/MM/yyyy");
            }

        }

        class BusinessAccount : Account
        {
            public string BusinessName { get; set; }
            public string BusinessAddress { get; set; }

            public override string Name { get => BusinessName; }
            public override string Address { get => BusinessAddress; }

            public override string DueDate()
            {
                return InvoiceDate.AddDays(60).ToString("dd/MM/yyyy");
            }
        }
    }
}
