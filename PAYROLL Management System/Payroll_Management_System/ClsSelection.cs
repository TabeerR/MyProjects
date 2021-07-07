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
    public class clsSelection : ClsRecuitment
    {
        private string _employeeid;
        public string Employeeid
        {
            get { return _employeeid; }
            set { _employeeid = value; }
        }
        private static List<clsSelection> _selectiondat = new List<clsSelection>();
        public static List<clsSelection> SelectionData
        {
            get { return clsSelection._selectiondat; }
            set { clsSelection._selectiondat = value; }
        }

        public clsSelection()
        {
        }
        public clsSelection(int CandidateID)
        {
            Candidate_id = Candidate_id;
           // _Candidateid = CandidateID;
        }

        public int RetrieveS()
        {
            int idx;
            idx = SelectionData.FindIndex(x => x.Employeeid == Employeeid);
            if (idx != -1)
            {
                First_Name = clsSelection.SelectionData[idx].First_Name;
                Last_Name = clsSelection.SelectionData[idx].Last_Name;
                Address = clsSelection.SelectionData[idx].Address;
                E_mail = clsSelection.SelectionData[idx].E_mail;
                Phone_number = clsSelection.SelectionData[idx].Phone_number;
                City = clsSelection.SelectionData[idx].City;
                Gender = clsSelection.SelectionData[idx].Gender;
                Country = clsSelection.SelectionData[idx].Country;
                Department = clsSelection.SelectionData[idx].Department;
                   
            }
            return idx;
        }
        public int DeleteS()
        {
            int idx;
            idx = SelectionData.FindIndex(x => x.Candidate_id == Candidate_id);
            if (idx != -1)
            {
                SelectionData.RemoveAt(idx);
            }
            else if (idx == -1)
            {
                throw new Exception("Record not found");
            }
            return idx;
        }
        public void CreateSel()
        {
            int idx;
            idx = SelectionData.FindIndex(x => x.Candidate_id == Candidate_id);
            if (idx != -1)
                throw new Exception("Id Already exists");
            SelectionData.Add(this);
        }

        public void LoadXML()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsSelection>));
            try
            {
                using (FileStream fs = File.OpenRead("ClsSelection.xml"))
                {
                    clsSelection._selectiondat = (List<clsSelection>)myXML.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SaveXLM()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsSelection>));
            try
            {
                using (FileStream fs = File.Create("ClsSelection.xml"))
                {
                    myXML.Serialize(fs, _selectiondat);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

    }
    public class clsSearch
    {

    }
}