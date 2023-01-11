using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DBFactory
{


    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDostavka = new System.Windows.Forms.Button();
            this.buttonBuyer = new System.Windows.Forms.Button();
            this.buttonSeller = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonSklad = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.buttonTovarDelete = new System.Windows.Forms.Button();
            this.buttonSkladDelete = new System.Windows.Forms.Button();
            this.buttonSellDelete = new System.Windows.Forms.Button();
            this.buttonSellerDelete = new System.Windows.Forms.Button();
            this.buttonBuyerDelete = new System.Windows.Forms.Button();
            this.buttonDostavkaDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDetalEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttoDetalAdd = new System.Windows.Forms.Button();
            this.deleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Detal_id_edit = new System.Windows.Forms.TextBox();
            this.Detal_name_edit = new System.Windows.Forms.TextBox();
            this.Detal_size_edit = new System.Windows.Forms.TextBox();
            this.Detal_weight_edit = new System.Windows.Forms.TextBox();
            this.Detal_date_edit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonTovarInfo = new System.Windows.Forms.Button();
            this.buttonSellInfo = new System.Windows.Forms.Button();
            this.IzdelieMinWeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonSkladInfo = new System.Windows.Forms.Button();
            this.WithoutBuyer = new System.Windows.Forms.Button();
            this.WithoutTovar = new System.Windows.Forms.Button();
            this.WithoutDostavka = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Detal_date_add = new System.Windows.Forms.TextBox();
            this.Detal_weight_add = new System.Windows.Forms.TextBox();
            this.Detal_size_add = new System.Windows.Forms.TextBox();
            this.Detal_name_add = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(789, 29);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(725, 744);
            this.listBox1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Данные таблиц";
            // 
            // buttonDostavka
            // 
            this.buttonDostavka.Location = new System.Drawing.Point(81, 55);
            this.buttonDostavka.Name = "buttonDostavka";
            this.buttonDostavka.Size = new System.Drawing.Size(94, 29);
            this.buttonDostavka.TabIndex = 10;
            this.buttonDostavka.Text = "Детали";
            this.buttonDostavka.UseVisualStyleBackColor = true;
            this.buttonDostavka.Click += new System.EventHandler(this.buttonDetal_Click);
            // 
            // buttonBuyer
            // 
            this.buttonBuyer.Location = new System.Drawing.Point(180, 55);
            this.buttonBuyer.Name = "buttonBuyer";
            this.buttonBuyer.Size = new System.Drawing.Size(103, 29);
            this.buttonBuyer.TabIndex = 11;
            this.buttonBuyer.Text = "Изделия";
            this.buttonBuyer.UseVisualStyleBackColor = true;
            this.buttonBuyer.Click += new System.EventHandler(this.buttonIzdelia_Click);
            // 
            // buttonSeller
            // 
            this.buttonSeller.Location = new System.Drawing.Point(289, 55);
            this.buttonSeller.Name = "buttonSeller";
            this.buttonSeller.Size = new System.Drawing.Size(104, 29);
            this.buttonSeller.TabIndex = 12;
            this.buttonSeller.Text = "Технологии";
            this.buttonSeller.UseVisualStyleBackColor = true;
            this.buttonSeller.Click += new System.EventHandler(this.buttonTech_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(399, 55);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(94, 29);
            this.buttonSale.TabIndex = 13;
            this.buttonSale.Text = "Отделы";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonOtdeli_Click);
            // 
            // buttonSklad
            // 
            this.buttonSklad.Location = new System.Drawing.Point(499, 55);
            this.buttonSklad.Name = "buttonSklad";
            this.buttonSklad.Size = new System.Drawing.Size(94, 29);
            this.buttonSklad.TabIndex = 14;
            this.buttonSklad.Text = "Заводы";
            this.buttonSklad.UseVisualStyleBackColor = true;
            this.buttonSklad.Click += new System.EventHandler(this.buttonZavodi_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.Location = new System.Drawing.Point(606, 55);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(103, 29);
            this.buttonTovar.TabIndex = 15;
            this.buttonTovar.Text = "Поставщики";
            this.buttonTovar.UseVisualStyleBackColor = true;
            this.buttonTovar.Click += new System.EventHandler(this.buttonPostavchiki_Click);
            // 
            // buttonTovarDelete
            // 
            this.buttonTovarDelete.Location = new System.Drawing.Point(572, 162);
            this.buttonTovarDelete.Name = "buttonTovarDelete";
            this.buttonTovarDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonTovarDelete.TabIndex = 22;
            this.buttonTovarDelete.Text = "Поставщик";
            this.buttonTovarDelete.UseVisualStyleBackColor = true;
            this.buttonTovarDelete.Click += new System.EventHandler(this.buttonPostavchikDelete_Click);
            // 
            // buttonSkladDelete
            // 
            this.buttonSkladDelete.Location = new System.Drawing.Point(472, 162);
            this.buttonSkladDelete.Name = "buttonSkladDelete";
            this.buttonSkladDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSkladDelete.TabIndex = 21;
            this.buttonSkladDelete.Text = "Завод";
            this.buttonSkladDelete.UseVisualStyleBackColor = true;
            this.buttonSkladDelete.Click += new System.EventHandler(this.buttonZavodDelete_Click);
            // 
            // buttonSellDelete
            // 
            this.buttonSellDelete.Location = new System.Drawing.Point(372, 162);
            this.buttonSellDelete.Name = "buttonSellDelete";
            this.buttonSellDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSellDelete.TabIndex = 20;
            this.buttonSellDelete.Text = "Отдел";
            this.buttonSellDelete.UseVisualStyleBackColor = true;
            this.buttonSellDelete.Click += new System.EventHandler(this.buttonOtdelDelete_Click);
            // 
            // buttonSellerDelete
            // 
            this.buttonSellerDelete.Location = new System.Drawing.Point(272, 162);
            this.buttonSellerDelete.Name = "buttonSellerDelete";
            this.buttonSellerDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSellerDelete.TabIndex = 19;
            this.buttonSellerDelete.Text = "Технология";
            this.buttonSellerDelete.UseVisualStyleBackColor = true;
            this.buttonSellerDelete.Click += new System.EventHandler(this.buttonTechDelete_Click);
            // 
            // buttonBuyerDelete
            // 
            this.buttonBuyerDelete.Location = new System.Drawing.Point(163, 162);
            this.buttonBuyerDelete.Name = "buttonBuyerDelete";
            this.buttonBuyerDelete.Size = new System.Drawing.Size(103, 29);
            this.buttonBuyerDelete.TabIndex = 18;
            this.buttonBuyerDelete.Text = "Изделие";
            this.buttonBuyerDelete.UseVisualStyleBackColor = true;
            this.buttonBuyerDelete.Click += new System.EventHandler(this.buttonIzdelieDelete_Click);
            // 
            // buttonDostavkaDelete
            // 
            this.buttonDostavkaDelete.Location = new System.Drawing.Point(64, 162);
            this.buttonDostavkaDelete.Name = "buttonDostavkaDelete";
            this.buttonDostavkaDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDostavkaDelete.TabIndex = 17;
            this.buttonDostavkaDelete.Text = "Деталь";
            this.buttonDostavkaDelete.UseVisualStyleBackColor = true;
            this.buttonDostavkaDelete.Click += new System.EventHandler(this.buttonDetalDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Удаление данных по id";
            // 
            // buttonDetalEdit
            // 
            this.buttonDetalEdit.Location = new System.Drawing.Point(631, 318);
            this.buttonDetalEdit.Name = "buttonDetalEdit";
            this.buttonDetalEdit.Size = new System.Drawing.Size(94, 29);
            this.buttonDetalEdit.TabIndex = 24;
            this.buttonDetalEdit.Text = "Обновить";
            this.buttonDetalEdit.UseVisualStyleBackColor = true;
            this.buttonDetalEdit.Click += new System.EventHandler(this.buttonDetalEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(281, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Изменение Детали";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(265, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Получение информации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(328, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Добавление";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(550, 468);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 34;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttonDetalAdd_Click);
            // 
            // deleteID
            // 
            this.deleteID.Location = new System.Drawing.Point(272, 211);
            this.deleteID.Name = "deleteID";
            this.deleteID.Size = new System.Drawing.Size(125, 27);
            this.deleteID.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(402, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Код для удаления";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Detal_id_edit
            // 
            this.Detal_id_edit.Location = new System.Drawing.Point(103, 320);
            this.Detal_id_edit.Name = "Detal_id_edit";
            this.Detal_id_edit.Size = new System.Drawing.Size(94, 27);
            this.Detal_id_edit.TabIndex = 37;
            // 
            // Detal_name_edit
            // 
            this.Detal_name_edit.Location = new System.Drawing.Point(202, 320);
            this.Detal_name_edit.Name = "Detal_name_edit";
            this.Detal_name_edit.Size = new System.Drawing.Size(94, 27);
            this.Detal_name_edit.TabIndex = 38;
            // 
            // Detal_size_edit
            // 
            this.Detal_size_edit.Location = new System.Drawing.Point(303, 320);
            this.Detal_size_edit.Name = "Detal_size_edit";
            this.Detal_size_edit.Size = new System.Drawing.Size(94, 27);
            this.Detal_size_edit.TabIndex = 39;
            // 
            // Detal_weight_edit
            // 
            this.Detal_weight_edit.Location = new System.Drawing.Point(404, 320);
            this.Detal_weight_edit.Name = "Detal_weight_edit";
            this.Detal_weight_edit.Size = new System.Drawing.Size(94, 27);
            this.Detal_weight_edit.TabIndex = 40;
            // 
            // Detal_date_edit
            // 
            this.Detal_date_edit.Location = new System.Drawing.Point(503, 320);
            this.Detal_date_edit.Name = "Detal_date_edit";
            this.Detal_date_edit.Size = new System.Drawing.Size(94, 27);
            this.Detal_date_edit.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(112, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Код детали";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(304, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Размер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(202, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Наименование";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(409, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Вес";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(503, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Срок поставки";
            // 
            // buttonTovarInfo
            // 
            this.buttonTovarInfo.Location = new System.Drawing.Point(3, 615);
            this.buttonTovarInfo.Name = "buttonTovarInfo";
            this.buttonTovarInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonTovarInfo.TabIndex = 47;
            this.buttonTovarInfo.Text = "Изделия и Детали";
            this.buttonTovarInfo.UseVisualStyleBackColor = true;
            this.buttonTovarInfo.Click += new System.EventHandler(this.buttonIzdeliaDetal_Click);
            // 
            // buttonSellInfo
            // 
            this.buttonSellInfo.Location = new System.Drawing.Point(265, 701);
            this.buttonSellInfo.Name = "buttonSellInfo";
            this.buttonSellInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonSellInfo.TabIndex = 48;
            this.buttonSellInfo.Text = "Люди";
            this.buttonSellInfo.UseVisualStyleBackColor = true;
            this.buttonSellInfo.Click += new System.EventHandler(this.buttonPeople_Click);
            // 
            // IzdelieMinWeight
            // 
            this.IzdelieMinWeight.Location = new System.Drawing.Point(328, 582);
            this.IzdelieMinWeight.Name = "IzdelieMinWeight";
            this.IzdelieMinWeight.Size = new System.Drawing.Size(137, 27);
            this.IzdelieMinWeight.TabIndex = 51;
            this.IzdelieMinWeight.TextChanged += new System.EventHandler(this.IzdelieMinWeight_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(345, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Минимальный вес";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // buttonSkladInfo
            // 
            this.buttonSkladInfo.Location = new System.Drawing.Point(527, 615);
            this.buttonSkladInfo.Name = "buttonSkladInfo";
            this.buttonSkladInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonSkladInfo.TabIndex = 54;
            this.buttonSkladInfo.Text = "Детали по убыванию размера";
            this.buttonSkladInfo.UseVisualStyleBackColor = true;
            this.buttonSkladInfo.Click += new System.EventHandler(this.buttonDetalDescSize_Click);
            // 
            // WithoutBuyer
            // 
            this.WithoutBuyer.Location = new System.Drawing.Point(527, 701);
            this.WithoutBuyer.Name = "WithoutBuyer";
            this.WithoutBuyer.Size = new System.Drawing.Size(256, 71);
            this.WithoutBuyer.TabIndex = 59;
            this.WithoutBuyer.Text = "Максимальный вес деталей у поставщиков";
            this.WithoutBuyer.UseVisualStyleBackColor = true;
            this.WithoutBuyer.Click += new System.EventHandler(this.buttonMaxWeightPostavchik);
            // 
            // WithoutTovar
            // 
            this.WithoutTovar.Location = new System.Drawing.Point(262, 615);
            this.WithoutTovar.Name = "WithoutTovar";
            this.WithoutTovar.Size = new System.Drawing.Size(256, 71);
            this.WithoutTovar.TabIndex = 58;
            this.WithoutTovar.Text = "Изделия с заданным минимальным весом";
            this.WithoutTovar.UseVisualStyleBackColor = true;
            this.WithoutTovar.Click += new System.EventHandler(this.buttonIzdelieMinWeight_Click);
            // 
            // WithoutDostavka
            // 
            this.WithoutDostavka.Location = new System.Drawing.Point(3, 701);
            this.WithoutDostavka.Name = "WithoutDostavka";
            this.WithoutDostavka.Size = new System.Drawing.Size(256, 71);
            this.WithoutDostavka.TabIndex = 57;
            this.WithoutDostavka.Text = "Общий вес изделий по заводам";
            this.WithoutDostavka.UseVisualStyleBackColor = true;
            this.WithoutDostavka.Click += new System.EventHandler(this.buttonZavodTotalWeight_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(328, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Вес";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(427, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "Срок поставки";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(126, 445);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 67;
            this.label17.Text = "Наименование";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(227, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Размеры";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Detal_date_add
            // 
            this.Detal_date_add.Location = new System.Drawing.Point(427, 468);
            this.Detal_date_add.Name = "Detal_date_add";
            this.Detal_date_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_date_add.TabIndex = 64;
            this.Detal_date_add.TextChanged += new System.EventHandler(this.Detal_date_add_TextChanged);
            // 
            // Detal_weight_add
            // 
            this.Detal_weight_add.Location = new System.Drawing.Point(328, 468);
            this.Detal_weight_add.Name = "Detal_weight_add";
            this.Detal_weight_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_weight_add.TabIndex = 63;
            // 
            // Detal_size_add
            // 
            this.Detal_size_add.Location = new System.Drawing.Point(227, 468);
            this.Detal_size_add.Name = "Detal_size_add";
            this.Detal_size_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_size_add.TabIndex = 62;
            // 
            // Detal_name_add
            // 
            this.Detal_name_add.Location = new System.Drawing.Point(126, 468);
            this.Detal_name_add.Name = "Detal_name_add";
            this.Detal_name_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_name_add.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 75;
            this.button1.Text = "Поставщики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 74;
            this.button2.Text = "Заводы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(403, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 73;
            this.button3.Text = "Отделы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(293, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 29);
            this.button4.TabIndex = 72;
            this.button4.Text = "Технологии";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 29);
            this.button5.TabIndex = 71;
            this.button5.Text = "Изделия";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 70;
            this.button6.Text = "Детали";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 781);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Detal_date_add);
            this.Controls.Add(this.Detal_weight_add);
            this.Controls.Add(this.Detal_size_add);
            this.Controls.Add(this.Detal_name_add);
            this.Controls.Add(this.WithoutBuyer);
            this.Controls.Add(this.WithoutTovar);
            this.Controls.Add(this.WithoutDostavka);
            this.Controls.Add(this.buttonSkladInfo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.IzdelieMinWeight);
            this.Controls.Add(this.buttonSellInfo);
            this.Controls.Add(this.buttonTovarInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Detal_date_edit);
            this.Controls.Add(this.Detal_weight_edit);
            this.Controls.Add(this.Detal_size_edit);
            this.Controls.Add(this.Detal_name_edit);
            this.Controls.Add(this.Detal_id_edit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteID);
            this.Controls.Add(this.buttoDetalAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDetalEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTovarDelete);
            this.Controls.Add(this.buttonSkladDelete);
            this.Controls.Add(this.buttonSellDelete);
            this.Controls.Add(this.buttonSellerDelete);
            this.Controls.Add(this.buttonBuyerDelete);
            this.Controls.Add(this.buttonDostavkaDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonSklad);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.buttonSeller);
            this.Controls.Add(this.buttonBuyer);
            this.Controls.Add(this.buttonDostavka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Button buttonDostavka;
        private Button buttonBuyer;
        private Button buttonSeller;
        private Button buttonSale;
        private Button buttonSklad;
        private Button buttonTovar;
        private Button buttonTovarDelete;
        private Button buttonSkladDelete;
        private Button buttonSellDelete;
        private Button buttonSellerDelete;
        private Button buttonBuyerDelete;
        private Button buttonDostavkaDelete;
        private Label label2;
        private Button buttonDetalEdit;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button buttoDetalAdd;
        private TextBox deleteID;
        private Label label7;
        private TextBox Detal_id_edit;
        private TextBox Detal_name_edit;
        private TextBox Detal_size_edit;
        private TextBox Detal_weight_edit;
        private TextBox Detal_date_edit;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonTovarInfo;
        private Button buttonSellInfo;
        private TextBox IzdelieMinWeight;
        private Label label14;
        private Button buttonSkladInfo;
        private Button WithoutBuyer;
        private Button WithoutTovar;
        private Button WithoutDostavka;
        private Label label5;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox Detal_date_add;
        private TextBox Detal_weight_add;
        private TextBox Detal_size_add;
        private TextBox Detal_name_add;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}


