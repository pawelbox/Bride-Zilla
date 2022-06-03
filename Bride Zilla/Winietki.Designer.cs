
namespace Bride_Zilla
{
    partial class Winietki
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winietki));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarezerwowaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostępneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwer117140_customerDataSet = new Bride_Zilla.serwer117140_customerDataSet();
            this.paseTableAdapter = new Bride_Zilla.serwer117140_customerDataSetTableAdapters.paseTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt21pod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt21poj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt30pod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt30poj = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwer117140_customerDataSet)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.rodzajDataGridViewTextBoxColumn,
            this.stanDataGridViewTextBoxColumn,
            this.zarezerwowaneDataGridViewTextBoxColumn,
            this.dostępneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // rodzajDataGridViewTextBoxColumn
            // 
            this.rodzajDataGridViewTextBoxColumn.DataPropertyName = "Rodzaj";
            this.rodzajDataGridViewTextBoxColumn.HeaderText = "Rodzaj";
            this.rodzajDataGridViewTextBoxColumn.Name = "rodzajDataGridViewTextBoxColumn";
            // 
            // stanDataGridViewTextBoxColumn
            // 
            this.stanDataGridViewTextBoxColumn.DataPropertyName = "Stan";
            this.stanDataGridViewTextBoxColumn.HeaderText = "Stan";
            this.stanDataGridViewTextBoxColumn.Name = "stanDataGridViewTextBoxColumn";
            // 
            // zarezerwowaneDataGridViewTextBoxColumn
            // 
            this.zarezerwowaneDataGridViewTextBoxColumn.DataPropertyName = "Zarezerwowane";
            this.zarezerwowaneDataGridViewTextBoxColumn.HeaderText = "Zarezerwowane";
            this.zarezerwowaneDataGridViewTextBoxColumn.Name = "zarezerwowaneDataGridViewTextBoxColumn";
            // 
            // dostępneDataGridViewTextBoxColumn
            // 
            this.dostępneDataGridViewTextBoxColumn.DataPropertyName = "Dostępne";
            this.dostępneDataGridViewTextBoxColumn.HeaderText = "Dostępne";
            this.dostępneDataGridViewTextBoxColumn.Name = "dostępneDataGridViewTextBoxColumn";
            // 
            // paseBindingSource
            // 
            this.paseBindingSource.DataMember = "pase";
            this.paseBindingSource.DataSource = this.serwer117140_customerDataSet;
            // 
            // serwer117140_customerDataSet
            // 
            this.serwer117140_customerDataSet.DataSetName = "serwer117140_customerDataSet";
            this.serwer117140_customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paseTableAdapter
            // 
            this.paseTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 39);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Dodaj na stan";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt21pod);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt21poj);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt30pod);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt30poj);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 173);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dodatki";
            // 
            // txt21pod
            // 
            this.txt21pod.Location = new System.Drawing.Point(184, 77);
            this.txt21pod.Name = "txt21pod";
            this.txt21pod.Size = new System.Drawing.Size(153, 21);
            this.txt21pod.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "15x21 podwójne";
            // 
            // txt21poj
            // 
            this.txt21poj.Location = new System.Drawing.Point(184, 37);
            this.txt21poj.Name = "txt21poj";
            this.txt21poj.Size = new System.Drawing.Size(153, 21);
            this.txt21poj.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "15x21 pojedyncze";
            // 
            // txt30pod
            // 
            this.txt30pod.Location = new System.Drawing.Point(7, 119);
            this.txt30pod.Name = "txt30pod";
            this.txt30pod.Size = new System.Drawing.Size(153, 21);
            this.txt30pod.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "15x30 podwójne";
            // 
            // txt30poj
            // 
            this.txt30poj.Location = new System.Drawing.Point(7, 79);
            this.txt30poj.Name = "txt30poj";
            this.txt30poj.Size = new System.Drawing.Size(153, 21);
            this.txt30poj.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "15x30 pojedyncze";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(7, 38);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 21);
            this.txtID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(431, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Dodaj pozycję";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Winietki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Lato", 8.25F);
            this.Name = "Winietki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn winietek";
            this.Load += new System.EventHandler(this.Winietki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwer117140_customerDataSet)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private serwer117140_customerDataSet serwer117140_customerDataSet;
        private System.Windows.Forms.BindingSource paseBindingSource;
        private serwer117140_customerDataSetTableAdapters.paseTableAdapter paseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarezerwowaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostępneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.TextBox txt21pod;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt21poj;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txt30pod;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt30poj;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}