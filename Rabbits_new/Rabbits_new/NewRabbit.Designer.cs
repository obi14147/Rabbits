
namespace Rabbits_new
{
    partial class NewRabbit
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtTmStart = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Jméno";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(54, 108);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(150, 25);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Datum připuštění";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(54, 177);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(93, 25);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Poznámka";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 31);
            this.txtName.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(250, 177);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(317, 31);
            this.txtNote.TabIndex = 4;
            // 
            // dtTmStart
            // 
            this.dtTmStart.Location = new System.Drawing.Point(250, 108);
            this.dtTmStart.Name = "dtTmStart";
            this.dtTmStart.Size = new System.Drawing.Size(317, 31);
            this.dtTmStart.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(147, 304);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Potvrdit";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(344, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Zrušit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NewRabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtTmStart);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblName);
            this.Name = "NewRabbit";
            this.Text = "NewRabbit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtTmStart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}