using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatic_idle_task_processor
{
    public partial class Form1 : Form
    {

        public bool exit = false;
        bool hidden = false;


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("💚 Thanks for using Auto-ITP! \n\nAn optimization instance is already running, click hide to run only in the background.");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

            if(e.ClickedItem.Name.ToString() == "Exit")
            {
                this.Close();
                exit = true;
                
            }
            else if(e.ClickedItem.Name.ToString() == "Hide")
            {
                if (hidden)
                {
                    Show();
                    hidden = false;
                }
                else if(!hidden)
                {
                    Hide();
                    hidden = true;
                }
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            hidden = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unsupported version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.RunRundll();
            MessageBox.Show("Successfully executed.", "Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (hidden)
            {
                Show();
                hidden = false;
            }
        }
    }
}
