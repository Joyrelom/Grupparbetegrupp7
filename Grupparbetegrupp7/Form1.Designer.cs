namespace Grupparbetegrupp7
{
    partial class Form1
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
            this.cmdSok = new System.Windows.Forms.Button();
            this.txtSok = new System.Windows.Forms.TextBox();
            this.cmdTaBort = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.cmdAndra = new System.Windows.Forms.Button();
            this.cmdSpara = new System.Windows.Forms.Button();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.listRecept = new System.Windows.Forms.ListBox();
            this.cxtAmne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSok
            // 
            this.cmdSok.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSok.Location = new System.Drawing.Point(22, 19);
            this.cmdSok.Name = "cmdSok";
            this.cmdSok.Size = new System.Drawing.Size(92, 32);
            this.cmdSok.TabIndex = 0;
            this.cmdSok.Text = "Sök";
            this.cmdSok.UseVisualStyleBackColor = true;
            // 
            // txtSok
            // 
            this.txtSok.Location = new System.Drawing.Point(120, 28);
            this.txtSok.Name = "txtSok";
            this.txtSok.Size = new System.Drawing.Size(265, 20);
            this.txtSok.TabIndex = 1;
            // 
            // cmdTaBort
            // 
            this.cmdTaBort.Location = new System.Drawing.Point(236, 417);
            this.cmdTaBort.Name = "cmdTaBort";
            this.cmdTaBort.Size = new System.Drawing.Size(75, 23);
            this.cmdTaBort.TabIndex = 2;
            this.cmdTaBort.Text = "Ta bort recept";
            this.cmdTaBort.UseVisualStyleBackColor = true;
            this.cmdTaBort.Click += new System.EventHandler(this.cmdTaBort_Click);
            // 
            // rtxt
            // 
            this.rtxt.Location = new System.Drawing.Point(16, 116);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(295, 295);
            this.rtxt.TabIndex = 3;
            this.rtxt.Text = "";
            // 
            // cmdAndra
            // 
            this.cmdAndra.Location = new System.Drawing.Point(155, 417);
            this.cmdAndra.Name = "cmdAndra";
            this.cmdAndra.Size = new System.Drawing.Size(75, 23);
            this.cmdAndra.TabIndex = 4;
            this.cmdAndra.Text = " Ändra recept";
            this.cmdAndra.UseVisualStyleBackColor = true;
            this.cmdAndra.Click += new System.EventHandler(this.cmdAndra_Click);
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(16, 417);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(121, 23);
            this.cmdSpara.TabIndex = 5;
            this.cmdSpara.Text = "Spara recept";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSpara_Click);
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(64, 24);
            this.txtTitel.Multiline = true;
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(217, 25);
            this.txtTitel.TabIndex = 6;
            // 
            // listRecept
            // 
            this.listRecept.FormattingEnabled = true;
            this.listRecept.Location = new System.Drawing.Point(22, 68);
            this.listRecept.Name = "listRecept";
            this.listRecept.Size = new System.Drawing.Size(363, 368);
            this.listRecept.TabIndex = 7;
            // 
            // cxtAmne
            // 
            this.cxtAmne.FormattingEnabled = true;
            this.cxtAmne.Items.AddRange(new object[] {
            "Kött",
            "Fisk",
            "Sallader",
            "Soppor",
            "Desserter/Kakor"});
            this.cxtAmne.Location = new System.Drawing.Point(64, 58);
            this.cxtAmne.Name = "cxtAmne";
            this.cxtAmne.Size = new System.Drawing.Size(121, 21);
            this.cxtAmne.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ämne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Beskrivning";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTitel);
            this.groupBox1.Controls.Add(this.rtxt);
            this.groupBox1.Controls.Add(this.cmdTaBort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmdAndra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdSpara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cxtAmne);
            this.groupBox1.Location = new System.Drawing.Point(63, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 453);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listRecept);
            this.groupBox2.Controls.Add(this.cmdSok);
            this.groupBox2.Controls.Add(this.txtSok);
            this.groupBox2.Location = new System.Drawing.Point(464, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 453);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSok;
        private System.Windows.Forms.TextBox txtSok;
        private System.Windows.Forms.Button cmdTaBort;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button cmdAndra;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.ListBox listRecept;
        private System.Windows.Forms.ComboBox cxtAmne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

