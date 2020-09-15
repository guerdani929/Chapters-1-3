using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapters_1_3
{
    public partial class MainForm : Form
    {
        double height;
        int age;
        string name;
        
        public MainForm()
        {
            InitializeComponent();
            


        }   
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            name = txtName.Text;
            
            age = Convert.ToInt32(numUD.Value);
            int exp = 82 - age;

            height = Convert.ToDouble(txtHeight.Text);
            double tallheig = 272 - height;
            double finalh = tallheig / 100;
            double heigh = Math.Round(finalh, 2);



            lblState.Text = $"Hello {name},";

            lblStateA.Text = $"You're currently {exp} away from the average life expectancy.";

            lblStateH.Text = $"The tallest man in the world is { heigh } m taller than you.";


        }

        private void numUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
