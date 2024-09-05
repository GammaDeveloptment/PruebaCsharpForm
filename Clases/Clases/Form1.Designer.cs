namespace Clases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrueba = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombreGET = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoGET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodaereo = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RefIntHija = new System.Windows.Forms.TextBox();
            this.ShipperM = new System.Windows.Forms.TextBox();
            this.Consignee = new System.Windows.Forms.TextBox();
            this.Numguia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(15, 277);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(295, 53);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "GET";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(333, 277);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(295, 53);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNombreGET
            // 
            this.txtNombreGET.Location = new System.Drawing.Point(70, 225);
            this.txtNombreGET.Name = "txtNombreGET";
            this.txtNombreGET.Size = new System.Drawing.Size(237, 20);
            this.txtNombreGET.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres:";
            // 
            // txtApellidoGET
            // 
            this.txtApellidoGET.Location = new System.Drawing.Point(70, 251);
            this.txtApellidoGET.Name = "txtApellidoGET";
            this.txtApellidoGET.Size = new System.Drawing.Size(237, 20);
            this.txtApellidoGET.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Numguia);
            this.groupBox1.Controls.Add(this.Consignee);
            this.groupBox1.Controls.Add(this.ShipperM);
            this.groupBox1.Controls.Add(this.RefIntHija);
            this.groupBox1.Controls.Add(this.txtCodaereo);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(333, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 185);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Trabajador:";
            // 
            // txtCodaereo
            // 
            this.txtCodaereo.Location = new System.Drawing.Point(66, 45);
            this.txtCodaereo.Name = "txtCodaereo";
            this.txtCodaereo.Size = new System.Drawing.Size(225, 20);
            this.txtCodaereo.TabIndex = 13;
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(66, 19);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(225, 20);
            this.txtReserva.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CodAero:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reserva:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RefIntHija
            // 
            this.RefIntHija.Location = new System.Drawing.Point(66, 69);
            this.RefIntHija.Name = "RefIntHija";
            this.RefIntHija.Size = new System.Drawing.Size(225, 20);
            this.RefIntHija.TabIndex = 14;
            // 
            // ShipperM
            // 
            this.ShipperM.Location = new System.Drawing.Point(66, 95);
            this.ShipperM.Name = "ShipperM";
            this.ShipperM.Size = new System.Drawing.Size(225, 20);
            this.ShipperM.TabIndex = 15;
            // 
            // Consignee
            // 
            this.Consignee.Location = new System.Drawing.Point(66, 121);
            this.Consignee.Name = "Consignee";
            this.Consignee.Size = new System.Drawing.Size(225, 20);
            this.Consignee.TabIndex = 16;
            // 
            // Numguia
            // 
            this.Numguia.Location = new System.Drawing.Point(66, 147);
            this.Numguia.Name = "Numguia";
            this.Numguia.Size = new System.Drawing.Size(225, 20);
            this.Numguia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "RefIntHija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ShipperM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Consignee:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numguia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApellidoGET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreGET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombreGET;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoGET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodaereo;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numguia;
        private System.Windows.Forms.TextBox Consignee;
        private System.Windows.Forms.TextBox ShipperM;
        private System.Windows.Forms.TextBox RefIntHija;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

