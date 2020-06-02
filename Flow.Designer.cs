using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


namespace Flow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Label lbNome;
        private TextBox txtNome;
        private Button btnConfirma;
        ErrorProvider nomeError;
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

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.BackColor = Color.Yellow;

            this.lbNome = new Label();
            this.lbNome.Text = "Nome: ";

            this.txtNome = new TextBox();
            this.txtNome.Size = new System.Drawing.Size(120,15);

            this.nomeError = new ErrorProvider();
            this.nomeError.SetIconAlignment(this.txtNome, ErrorIconAlignment.MiddleRight);
            this.nomeError.SetIconPadding(this.txtNome, 3);
            this.nomeError.BlinkRate = 10000;
            this.nomeError.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            this.btnConfirma = new Button();
            this.btnConfirma.Size = new Size(120,30);
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.Click += new EventHandler(this.btnConfirmar_click);
            
            this.FlowLayoutPanel.Controls.Add(lbNome);
            this.FlowLayoutPanel.Controls.Add(this.txtNome);
            this.FlowLayoutPanel.Controls.Add(this.btnConfirma);

            this.Controls.Add(FlowLayoutPanel);
        }

        #endregion
    }
}

