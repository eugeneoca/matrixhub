using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Hub
{
    class ThreadSafe
    {
        // ClearListBox
        private delegate void ClearListCallBack(ListBox c);
        public static void ClearList(ListBox c)
        {
            if (c.InvokeRequired)
            {
                ClearListCallBack d = new ClearListCallBack(ClearList);
                c.BeginInvoke(d, c);
            }
            else
            {
                c.Items.Clear();
            }
        }

        // CloneListBox
        private delegate void CloneListCallBack(DataGridView dgv_table, DataGridView dgv_original_matrix);
        public static void CloneList(DataGridView dgv_table, DataGridView dgv_original_matrix)
        {
            if (dgv_table.InvokeRequired && dgv_original_matrix.InvokeRequired)
            {
                CloneListCallBack d = new CloneListCallBack(CloneList);
                dgv_table.BeginInvoke(d, dgv_table, dgv_original_matrix);
            }
            else
            {
                int size = dgv_table.Rows.Count;
                DataTable m = new DataTable("matrix");
                for (int k = 1; k <= size; k++)
                {
                    m.Columns.Add("X" + (k));
                }
                for (int k = 1; k <= size; k++)
                {
                    m.Rows.Add();
                }
                DataSet database = new DataSet();
                database.Tables.Add(m);
                dgv_original_matrix.AutoGenerateColumns = true;
                dgv_original_matrix.DataSource = database;
                dgv_original_matrix.DataMember = "matrix";
                m.Columns.Add("C");
                for (int k = 0; k < size; k++)
                {
                    for (int w = 0; w <= size; w++)
                    {
                        dgv_original_matrix.Rows[k].Cells[w].Value = dgv_table.Rows[k].Cells[w].Value;
                    }
                }
            }
        }

        // AddItemListBox
        private delegate void AddItemListCallBack(ListBox c, object str);
        public static void AddList(ListBox c, object str)
        {
            if (c.InvokeRequired)
            {
                AddItemListCallBack d = new AddItemListCallBack(AddList);
                c.BeginInvoke(d, c, str);
            }
            else
            {
                c.Items.Add(str);
            }
        }

        // SetTopIndexListBox
        private delegate void SetTopIndexListCallBack(ListBox c, int i);
        public static void SetIndexList(ListBox c, int i)
        {
            if (c.InvokeRequired)
            {
                SetTopIndexListCallBack d = new SetTopIndexListCallBack(SetIndexList);
                c.BeginInvoke(d, c, i);
            }
            else
            {
                c.TopIndex = i;
            }
        }

        // DisableButton
        private delegate void DisableButtonCallBack(Button c);
        public static void DisableBTN(Button c)
        {
            if (c.InvokeRequired)
            {
                DisableButtonCallBack d = new DisableButtonCallBack(DisableBTN);
                c.BeginInvoke(d, c);
            }
            else
            {
                if (c.Enabled == true)
                {
                    c.Enabled = false;
                }
                else
                {
                    c.Enabled = true;
                }
            }
        }
    }
}
