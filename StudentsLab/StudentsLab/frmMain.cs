using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsLab
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void studentLabBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentLabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsLabsDataSet);

        }

        private void studentLabBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentLabBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsLabsDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsLabsDataSet.StudentLab". При необходимости она может быть перемещена или удалена.
            this.studentLabTableAdapter.Fill(this.studentsLabsDataSet.StudentLab);

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentLabel_Click(object sender, EventArgs e)
        {

        }

        private void studentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wasAttendedLabel_Click(object sender, EventArgs e)
        {

        }

        private void wasAttendedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}
