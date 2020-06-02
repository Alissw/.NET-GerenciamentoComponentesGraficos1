using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


namespace Table
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        public FlowLayoutPanel FlowLayoutPanel { get; private set; }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(300, 300);
            this.Text = "FlowLayoutPanel";

            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = 3;
            panel.RowCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);
            panel.Controls.Add(new Label() { Text = "Contact No" }, 2, 0);
            panel.Controls.Add(new Label() { Text = "Email ID" }, 3, 0);

            // For Add New Row (Loop this code for add multiple rows)
            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Street, City, State" }, 1, panel.RowCount-1);
            panel.Controls.Add(new Label() { Text = "888888888888" }, 2, panel.RowCount-1);
            panel.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 3, panel.RowCount-1);

            this.Controls.Add(panel);
        }

        #endregion
    }
}

