
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.dataGridRabbits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridRabbits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRabbits.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridRabbits.Location = new System.Drawing.Point(13, 44);
            this.dataGridRabbits.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridRabbits.MultiSelect = false;
            this.dataGridRabbits.Name = "dataGridRabbits";
            this.dataGridRabbits.ReadOnly = true;
            this.dataGridRabbits.RowHeadersVisible = false;
            this.dataGridRabbits.RowHeadersWidth = 62;
            this.dataGridRabbits.RowTemplate.Height = 33;
            this.dataGridRabbits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRabbits.Size = new System.Drawing.Size(952, 287);
            this.dataGridRabbits.TabIndex = 0;
            this.dataGridRabbits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRabbits_CellClick);
            // 
            // mnStrip
            // 
            this.mnStrip.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vložitToolStripMenuItem,
            this.informaceToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnStrip.Size = new System.Drawing.Size(978, 40);
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
            this.vložitToolStripMenuItem.Size = new System.Drawing.Size(83, 34);
            this.vložitToolStripMenuItem.Text = "Vložit";
            // 
            // newRabbitToolStripMenuItem
            // 
            this.newRabbitToolStripMenuItem.Name = "newRabbitToolStripMenuItem";
            this.newRabbitToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.newRabbitToolStripMenuItem.Text = "Nový Králík";
            this.newRabbitToolStripMenuItem.Click += new System.EventHandler(this.newRabbitToolStripMenuItem_Click);
            // 
            // připuštěníToolStripMenuItem
            // 
            this.připuštěníToolStripMenuItem.Name = "připuštěníToolStripMenuItem";
            this.připuštěníToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.připuštěníToolStripMenuItem.Text = "Připuštění";
            // 
            // smazatToolStripMenuItem
            // 
            this.smazatToolStripMenuItem.Name = "smazatToolStripMenuItem";
            this.smazatToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.smazatToolStripMenuItem.Text = "Smazat";
            // 
            // informaceToolStripMenuItem
            // 
            this.informaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistikaToolStripMenuItem});
            this.informaceToolStripMenuItem.Name = "informaceToolStripMenuItem";
            this.informaceToolStripMenuItem.Size = new System.Drawing.Size(127, 34);
            this.informaceToolStripMenuItem.Text = "Informace";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 344);
            this.Controls.Add(this.dataGridRabbits);
            this.Controls.Add(this.mnStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
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

