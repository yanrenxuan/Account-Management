using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Account_Management
{
    public class Customer
    {
        string _connStr = ConfigurationManager.ConnectionStrings["CustomerContext"].ConnectionString;
        private string _CustID = null;
        private string _Fname = "";
        private string _Lname = "";
        private DateTime _CustDOB;
        private string _CustPicture = "";
        private string _CustEmail = "";
        private string _CustHP = "";
        private string _CustAddress = "";
        private string _CustPostal = "";
        private string _CustPass = "";
        private string _RefCode = "";

        public Customer(string CustID, string Fname, string Lname, DateTime CustDOB,
            string CustPicture, string CustEmail, string CustHP, 
            string CustAddress, string CustPostal, string CustPass, string RefCode)
        {
            _CustID = CustID;
            _Fname = Fname;
            _Lname = Lname;
            _CustDOB = CustDOB;
            _CustPicture = CustPicture;
            _CustEmail = CustEmail;
            _CustHP = CustHP;
            _CustAddress = CustAddress;
            _CustPostal = CustPostal;
            _CustPass = CustPass;
            _RefCode = RefCode;
        }

        public Customer()
        {
        }
        public string Cust_ID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }

        public string First_Name
        {
            get { return _Fname; }
            set { _Fname = value; }
        }

        public string Last_Name
        {
            get { return _Lname; }
            set { _Lname = value; }
        }

        public DateTime DOB
        {
            get { return _CustDOB; }
            set { _CustDOB = value.Date; }
        }

        public string Cust_Picture
        {
            get { return _CustPicture; }
            set { _CustPicture = value; }
        }

        public string Cust_Email
        {
            get { return _CustEmail; }
            set { _CustEmail = value; }
        }
        public string Cust_HP
        {
            get { return _CustHP; }
            set { _CustHP = value; }
        }
        public string Cust_Address
        {
            get { return _CustAddress; }
            set { _CustAddress = value; }
        }

        public string Cust_Postal
        {
            get { return _CustPostal; }
            set { _CustPostal = value; }
        }

        public string Cust_Password
        {
            get { return _CustPass; }
            set { _CustPass = value; }
        }

        public string Referral_Code
        {
            get { return _RefCode; }
            set { _RefCode = value; }
        }

        public Customer getCustDetails(string CustID)
        {
            Customer CustDetail = null;

            string Fname, Lname;
            DateTime CustDOB;
            string CustPicture, CustEmail, CustHP, CustAddress, CustPostal, CustPass, RefCode;

            string queryStr = "SELECT * FROM Customer WHERE Cust_ID = @CustID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@CustID", CustID);
            
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                CustID = dr["Cust_ID"].ToString();
                Fname = dr["First_Name"].ToString(); 
                Lname = dr["Last_Name"].ToString();
                CustDOB = Convert.ToDateTime(dr["DOB"]).Date;
                CustPicture = dr["Cust_Picture"].ToString();
                CustEmail = dr["Cust_Email"].ToString();  
                CustHP = dr["Cust_HP"].ToString();  
                CustAddress = dr["Cust_Address"].ToString();  
                CustPostal = dr["Cust_Postal"].ToString();  
                CustPass = dr["Cust_Password"].ToString();  
                RefCode = dr["Referral_Code"].ToString();

                CustDetail = new Customer(CustID, Fname, Lname, CustDOB, CustPicture, CustEmail, CustHP, CustAddress, CustPostal, CustPass, RefCode);
            }

            else
            {
                CustDetail = null;
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return CustDetail;
        }

        public List<Customer> getCustomerList()
        {
            List<Customer> CustList = new List<Customer>();

            string CustID, Fname, Lname;
            DateTime CustDOB;
            string CustPicture, CustEmail, CustHP, CustAddress, CustPostal, CustPass, RefCode;

            string queryStr = "SELECT * FROM Customer Order By Cust_ID";

            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CustID = dr["Cust_ID"].ToString();
                Fname = dr["First_Name"].ToString();
                Lname = dr["Last_Name"].ToString();
                CustDOB = Convert.ToDateTime(dr["DOB"]).Date;
                CustPicture = dr["Cust_Picture"].ToString();
                CustEmail = dr["Cust_Email"].ToString();
                CustHP = dr["Cust_HP"].ToString();
                CustAddress = dr["Cust_Address"].ToString();
                CustPostal = dr["Cust_Postal"].ToString();
                CustPass = dr["Cust_Password"].ToString();
                RefCode = dr["Referral_Code"].ToString();

                Customer a = new Customer(CustID, Fname, Lname, CustDOB, CustPicture, CustEmail, CustHP, CustAddress, CustPostal, CustPass, RefCode);
                CustList.Add(a);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();

            return CustList;
        }






























































































    }


}