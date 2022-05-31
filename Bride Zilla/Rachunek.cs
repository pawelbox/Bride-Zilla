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
    public partial class Rachunek : Form
    {
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("bill");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public void ClearText()
        {
            //txtID.Clear();
            txtJurnal.Clear();
            txtSesion.Clear();
            txtEngag.Clear();
            txtEngagPaid.Clear();
            txtPhoto.Clear();
            txtExtraPhoto.Clear();
            txtPaint.Clear();
            txtPrints.Clear();
            txtGuestPaid.Clear();
            txtGuestToPay.Clear();
            txtWedPaid.Clear();
            txtTravel.Clear();
            txtProfit.Clear();
            txtToPay.Clear();
        }
        public void LoadBill()
        {
            try
            {
                ClearText();
                string customerID = txtID.Text;
                LoadData load = new LoadData();
                load.LoadBillData("bill", customerID);

                txtJurnal.AppendText(load.jurnal.ToString());
                txtSesion.AppendText(load.sesion.ToString());
                txtEngag.AppendText(load.engag.ToString());
                txtEngagPaid.AppendText(load.engagPaid);
                txtPhoto.AppendText(load.photobook.ToString());
                txtExtraPhoto.AppendText(load.extraPhotobook.ToString());
                txtPaint.AppendText(load.paint.ToString());
                txtPrints.AppendText(load.prints.ToString());
                txtGuestPaid.AppendText(load.guestPaid.ToString());
                txtGuestToPay.AppendText(load.guestToPay.ToString());
                txtTravel.AppendText(load.travel.ToString());
                txtWedPaid.AppendText(load.wedPaid.ToString());
            }
            catch (Exception)
            {

            }

        }
        public Rachunek()
        {
            InitializeComponent();
        }

        private void Rachunek_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
            if (txtID.Text.Length >= 4)
            {
                ClearText();
                LoadBill();
            }
        }
    }
}
