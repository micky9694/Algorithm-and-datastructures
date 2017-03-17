using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoublyLinkedList<int> d = new DoublyLinkedList<int>();
            d.AddToEnd(1);
            d.AddToEnd(2);
            d.AddToEnd(3);
            d.AddToEnd(4);
            d.PrintList();
        }
    }
}
