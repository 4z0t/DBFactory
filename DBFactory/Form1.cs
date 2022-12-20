﻿using System;
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

                string query = "SELECT [Наименование], [Размеры], [Срок поставки], [Вес] FROM Деталь AS d";

                DisplayQueryResult(
                    query,
                    "Наименование".PadRight(20) +
                    "Размеры".PadRight(30) +
                    "Срок поставки".PadRight(25) +
                    "Вес".PadRight(10),
                    new int[] { 30, 20, 40, 40 }
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
                    "Код изделия".PadRight(10)+
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

                string query = "SELECT [Код продавца], [Наименование продавца], [Адрес], [Телефон], [ИНН] FROM Продавец";


                DisplayQueryResult(
                    query,
                    "Код продавца".PadRight(20) + "Имя".PadRight(20) + "Адрес".PadRight(20) + "Телефон".PadRight(15) + "ИНН".PadRight(10),
                    new int[] { 30, 20, 20, 20, 10 }
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

                string query = "SELECT [Номер накладной], [Цена], [Количество], [Дата продажи], [Код покупателя], [Код продавца], [Код доставки], [Код товара] FROM Продажа";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(10) +
                    "Цена".PadRight(15) +
                    "Количество".PadRight(15) +
                    "Дата".PadRight(35) +
                    "Покупатель".PadRight(10) +
                    "Продавец".PadRight(10) +
                    "Доставка".PadRight(10) +
                    "Товар".PadRight(15),
                    new int[] { 15, 25, 15, 15, 25, 15 }
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

                string query = "SELECT [Код склада], [Регион], [Адрес], [Телефон], [Площадь] FROM Склад";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(10) + "Регион".PadRight(29) + "Адрес".PadRight(25) + "Телефон".PadRight(25) + "Площадь".PadRight(10),
                    new int[] { 10, 25, 25, 25, 10 }
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

                string query = "SELECT [Код товара], [Наименование товара], [Вес], [Размеры], [Номер склада] FROM Товар";

                DisplayQueryResult(
                    query,
                    "Номер".PadRight(20) + "Название".PadRight(20) + "Вес".PadRight(25) + "Размер".PadRight(15) + "Склад".PadRight(10),
                    new int[] { 30, 25, 25, 25, 10 }
                    );

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally { cn.Close(); }
        }

        private void buttonDostavkaDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Доставка.[Код доставки] FROM Доставка WHERE Доставка.[Код доставки]=" + id_pasient.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Доставка WHERE [Код доставки] =" + id_pasient.ToString();
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

        private void buttonBuyerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Покупатель.[Код покупателя] FROM Покупатель WHERE Покупатель.[Код покупателя]=" + id_pasient.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Покупатель WHERE [Код покупателя] =" + id_pasient.ToString();
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

        private void buttonSellerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Продавец.[Код продавцп] FROM Продавец WHERE Продавец.[Код продавца]=" + id_pasient.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Продавец WHERE [Код продавца] =" + id_pasient.ToString();
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

        private void buttonSellDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Продажа.[Номер накладной] FROM Продажа WHERE Продажа.[Номер накладной]=" + id_pasient.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Продажа WHERE [Номер накладной] =" + id_pasient.ToString();
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

        private void buttonSkladDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Склад.[Код склада] FROM Склад WHERE Склад.[Код склада]=" + id_pasient.ToString();

                if (Exists(query2))
                {
                    string query = "DELETE FROM Склад WHERE [Код склада] =" + id_pasient.ToString();
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

        private void buttonTovarDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int id_pasient = Convert.ToInt32(deleteID.Text);

                string query2 = "SELECT Товар.[Код товара] FROM Товар WHERE Товар.[Код товара]=" + id_pasient.ToString();


                if (Exists(query2))
                {
                    string query = "DELETE FROM Товар WHERE [Код товара] =" + id_pasient.ToString();
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

        private void buttonSellerInfo_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int tip = Convert.ToInt32(TovarGiveInfoID.Text);
                string query = "SELECT * FROM Товар WHERE Размеры<=@tip";
                OleDbCommand command = new OleDbCommand(query, cn);

                command.Parameters.AddWithValue("@tip", tip);

                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                listBox1.Items.Add("Номер".PadRight(20) + "Название".PadRight(20) + "Вес".PadRight(25) + "Размер".PadRight(15) + "Склад".PadRight(10));
                listBox1.Items.Add("");

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString().PadRight(30) + reader[1].ToString().PadRight(25) + reader[2].ToString().PadRight(25) + reader[3].ToString().PadRight(25) + reader[4].ToString().PadRight(10));
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

        private void buttonSellInfo_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                int tip = Convert.ToInt32(SellGiveInfoMinPrice.Text);
                string query = "SELECT * FROM Продажа WHERE Цена>=@tip";
                OleDbCommand command = new OleDbCommand(query, cn);

                command.Parameters.AddWithValue("@tip", tip);

                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();

                listBox1.Items.Add("Номер".PadRight(10) + "Цена".PadRight(15) + "Количество".PadRight(15) + "Дата".PadRight(35) + "Покупатель".PadRight(10) + "Продавец".PadRight(10) + "Доставка".PadRight(10) + "Товар".PadRight(15));
                listBox1.Items.Add("");

                while (reader.Read())
                {
                    listBox1.Items.Add(reader[0].ToString().PadRight(15) + reader[1].ToString().PadRight(25) + reader[2].ToString().PadRight(15) + reader[3].ToString().PadRight(15) + reader[4].ToString().PadRight(15) + reader[5].ToString().PadRight(15) + reader[6].ToString().PadRight(15) + "                     " + reader[7].ToString().PadRight(15));
                }
                reader.Close();
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
                    "Номер".PadRight(20) + "Название".PadRight(20) + "Вес".PadRight(25) + "Размер".PadRight(15) + "Склад".PadRight(10),
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

        private void buttonSkladChange_Click(object sender, EventArgs e)
        {
            try
            {

                cn.Open();

                int id = Convert.ToInt32(SkladID.Text);
                string region = Convert.ToString(Region.Text);
                string adress = Convert.ToString(Adres.Text);
                int number = Convert.ToInt32(Number.Text);
                int size = Convert.ToInt32(Ploshad.Text);

                string query = "UPDATE Склад SET"
                    + " Регион = \"" + region
                    + "\", Адрес = \"" + adress
                    + "\", Телефон = " + number
                    + ", Площадь = " + size
                    + " WHERE [Код склада] =" + id;
                Console.WriteLine(query);
                OleDbCommand command = new OleDbCommand(query, cn);

                command.ExecuteNonQuery();
                MessageBox.Show("Данные о складе обновлены");

                cn.Close();

                try
                {
                    cn.Open();

                    string query1 = "SELECT [Код склада], [Регион], [Адрес], [Телефон], [Площадь] FROM Склад";

                    OleDbCommand command1 = new OleDbCommand(query1, cn);

                    OleDbDataReader reader1 = command1.ExecuteReader();

                    listBox1.Items.Clear();
                    listBox1.Items.Add("Номер".PadRight(10) + "Регион".PadRight(29) + "Адрес".PadRight(25) + "Телефон".PadRight(25) + "Площадь".PadRight(10));
                    listBox1.Items.Add("");

                    while (reader1.Read())
                    {
                        listBox1.Items.Add(reader1[0].ToString().PadRight(10) + reader1[1].ToString().PadRight(25) + reader1[2].ToString().PadRight(25) + reader1[3].ToString().PadRight(25) + reader1[4].ToString().PadRight(10));
                    }
                    reader1.Close();

                    cn.Close();
                }
                catch (Exception exception)
                {
                    cn.Close();
                    MessageBox.Show(exception.Message);
                }

            }
            catch (Exception exception)
            {
                cn.Close();
                MessageBox.Show(exception.Message);
            }

        }

        private void buttonSkladAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string region = Convert.ToString(Region1.Text);
                string adress = Convert.ToString(Adres1.Text);
                int number = Convert.ToInt32(Number1.Text);
                int size = Convert.ToInt32(Ploshad1.Text);

                string query = "INSERT INTO Склад ( [Регион], [Адрес], [Телефон], [Площадь] ) VALUES (" + region + ", '" + adress + "', '" + number + "', '" + size + "')";
                Console.WriteLine(query);
                OleDbCommand command = new OleDbCommand(query, cn);

                command.ExecuteNonQuery();
                MessageBox.Show("Данные о складе обновлены");

                cn.Close();

                try
                {
                    cn.Open();

                    string query1 = "SELECT [Код склада], [Регион], [Адрес], [Телефон], [Площадь] FROM Склад";

                    OleDbCommand command1 = new OleDbCommand(query1, cn);

                    OleDbDataReader reader1 = command1.ExecuteReader();

                    listBox1.Items.Clear();
                    listBox1.Items.Add("Номер".PadRight(10) + "Регион".PadRight(29) + "Адрес".PadRight(25) + "Телефон".PadRight(25) + "Площадь".PadRight(10));
                    listBox1.Items.Add("");

                    while (reader1.Read())
                    {
                        listBox1.Items.Add(reader1[0].ToString().PadRight(10) + reader1[1].ToString().PadRight(25) + reader1[2].ToString().PadRight(25) + reader1[3].ToString().PadRight(25) + reader1[4].ToString().PadRight(10));
                    }
                    reader1.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally { cn.Close(); }
            }
            catch (Exception exception)
            {
                cn.Close();
                MessageBox.Show(exception.Message);
            }
        }
    }

}
