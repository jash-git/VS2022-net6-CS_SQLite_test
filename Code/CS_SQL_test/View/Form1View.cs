using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_SQL_test
{
    public partial class Form1 : Form
    {
        private void button1SetView()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private PersonModel button1GetData()
        {
            PersonModel person=new PersonModel();
            person.FirstName = textBox1.Text;
            person.LastName = textBox2.Text;
            return person;
        }

        private void listBox1Show()
        {
            listBox1.Items.Clear();
            List<PersonModel> LPM_data = SqliteDataAccess.LoadPeople();
            if(LPM_data.Count>0)
            {
                for(int i = 0; i < LPM_data.Count; i++)
                {
                    listBox1.Items.Add(LPM_data[i].FullName);
                }
            }//if(LPM_data.Count>0)
            else
            {
                //
            }//if (LPM_data.Count > 0) else
        }
    }
}
