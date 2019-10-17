using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableStudentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableStudentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crmDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crmDataSet.TableStudent' table. You can move, or remove it, as needed.
            this.tableStudentTableAdapter.Fill(this.crmDataSet.TableStudent);

        }
    }
}
