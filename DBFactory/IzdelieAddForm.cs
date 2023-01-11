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
    public partial class IzdelieAddForm : Form
    {

        private OleDbConnection cn;
        public IzdelieAddForm(OleDbConnection oleDbConnection)
        {
            cn = oleDbConnection;
            InitializeComponent();
        }

        private void buttoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string name = Convert.ToString(NameTB.Text);
                string purpose = Convert.ToString(PurposeTB.Text);
                double weight = Convert.ToDouble(WeightTB.Text);
                int otdel = Convert.ToInt32(OtdelTB.Text);
                int factory = Convert.ToInt32(FactoryTB.Text);
                int tech = Convert.ToInt32(TechTB.Text);




                string query = "INSERT INTO  Изделие ( [Наименование изделия], [Назначение изделия], [Вес изделия], [Номер отдела], [Номер завода], [Код технологии], [Код детали])" +
                    " VALUES (@name, @purpose, @weight, @otdel, @factory, @tech, 1)";


                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                command.Parameters.Add("@name", OleDbType.Char).Value = name;
                command.Parameters.Add("@purpose", OleDbType.Char).Value = purpose;
                command.Parameters.Add("@weight", OleDbType.Double).Value = weight;
                command.Parameters.Add("@otdel", OleDbType.Integer).Value = otdel;
                command.Parameters.Add("@factory", OleDbType.Integer).Value = factory;
                command.Parameters.Add("@tech", OleDbType.Integer).Value = tech;


                command.ExecuteNonQuery();
                MessageBox.Show("Данные о заводах обновлены");


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

        private void TechTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FactoryTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void OtdelTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurposeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
