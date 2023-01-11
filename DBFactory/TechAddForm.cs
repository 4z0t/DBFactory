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
    public partial class TechAddForm : Form
    {
        private OleDbConnection cn;
        public TechAddForm(OleDbConnection oleDbConnection)
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
          





                string query = "INSERT INTO  [Технология изготовления] ( [Описание], [Разработчик], [Продолжительность])" +
                    " VALUES (@name, @purpose, @weight)";


                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                command.Parameters.Add("@name", OleDbType.Char).Value = name;
                command.Parameters.Add("@purpose", OleDbType.Char).Value = purpose;
                command.Parameters.Add("@weight", OleDbType.Char).Value = weight;
       



                command.ExecuteNonQuery();
                MessageBox.Show("Данные о Технологиях обновлены");


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

        private void TechAddForm_Load(object sender, EventArgs e)
        {
            Text = "Добавление технологии изготовления";
        }
    }
}
