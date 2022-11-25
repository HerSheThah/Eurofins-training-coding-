using System;
namespace SBAccount
{
    internal class SBAccountCreation
    {
        int accountNumber;
        string accountHolderName;
        string typeofAccount;
        DateTime dateOfCreation;
        float balance;


        // Setting using properties
        public int AccNum
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public string AccHold
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }

        public string accType
        {
            get
            {
                return typeofAccount;
            }
            set
            {
                typeofAccount = value;
            }
        }


        //Constructors for default values
        public SBAccountCreation()
        {
            accountNumber = 0;
            balance = 0;
            dateOfCreation = DateTime.Now;


        }
        public SBAccountCreation(int accountNumber, string accountHolderName, string typeofAccount)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.typeofAccount = typeofAccount;
        }

        public SBAccountCreation(int accountNumber, string accountHolderName) 
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
        }

        public void getAccountDetails()
        {
            Console.WriteLine("Enter account number: ");
            accountNumber= int.Parse(Console.ReadLine());
            Console.WriteLine("Account holder name: ");
            accountHolderName = Console.ReadLine();
            Console.WriteLine("Account type: ");
            typeofAccount = Console.ReadLine();
        }

        public void showAccountdDetails()
        {

            Console.WriteLine("============Account Details==============");
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("AccountHolder Name: " + accountHolderName);
            Console.WriteLine("Type of Account: " + typeofAccount);
            Console.WriteLine("Account Created on: " + dateOfCreation.ToShortDateString());
            Console.WriteLine("Current Balance: " + balance);
        }
        
    }



    internal class SBTransaction
    {
        int TransactionId;
        String TAccountNumber;
        DateTime TransactionDate;
        float TransactionAmt;
        float NewBalance;

        public void getTransactionID()
        {

        }

    }
}


