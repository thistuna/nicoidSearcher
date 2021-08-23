using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nicoidSearch
{
    class VideoInfo
    {
        public string id { get; set; }
        public string title { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("ID",listView1.Width/4);
            listView1.Columns.Add("Title", listView1.Width - listView1.Columns[0].Width);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
