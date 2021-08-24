using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nicoidSearch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("ID", listView1.Width / 4);
            listView1.Columns.Add("Title", listView1.Width - listView1.Columns[0].Width - 10);

            toolStripStatusLabel1.Visible = false;
            toolStripProgressBar1.Visible = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Visible = true;
            toolStripProgressBar1.Visible = true;
            var filelist = System.IO.Directory.GetFiles(textBoxDirectory.Text, "*.json");

            int filenum = filelist.Length;
            toolStripProgressBar1.Maximum = filenum - 1;

            for (int i = 0; i<filenum; i++)
            {
                toolStripStatusLabel1.Text = i.ToString() + "/" + filenum.ToString();
                toolStripProgressBar1.Value = i;
                statusStrip1.Update();

                try
                {
                    var info = NicoidJson.Load(filelist[i]);

                    listView1.Items.Add(new ListViewItem(new string[] { info.id, info.title }));
                }
                catch { }

                Application.DoEvents();
            }

            toolStripStatusLabel1.Visible = false;
            toolStripProgressBar1.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
