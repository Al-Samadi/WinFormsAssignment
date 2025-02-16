using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st_App_in_CSharp
{
    public partial class Form1 : Form
    {
        Color SelectedColor;
        string gender;
        Boolean colorChecked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorChooser = new ColorDialog();

            if(colorChooser.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorChooser.Color;
                colorChecked = true ;
            }
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.txbName.Text.Trim() == "")
            {
                this.Result.Text = "No Result , you have to complete the Name field";
            }
            else if (this.txbPass.Text.Trim() == "")
            {
                this.Result.Text = "No Result , you have to complete the Password field";
            }
            else if (this.txbEmail.Text.Trim() == "")
            {
                this.Result.Text = "No Result , you have to complete the Email field";
            }
            else if (this.txbEmail.Text.Contains("@gmail.com"))
            {

                if (this.rbMale.Checked)
                {
                    gender = "Male";
                }
                else if (this.rbFemale.Checked)
                {
                    gender = "Female";
                }

                if(colorChecked == false)
                {
                    this.Result.Text = "No Result , you have to Choose a color";
                }
                else if(cbCountry.SelectedItem == null) {
                    this.Result.Text = "No Result , you have to Select Your Country";
                }
                else
                {
                    this.Result.Text = "\" " + this.txbName.Text  + ", " + this.txbEmail.Text.Trim() + ", " + gender + ", Favorite Color :  " + SelectedColor.Name.ToString() + ",\n Birthdate : " + this.dateTimePicker1.Value.ToString() + ", Country : " + this.cbCountry.SelectedItem.ToString() + "\"";
                }
            }

            else
            {
                this.Result.Text = "No Result , make sure that you wrote the email correctly";
            }
        }
    }
}
