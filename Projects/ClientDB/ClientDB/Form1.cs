using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDB
{
    public partial class Form1 : Form
    {
        private ClientDB CDB;

        public Form1()
        {
            InitializeComponent();
            CDB = new ClientDB("Do Nothing Pty Ltd");
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            if (!CDB.AddClient(inputBox.Text)) {
                MessageBox.Show("Cannot add this client!");
            }
        }

        private void removeClientBtn_Click(object sender, EventArgs e)
        {
            if (!CDB.RemoveClient(inputBox.Text)) {
                MessageBox.Show("Cannot remove this client!");
            }
        }

        private void isClientBtn_Click(object sender, EventArgs e)
        {
            if (CDB.IsAClient(inputBox.Text)) {
                MessageBox.Show("Our client!");
            }
            else {
                MessageBox.Show("Not our client!");
            }
        }
    }
}
