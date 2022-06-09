
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabbitInfo));
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
            this.dataGridInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridInfo.Location = new System.Drawing.Point(13, 51);
            this.dataGridInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInfo.MultiSelect = false;
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersVisible = false;
            this.dataGridInfo.RowHeadersWidth = 62;
            this.dataGridInfo.RowTemplate.Height = 33;
            this.dataGridInfo.Size = new System.Drawing.Size(991, 188);
            this.dataGridInfo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 38);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "name";
            // 
            // dtTmStart
            // 
            this.dtTmStart.CustomFormat = "";
            this.dtTmStart.Location = new System.Drawing.Point(124, 43);
            this.dtTmStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtTmStart.Name = "dtTmStart";
            this.dtTmStart.Size = new System.Drawing.Size(359, 37);
            this.dtTmStart.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(188, 145);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Připustit";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(124, 88);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(359, 37);
            this.txtNote.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(7, 43);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 30);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(7, 88);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(111, 30);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Poznámka";
            // 
            // grBxStart
            // 
            this.grBxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grBxStart.Controls.Add(this.lblDate);
            this.grBxStart.Controls.Add(this.btnStart);
            this.grBxStart.Controls.Add(this.txtNote);
            this.grBxStart.Controls.Add(this.lblNote);
            this.grBxStart.Controls.Add(this.dtTmStart);
            this.grBxStart.Location = new System.Drawing.Point(13, 247);
            this.grBxStart.Margin = new System.Windows.Forms.Padding(4);
            this.grBxStart.Name = "grBxStart";
            this.grBxStart.Padding = new System.Windows.Forms.Padding(4);
            this.grBxStart.Size = new System.Drawing.Size(517, 205);
            this.grBxStart.TabIndex = 7;
            this.grBxStart.TabStop = false;
            this.grBxStart.Text = "Připuštění";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(834, 322);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 50);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Potvrdit";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(641, 322);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 50);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Vytisknout";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // RabbitInfo
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 468);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grBxStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RabbitInfo";
            this.Text = "Podrobnosti";
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