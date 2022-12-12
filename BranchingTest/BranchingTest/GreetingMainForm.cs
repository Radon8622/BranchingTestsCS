using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void startTestButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TestForm testForm = new TestForm();
            testForm.Show();
            testForm.FormClosed += TestForm_FormClosed;
            startTestButton.Hide();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
