using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data;
namespace Payroll_Management_System
{
    public class ClsRecuitment
    {
        protected string candidate_id;
        public string Candidate_id
        {
            get  { return candidate_id; }
            set { candidate_id = value;  }
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
        
        
        
        private static
           
            List<ClsRecuitment> _recdat = new List<ClsRecuitment>();

         public static 
             
             List<ClsRecuitment> Recdat
         {
             get { return ClsRecuitment._recdat; }
             set { ClsRecuitment._recdat = value; }
         }

                public ClsRecuitment() { }
                public ClsRecuitment(string id)
                {
                    Candidate_id = id;
                }


                public void Add()
                {
                    int id;
                    id = Recdat.FindIndex(x => x.Candidate_id == Candidate_id);

                    if (id >= 0)
                        throw new Exception(": Id already Exists");
                    else
                    Recdat.Add(this);
                }



                public int Retrieve()
                {
                    int idx;
                    idx = Recdat.FindIndex(x => x.candidate_id == candidate_id);
                    if (idx != -1)
                    {
                        candidate_id = ClsRecuitment.Recdat[idx].candidate_id;
                        First_Name = ClsRecuitment.Recdat[idx].First_Name;
                        Last_Name = ClsRecuitment.Recdat[idx].Last_Name;
                        Address = ClsRecuitment.Recdat[idx].Address;
                        E_mail = ClsRecuitment.Recdat[idx].E_mail;
                        Phone_number = ClsRecuitment.Recdat[idx].Phone_number;
                        City = ClsRecuitment.Recdat[idx].City;
                        Country = ClsRecuitment.Recdat[idx].Country;
                        Department = ClsRecuitment.Recdat[idx].Department;
                        Gender = ClsRecuitment.Recdat[idx].Gender;
                    }
                    return idx;
                }


                public void saveXLM()
                {
                    XmlSerializer myXML = new XmlSerializer(typeof(List<ClsRecuitment>));
                    try
                    {
                        using (FileStream fs = File.Create("ClsRecruitment.xml"))
                        {
                            myXML.Serialize(fs, _recdat);
                        }
                    
                    }  

                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);

                    }
                }
                public void loadXML()
                {
                    XmlSerializer myXML = new XmlSerializer(typeof(List<ClsRecuitment>));
                    try
                    {
                        using (FileStream fs = File.OpenRead("ClsRecruitment.xml"))
                        {
                            ClsRecuitment._recdat = (List<ClsRecuitment>)myXML.Deserialize(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                public int Delete()
                {
                    int idx;
                    idx = Recdat.FindIndex(x => x.candidate_id == Candidate_id);

                    if (idx != -1)
                        Recdat.RemoveAt(idx);

                    return idx;
                }

                public void Update()
                {
                    int idx;
                    idx = Recdat.FindIndex(x => x.candidate_id == Candidate_id);
                    if (idx == -1)
                    {
                        throw new Exception("Record Not Found");
                    }
                    else if (idx != -1)
                    {
                        ClsRecuitment.Recdat[idx].candidate_id = candidate_id;
                        ClsRecuitment.Recdat[idx].First_Name=  First_Name ;
                        ClsRecuitment.Recdat[idx].Last_Name = Last_Name;
                        ClsRecuitment.Recdat[idx].Address = Address;
                        ClsRecuitment.Recdat[idx].E_mail = E_mail = E_mail;
                        ClsRecuitment.Recdat[idx].Phone_number = Phone_number;
                        ClsRecuitment.Recdat[idx].City = City;
                        ClsRecuitment.Recdat[idx].Country = Country;
                        ClsRecuitment.Recdat[idx].Department = Department;
                        ClsRecuitment.Recdat[idx].Gender = Gender;
                    }
                }

                public static List<ClsRecuitment> login { get; set; }
    }
}
