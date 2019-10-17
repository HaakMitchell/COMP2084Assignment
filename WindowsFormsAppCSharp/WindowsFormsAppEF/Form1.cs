using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableStudent s = new TableStudent();
            s.Email = textBox3.Text;
            s.Name = this.textBox2.Text;
            s.Id = Convert.ToInt32(textBox1.Text);

            crmEntities crmEntities = new crmEntities();

            crmEntities.TableStudents.Add(s);
            crmEntities.SaveChanges();

            if (crmEntities.TableStudents.Any(n => n.Id == s.Id))
            {
                MessageBox.Show(s.Id + "Added!");
            }

         
        }
    }
}
