using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    //wrapping of data and methods into a single unit
    //make data more secure by data
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetBalance() { return balance; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000);

            myAccount.Deposit(500);
            Console.WriteLine("Balance: "
                              + myAccount.GetBalance());

            myAccount.Withdraw(2200);
            Console.WriteLine("Balance: "
                              + myAccount.GetBalance());
        }
    }
}

// C# program to illustrate encapsulation
/*public class DemoEncap
{

    // private variables declared
    // these can only be accessed by
    // public methods of class
    private String studentName;
    private int studentAge;

    // using accessors to get and
    // set the value of studentName
    public String Name
    {

        get { return studentName; }

        set { studentName = value; }
    }

    // using accessors to get and
    // set the value of studentAge
    public int Age
    {

        get { return studentAge; }

        set { studentAge = value; }
    }
}

// Driver Class
class GFG
{

    // Main Method
    static public void Main()
    {

        // creating object
        DemoEncap obj = new DemoEncap();

        // calls set accessor of the property Name,
        // and pass "Ankita" as value of the
        // standard field 'value'
        obj.Name = "
        Ankita & quot;
        ;

        // calls set accessor of the property Age,
        // and pass "21" as value of the
        // standard field 'value'
        obj.Age = 21;

        // Displaying values of the variables
        Console.WriteLine(" Name : " + obj.Name);
        Console.WriteLine(" Age : " + obj.Age);
    }
}*/