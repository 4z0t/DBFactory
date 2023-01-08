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
    public partial class ZavodAddForm : Form
    {

        private OleDbConnection _cn;
        public ZavodAddForm(OleDbConnection cn)
        {
            _cn = cn;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _cn.Open();


                string name = Convert.ToString(NameText.Text);
                string adress = Convert.ToString(AdressText.Text);
                string fio = Convert.ToString(FIOText.Text);

                if (name.Length == 0 || fio.Length == 0 || adress.Length == 0) throw new Exception("Поля не могут быть пустыми!");

                string query = "INSERT INTO  Завод ( [Название], [Адрес], [ФИО директора])" +
                    " VALUES ('" + name + "', '" + adress + "', '" + fio + "')";
                OleDbCommand command = new OleDbCommand(query, _cn);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные о заводах обновлены");


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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void buttoDetalAdd_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Detal_weight_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Detal_size_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void Detal_name_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
