
namespace Rabbits_new
{
    partial class RabbitInfo
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
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.dtTmStart = new System.Windows.Forms.DateTimePicker();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grBxStart = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printRabbitInfo = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.grBxStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.AllowUserToAddRows = false;
            this.dataGridInfo.AllowUserToDeleteRows = false;
            this.dataGridInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(42, 64);
            this.dataGridInfo.MultiSelect = false;
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersVisible = false;
            this.dataGridInfo.RowHeadersWidth = 62;
            this.dataGridInfo.RowTemplate.Height = 33;
            this.dataGridInfo.Size = new System.Drawing.Size(761, 193);
            this.dataGridInfo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            // 
            // dtTmStart
            // 
            this.dtTmStart.CustomFormat = "";
            this.dtTmStart.Location = new System.Drawing.Point(103, 36);
            this.dtTmStart.Name = "dtTmStart";
            this.dtTmStart.Size = new System.Drawing.Size(300, 31);
            this.dtTmStart.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Připustit";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(103, 73);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(300, 31);
            this.txtNote.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(6, 73);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(93, 25);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Poznámka";
            // 
            // grBxStart
            // 
            this.grBxStart.Controls.Add(this.lblDate);
            this.grBxStart.Controls.Add(this.btnStart);
            this.grBxStart.Controls.Add(this.txtNote);
            this.grBxStart.Controls.Add(this.lblNote);
            this.grBxStart.Controls.Add(this.dtTmStart);
            this.grBxStart.Location = new System.Drawing.Point(42, 263);
            this.grBxStart.Name = "grBxStart";
            this.grBxStart.Size = new System.Drawing.Size(431, 171);
            this.grBxStart.TabIndex = 7;
            this.grBxStart.TabStop = false;
            this.grBxStart.Text = "Připuštění";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(604, 363);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Potrvdit";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(604, 290);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 34);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Vytisknout";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // RabbitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 458);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grBxStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridInfo);
            this.Name = "RabbitInfo";
            this.Text = "RabbitInfo";
            this.Deactivate += new System.EventHandler(this.RabbitInfo_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.grBxStart.ResumeLayout(false);
            this.grBxStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtTmStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.GroupBox grBxStart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printRabbitInfo;
    }
}