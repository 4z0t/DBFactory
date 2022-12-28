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
    public partial class Form1 : Form
    {
        const string PATH = "D:\\Git\\DBFactory\\DBFactory\\6.accdb";

        OleDbConnection cn;
        public Form1()
        {
            cn = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + PATH
            );
            InitializeComponent();
        }

        private void AddToListBox(ListBox lb, OleDbDataReader reader, int[] padding)
        {
            StringBuilder stringBuilder = new StringBuilder();
            while (reader.Read())
            {
                for (int i = 0; i < padding.Length; i++)
                {
                    stringBuilder.Append(reader[i].ToString().PadRight(padding[i]));
                }
                lb.Items.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }
        }

        private bool Exists(string query)
        {
            OleDbCommand command = new OleDbCommand(query, cn);
            OleDbDataReader reader = command.ExecuteReader();
            bool exists = false;
            while (reader.Read())
            {
                exists = true;
                break;
            }
            reader.Close();
            return exists;
        }

        private void DisplayQueryResult(string query, string titleString, int[] padding)
        {
            OleDbCommand command = new OleDbCommand(query, cn);

            OleDbDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();
            listBox1.Items.Add(titleString);
            listBox1.Items.Add("");

            AddToListBox(listBox1, reader, padding);
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonDetal_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Деталь AS d";

                DisplayQueryResult(
                    query,
                    "Код".PadRight(10) +
                    "Наименование".PadRight(20) +
                    "Размеры".PadRight(30) +
                    "Срок поставки".PadRight(25) +
                    "Вес".PadRight(10),
                    new int[] { 10, 30, 20, 40, 40 }
                    );

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonIzdelia_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Изделие";

                DisplayQueryResult(
                    query,
                    "Код".PadRight(10) +
                    "Наименование".PadRight(20) +
                    "Назначение".PadRight(20) +
                    "Вес".PadRight(20) +
                    "Код технологии".PadRight(15),
                    new int[] { 10, 30, 30, 20, 10 }
                    );


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonTech_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM [Технология изготовления]";


                DisplayQueryResult(
                    query,
                    "Код".PadRight(20) +
                    "Описание".PadRight(20) +
                    "Разрабочик".PadRight(20) +
                    "Продолжительность".PadRight(15),
                    new int[] { 10, 40, 40, 20 }
                    );


            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonOtdeli_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Отдел";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(10) +
                    "ФИО начальника".PadRight(15) +
                    "Номер завода".PadRight(15),
                    new int[] { 10, 50, 15 }
                    );

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonZavodi_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Завод";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(10) +
                    "Название".PadRight(29) +
                    "Адрес".PadRight(25) +
                    "ФИО директора".PadRight(25),

                    new int[] { 10, 25, 25, 25 }
                    );


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonPostavchiki_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Поставщик";

                DisplayQueryResult(
                    query,
                    "Код".PadRight(20) +
                    "Наименование".PadRight(20) +
                    "Регион".PadRight(25) +
                    "Адрес".PadRight(15) +
                    "ФИО Директора".PadRight(10),
                    new int[] { 10, 25, 25, 25, 10 }
                    );

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonDetalDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int entryId = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT d.[Код детали] FROM Деталь AS d WHERE d.[Код детали]=" + entryId.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Деталь WHERE [Код детали] =" + entryId.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonIzdelieDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int entryId = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Iz.[Код изделия] FROM Изделие AS Iz WHERE Iz.[Код изделия]=" + entryId.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Изделие WHERE [Код изделия] =" + entryId.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonTechDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int entryId = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT TI.[Код технологии] FROM [Технология изготовления] AS TI WHERE TI.[Код технологии]=" + entryId.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM [Технология изготовления] WHERE [Код технологии] =" + entryId.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonOtdelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int entryId = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT ot.[Номер отдела] FROM Отдел AS ot WHERE ot.[Номер отдела]=" + entryId.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Отдел WHERE [Номер отдела] =" + entryId.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonZavodDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int entryId = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT za.[Номер завода] FROM Завод AS za WHERE za.[Номер завода]=" + entryId.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Завод WHERE [Номер завода] =" + entryId.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonPostavchikDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT po.[Код поставщика] FROM Поставщик AS po WHERE po.[Код поставщика]=" + id_pasient.ToString();


                if (Exists(query2))
                {
                    string query = "DELETE FROM Поставщик WHERE [Код поставщика] =" + id_pasient.ToString();
                    OleDbCommand command = new OleDbCommand(query, cn);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные о записи удалены");
                }
                else
                {
                    MessageBox.Show("Записи не существует");
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonIzdeliaDetal_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT i.[Код изделия],i.[Наименование изделия], d.[Код детали],d.Наименование FROM Изделие AS i LEFT JOIN ([Изделие-Деталь] AS i_d LEFT JOIN Деталь AS d ON i_d.[Код детали]=d.[Код детали]) ON i_d.[Код изделия]=i.[Код изделия];";

                DisplayQueryResult(
                    query,
                    "Код изделия".PadRight(30) +
                    "Наименование изделия".PadRight(30) +
                    "Код детали".PadRight(30) +
                    "Наименование детали",
                    new int[] { 30, 30, 30, 30 }
                    );


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "(SELECT [ФИО директора] FROM Завод) UNION (SELECT [ФИО Директора] FROM Поставщик) UNION (SELECT [ФИО начальника] FROM Отдел) UNION (SELECT Разработчик FROM [Технология изготовления]);";
                DisplayQueryResult(
                    query,
                    "ФИО",
                    new int[] { 0 }

                    );
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonSkladInfo_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string tip = Convert.ToString(SkladGiveInfoRegion.Text);
                string query = "SELECT * FROM Склад WHERE Регион=@tip";
                OleDbCommand command = new OleDbCommand(query, cn);

                command.Parameters.AddWithValue("@tip", tip);

                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                listBox1.Items.Add("Номер".PadRight(10) + "Регион".PadRight(29) + "Адрес".PadRight(25) + "Телефон".PadRight(25) + "Площадь".PadRight(10));
                listBox1.Items.Add("");

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString().PadRight(10) + reader[1].ToString().PadRight(25) + reader[2].ToString().PadRight(25) + reader[3].ToString().PadRight(25) + reader[4].ToString().PadRight(10));
                }
                reader.Close();



            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void WithoutTovar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();


                string query = "SELECT * FROM Товар WHERE Вес>1";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(20) +
                    "Название".PadRight(20) +
                    "Вес".PadRight(25) +
                    "Размер".PadRight(15) +
                    "Склад".PadRight(10),
                    new int[] { 30, 25, 25, 25, 10 }
                    );
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void WithoutBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();


                string query = "SELECT [Код покупателя], [Телефон] FROM Покупатель";
                OleDbCommand command = new OleDbCommand(query, cn);


                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                listBox1.Items.Add("Код покупателя".PadRight(15) + "Телефон".PadRight(20));
                listBox1.Items.Add("");

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString().PadRight(30) + reader[1].ToString().PadRight(25));
                }
                reader.Close();


                cn.Close();
            }
            catch (Exception exception)
            {
                cn.Close();
                MessageBox.Show(exception.Message);
            }
        }

        private void WithoutDostavka_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();


                string query = "SELECT [Код доставки], [Дата] FROM Доставка";
                OleDbCommand command = new OleDbCommand(query, cn);


                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                listBox1.Items.Add("Код доставки".PadRight(15) + "Дата".PadRight(20));
                listBox1.Items.Add("");

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString().PadRight(20) + reader[1].ToString().PadRight(25));
                }
                reader.Close();



            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void buttonDetalEdit_Click(object sender, EventArgs e)
        {
            try
            {

                cn.Open();




                int id = Convert.ToInt32(Detal_id_edit.Text);
                string query = "UPDATE Деталь SET";
                bool hasDate = false;
                DateTime date = DateTime.Now;
                if (Detal_name_edit.Text.Length != 0)
                {
                    string name = Convert.ToString(Detal_name_edit.Text);
                    query += " Наименование = \"" + name + "\",";
                }

                if (Detal_size_edit.Text.Length != 0)
                {
                    int size = Convert.ToInt32(Detal_size_edit.Text);
                    query += "Размеры = " + size + ",";

                }
                if (Detal_weight_edit.Text.Length != 0)
                {
                    int weight = Convert.ToInt32(Detal_weight_edit.Text);

                    query += "Вес = " + weight + ",";

                }
                if (Detal_date_edit.Text.Length != 0)
                {
                    date = Convert.ToDateTime(Detal_date_edit.Text);
                    hasDate = true;
                    query += "[Срок Поставки] =@date,";

                }


                query += " [Код поставщика]=1 "
              + " WHERE [Код детали] =" + id;




                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                if (hasDate)
                    command.Parameters.Add("@date", OleDbType.Date).Value = date;
                command.ExecuteNonQuery();
                MessageBox.Show("Данные о складе обновлены");

                cn.Close();


                cn.Open();

                string query1 = "SELECT * FROM Деталь AS d";

                DisplayQueryResult(
                    query1,
                    "Код".PadRight(10) +
                    "Наименование".PadRight(20) +
                    "Размеры".PadRight(30) +
                    "Срок поставки".PadRight(25) +
                    "Вес".PadRight(10),
                    new int[] { 10, 30, 20, 40, 40 }
                    );



            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); };

        }

        private void buttonDetalAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string name = Convert.ToString(Detal_name_add.Text);
                int size = Convert.ToInt32(Detal_size_add.Text);
                int weight = Convert.ToInt32(Detal_weight_add.Text);
                DateTime date = Convert.ToDateTime(Detal_date_add.Text);

                string query = "INSERT INTO Деталь ( [Наименование], [Размеры], [Срок поставки], [Вес], [Код поставщика] )" +
                    " VALUES ('" + name + "', " + size + ", @date, " + weight + ",1)";
                Console.WriteLine(query);
                OleDbCommand command = new OleDbCommand();
                command.CommandText = query;
                command.Connection = cn;
                command.Parameters.Add("@date", OleDbType.Date).Value = date;

                command.ExecuteNonQuery();
                MessageBox.Show("Данные о складе обновлены");

                cn.Close();

                cn.Open();

                string query1 = "SELECT * FROM Деталь AS d";

                DisplayQueryResult(
                    query1,
                    "Код".PadRight(10) +
                    "Наименование".PadRight(20) +
                    "Размеры".PadRight(30) +
                    "Срок поставки".PadRight(25) +
                    "Вес".PadRight(10),
                    new int[] { 10, 30, 20, 40, 40 }
                    );

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
