using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASimulation
{
    public partial class Form1 : Form
        
    {
        MyContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new MyContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db.AppUsers.ToList();
        }
    }
}
