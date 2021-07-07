using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.IO;




namespace Payroll_Management_System
{
    public class clsHiring
    {

        private int _EmployeeID;
        public int Employeeid
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }

        }


        private string first_Name;

        public string First_Name
        {
            get { return first_Name; }
            set { first_Name = value; }
        }


        private string last_Name;

        public string Last_Name
        {
            get { return last_Name; }
            set { last_Name = value; }
        }
        private double _empsalary;
        public double Salary
        {
            get { return _empsalary; }
            set { _empsalary = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string e_mail;

        public string E_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }
        private string phone_number;

        public string Phone_number
        {
            get { return phone_number; }
            set { phone_number = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }



        private static List<clsHiring> _hiringdata = new List<clsHiring>();
        public static List<clsHiring> HiringData
        {
            get { return clsHiring._hiringdata; }
            set { clsHiring._hiringdata = value; }
        }
        public clsHiring() { }
        public clsHiring(int id)
        {
            Employeeid = id;
        }


        public int HRrtrive()
        {
            clsHiring hir = new clsHiring();

            int hidx;
            hidx = HiringData.FindIndex(x => x.Employeeid == Employeeid);
            if (hidx != -1)
            {
                First_Name = clsHiring.HiringData[hidx].First_Name;
                Salary = clsHiring.HiringData[hidx].Salary;

            }
            else if (hidx == -1)
            {
                throw new Exception("Record // Not Found");
            }
            return hidx;
        }

        public int PRetrive()
        {
            clsHiring hir = new clsHiring();

            int idx;
            idx = HiringData.FindIndex(x => x.Employeeid == Employeeid);
            if (idx != -1)
            {
                First_Name = clsHiring.HiringData[idx].First_Name;
               // Last_Name = clsHiring.HiringData[idx].Last_Name;
                Department = clsHiring.HiringData[idx].Department;
                Gender = clsHiring.HiringData[idx].Gender;
                E_mail = clsHiring.HiringData[idx].E_mail;
                Phone_number = clsHiring.HiringData[idx].Phone_number;

            }
            else if (idx == -1)
            {
                throw new Exception("Record not found");
            }
            return idx;
        }


        public int Retrieve()
        {
            int idx;
            idx = HiringData.FindIndex(x => x.Employeeid == Employeeid);
            if (idx != -1)
            {
                Employeeid = clsHiring.HiringData[idx].Employeeid;
                Salary = clsHiring.HiringData[idx].Salary;

            }
            else if (idx == -1)
            {
                throw new Exception("Record not found");
            }
            return idx;
        }

        public void GetHired()
        {
            int idx;
            idx = HiringData.FindIndex(x => x.Employeeid == Employeeid);
            if (idx != -1)
                throw new Exception(Employeeid + " :Employee id Already Exist");
            HiringData.Add(this);
        }

        public int DeleteH()
        {
            int idx;
            idx = HiringData.FindIndex(x => x.Employeeid == Employeeid);
            if (idx != -1)
            {
                HiringData.RemoveAt(idx);
            }
            else if (idx == -1)
            {
                throw new Exception("Record not found");
            }
            return idx;
        }
        public void LoadXMLH()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsHiring>));
            try
            {
                using (FileStream fs = File.OpenRead("Clshiring.xml"))
                {
                    clsHiring._hiringdata = (List<clsHiring>)myXML.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SaveXLMH()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsHiring>));
            try
            {
                using (FileStream fs = File.Create("Clshiring.xml"))
                {
                    myXML.Serialize(fs, _hiringdata);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


    }
}

