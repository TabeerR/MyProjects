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
    public class clsAttendence
    {
        private string _EmployeeName;
        private double _EmployeeBasicPay;
        private int _EmployeeSalaryYear;
        public int EmployeeSalaryYear
        {
            get { return _EmployeeSalaryYear; }
            set
            {
               
                if (value >= 2019)
                {
                    _EmployeeSalaryYear = value;
                }
                else
                {
                    
                    throw new Exception("Invalid Salary Year");
                   
                }
            }
        }

        private int _EmployeeID;
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Error! Employee ID cannot be a negative value or zero");
                }
                else
                {
                    _EmployeeID = value;
                }
            }
        }
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }
        public double EmployeeBasicPay
        {
            get { return _EmployeeBasicPay; }
            set { _EmployeeBasicPay = value; }
        }
        private int _EmployeeDaysOnTime, _EmployeeDaysLate, _EmployeeAbsent;

        public int EmployeeAbsent
        {
            get { return _EmployeeAbsent; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Applicant Name");
                }
                else
                {
                    _EmployeeAbsent = value;
                }
            }
        }
        public int EmployeeDaysLate
        {
            get { return _EmployeeDaysLate; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Applicant Name");
                }
                else
                {
                    _EmployeeDaysLate = value;
                }
            }
        }
        public int EmployeeDaysOnTime
        {
            get { return _EmployeeDaysOnTime; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid Applicant Name");
                }
                else
                {
                    _EmployeeDaysOnTime = value;
                }
            }
        }
        private string _EmployeeSalaryMonth;
        public string EmployeeSalaryMonth
        {
            get { return _EmployeeSalaryMonth; }
            set
            {
                if (value == "January" || value == "February" || value == "March")
                {
                    _EmployeeSalaryMonth = value;
                }
                else if (value == "April" || value == "May" || value == "June")
                {
                    _EmployeeSalaryMonth = value;
                }
                else if (value == "July" || value == "August" || value == "September")
                {
                    _EmployeeSalaryMonth = value;
                }
                else if (value == "October" || value == "November" || value == "December")
                {
                    _EmployeeSalaryMonth = value;
                }
                else
                {
                    throw new Exception("Invalid Salary Month");
                }
            }
        }
        private static List<clsAttendence> _AttendenceData = new List<clsAttendence>();
        public static List<clsAttendence> AttendenceData
        {
            get { return clsAttendence._AttendenceData; }
            set { clsAttendence._AttendenceData = value; }
        }
        public void Create()
        {
            int idx;
            idx = AttendenceData.FindIndex(x => x._EmployeeID == _EmployeeID);
            if (idx != -1)
                throw new Exception("Attendence ID: " + EmployeeID + " already exists");

            _AttendenceData.Add(this);
        }
        public int Delete()
        {
            int idx;
            idx = AttendenceData.FindIndex(x => x.EmployeeID == EmployeeID);
            if (idx != -1)
            {
                AttendenceData.RemoveAt(idx);
            }
            else if (idx == -1)
            {
                new Exception("Record Not Found");
            }
            return idx;
        }

        public int Retrieve()
        {
            clsHiring hir = new clsHiring();
            clsAttendence Attend = new clsAttendence();
            Attend.EmployeeID = EmployeeID;
            int idx;
            idx = AttendenceData.FindIndex(x => x.EmployeeID == EmployeeID);
            if (idx != -1)
            {
                EmployeeName = clsAttendence.AttendenceData[idx]._EmployeeName;
                EmployeeBasicPay = clsAttendence.AttendenceData[idx].EmployeeBasicPay;
                EmployeeDaysOnTime = clsAttendence.AttendenceData[idx].EmployeeDaysOnTime;
                EmployeeDaysLate = clsAttendence.AttendenceData[idx].EmployeeDaysLate;
                EmployeeAbsent = clsAttendence.AttendenceData[idx].EmployeeAbsent;
              //  EmployeeSalaryMonth = clsAttendence.AttendenceData[idx].EmployeeSalaryMonth;
                EmployeeSalaryMonth = clsAttendence.AttendenceData[idx].EmployeeSalaryMonth;
                EmployeeSalaryYear = clsAttendence.AttendenceData[idx].EmployeeSalaryYear;
            }
            else if (idx == -1)
            {
                new Exception("Record Not Found");
            }
            return idx;
        }
        public void Update()
        {
            int idx;
            idx = AttendenceData.FindIndex(x => x.EmployeeID == EmployeeID);
            if (idx == -1)
            {
                throw new Exception("Record Not Found");
            }
            else if (idx != -1)
            {
                clsAttendence.AttendenceData[idx].EmployeeDaysOnTime = EmployeeDaysOnTime;
                clsAttendence.AttendenceData[idx].EmployeeDaysLate = EmployeeDaysLate;
                clsAttendence.AttendenceData[idx].EmployeeAbsent = EmployeeAbsent;
                clsAttendence.AttendenceData[idx].EmployeeSalaryMonth = EmployeeSalaryMonth;
                clsAttendence.AttendenceData[idx].EmployeeSalaryYear = EmployeeSalaryYear;
            }
        }
        public int SRetieve()
        {
            clsHiring hir = new clsHiring();
            clsAttendence att = new clsAttendence();
          //  Payroll pay = new Payroll();
            int idx;
            idx = AttendenceData.FindIndex(x => x.EmployeeID == EmployeeID);

            if (idx != -1)
            {
                EmployeeDaysOnTime = clsAttendence.AttendenceData[idx].EmployeeDaysOnTime;
                EmployeeDaysLate = clsAttendence.AttendenceData[idx].EmployeeDaysLate;
                EmployeeAbsent = clsAttendence.AttendenceData[idx].EmployeeAbsent;
                EmployeeSalaryMonth = clsAttendence.AttendenceData[idx].EmployeeSalaryMonth;
                EmployeeSalaryMonth = clsAttendence.AttendenceData[idx].EmployeeSalaryMonth;
                EmployeeSalaryYear = clsAttendence.AttendenceData[idx].EmployeeSalaryYear;
                EmployeeBasicPay = clsAttendence.AttendenceData[idx].EmployeeBasicPay;


            }
            else if (idx == -1)
            {
                throw new Exception("Record // Not Found");
            }
            return idx;
        }
        public void SaveXML()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsAttendence>));

            try
            {
                using (FileStream fs = File.Create("AttendData.xml"))
                {
                    myXML.Serialize(fs, _AttendenceData);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void LoadXML()
        {
            XmlSerializer myXML = new XmlSerializer(typeof(List<clsAttendence>));
            try
            {
                using (FileStream fs = File.OpenRead("AttendData.xml"))
                {
                    clsAttendence.AttendenceData = (List<clsAttendence>)myXML.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
