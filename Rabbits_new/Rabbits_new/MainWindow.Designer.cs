
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
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.vložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRabbitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.připuštěníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRabbits)).BeginInit();
            this.mnStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRabbits
            // 
            this.dataGridRabbits.AllowUserToAddRows = false;
            this.dataGridRabbits.AllowUserToDeleteRows = false;
            this.dataGridRabbits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            // mnStrip
            // 
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vložitToolStripMenuItem,
            this.informaceToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(965, 33);
            this.mnStrip.TabIndex = 1;
            this.mnStrip.Text = "menuStrip1";
            // 
            // vložitToolStripMenuItem
            // 
            this.vložitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRabbitToolStripMenuItem,
            this.připuštěníToolStripMenuItem,
            this.smazatToolStripMenuItem});
            this.vložitToolStripMenuItem.Name = "vložitToolStripMenuItem";
            this.vložitToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.vložitToolStripMenuItem.Text = "Vložit";
            // 
            // newRabbitToolStripMenuItem
            // 
            this.newRabbitToolStripMenuItem.Name = "newRabbitToolStripMenuItem";
            this.newRabbitToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.newRabbitToolStripMenuItem.Text = "Nový Králík";
            this.newRabbitToolStripMenuItem.Click += new System.EventHandler(this.newRabbitToolStripMenuItem_Click);
            // 
            // připuštěníToolStripMenuItem
            // 
            this.připuštěníToolStripMenuItem.Name = "připuštěníToolStripMenuItem";
            this.připuštěníToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.připuštěníToolStripMenuItem.Text = "Připuštění";
            // 
            // smazatToolStripMenuItem
            // 
            this.smazatToolStripMenuItem.Name = "smazatToolStripMenuItem";
            this.smazatToolStripMenuItem.Size = new System.Drawing.Size(203, 34);
            this.smazatToolStripMenuItem.Text = "Smazat";
            // 
            // informaceToolStripMenuItem
            // 
            this.informaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistikaToolStripMenuItem});
            this.informaceToolStripMenuItem.Name = "informaceToolStripMenuItem";
            this.informaceToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.informaceToolStripMenuItem.Text = "Informace";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 416);
            this.Controls.Add(this.dataGridRabbits);
            this.Controls.Add(this.mnStrip);
            this.MainMenuStrip = this.mnStrip;
            this.Name = "MainWindow";
            this.Text = "Hlavní okno";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRabbits)).EndInit();
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRabbits;
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem vložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRabbitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem připuštěníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
    }
}

