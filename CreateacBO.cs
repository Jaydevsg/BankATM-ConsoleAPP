using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


    class CreateacBO
    {
    ADO c = new ADO();

    public bool InsertAccount(CreateAccount ca)
    {
        return c.InsertAccount(ca);
    }


    public void View()
    {
        List<CreateAccount> l = c.ViewAll();
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}","AccountId", "BankName", "FirstName", "Email", "TypeOfAccount", "PhoneNumber", "AnnualIncome");

        foreach (CreateAccount item in l)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}", item.AccountID,item.BankName,item.FirstName,item.Email,item.TypeOfAccount,item.PhoneNumber,item.AnualIncome);

        }
    }

    public void viewBAl()
    {
        List<CreateAccount> l = c.ViewBalance();
        
        Console.WriteLine("{0,-15}{1,-15}","AccountID","Balance");
        foreach (CreateAccount item in l)
        {
            Console.WriteLine("{0,-15}{1,-15}", item.AccountID, item.AnualIncome);
        }
    }
    }

