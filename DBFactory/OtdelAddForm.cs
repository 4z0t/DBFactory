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
    public partial class OtdelAddForm : Form
    {

        private OleDbConnection cn;
        public OtdelAddForm(OleDbConnection oleDbConnection)
        {
            cn = oleDbConnection;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttoDetalAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string name = Convert.ToString(FIOTB.Text);
              
                int factory = Convert.ToInt32(FactoryTB.Text);
              




                string query = "INSERT INTO  Отдел ( [ФИО начальника],  [Номер завода])" +
                    " VALUES (@name, @factory)";


                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                command.Parameters.Add("@name", OleDbType.Char).Value = name;
                command.Parameters.Add("@factory", OleDbType.Integer).Value = factory;


                command.ExecuteNonQuery();
                MessageBox.Show("Данные об отделах обновлены");


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
