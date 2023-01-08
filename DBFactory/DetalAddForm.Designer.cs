namespace DBFactory
{
    partial class DetalAddForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Detal_date_add = new System.Windows.Forms.TextBox();
            this.Detal_weight_add = new System.Windows.Forms.TextBox();
            this.Detal_size_add = new System.Windows.Forms.TextBox();
            this.Detal_name_add = new System.Windows.Forms.TextBox();
            this.buttoDetalAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PostCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(272, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Вес";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(371, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 77;
            this.label16.Text = "Срок поставки";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(70, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 76;
            this.label17.Text = "Наименование";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(171, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 75;
            this.label18.Text = "Размеры";
            // 
            // Detal_date_add
            // 
            this.Detal_date_add.Location = new System.Drawing.Point(371, 53);
            this.Detal_date_add.Name = "Detal_date_add";
            this.Detal_date_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_date_add.TabIndex = 74;
            // 
            // Detal_weight_add
            // 
            this.Detal_weight_add.Location = new System.Drawing.Point(272, 53);
            this.Detal_weight_add.Name = "Detal_weight_add";
            this.Detal_weight_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_weight_add.TabIndex = 73;
            // 
            // Detal_size_add
            // 
            this.Detal_size_add.Location = new System.Drawing.Point(171, 53);
            this.Detal_size_add.Name = "Detal_size_add";
            this.Detal_size_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_size_add.TabIndex = 72;
            // 
            // Detal_name_add
            // 
            this.Detal_name_add.Location = new System.Drawing.Point(70, 53);
            this.Detal_name_add.Name = "Detal_name_add";
            this.Detal_name_add.Size = new System.Drawing.Size(94, 27);
            this.Detal_name_add.TabIndex = 71;
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(266, 101);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 70;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttoDetalAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(471, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "Код поставщика";
            // 
            // PostCode
            // 
            this.PostCode.Location = new System.Drawing.Point(471, 53);
            this.PostCode.Name = "PostCode";
            this.PostCode.Size = new System.Drawing.Size(94, 27);
            this.PostCode.TabIndex = 79;
            // 
            // DetalAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Detal_date_add);
            this.Controls.Add(this.Detal_weight_add);
            this.Controls.Add(this.Detal_size_add);
            this.Controls.Add(this.Detal_name_add);
            this.Controls.Add(this.buttoDetalAdd);
            this.Name = "DetalAddForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Detal_date_add;
        private System.Windows.Forms.TextBox Detal_weight_add;
        private System.Windows.Forms.TextBox Detal_size_add;
        private System.Windows.Forms.TextBox Detal_name_add;
        private System.Windows.Forms.Button buttoDetalAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostCode;
    }
}