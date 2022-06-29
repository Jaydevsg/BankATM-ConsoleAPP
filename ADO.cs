using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


    class ADO
    {
    SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = Bank_DB; Integrated Security = true;");
    //CreateAccount ca = new CreateAccount();
    public bool InsertAccount(CreateAccount ca)
        {
       
        bool flag = false;
        con.Open();
        SqlCommand cmd = new SqlCommand
            ("insert into CreateAccount(BankName,FirstName,LastName,DateOfBirth,Email,PANnumber,TypeOfAccount,PhoneNumber,AnnualIncome,Nominee) values(@BankName,@FirstName,@LastName,@DateOfBirth,@Email,@PANnumber,@TypeOfAccount,@PhoneNumber,@AnnualIncome,@Nominee)", con);
           
            cmd.Parameters.AddWithValue("@BankName", ca.BankName);
            cmd.Parameters.AddWithValue("@FirstName", ca.FirstName);
            cmd.Parameters.AddWithValue("@LastName", ca.LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", ca.Dob);
            cmd.Parameters.AddWithValue("@Email", ca.Email);
            cmd.Parameters.AddWithValue("@PANnumber", ca.Pannumber);
            cmd.Parameters.AddWithValue("@TypeOfAccount", ca.TypeOfAccount);
            cmd.Parameters.AddWithValue("@PhoneNumber", ca.PhoneNumber);
            cmd.Parameters.AddWithValue("@AnnualIncome", ca.AnualIncome);
            cmd.Parameters.AddWithValue("@Nominee", ca.Nominiee);
            int result = cmd.ExecuteNonQuery();
            if (result>0)
            {
                flag = true;
            }
            con.Close();
            return flag;
        }

    public bool UpdateAccount()
    {
        bool flag = false;
        con.Open();
        SqlCommand cmd = new SqlCommand("update CreateAccount set BankName=@BankName,FirstName=@FirstName,LastName=@LastName,DateOfBirth=@DateOfBirth,Email=@Email,PANnumber=@PANnumber,TypeOfAccount=@TypeOfAccount,PhoneNumber=@PhoneNumber,AnnualIncome=@AnnualIncome,Nominee=@Nominee where AccountId=@AccountId", con);
        CreateAccount ca = new CreateAccount();
        cmd.Parameters.AddWithValue("@AccountId", ca.AccountID);
        cmd.Parameters.AddWithValue("@BankName", ca.BankName);
        cmd.Parameters.AddWithValue("@FirstName", ca.FirstName);
        cmd.Parameters.AddWithValue("@LastName", ca.LastName);
        cmd.Parameters.AddWithValue("@DateOfBirth", ca.Dob);
        cmd.Parameters.AddWithValue("@Email", ca.Email);
        cmd.Parameters.AddWithValue("@PANnumber", ca.Pannumber);
        cmd.Parameters.AddWithValue("@TypeOfAccount", ca.TypeOfAccount);
        cmd.Parameters.AddWithValue("@PhoneNumber", ca.PhoneNumber);
        cmd.Parameters.AddWithValue("@AnnualIncome", ca.AnualIncome);
        cmd.Parameters.AddWithValue("@Nominee", ca.Nominiee);
        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            flag = true;
        }
        con.Close();
        return flag;
    }

    public bool PhoneNumberUpdateAccount()
    {
        bool flag = false;
        con.Open();
        SqlCommand cmd = new SqlCommand("update CreateAccount set PhoneNumber=@PhoneNumber where AccountId=@AccountId", con);
        CreateAccount ca = new CreateAccount();
        cmd.Parameters.AddWithValue("@AccountId", ca.AccountID);
        
        cmd.Parameters.AddWithValue("@PhoneNumber", ca.PhoneNumber);
       
        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            flag = true;
        }
        con.Close();
        return flag;
    }

    public bool EmailUpdateAccount()
    {
        bool flag = false;
        con.Open();
        SqlCommand cmd = new SqlCommand("update CreateAccount set FirstName=@FirstName,LastName=@LastName where AccountId=@AccountId", con);
        CreateAccount ca = new CreateAccount();
        cmd.Parameters.AddWithValue("@AccountId", ca.AccountID);
     
        cmd.Parameters.AddWithValue("@Email", ca.Email);
        
        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            flag = true;
        }
        con.Close();
        return flag;
    }
    


    public bool DeleteAccount()
    {
        bool flag = false;
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from CreateAccount where AccountId = @id", con);
        CreateAccount ca = new CreateAccount();
        cmd.Parameters.AddWithValue("@id", ca.AccountID);
        
        int result = cmd.ExecuteNonQuery();
        if (result > 0)
        {
            flag = true;
        }
        con.Close();
        return flag;
    }

    public List<CreateAccount> ViewAll()
    {
        con.Open();
        List<CreateAccount> li = new List<CreateAccount>();
        SqlCommand cmd = new SqlCommand("select AccountId,BankName,FirstName,Email,TypeOfAccount,PhoneNumber,AnnualIncome from CreateAccount",con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            CreateAccount ca = new CreateAccount(dr.GetInt32(0),dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), Convert.ToDouble(dr[6]));
            li.Add(ca);
        }
        con.Close();
        return li;
    }
    public List<CreateAccount> ViewBalance()
    {
        con.Open();
        List<CreateAccount> li = new List<CreateAccount>();
        SqlCommand cmd = new SqlCommand("select AccountId,AnnualIncome from CreateAccount where AccountId = @AccountId", con);
        CreateAccount ca = new CreateAccount();
        cmd.Parameters.AddWithValue("@AccountId", ca.AccountID);
        int result = cmd.ExecuteNonQuery();
        if (result>0)
        {
            CreateAccount c = new CreateAccount( ca.AccountID,ca.AnualIncome);
            li.Add(c);
        }

            con.Close();
        return li;
    }
}

