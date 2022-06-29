using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CreateAccount
    {
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

    public CreateAccount() { }

    public CreateAccount(int accountID)
    {
        this.accountID = accountID;
    }

    public CreateAccount(string bankName, string firstName, string lastName, string dob, string email, string pannumber, string typeOfAccount, string phoneNumber, double anualIncome, string nominiee)
    {
        this.bankName = bankName;
        this.firstName = firstName;
        this.lastName = lastName;
        this.dob = dob;
        this.email = email;
        this.pannumber = pannumber;
        this.typeOfAccount = typeOfAccount;
        this.phoneNumber = phoneNumber;
        this.anualIncome = anualIncome;
        this.nominiee = nominiee;
    }
    public CreateAccount(int accountID,string bankName, string firstName,  string email,  string typeOfAccount, string phoneNumber, double anualIncome)
    {
        this.AccountID = accountID;
        this.bankName = bankName;
        this.firstName = firstName;
        
        this.email = email;
        
        this.typeOfAccount = typeOfAccount;
        this.phoneNumber = phoneNumber;
        this.anualIncome = anualIncome;
       
    }
    public CreateAccount(int accountID, double anualIncome)
    {
        this.AccountID = accountID;
        this.anualIncome = anualIncome;
    }


    public CreateAccount(int accountID, string bankName, string firstName, string lastName, string dob, string email, string pannumber, string typeOfAccount, string phoneNumber, double anualIncome, string nominiee)
    {
        this.AccountID = accountID;
        this.BankName = bankName;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Dob = dob;
        this.Email = email;
        this.Pannumber = pannumber;
        this.TypeOfAccount = typeOfAccount;
        this.PhoneNumber = phoneNumber;
        this.AnualIncome = anualIncome;
        this.Nominiee = nominiee;
    }

    public int AccountID { get => accountID; set => accountID = value; }
    public string BankName { get => bankName; set => bankName = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Dob { get => dob; set => dob = value; }
    public string Email { get => email; set => email = value; }
    public string Pannumber { get => pannumber; set => pannumber = value; }
    public string TypeOfAccount { get => typeOfAccount; set => typeOfAccount = value; }
    public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    public double AnualIncome { get => anualIncome; set => anualIncome = value; }
    public string Nominiee { get => nominiee; set => nominiee = value; }

   
}

