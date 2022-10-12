using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    using ClassLibrary;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           AddTimeToUserName userTimeName = new AddTimeToUserName();

             if (!string.IsNullOrWhiteSpace(textName.Text) && ! greetingOutput.Items.Contains(textName.Text))
                 greetingOutput.Items.Add($"Hello, {textName.Text}!"); 

          /*  if (!string.IsNullOrWhiteSpace(textName.Text) && !greetingOutput.Items.Contains(textName.Text))
                greetingOutput.Items.Add(userTimeName.AddTime(textName.Text)); */

        }
    }
}
