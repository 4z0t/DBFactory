namespace DBFactory
{
    partial class PostavchikAddForm
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
            this.FIOTB = new System.Windows.Forms.TextBox();
            this.AdressTB = new System.Windows.Forms.TextBox();
            this.RegTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.buttoDetalAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(281, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Адрес";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(380, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 101;
            this.label16.Text = "ФИО директора";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(79, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 100;
            this.label17.Text = "Наименование";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(180, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 16);
            this.label18.TabIndex = 99;
            this.label18.Text = "Регион";
            // 
            // FIOTB
            // 
            this.FIOTB.Location = new System.Drawing.Point(380, 59);
            this.FIOTB.Name = "FIOTB";
            this.FIOTB.Size = new System.Drawing.Size(94, 27);
            this.FIOTB.TabIndex = 98;
            // 
            // AdressTB
            // 
            this.AdressTB.Location = new System.Drawing.Point(281, 59);
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(94, 27);
            this.AdressTB.TabIndex = 97;
            // 
            // RegTB
            // 
            this.RegTB.Location = new System.Drawing.Point(180, 59);
            this.RegTB.Name = "RegTB";
            this.RegTB.Size = new System.Drawing.Size(94, 27);
            this.RegTB.TabIndex = 96;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(79, 59);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(94, 27);
            this.NameTB.TabIndex = 95;
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(230, 107);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 94;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttoDetalAdd_Click);
            // 
            // PostavchikAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 184);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FIOTB);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.RegTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.buttoDetalAdd);
            this.Name = "PostavchikAddForm";
            this.Text = "PostavchikAddForm";
            this.Load += new System.EventHandler(this.PostavchikAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FIOTB;
        private System.Windows.Forms.TextBox AdressTB;
        private System.Windows.Forms.TextBox RegTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button buttoDetalAdd;
    }
}