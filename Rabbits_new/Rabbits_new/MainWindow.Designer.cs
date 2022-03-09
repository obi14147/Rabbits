
namespace Rabbits_new
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridRabbits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRabbits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRabbits
            // 
            this.dataGridRabbits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridRabbits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRabbits.Location = new System.Drawing.Point(54, 54);
            this.dataGridRabbits.MultiSelect = false;
            this.dataGridRabbits.Name = "dataGridRabbits";
            this.dataGridRabbits.ReadOnly = true;
            this.dataGridRabbits.RowHeadersVisible = false;
            this.dataGridRabbits.RowHeadersWidth = 62;
            this.dataGridRabbits.RowTemplate.Height = 33;
            this.dataGridRabbits.Size = new System.Drawing.Size(861, 334);
            this.dataGridRabbits.TabIndex = 0;
            this.dataGridRabbits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRabbits_CellClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 416);
            this.Controls.Add(this.dataGridRabbits);
            this.Name = "MainWindow";
            this.Text = "Hlavní okno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRabbits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRabbits;
    }
}

