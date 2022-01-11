using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class ColorsForm : Form
    {
        public ColorsForm()
        {
            InitializeComponent();
        }

        private void applyColorButton_Click(object sender, EventArgs e)
        {
            if (foreWhiteRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.White;
            }
            else if (foreYellowRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.Yellow;
            }
            else if (foreRedRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.Red;
            }
            else if (foreBlueRadioButton.Checked)
            {
                outputLabel.ForeColor = Color.Blue;
            }
            
            if (backWhiteRadioButton.Checked)
            {
                outputLabel.BackColor = Color.White;
            }
            else if (backYellowRadioButton.Checked)
            {
                outputLabel.BackColor = Color.Yellow;
            }
            else if (backRedRadioButton.Checked)
            {
                outputLabel.BackColor = Color.Red;
            }
            else if (backBlueRadioButton.Checked)
            {
                outputLabel.BackColor = Color.Blue;
            }
        }
    }
}
