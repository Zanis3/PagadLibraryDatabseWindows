using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagadLibraryDatabseWindows
{
    public partial class UCAdminViewLogs : UserControl
    {
        public UCAdminViewLogs()
        {
            InitializeComponent();
            tblViewLogs.AutoGenerateColumns = true;
            loadLogs("SELECT * FROM Log");
        }

        private void loadLogs(string query)
        {
            tblViewLogs.DataSource = null;
            SqlConnection conn = new SqlConnection(Extra.connectionString);

            try
            {
                conn.Open();
                SqlCommand viewLogs = new SqlCommand(query, conn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(viewLogs);
                DataTable logData = new DataTable();
                dataAdapter.Fill(logData);

                if (logData.Rows.Count > 0)
                {
                    tblViewLogs.DataSource = logData;
                }
                else
                {
                    Extra.showNoticeMessage("No data found.");
                }
            }
            catch (Exception ex)
            {
                Extra.showException(ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
