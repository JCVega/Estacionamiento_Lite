namespace Estacionamiento_Lite
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.NumericUpDown();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtCabecera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cabecera";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(13, 30);
            this.txtFolio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(85, 20);
            this.txtFolio.TabIndex = 2;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // txtCabecera
            // 
            this.txtCabecera.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCabecera.Location = new System.Drawing.Point(13, 86);
            this.txtCabecera.Multiline = true;
            this.txtCabecera.Name = "txtCabecera";
            this.txtCabecera.Size = new System.Drawing.Size(240, 134);
            this.txtCabecera.TabIndex = 3;
            this.txtCabecera.Text = "*********ESTACIONAMIENTO*******";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pie";
            // 
            // txtPie
            // 
            this.txtPie.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPie.Location = new System.Drawing.Point(13, 275);
            this.txtPie.Multiline = true;
            this.txtPie.Name = "txtPie";
            this.txtPie.Size = new System.Drawing.Size(240, 153);
            this.txtPie.TabIndex = 5;
            this.txtPie.Text = "Modelo__________________________\r\n\r\nColor:__________________________\r\n\r\nHora Entr" +
    "ada:___________________\r\n\r\nHora Salida:____________________\r\n\r\nCobro:___________" +
    "_______________\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCabecera);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Estacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtFolio;
        private System.Windows.Forms.TextBox txtCabecera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPie;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

