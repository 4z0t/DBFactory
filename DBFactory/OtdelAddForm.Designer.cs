namespace DBFactory
{
    partial class OtdelAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.FIOTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FactoryTB = new System.Windows.Forms.TextBox();
            this.buttoDetalAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "ФИО начальника";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FIOTB
            // 
            this.FIOTB.Location = new System.Drawing.Point(222, 50);
            this.FIOTB.Name = "FIOTB";
            this.FIOTB.Size = new System.Drawing.Size(185, 27);
            this.FIOTB.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Номер завода";
            // 
            // FactoryTB
            // 
            this.FactoryTB.Location = new System.Drawing.Point(122, 50);
            this.FactoryTB.Name = "FactoryTB";
            this.FactoryTB.Size = new System.Drawing.Size(94, 27);
            this.FactoryTB.TabIndex = 94;
            // 
            // buttoDetalAdd
            // 
            this.buttoDetalAdd.Location = new System.Drawing.Point(209, 109);
            this.buttoDetalAdd.Name = "buttoDetalAdd";
            this.buttoDetalAdd.Size = new System.Drawing.Size(106, 29);
            this.buttoDetalAdd.TabIndex = 98;
            this.buttoDetalAdd.Text = "Добавить";
            this.buttoDetalAdd.UseVisualStyleBackColor = true;
            this.buttoDetalAdd.Click += new System.EventHandler(this.buttoDetalAdd_Click);
            // 
            // OtdelAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 174);
            this.Controls.Add(this.buttoDetalAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactoryTB);
            this.Name = "OtdelAddForm";
            this.Text = "OtdelAddForm";
            this.Load += new System.EventHandler(this.OtdelAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIOTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FactoryTB;
        private System.Windows.Forms.Button buttoDetalAdd;
    }
}