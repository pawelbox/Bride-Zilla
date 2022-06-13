
namespace Bride_Zilla
{
    partial class Calendar
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
            this.cal1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // cal1
            // 
            this.cal1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.cal1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cal1.Font = new System.Drawing.Font("Lato", 8.25F);
            this.cal1.Location = new System.Drawing.Point(135, 39);
            this.cal1.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.cal1.Name = "cal1";
            this.cal1.TabIndex = 0;
            this.cal1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cal1);
            this.Name = "Calendar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal1;
    }
}