
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
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtTmBirth = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmBoxSex = new System.Windows.Forms.ComboBox();
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
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(54, 108);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(138, 25);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "Datum narození";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(54, 222);
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
            this.txtNote.Location = new System.Drawing.Point(250, 222);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(317, 31);
            this.txtNote.TabIndex = 4;
            // 
            // dtTmBirth
            // 
            this.dtTmBirth.Location = new System.Drawing.Point(250, 108);
            this.dtTmBirth.Name = "dtTmBirth";
            this.dtTmBirth.Size = new System.Drawing.Size(317, 31);
            this.dtTmBirth.TabIndex = 5;
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
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(54, 164);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(68, 25);
            this.lblSex.TabIndex = 8;
            this.lblSex.Text = "Pohlaví";
            // 
            // cmBoxSex
            // 
            this.cmBoxSex.FormattingEnabled = true;
            this.cmBoxSex.Items.AddRange(new object[] {
            "Samica",
            "Samec"});
            this.cmBoxSex.Location = new System.Drawing.Point(250, 164);
            this.cmBoxSex.Name = "cmBoxSex";
            this.cmBoxSex.Size = new System.Drawing.Size(317, 33);
            this.cmBoxSex.TabIndex = 9;
            this.cmBoxSex.Text = "Samica";
            // 
            // NewRabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.cmBoxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtTmBirth);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblName);
            this.Name = "NewRabbit";
            this.Text = "NewRabbit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtTmBirth;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmBoxSex;
    }
}