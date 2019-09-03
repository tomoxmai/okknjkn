﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
            textBox1.Text = "www.google.com";

       }

        private void Btnir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);

        }

        private void Btnatras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Btnagreg_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(webBrowser1.Url.ToString());
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==(char)Keys.Return)
            {
                webBrowser1.Navigate(textBox1.Text);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.SelectedItem.ToString());
        }
    }
}
