namespace DBFactory
{
    partial class ZavodAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FIOText = new System.Windows.Forms.TextBox();
            this.AdressText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.buttoDetalAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(372, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 85;
            this.label5.Text = "ФИО Директора";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(170, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 84;
            this.label17.Text = "Название";
            this.label17.Click += new System.EventHandler(this.label17_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(271, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 16);
            this.label18.TabIndex = 83;
            this.label18.Text = "Адрес";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // FIOText
            // 
            this.FIOText.Location = new System.Drawing.Point(372, 66);
            this.FIOText.Name = "FIOText";
            this.FIOText.Size = new System.Drawing.Size(94, 27);
            this.FIOText.TabIndex = 82;
            this.FIOText.TextChanged += new System.EventHandler(this.Detal_weight_add_TextChanged);
            // 
            // AdressText
            // 
            this.AdressText.Location = new System.Drawing.Point(271, 66);
            this.AdressText.Name = "AdressText";
            this.AdressText.Size = new System.Drawing.Size(94, 27);
            this.AdressText.TabIndex = 81;
            this.AdressText.TextChanged += new System.EventHandler(this.Detal_size_add_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(170, 66);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(94, 27);
            this.NameText.TabIndex = 80;
            this.NameText.TextChanged += new System.EventHandler(this.Detal_name_add_TextChanged);
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(271, 116);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 79;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ZavodAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 214);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FIOText);
            this.Controls.Add(this.AdressText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.buttoDetalAdd);
            this.Name = "ZavodAddForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ZavodAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FIOText;
        private System.Windows.Forms.TextBox AdressText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button buttoDetalAdd;
    }
}