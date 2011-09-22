using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Missle_Crisis
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void cardbutton_Click(object sender, EventArgs e)
        {
            
            label1.Text = "testing";
            // Will place card action info here

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Missle Crisis \n2-Play Edition 2011 \nby Connor Belanger \n \nUpdate# 1.01", "About");
        }

        private void nukebutton_Click(object sender, EventArgs e)
        {
            label1.Text = "Nuke Fired!";
            // Will  place fire nuke parametiers here and action
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Click Draw Card to pick a card. \n2. If you get a nuke with the get a nuke card you can choose to fire it. \n3. Firing a nuke will move you back 4 spaces and the opponent back to start. \n4. Have fun!", "Rules");
        }

        

        }
    }

