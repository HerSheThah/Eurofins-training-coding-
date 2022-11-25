
using System;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
namespace adoexample

{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;

        //Connecting to sql server
        private static SqlConnection getcon()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Eurofins;Integrated Security=true");
            //var builder = new ConfigurationBuilder().AddJsonFile($"appSettings.json", true, true);
            //var config = builder.Build();
            //con = new SqlConnection(config["ConnectionString"]);


            con.Open();
            return con;
        }

        // selecting sql command

        private static void disconselectData()
        {
            con=getcon();
            cmd = new SqlCommand("select * from Employee", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            foreach(DataRow dr in dt.Rows)
            {
                foreach(var item in dr.ItemArray)
                {
                    Console.WriteLine(item + " ");
                }
            }
        }
        
        private static void selectData()
        {
            con=getcon();
            //cmd = new SqlCommand("select * from Employee");
            cmd = new SqlCommand("spselectEmployee");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader[i] + " ");
                }
                Console.WriteLine();
            }
        }

        // inserting value into table
        private static void insertData()
        {
            Console.WriteLine("Enter empid, empname, location, dept, salary: ");
            int empid = int.Parse(Console.ReadLine());
            string ename = Console.ReadLine();
            string location = Console.ReadLine();
            string dept = Console.ReadLine();
            float salary = float.Parse(Console.ReadLine());

            con = getcon();
            cmd = new SqlCommand("insert into Employee values(@empid, @empname, @location, @dept, @salary)");
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@empid", empid);
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@salary", salary);
            int i =cmd.ExecuteNonQuery();
            Console.WriteLine(i + " rows affected");
        }
        private static void checkdata(int eid)
        {
            con = getcon();
            cmd = new SqlCommand("select count(*) from Employee where empid="+eid, con);
            //cmd.ExecuteNonQuery();
            int userExist = (int)cmd.ExecuteScalar();
            if (userExist > 0)
                Console.WriteLine("Exists");
            else
                Console.WriteLine("Donot exists");
        }
        // Update value into table 
        private static void updateData()
        {
            con = getcon();
            Console.WriteLine("Enter eid and salary");
            int empid = int.Parse(Console.ReadLine());
            float salary = float.Parse(Console.ReadLine());
            string querry = "update Employee set salary=" + salary + " where empid=" + empid;
            cmd = new SqlCommand(querry);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("\n" + i + " row(s) affected\n");
        }

        //Delete record from table
        private static void deleteData()
        {
            con = getcon();
            Console.WriteLine("Enter the eid to be deleted: ");
            int eid = int.Parse(Console.ReadLine());
            string querry = "delete from Employee where empid=" + eid;
            cmd= new SqlCommand(querry);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        static void Main()
        {
            //insertData();
            //updateData();
            //deleteData();
            //selectData();

            checkdata(190);
            Console.WriteLine("Enter your Name: ");

        }
    }
}

