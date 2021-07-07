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
  public   class loginform
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string Username;

        public string Username1
        {
            get { return Username; }
            set { Username = value; }
        }


        private string Password;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }



        public void Add()
        {
            int id;
            id = Login.FindIndex(x => x.id == Id);

            if (id >= 0)
                throw new Exception(": Id already Exists");
            else
                Login.Add(this);
        }


       private static
           
            List<loginform> login = new List<loginform>();

       private static List<loginform> Login;
        
public static List<loginform> Login1
{
  get { return loginform.Login; }
  set { loginform.Login = value; }
}
         public loginform() { }
         public loginform(string id)
                {
                    
                }


public void saveXLM()
{
    XmlSerializer myXML = new XmlSerializer(typeof(List<loginform>));
    try
    {
        using (FileStream fs = File.Create("LoginForm.xml"))
        {
            myXML.Serialize(fs, login);
        }

    }

    catch (Exception ex)
    {
        throw new Exception(ex.Message);

    }
}

}
      
}
