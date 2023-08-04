using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvpActionSimple.IViews;
using MvpActionSimple.Presenters;

namespace MvpActionSimple
{
    public partial class Form1 : Form, IView
    {
        public string UserText { get => textBox1.Text; set => textBox1.Text = value; }
        public string OuterText { get => label2.Text; set => label2.Text = value; }

        public event Action UpdateText;

        public Form1()
        {
            InitializeComponent();
            //Presenter present = new Presenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateText?.Invoke();
        }
    }
}
