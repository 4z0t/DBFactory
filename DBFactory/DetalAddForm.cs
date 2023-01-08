using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DBFactory
{
    public partial class DetalAddForm : Form
    {

        private OleDbConnection _cn;

        public DetalAddForm(OleDbConnection cn)
        {
            _cn = cn;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttoDetalAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _cn.Open();

                string name = Convert.ToString(Detal_name_add.Text);
                int size = Convert.ToInt32(Detal_size_add.Text);
                int weight = Convert.ToInt32(Detal_weight_add.Text);
                DateTime date = Convert.ToDateTime(Detal_date_add.Text);
                int code = Convert.ToInt32(PostCode.Text);

                string query = "INSERT INTO Деталь ( [Наименование], [Размеры], [Срок поставки], [Вес], [Код поставщика] )" +
                    " VALUES ('" + name + "', " + size + ", @date, " + weight + "," + code + ")";
                Console.WriteLine(query);
                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = _cn;
                command.Parameters.Add("@date", OleDbType.Date).Value = date;

                command.ExecuteNonQuery();
                MessageBox.Show("Данные о складе обновлены");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                _cn.Close();
                this.Close();
            }

        }
    }
}
