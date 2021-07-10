namespace ColorPicker
{
    partial class Form1
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
            this.panelBoja = new System.Windows.Forms.Panel();
            this.trackBarCrvena = new System.Windows.Forms.TrackBar();
            this.trackBarZelena = new System.Windows.Forms.TrackBar();
            this.trackBarPlava = new System.Windows.Forms.TrackBar();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.numericUpDownCrvena = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZelena = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlava = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrvena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZelena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrvena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZelena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlava)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoja
            // 
            this.panelBoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBoja.Location = new System.Drawing.Point(0, 0);
            this.panelBoja.Name = "panelBoja";
            this.panelBoja.Size = new System.Drawing.Size(555, 165);
            this.panelBoja.TabIndex = 0;
            // 
            // trackBarCrvena
            // 
            this.trackBarCrvena.BackColor = System.Drawing.Color.Red;
            this.trackBarCrvena.Location = new System.Drawing.Point(83, 200);
            this.trackBarCrvena.Maximum = 255;
            this.trackBarCrvena.Name = "trackBarCrvena";
            this.trackBarCrvena.Size = new System.Drawing.Size(255, 45);
            this.trackBarCrvena.TabIndex = 1;
            this.trackBarCrvena.TickFrequency = 15;
            this.trackBarCrvena.Scroll += new System.EventHandler(this.trackBarCrvena_Scroll);
            // 
            // trackBarZelena
            // 
            this.trackBarZelena.BackColor = System.Drawing.Color.Green;
            this.trackBarZelena.Location = new System.Drawing.Point(83, 251);
            this.trackBarZelena.Maximum = 255;
            this.trackBarZelena.Name = "trackBarZelena";
            this.trackBarZelena.Size = new System.Drawing.Size(255, 45);
            this.trackBarZelena.TabIndex = 1;
            this.trackBarZelena.TickFrequency = 15;
            this.trackBarZelena.Scroll += new System.EventHandler(this.trackBarZelena_Scroll);
            // 
            // trackBarPlava
            // 
            this.trackBarPlava.BackColor = System.Drawing.Color.Blue;
            this.trackBarPlava.Location = new System.Drawing.Point(83, 300);
            this.trackBarPlava.Maximum = 255;
            this.trackBarPlava.Name = "trackBarPlava";
            this.trackBarPlava.Size = new System.Drawing.Size(255, 45);
            this.trackBarPlava.TabIndex = 1;
            this.trackBarPlava.TickFrequency = 15;
            this.trackBarPlava.Scroll += new System.EventHandler(this.trackBarPlava_Scroll);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(433, 263);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(100, 20);
            this.textBoxHex.TabIndex = 3;
            this.textBoxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownCrvena
            // 
            this.numericUpDownCrvena.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownCrvena.Location = new System.Drawing.Point(356, 210);
            this.numericUpDownCrvena.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownCrvena.Name = "numericUpDownCrvena";
            this.numericUpDownCrvena.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownCrvena.TabIndex = 4;
            this.numericUpDownCrvena.ValueChanged += new System.EventHandler(this.numericUpDownCrvena_ValueChanged);
            // 
            // numericUpDownZelena
            // 
            this.numericUpDownZelena.ForeColor = System.Drawing.Color.Green;
            this.numericUpDownZelena.Location = new System.Drawing.Point(356, 262);
            this.numericUpDownZelena.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownZelena.Name = "numericUpDownZelena";
            this.numericUpDownZelena.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownZelena.TabIndex = 4;
            this.numericUpDownZelena.ValueChanged += new System.EventHandler(this.numericUpDownZelena_ValueChanged);
            // 
            // numericUpDownPlava
            // 
            this.numericUpDownPlava.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDownPlava.Location = new System.Drawing.Point(356, 310);
            this.numericUpDownPlava.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownPlava.Name = "numericUpDownPlava";
            this.numericUpDownPlava.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownPlava.TabIndex = 4;
            this.numericUpDownPlava.ValueChanged += new System.EventHandler(this.numericUpDownPlava_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(22, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(457, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "HEX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPlava);
            this.Controls.Add(this.numericUpDownZelena);
            this.Controls.Add(this.numericUpDownCrvena);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.trackBarPlava);
            this.Controls.Add(this.trackBarZelena);
            this.Controls.Add(this.trackBarCrvena);
            this.Controls.Add(this.panelBoja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrvena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZelena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrvena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZelena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoja;
        private System.Windows.Forms.TrackBar trackBarCrvena;
        private System.Windows.Forms.TrackBar trackBarZelena;
        private System.Windows.Forms.TrackBar trackBarPlava;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.NumericUpDown numericUpDownCrvena;
        private System.Windows.Forms.NumericUpDown numericUpDownZelena;
        private System.Windows.Forms.NumericUpDown numericUpDownPlava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

