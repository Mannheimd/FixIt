using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        // Assign variables.
        public string selectedItem = "";
        public bool fail = false;
        public int progress = 0;
        public int delay = 100;
        public bool success = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (success == true)
            {
                label2.Text = "Fixed it!";
            }
            
            // Reset progress bar to 0.
            progressBar1.Value = 0;

            // Retrieve ComboBox selection and assign to string.
            selectedItem = comboBox1.Text;

            // Request a selection be made if no selection has been input in ComboBox.
            if (selectedItem == "")
            {
                label2.Text = "Please provide an issue to fix.";
            }
            // Assuming input is provided, commence progress bar and update status label.
            else
            {
                for (progress = 0; progress < 100; progress = progress + 1)
                {
                    // Asssign strings to status label depending on input from ComboBox.
                    // Further inputs & outputs can be provided by duplicating these statements.
                    if (selectedItem == "Hurt feelings") { label2.Text = "Giving hugs..."; }
                    if (selectedItem == "Dry spell") { label2.Text = "Assuming position..."; }
                    if (selectedItem == "Ex wife") { label2.Text = "Arranging 'accident'..."; }
                    //if (selectedItem == "") { label2.Text = "..."; }

                    progressBar1.PerformStep();

                    if (progressBar1.Value == 100)
                    {
                        // Inform user of successful issue fix.
                        // label2.Text = "Fixed it!";
                        success = true;
                    }
                }
            }
        }
    }
}
