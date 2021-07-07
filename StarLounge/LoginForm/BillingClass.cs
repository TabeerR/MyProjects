using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
namespace LoginForm
{
    public class BillingClass
    {
        private string _Id;
        public string id
        {
            get { return _Id; }
            set
            {
                try
                {
                    _Id = value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Invalid Id: only numeric");
                }
            }

        }
        private string _Coffeename;
        public string coffeename
        {
            get { return _Coffeename; }
            set
            {
                try
                {
                    if (value.Length >= 1 && value.Length <= 30)
                        _Coffeename = value;
                    else
                        throw new Exception("Invalid Name: Range 1 to 30");
                }
                catch (Exception ex) { throw new Exception("Invalid Name: Range 1 to 30"); }

            }
        }
        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string NetPrice
        {
            get
            {
                return netPrice;
            }

            set
            {
                netPrice = value;
            }
        }

        public string TotalAmount
        {
            get
            {
                return totalAmount;
            }

            set
            {
                totalAmount = value;
            }
        }

        public string Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public string FinalAmount
        {
            get
            {
                return finalAmount;
            }

            set
            {
                finalAmount = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string CustomerOrderNumber
        {
            get
            {
                return customerOrderNumber;
            }

            set
            {
                customerOrderNumber = value;
            }
        }


        private string quantity;

        private string netPrice;
        private string totalAmount;
        private string discount;
        private string finalAmount;
        private string date;
        private string customerOrderNumber;



        public static void add(string query)
        {
            string exequery = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True"; 
            SqlConnection con = new SqlConnection(exequery); 
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public static SqlDataReader readata(string query)
        {
            string exequery = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True"; 
            SqlConnection con = new SqlConnection(exequery);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dataread = cmd.ExecuteReader();
            return dataread;
        }

        public static DataSet dset(string query)
        {
            string connstring = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connstring);
            sqlconn.Open();
            SqlCommand sqlcmd = new SqlCommand(query, sqlconn);
            DataSet dset = new DataSet();
            SqlDataAdapter sqlad = new SqlDataAdapter(sqlcmd);
            sqlad.Fill(dset, "data");
            return dset;
        }
    }
}
