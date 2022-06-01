
namespace Bride_Zilla
{
    partial class MainPage
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.klieciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rachunekKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.księgowośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kosztyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statystykaZapytańToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klieciToolStripMenuItem,
            this.księgowośćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // klieciToolStripMenuItem
            // 
            this.klieciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kartaKlientaToolStripMenuItem,
            this.rachunekKlientaToolStripMenuItem,
            this.statystykaZapytańToolStripMenuItem});
            this.klieciToolStripMenuItem.Name = "klieciToolStripMenuItem";
            this.klieciToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.klieciToolStripMenuItem.Text = "Klieci";
            // 
            // kartaKlientaToolStripMenuItem
            // 
            this.kartaKlientaToolStripMenuItem.Name = "kartaKlientaToolStripMenuItem";
            this.kartaKlientaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kartaKlientaToolStripMenuItem.Text = "Karta klienta";
            this.kartaKlientaToolStripMenuItem.Click += new System.EventHandler(this.kartaKlientaToolStripMenuItem_Click);
            // 
            // rachunekKlientaToolStripMenuItem
            // 
            this.rachunekKlientaToolStripMenuItem.Name = "rachunekKlientaToolStripMenuItem";
            this.rachunekKlientaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rachunekKlientaToolStripMenuItem.Text = "Rachunek klienta";
            this.rachunekKlientaToolStripMenuItem.Click += new System.EventHandler(this.rachunekKlientaToolStripMenuItem_Click);
            // 
            // księgowośćToolStripMenuItem
            // 
            this.księgowośćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kosztyToolStripMenuItem});
            this.księgowośćToolStripMenuItem.Name = "księgowośćToolStripMenuItem";
            this.księgowośćToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.księgowośćToolStripMenuItem.Text = "Księgowość";
            // 
            // kosztyToolStripMenuItem
            // 
            this.kosztyToolStripMenuItem.Name = "kosztyToolStripMenuItem";
            this.kosztyToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kosztyToolStripMenuItem.Text = "Koszty";
            this.kosztyToolStripMenuItem.Click += new System.EventHandler(this.kosztyToolStripMenuItem_Click);
            // 
            // statystykaZapytańToolStripMenuItem
            // 
            this.statystykaZapytańToolStripMenuItem.Name = "statystykaZapytańToolStripMenuItem";
            this.statystykaZapytańToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statystykaZapytańToolStripMenuItem.Text = "Statystyka zapytań";
            this.statystykaZapytańToolStripMenuItem.Click += new System.EventHandler(this.statystykaZapytańToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 841);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lato", 8.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bride Zilla";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem klieciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rachunekKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem księgowośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kosztyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statystykaZapytańToolStripMenuItem;
    }
}

