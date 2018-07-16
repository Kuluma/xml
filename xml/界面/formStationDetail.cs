using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xml.界面
{
    public partial class formStationDetail : Form
    {
        public formStationDetail()
        {
            InitializeComponent();
        }

        private void formStationDetail_Load(object sender, EventArgs e)
        {


            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "车站";
            dataGridView1.Columns.Add(col1);
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "股道";
            dataGridView1.Columns.Add(col2);
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "可接车类型";
            dataGridView1.Columns.Add(col3);
            int count1 = 0;
            int count2 = 0;
            dataGridView1.Rows.Clear();


            foreach (String DevBtn in PublicValue.DevBtn1)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[count1].Cells[0].Value = DevBtn;
                if (DevBtn == null)
                {
                    dataGridView1.Rows[count1].Cells[0].Style.BackColor = Color.Yellow;
                }
                count1 += 1;
            }
            foreach (String InterLocBtn in PublicValue.InterLocBtn1)
            {

                if (count2 < count1)
                {
                    dataGridView1.Rows[count2].Cells[1].Value = InterLocBtn;
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[count2].Cells[1].Value = InterLocBtn;
                }
                if (InterLocBtn == null)
                {
                    dataGridView1.Rows[count2].Cells[1].Style.BackColor = Color.Yellow;
                }
                count2 += 1;
            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            PublicValue.DevBtn1.Clear();
            PublicValue.InterLocBtn1.Clear();
        }
    }
}
