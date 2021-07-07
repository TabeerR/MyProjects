using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace LoginForm
{
    public class NewCoffeeCls
    {
      
        public NewCoffeeCls() { }
        public NewCoffeeCls(string id)
        {
            Id = id;
        }

        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                if (value == "")
                    throw new Exception("Invalid Id");
                _id = value;
            }
        }

        private string _Coffeename;
        public string coffeeName
        {
            get { return _Coffeename; }
            set { _Coffeename = value; }
        }

        private string _Coffeetype;
        public string coffeetype
        {
            get { return _Coffeetype; }
            set { _Coffeetype = value; }
        }

        private string _quantity;
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string _NetPrice;
        public string NetPrice
        {
            get
            { return _NetPrice; }

            set
            { _NetPrice = value; }
        }

       
        public static void add(string query)
        {
            string exequery = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            SqlConnection con = new SqlConnection(exequery);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void update(string query)
        {
            string exequery = "Data Source=DESKTOP-FUADHO6;Initial Catalog=Star_lounge;Integrated Security=True";
            SqlConnection con = new SqlConnection(exequery);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void delete(string query)
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