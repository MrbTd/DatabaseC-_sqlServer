using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        DataTable dtCourses = new DataTable();
        DataTable dtSelectedCourses = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCoursesTable();
            SelectedCoursesTable();

            listBox1.DataSource = dtCourses;
            listBox1.DisplayMember = "CourseName";

            listBox2.DataSource = dtSelectedCourses;
            listBox2.DisplayMember = "CourseName";


        }

        private void FillCoursesTable()
        {
            dtCourses.Columns.Add("CourseID", typeof(int));
            dtCourses.Columns.Add("CourseName");
            dtCourses.Columns.Add("CourseDuration");

            dtCourses.Rows.Add(1, "Advanced OOP", "4 Months");
            dtCourses.Rows.Add(2, "Formal Method", "3 Months");
            dtCourses.Rows.Add(3, "Web Enginer", "2 Months");
            dtCourses.Rows.Add(4, "ITC ", "1 Months");

        }

        private void SelectedCoursesTable()
        {
            dtSelectedCourses.Columns.Add("CourseID", typeof(int));
            dtSelectedCourses.Columns.Add("CourseName");
            dtSelectedCourses.Columns.Add("CourseDuration");

           

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                dtCourses.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void RmvBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void AddAllBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                int Count = dtCourses.Rows.Count;
                for(int i = 0 ; i< Count; i++)
                {
                    dtSelectedCourses.ImportRow(dtCourses.Rows[listBox1.SelectedIndex]);
                    dtCourses.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void RmvAllBtn_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Count > 0)
            {
                int Count = dtSelectedCourses.Rows.Count;
                for (int i = 0; i < Count; i++)
                {
                    dtCourses.ImportRow(dtSelectedCourses.Rows[listBox2.SelectedIndex]);
                    dtSelectedCourses.Rows[listBox2.SelectedIndex].Delete();
                }
                   
            }
        }

        private void finalizeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Etes vous sur voulez vous finalize","INFORMATION",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                dataGridView1.DataSource = dtSelectedCourses;

                dataGridView1.Enabled = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.RowHeadersVisible = false;

                dataGridView1.Columns[1].Width = 350;
                dataGridView1.Columns[2].Width = 500;

            }
            else
            {
             MessageBox.Show("Stp selectionne une course", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
