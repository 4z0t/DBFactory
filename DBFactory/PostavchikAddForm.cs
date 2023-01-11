using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFactory
{
    public partial class PostavchikAddForm : Form
    {
        private OleDbConnection cn;
        public PostavchikAddForm(OleDbConnection oleDbConnection)
        {
            cn = oleDbConnection;
            InitializeComponent();
        }

        private void buttoDetalAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string name = Convert.ToString(NameTB.Text);
                string purpose = Convert.ToString(RegTB.Text);
                string weight = Convert.ToString(AdressTB.Text);
                string otdel = Convert.ToString(FIOTB.Text);
             




                string query = "INSERT INTO  Поставщик ( [Наименование], [Регион], [Адрес], [ФИО Директора])" +
                    " VALUES (@name, @purpose, @weight, @otdel)";


                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                command.Parameters.Add("@name", OleDbType.Char).Value = name;
                command.Parameters.Add("@purpose", OleDbType.Char).Value = purpose;
                command.Parameters.Add("@weight", OleDbType.Char).Value = weight;
                command.Parameters.Add("@otdel", OleDbType.Char).Value = otdel;
                


                command.ExecuteNonQuery();
                MessageBox.Show("Данные о поставщиках обновлены");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cn.Close();
                this.Close();
            }
        }
    }
}
