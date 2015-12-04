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

namespace SGunpacker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void list_btn_Click(object sender, EventArgs e)
        {
            try
            {
                data_dump.Read_Type(data_dir, file_count, progressBar3, dgv3);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error loading Items! " + ex.ToString());
            }
        }

        private void dump_a_Click(object sender, EventArgs e)
        {
            data_dump.Dump_All(data_dir,dump_dir,progressBar3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data_dir.Text = Properties.Settings.Default.SGPath;
            dump_dir.Text = Properties.Settings.Default.UnpackPath;
        }

        private void data_dir_Click(object sender, EventArgs e)
        {
            FBD.Reset();
            FBD.ShowDialog();
            data_dir.Text = FBD.SelectedPath;
            Properties.Settings.Default.SGPath = data_dir.Text = FBD.SelectedPath;
            Properties.Settings.Default.Save();
        }

        private void dump_dir_Click(object sender, EventArgs e)
        {
            FBD.Reset();
            FBD.ShowDialog();
            dump_dir.Text = FBD.SelectedPath;
            Properties.Settings.Default.UnpackPath = dump_dir.Text = FBD.SelectedPath;
            Properties.Settings.Default.Save();
        }
    }
}
