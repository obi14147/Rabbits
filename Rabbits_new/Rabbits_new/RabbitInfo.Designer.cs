
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
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
            this.dataGridInfo.ColumnHeadersVisible = false;
            this.dataGridInfo.Location = new System.Drawing.Point(42, 54);
            this.dataGridInfo.MultiSelect = false;
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.ReadOnly = true;
            this.dataGridInfo.RowHeadersVisible = false;
            this.dataGridInfo.RowHeadersWidth = 62;
            this.dataGridInfo.RowTemplate.Height = 33;
            this.dataGridInfo.Size = new System.Drawing.Size(742, 290);
            this.dataGridInfo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 1;
            // 
            // dtTmStart
            // 
            this.dtTmStart.CustomFormat = "";
            this.dtTmStart.Location = new System.Drawing.Point(146, 350);
            this.dtTmStart.Name = "dtTmStart";
            this.dtTmStart.Size = new System.Drawing.Size(300, 31);
            this.dtTmStart.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(465, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Připustit";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(146, 404);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(300, 31);
            this.txtNote.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 351);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 25);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Datum:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(42, 404);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(93, 25);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Poznámka";
            // 
            // RabbitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 452);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dtTmStart);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridInfo);
            this.Name = "RabbitInfo";
            this.Text = "RabbitInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
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
    }
}