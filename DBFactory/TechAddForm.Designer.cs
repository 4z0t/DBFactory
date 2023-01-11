namespace DBFactory
{
    partial class TechAddForm
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
            this.label5.Location = new System.Drawing.Point(317, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 111;
            this.label5.Text = "Продолжительность";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(82, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 109;
            this.label17.Text = "Описание";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(183, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 108;
            this.label18.Text = "Разработчик";
            // 
            // AdressTB
            // 
            this.AdressTB.Location = new System.Drawing.Point(317, 65);
            this.AdressTB.Name = "AdressTB";
            this.AdressTB.Size = new System.Drawing.Size(111, 27);
            this.AdressTB.TabIndex = 106;
            // 
            // RegTB
            // 
            this.RegTB.Location = new System.Drawing.Point(183, 65);
            this.RegTB.Name = "RegTB";
            this.RegTB.Size = new System.Drawing.Size(128, 27);
            this.RegTB.TabIndex = 105;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(82, 65);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(94, 27);
            this.NameTB.TabIndex = 104;
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(233, 113);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 103;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttoDetalAdd_Click);
            // 
            // TechAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 205);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.AdressTB);
            this.Controls.Add(this.RegTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.buttoDetalAdd);
            this.Name = "TechAddForm";
            this.Text = "TechAddForm";
            this.Load += new System.EventHandler(this.TechAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AdressTB;
        private System.Windows.Forms.TextBox RegTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button buttoDetalAdd;
    }
}