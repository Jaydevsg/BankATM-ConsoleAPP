using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

    class Program
    {
        static void Main(string[] args)
        {
        SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Bank_DB; Integrated Security = true;");
        int accountID;
        string bankName;
        string firstName;
        string lastName;
        string dob;
        string email;
        string pannumber;
        string typeOfAccount;
        string phoneNumber;
        double anualIncome;
        string nominiee;
        CreateacBO obj = new CreateacBO();
        Console.WriteLine("1.Create Your Bank Account");
        Console.WriteLine("2.Card Activation");
        Console.WriteLine("3.Pin Change");
        Console.WriteLine("4.Account Balance");
        Console.WriteLine("5.cash Deposit");
        Console.WriteLine("6.Withadraw");
        Console.WriteLine("7.Transfer");
        Console.WriteLine("Enter the Required Fuction to be Performed From the Above OPtions:");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("Enter Bank Name:");
                bankName = Console.ReadLine();
                Console.WriteLine("Enter First Name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Date of Birth:");
                dob = Console.ReadLine();
                Console.WriteLine("Enter email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter PAN card number:");
                pannumber = Console.ReadLine();
                Console.WriteLine("Enter Type Of Account(Personal/Joint/Saving/Current):");
                typeOfAccount = Console.ReadLine();
                Console.WriteLine("Enter Mobile Number:");
                phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Anual Income:");
                anualIncome = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter nominiee:");
                nominiee = Console.ReadLine();

                CreateAccount cacc = new CreateAccount
                    (bankName, firstName, lastName,dob,email,pannumber,typeOfAccount,phoneNumber,anualIncome,nominiee);
                if (obj.InsertAccount(cacc))
                {
                    Console.WriteLine("Record Inserted");
                    obj.View();
                }
                else
                {
                    Console.WriteLine("Record not inserted");
                }
                break;
            case 2:
                Console.WriteLine("Card Applied? Yes/No");
                string d =Console.ReadLine();
                obj.View();
                if (d == "Yes" || d =="YES" || d =="yes")
                {
                    Console.WriteLine("Enter AccountID");
                    accountID = int.Parse(Console.ReadLine());
                    //Ado i
                    con.Open();
                    SqlCommand cmd = new SqlCommand("checkuser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@accountId", accountID);
                   int result = (int)cmd.ExecuteScalar();//obj type
                    if (result>0)
                    {
                        Console.WriteLine("Card Activated");
                    }
                    else
                    {
                        Console.WriteLine("unknown user");
                    }
                    con.Close();

                }
                break;
            case 3:
                break;
            case 4:
                Console.WriteLine("Enter Account Id to which balance is checked ");
                accountID = int.Parse(Console.ReadLine());
                CreateAccount cac = new CreateAccount(accountID);
                obj.viewBAl();
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
               
                break;
             default:
                break;
        }
    }
    }

