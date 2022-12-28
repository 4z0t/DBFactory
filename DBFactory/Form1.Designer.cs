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
            this.buttonSkladChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSkladAdd = new System.Windows.Forms.Button();
            this.deleteID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SkladID = new System.Windows.Forms.TextBox();
            this.Region = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Ploshad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonTovarInfo = new System.Windows.Forms.Button();
            this.buttonSellInfo = new System.Windows.Forms.Button();
            this.TovarGiveInfoID = new System.Windows.Forms.TextBox();
            this.SellGiveInfoMinPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SkladGiveInfoRegion = new System.Windows.Forms.TextBox();
            this.buttonSkladInfo = new System.Windows.Forms.Button();
            this.WithoutBuyer = new System.Windows.Forms.Button();
            this.WithoutTovar = new System.Windows.Forms.Button();
            this.WithoutDostavka = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Ploshad1 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Adres1 = new System.Windows.Forms.TextBox();
            this.Region1 = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(301, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Данные таблиц";
            // 
            // buttonDostavka
            // 
            this.buttonDostavka.Location = new System.Drawing.Point(64, 87);
            this.buttonDostavka.Name = "buttonDostavka";
            this.buttonDostavka.Size = new System.Drawing.Size(94, 29);
            this.buttonDostavka.TabIndex = 10;
            this.buttonDostavka.Text = "Детали";
            this.buttonDostavka.UseVisualStyleBackColor = true;
            this.buttonDostavka.Click += new System.EventHandler(this.buttonDetal_Click);
            // 
            // buttonBuyer
            // 
            this.buttonBuyer.Location = new System.Drawing.Point(163, 87);
            this.buttonBuyer.Name = "buttonBuyer";
            this.buttonBuyer.Size = new System.Drawing.Size(103, 29);
            this.buttonBuyer.TabIndex = 11;
            this.buttonBuyer.Text = "Изделия";
            this.buttonBuyer.UseVisualStyleBackColor = true;
            this.buttonBuyer.Click += new System.EventHandler(this.buttonIzdelia_Click);
            // 
            // buttonSeller
            // 
            this.buttonSeller.Location = new System.Drawing.Point(272, 87);
            this.buttonSeller.Name = "buttonSeller";
            this.buttonSeller.Size = new System.Drawing.Size(104, 29);
            this.buttonSeller.TabIndex = 12;
            this.buttonSeller.Text = "Технологии";
            this.buttonSeller.UseVisualStyleBackColor = true;
            this.buttonSeller.Click += new System.EventHandler(this.buttonTech_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.Location = new System.Drawing.Point(382, 87);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(94, 29);
            this.buttonSale.TabIndex = 13;
            this.buttonSale.Text = "Отделы";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.buttonOtdeli_Click);
            // 
            // buttonSklad
            // 
            this.buttonSklad.Location = new System.Drawing.Point(482, 87);
            this.buttonSklad.Name = "buttonSklad";
            this.buttonSklad.Size = new System.Drawing.Size(94, 29);
            this.buttonSklad.TabIndex = 14;
            this.buttonSklad.Text = "Заводы";
            this.buttonSklad.UseVisualStyleBackColor = true;
            this.buttonSklad.Click += new System.EventHandler(this.buttonZavodi_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.Location = new System.Drawing.Point(589, 87);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(103, 29);
            this.buttonTovar.TabIndex = 15;
            this.buttonTovar.Text = "Поставщики";
            this.buttonTovar.UseVisualStyleBackColor = true;
            this.buttonTovar.Click += new System.EventHandler(this.buttonPostavchiki_Click);
            // 
            // buttonTovarDelete
            // 
            this.buttonTovarDelete.Location = new System.Drawing.Point(572, 187);
            this.buttonTovarDelete.Name = "buttonTovarDelete";
            this.buttonTovarDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonTovarDelete.TabIndex = 22;
            this.buttonTovarDelete.Text = "Поставщик";
            this.buttonTovarDelete.UseVisualStyleBackColor = true;
            this.buttonTovarDelete.Click += new System.EventHandler(this.buttonPostavchikDelete_Click);
            // 
            // buttonSkladDelete
            // 
            this.buttonSkladDelete.Location = new System.Drawing.Point(472, 187);
            this.buttonSkladDelete.Name = "buttonSkladDelete";
            this.buttonSkladDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSkladDelete.TabIndex = 21;
            this.buttonSkladDelete.Text = "Завод";
            this.buttonSkladDelete.UseVisualStyleBackColor = true;
            this.buttonSkladDelete.Click += new System.EventHandler(this.buttonZavodDelete_Click);
            // 
            // buttonSellDelete
            // 
            this.buttonSellDelete.Location = new System.Drawing.Point(372, 187);
            this.buttonSellDelete.Name = "buttonSellDelete";
            this.buttonSellDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSellDelete.TabIndex = 20;
            this.buttonSellDelete.Text = "Отдел";
            this.buttonSellDelete.UseVisualStyleBackColor = true;
            this.buttonSellDelete.Click += new System.EventHandler(this.buttonOtdelDelete_Click);
            // 
            // buttonSellerDelete
            // 
            this.buttonSellerDelete.Location = new System.Drawing.Point(272, 187);
            this.buttonSellerDelete.Name = "buttonSellerDelete";
            this.buttonSellerDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonSellerDelete.TabIndex = 19;
            this.buttonSellerDelete.Text = "Технология";
            this.buttonSellerDelete.UseVisualStyleBackColor = true;
            this.buttonSellerDelete.Click += new System.EventHandler(this.buttonTechDelete_Click);
            // 
            // buttonBuyerDelete
            // 
            this.buttonBuyerDelete.Location = new System.Drawing.Point(163, 187);
            this.buttonBuyerDelete.Name = "buttonBuyerDelete";
            this.buttonBuyerDelete.Size = new System.Drawing.Size(103, 29);
            this.buttonBuyerDelete.TabIndex = 18;
            this.buttonBuyerDelete.Text = "Изделие";
            this.buttonBuyerDelete.UseVisualStyleBackColor = true;
            this.buttonBuyerDelete.Click += new System.EventHandler(this.buttonIzdelieDelete_Click);
            // 
            // buttonDostavkaDelete
            // 
            this.buttonDostavkaDelete.Location = new System.Drawing.Point(64, 187);
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
            this.label2.Location = new System.Drawing.Point(262, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Удаление данных по id";
            // 
            // buttonSkladChange
            // 
            this.buttonSkladChange.Location = new System.Drawing.Point(617, 347);
            this.buttonSkladChange.Name = "buttonSkladChange";
            this.buttonSkladChange.Size = new System.Drawing.Size(94, 29);
            this.buttonSkladChange.TabIndex = 24;
            this.buttonSkladChange.Text = "Обновить";
            this.buttonSkladChange.UseVisualStyleBackColor = true;
            this.buttonSkladChange.Click += new System.EventHandler(this.buttonSkladChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(238, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Изменение данных склада";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(235, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Получение информации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(285, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Добавление склада";
            // 
            // buttonSkladAdd
            // 
            this.buttonSkladAdd.Location = new System.Drawing.Point(560, 450);
            this.buttonSkladAdd.Name = "buttonSkladAdd";
            this.buttonSkladAdd.Size = new System.Drawing.Size(106, 29);
            this.buttonSkladAdd.TabIndex = 34;
            this.buttonSkladAdd.Text = "Добавить";
            this.buttonSkladAdd.UseVisualStyleBackColor = true;
            this.buttonSkladAdd.Click += new System.EventHandler(this.buttonSkladAdd_Click);
            // 
            // deleteID
            // 
            this.deleteID.Location = new System.Drawing.Point(276, 236);
            this.deleteID.Name = "deleteID";
            this.deleteID.Size = new System.Drawing.Size(125, 27);
            this.deleteID.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(406, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Код для удаления";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SkladID
            // 
            this.SkladID.Location = new System.Drawing.Point(72, 348);
            this.SkladID.Name = "SkladID";
            this.SkladID.Size = new System.Drawing.Size(94, 27);
            this.SkladID.TabIndex = 37;
            // 
            // Region
            // 
            this.Region.Location = new System.Drawing.Point(171, 348);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(94, 27);
            this.Region.TabIndex = 38;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(272, 348);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(94, 27);
            this.Adres.TabIndex = 39;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(373, 348);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(94, 27);
            this.Number.TabIndex = 40;
            // 
            // Ploshad
            // 
            this.Ploshad.Location = new System.Drawing.Point(472, 348);
            this.Ploshad.Name = "Ploshad";
            this.Ploshad.Size = new System.Drawing.Size(94, 27);
            this.Ploshad.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(81, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Номер склада";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(299, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Адрес";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(198, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Регион";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(390, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Телефон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(491, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Площадь";
            // 
            // buttonTovarInfo
            // 
            this.buttonTovarInfo.Location = new System.Drawing.Point(3, 604);
            this.buttonTovarInfo.Name = "buttonTovarInfo";
            this.buttonTovarInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonTovarInfo.TabIndex = 47;
            this.buttonTovarInfo.Text = "Товары меньше заданного размера";
            this.buttonTovarInfo.UseVisualStyleBackColor = true;
            this.buttonTovarInfo.Click += new System.EventHandler(this.buttonSellerInfo_Click);
            // 
            // buttonSellInfo
            // 
            this.buttonSellInfo.Location = new System.Drawing.Point(265, 604);
            this.buttonSellInfo.Name = "buttonSellInfo";
            this.buttonSellInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonSellInfo.TabIndex = 48;
            this.buttonSellInfo.Text = "Список продаж по минимальной цене";
            this.buttonSellInfo.UseVisualStyleBackColor = true;
            this.buttonSellInfo.Click += new System.EventHandler(this.buttonSellInfo_Click);
            // 
            // TovarGiveInfoID
            // 
            this.TovarGiveInfoID.Location = new System.Drawing.Point(59, 564);
            this.TovarGiveInfoID.Name = "TovarGiveInfoID";
            this.TovarGiveInfoID.Size = new System.Drawing.Size(137, 27);
            this.TovarGiveInfoID.TabIndex = 50;
            // 
            // SellGiveInfoMinPrice
            // 
            this.SellGiveInfoMinPrice.Location = new System.Drawing.Point(327, 564);
            this.SellGiveInfoMinPrice.Name = "SellGiveInfoMinPrice";
            this.SellGiveInfoMinPrice.Size = new System.Drawing.Size(137, 27);
            this.SellGiveInfoMinPrice.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(105, 535);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Размер";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(343, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 53;
            this.label14.Text = "Минимальная цена";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(636, 535);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Регион";
            // 
            // SkladGiveInfoRegion
            // 
            this.SkladGiveInfoRegion.Location = new System.Drawing.Point(589, 564);
            this.SkladGiveInfoRegion.Name = "SkladGiveInfoRegion";
            this.SkladGiveInfoRegion.Size = new System.Drawing.Size(137, 27);
            this.SkladGiveInfoRegion.TabIndex = 55;
            // 
            // buttonSkladInfo
            // 
            this.buttonSkladInfo.Location = new System.Drawing.Point(527, 604);
            this.buttonSkladInfo.Name = "buttonSkladInfo";
            this.buttonSkladInfo.Size = new System.Drawing.Size(256, 71);
            this.buttonSkladInfo.TabIndex = 54;
            this.buttonSkladInfo.Text = "Склады по региону";
            this.buttonSkladInfo.UseVisualStyleBackColor = true;
            this.buttonSkladInfo.Click += new System.EventHandler(this.buttonSkladInfo_Click);
            // 
            // WithoutBuyer
            // 
            this.WithoutBuyer.Location = new System.Drawing.Point(527, 701);
            this.WithoutBuyer.Name = "WithoutBuyer";
            this.WithoutBuyer.Size = new System.Drawing.Size(256, 71);
            this.WithoutBuyer.TabIndex = 59;
            this.WithoutBuyer.Text = "Телефоны покупателей";
            this.WithoutBuyer.UseVisualStyleBackColor = true;
            this.WithoutBuyer.Click += new System.EventHandler(this.WithoutBuyer_Click);
            // 
            // WithoutTovar
            // 
            this.WithoutTovar.Location = new System.Drawing.Point(265, 701);
            this.WithoutTovar.Name = "WithoutTovar";
            this.WithoutTovar.Size = new System.Drawing.Size(256, 71);
            this.WithoutTovar.TabIndex = 58;
            this.WithoutTovar.Text = "Товары весом больше 1кг";
            this.WithoutTovar.UseVisualStyleBackColor = true;
            this.WithoutTovar.Click += new System.EventHandler(this.WithoutTovar_Click);
            // 
            // WithoutDostavka
            // 
            this.WithoutDostavka.Location = new System.Drawing.Point(3, 701);
            this.WithoutDostavka.Name = "WithoutDostavka";
            this.WithoutDostavka.Size = new System.Drawing.Size(256, 71);
            this.WithoutDostavka.TabIndex = 57;
            this.WithoutDostavka.Text = "Даты доставок";
            this.WithoutDostavka.UseVisualStyleBackColor = true;
            this.WithoutDostavka.Click += new System.EventHandler(this.WithoutDostavka_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(446, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Площадь";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(345, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 68;
            this.label16.Text = "Телефон";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(153, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 67;
            this.label17.Text = "Регион";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(254, 427);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 66;
            this.label18.Text = "Адрес";
            // 
            // Ploshad1
            // 
            this.Ploshad1.Location = new System.Drawing.Point(427, 450);
            this.Ploshad1.Name = "Ploshad1";
            this.Ploshad1.Size = new System.Drawing.Size(94, 27);
            this.Ploshad1.TabIndex = 64;
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(328, 450);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(94, 27);
            this.Number1.TabIndex = 63;
            // 
            // Adres1
            // 
            this.Adres1.Location = new System.Drawing.Point(227, 450);
            this.Adres1.Name = "Adres1";
            this.Adres1.Size = new System.Drawing.Size(94, 27);
            this.Adres1.TabIndex = 62;
            // 
            // Region1
            // 
            this.Region1.Location = new System.Drawing.Point(126, 450);
            this.Region1.Name = "Region1";
            this.Region1.Size = new System.Drawing.Size(94, 27);
            this.Region1.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 781);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Ploshad1);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Adres1);
            this.Controls.Add(this.Region1);
            this.Controls.Add(this.WithoutBuyer);
            this.Controls.Add(this.WithoutTovar);
            this.Controls.Add(this.WithoutDostavka);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SkladGiveInfoRegion);
            this.Controls.Add(this.buttonSkladInfo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SellGiveInfoMinPrice);
            this.Controls.Add(this.TovarGiveInfoID);
            this.Controls.Add(this.buttonSellInfo);
            this.Controls.Add(this.buttonTovarInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Ploshad);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.SkladID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteID);
            this.Controls.Add(this.buttonSkladAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSkladChange);
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
        private Button buttonSkladChange;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button buttonSkladAdd;
        private TextBox deleteID;
        private Label label7;
        private TextBox SkladID;
        private TextBox Region;
        private TextBox Adres;
        private TextBox Number;
        private TextBox Ploshad;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonTovarInfo;
        private Button buttonSellInfo;
        private TextBox TovarGiveInfoID;
        private TextBox SellGiveInfoMinPrice;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox SkladGiveInfoRegion;
        private Button buttonSkladInfo;
        private Button WithoutBuyer;
        private Button WithoutTovar;
        private Button WithoutDostavka;
        private Label label5;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox Ploshad1;
        private TextBox Number1;
        private TextBox Adres1;
        private TextBox Region1;
    }
}


