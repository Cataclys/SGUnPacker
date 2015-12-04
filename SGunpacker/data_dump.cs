using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGunpacker
{
    class data_dump
    {
        public static void Read_Type(Label data_dir, Label file_count, ProgressBar pBar, DataGridView dgv)
        {
            try
            {
                StreetgearsDataCipher.Open(data_dir.Text + "\\res.000");  
                 file_count.Text = "File Count: " + StreetgearsDataCipher.sg_data.Count.ToString();
                 dgv.RowCount = StreetgearsDataCipher.sg_data.Count + 1;
                //for (int i = 0; i <  10000; i++)
                for (int i = 0; i < StreetgearsDataCipher.sg_data.Count; i++)

                {
                            dgv.Rows[i].Cells[0].Value = StreetgearsDataCipher.sg_data[i].name;
                            dgv.Rows[i].Cells[1].Value = StreetgearsDataCipher.sg_data[i].hash;
                            dgv.Rows[i].Cells[2].Value = StreetgearsDataCipher.sg_data[i].size;
                            dgv.Rows[i].Cells[3].Value = StreetgearsDataCipher.sg_data[i].DataID;
                            dgv.Rows[i].Cells[4].Value = StreetgearsDataCipher.sg_data[i].offset;                 
                }
                        dgv.Sort(dgv.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch (Exception e)
            {
               
                MessageBox.Show("res.000 not found!" +e , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Dump_All(Label data_dir, Label dump_dir, ProgressBar pBar)
        {
            pBar.Value = 0;
            pBar.Maximum = StreetgearsDataCipher.sg_data.Count;
            foreach (SGDATA_INDEX sg_index in StreetgearsDataCipher.sg_data)
            {
                StreetgearsDataCipher.DumpFile(data_dir.Text, dump_dir.Text + "\\" + Path.GetExtension(sg_index.name).Replace(".", ""), sg_index.name, sg_index.offset, sg_index.DataID, sg_index.size);
                pBar.Value++;
            }
        }
    }
}
