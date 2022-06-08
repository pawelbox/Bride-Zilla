
namespace Bride_Zilla
{
    partial class MySql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySql));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPass);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtUser);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtServer);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(42, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 196);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ustawienia bazy MySql";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(7, 159);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(153, 21);
            this.txtPass.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hasło";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(7, 119);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(153, 21);
            this.txtUser.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Użytkownik";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 21);
            this.txtName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nazwa bazy danych";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(7, 38);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(153, 21);
            this.txtServer.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Serwer";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(42, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 39);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edytuj dane";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // MySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(295, 332);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Lato", 8.25F);
            this.Name = "MySql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia bazy danych";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEdit;
    }
}