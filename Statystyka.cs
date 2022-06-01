﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bride_Zilla
{
    public partial class Statystyka : Form
    {
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("statistic");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public Statystyka()
        {
            InitializeComponent();
        }

        private void Statystyka_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }
    }
}