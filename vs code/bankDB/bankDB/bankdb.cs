using System.Data.SqlClient;
using System.Data;
using banklibrary;

namespace bankDB
{
    public class BankDataBase   
    {
        public class BalanceException : ApplicationException
        {
            public BalanceException(string message) : base(message) { }
        }

        public static SqlConnection con;
        public static SqlCommand cmd;


        // ********************* Connecting to sql server ********************* 
        public SqlConnection getConnection()
        {
                con = new SqlConnection("Data Source=.;Initial Catalog=BankDB;Integrated Security=true");
                con.Open();
                return con;
        }

        // ********************* Inserting account details of new user *********************
        public SBAccount insertAccountDetails(SBAccount acc)
        {
            con = getConnection();
            cmd = new SqlCommand("spinsertacc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AccountNumber", acc.AccountNumber);
            cmd.Parameters.AddWithValue("@CustomerName", acc.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerAddress", acc.CustomerAddress);
            cmd.Parameters.AddWithValue("@CurrentBalance", acc.CurrentBalance);
            cmd.ExecuteNonQuery();
            return retriveAccountDetails(acc.AccountNumber);

        }

        // ********************* Retriving account details of one user *********************

        public SBAccount retriveAccountDetails(long accountnum)
        {  
            con = getConnection();
            if (checkUserExists(accountnum))
            {
                SBAccount newuser = new SBAccount();
                
                cmd = new SqlCommand("spaccountdetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountNumber", accountnum);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    newuser.AccountNumber = long.Parse(dr["AccountNumber"].ToString());
                    newuser.CustomerName = dr["CustomerName"].ToString();
                    newuser.CustomerAddress = dr["CustomerAddress"].ToString();
                    newuser.CurrentBalance = decimal.Parse(dr["CurrentBalance"].ToString());
                }
                return newuser;

            }
            return null;              
        }

        // ********************* Retriving all account details *********************

        public List<SBAccount> retriveAllAccounts()
        {
            List<SBAccount> retriveAccounts = new List<SBAccount>();
            con = getConnection();
            cmd = new SqlCommand("spallaccounts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SBAccount newobj = new SBAccount();

                newobj.AccountNumber = long.Parse(dr["AccountNumber"].ToString());
                newobj.CustomerName = dr["CustomerName"].ToString();
                newobj.CustomerAddress = dr["CustomerAddress"].ToString();
                newobj.CurrentBalance = decimal.Parse(dr["CurrentBalance"].ToString());

                retriveAccounts.Add(newobj);
            }
            return retriveAccounts;

        }
        // ********************* Depositing amount *********************


        public void depositAmount(long accno, decimal amt)
        {
            if (checkamt(amt))
            {
                con = getConnection();
                cmd = new SqlCommand("spcurrentbalance", con);
                cmd.Parameters.AddWithValue("@AccountNumber", accno);

                cmd.CommandType = CommandType.StoredProcedure;

                decimal currentBalance = (decimal)cmd.ExecuteScalar();
                updateAmount("Deposit", amt, currentBalance, accno);
            }       
        }

        // ********************* Updating amount and adding to transactions *********************

        public void updateAmount(string type, decimal amt, decimal currentBalance, long accno)
        {
            if(type=="Deposit")
                currentBalance += amt;
            else
                currentBalance -= amt;
            cmd = new SqlCommand("spupdateamount", con);
            cmd.Parameters.AddWithValue("@CurrentBalance", currentBalance);
            cmd.Parameters.AddWithValue("@AccountNumber", accno);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            Random rand = new Random();
            Int64 transId = rand.NextInt64(999999999, 10000000000);
            addTransactions(transId, DateTime.Now, accno, amt, type);
            Console.WriteLine("Current balance=" + currentBalance+"\n");
            
        }

        // ********************* Withdraw amount *********************

        public bool withdrawAmount(long accno, decimal amt)
        {
            
            con = getConnection();
            cmd = new SqlCommand("spcurrentbalance", con);
            cmd.Parameters.AddWithValue("@AccountNumber", accno);
            cmd.CommandType = CommandType.StoredProcedure;
            decimal currentBalance = (decimal)cmd.ExecuteScalar();
            if((validateWithdrawamt(amt, currentBalance))&&(checkamt(amt)))
            {
                updateAmount("Withdraw", amt, currentBalance, accno);
                return true;
            }
               
            return false;   
        }


        // ********************* Adding details to transactions table *********************

        public void addTransactions(long transid, DateTime transdate, long accno, decimal amt, string transtype)
        {
            con = getConnection();
            cmd = new SqlCommand("spinserttransac", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TransactionId", transid);
            cmd.Parameters.AddWithValue("@TransactionDate", transdate);
            cmd.Parameters.AddWithValue("@AccountNumber", accno);
            cmd.Parameters.AddWithValue("@Amount", amt);
            cmd.Parameters.AddWithValue("@TransactionType", transtype);
            cmd.ExecuteReader();
            

        }

        // ********************* Retriving all transactions *********************

        public List<SBTransaction> displayTransaction(long accno)
        {
            con = getConnection();

            if (checkUserExists(accno))
            {
                List<SBTransaction> transactions = new List<SBTransaction>();
                cmd = new SqlCommand("spaccounttrans", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AccountNumber", accno);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SBTransaction newobj = new SBTransaction();
                    newobj.TransactionId = long.Parse(dr["TransactionId"].ToString());
                    newobj.AccountNumber = long.Parse(dr["AccountNumber"].ToString());
                    newobj.Amount = decimal.Parse(dr["Amount"].ToString());
                    newobj.TransactionDate = DateTime.Parse(dr["TransactionDate"].ToString());
                    newobj.TransactionType = dr["TransactionType"].ToString();

                    transactions.Add(newobj);
                }
                return transactions;
            }
            return null;


        }

        // ********************* Checking if user exist in database *********************

        public bool checkUserExists(long accno)
        {
            con = getConnection();
            cmd = new SqlCommand("select count(*) from SBAccount where AccountNumber=" + accno, con);
            int userexist = (int)cmd.ExecuteScalar();
            if (userexist > 0)
                return true;
            return false;
        }

        // ********************* Validating withdraw amount *********************

        private bool validateWithdrawamt(decimal amt, decimal balance)
        {
            if (balance - amt < 0)
            {
                Console.WriteLine("Your current balance: " + balance);
                throw new BalanceException("Insufficient balance");
            }

            else
                return true;

        }

        // ********************* Checking amount input is > 0 *********************

        private bool checkamt(decimal amt)
        {
            if (amt <= 0)
            {
                
                throw new BalanceException("Amount must be greater than zero");
            }

            else
                return true;

        }
    }
}