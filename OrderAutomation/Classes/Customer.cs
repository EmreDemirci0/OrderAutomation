using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using OrderAutomation.Forms;
namespace OrderAutomation
{
    class Customer
    {
        public string FirstName { get; set; }
        public string Adress { get; set; }
        private string[]  Name;

        public Customer()
        {
            Name = System.IO.File.ReadAllLines(Application.StartupPath+"\\IdPw.txt");

            Adress = "Şehit Ahmet Yağız Sokak No 1 daire 1.Turugutlu\\Manisa";
            FirstName = Name[0];
        }       

    }
}
