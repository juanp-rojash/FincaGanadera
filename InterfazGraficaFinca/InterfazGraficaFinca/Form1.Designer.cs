namespace InterfazGraficaFinca
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
            this.components = new System.ComponentModel.Container();
            this.lbPotreros = new System.Windows.Forms.ListBox();
            this.estandarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbGanado = new System.Windows.Forms.ListBox();
            this.resBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbEspecial = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudRaza = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCantidadR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVacunar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTrasladarEsp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnMover = new System.Windows.Forms.Button();
            this.nudPotrero = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbFeria = new System.Windows.Forms.ListBox();
            this.lbVentas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEnviarFeria = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.potreroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.estandarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBindingSource)).BeginInit();
            this.tcMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRaza)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrero)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potreroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPotreros
            // 
            this.lbPotreros.BackColor = System.Drawing.Color.Gray;
            this.lbPotreros.DataSource = this.estandarBindingSource;
            this.lbPotreros.DisplayMember = "Nombre";
            this.lbPotreros.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbPotreros.FormattingEnabled = true;
            this.lbPotreros.Location = new System.Drawing.Point(13, 13);
            this.lbPotreros.Name = "lbPotreros";
            this.lbPotreros.Size = new System.Drawing.Size(233, 121);
            this.lbPotreros.TabIndex = 0;
            this.lbPotreros.SelectedIndexChanged += new System.EventHandler(this.LbPotreros_SelectedIndexChanged);
            // 
            // estandarBindingSource
            // 
            this.estandarBindingSource.DataSource = typeof(ProyectoFincaGanadera.Estandar);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataSource = typeof(ProyectoFincaGanadera.Venta);
            // 
            // lbGanado
            // 
            this.lbGanado.BackColor = System.Drawing.Color.DarkGreen;
            this.lbGanado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbGanado.DataSource = this.resBindingSource;
            this.lbGanado.DisplayMember = "Id";
            this.lbGanado.ForeColor = System.Drawing.SystemColors.Window;
            this.lbGanado.FormattingEnabled = true;
            this.lbGanado.Location = new System.Drawing.Point(404, 42);
            this.lbGanado.Name = "lbGanado";
            this.lbGanado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGanado.Size = new System.Drawing.Size(235, 455);
            this.lbGanado.TabIndex = 1;
            // 
            // resBindingSource
            // 
            this.resBindingSource.DataSource = typeof(ProyectoFincaGanadera.Res);
            // 
            // lbEspecial
            // 
            this.lbEspecial.BackColor = System.Drawing.Color.RosyBrown;
            this.lbEspecial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbEspecial.DataSource = this.resBindingSource;
            this.lbEspecial.DisplayMember = "Id";
            this.lbEspecial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbEspecial.FormattingEnabled = true;
            this.lbEspecial.Location = new System.Drawing.Point(672, 12);
            this.lbEspecial.Name = "lbEspecial";
            this.lbEspecial.Size = new System.Drawing.Size(229, 208);
            this.lbEspecial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "__";
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tabPage1);
            this.tcMenu.Controls.Add(this.tabPage2);
            this.tcMenu.Controls.Add(this.tabPage3);
            this.tcMenu.Controls.Add(this.tabPage4);
            this.tcMenu.Location = new System.Drawing.Point(13, 150);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(367, 159);
            this.tcMenu.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.nudRaza);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbCantidadR);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 133);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(330, 22);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // nudRaza
            // 
            this.nudRaza.Location = new System.Drawing.Point(260, 58);
            this.nudRaza.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudRaza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRaza.Name = "nudRaza";
            this.nudRaza.Size = new System.Drawing.Size(36, 20);
            this.nudRaza.TabIndex = 5;
            this.nudRaza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese la raza de las reses que agregará:";
            // 
            // txtbCantidadR
            // 
            this.txtbCantidadR.Location = new System.Drawing.Point(260, 29);
            this.txtbCantidadR.Name = "txtbCantidadR";
            this.txtbCantidadR.Size = new System.Drawing.Size(36, 20);
            this.txtbCantidadR.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrese la cantidad de reses que desea agregar:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "__";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecione el potrero al que desea agregar reses:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGreen;
            this.tabPage2.Controls.Add(this.btnVacunar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 133);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // btnVacunar
            // 
            this.btnVacunar.Location = new System.Drawing.Point(10, 42);
            this.btnVacunar.Name = "btnVacunar";
            this.btnVacunar.Size = new System.Drawing.Size(343, 23);
            this.btnVacunar.TabIndex = 3;
            this.btnVacunar.Text = "Vacunar";
            this.btnVacunar.UseVisualStyleBackColor = true;
            this.btnVacunar.Click += new System.EventHandler(this.BtnVacunar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(282, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "__";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Selecione el potrero al que desea vacunar las reses:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage3.Controls.Add(this.btnTrasladarEsp);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(359, 133);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // btnTrasladarEsp
            // 
            this.btnTrasladarEsp.Location = new System.Drawing.Point(9, 41);
            this.btnTrasladarEsp.Name = "btnTrasladarEsp";
            this.btnTrasladarEsp.Size = new System.Drawing.Size(344, 23);
            this.btnTrasladarEsp.TabIndex = 1;
            this.btnTrasladarEsp.Text = "Trasladar";
            this.btnTrasladarEsp.UseVisualStyleBackColor = true;
            this.btnTrasladarEsp.Click += new System.EventHandler(this.BtnTrasladarEsp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seleccione las reses que desea transferir al potrero especial";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.btnMover);
            this.tabPage4.Controls.Add(this.nudPotrero);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(359, 133);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(10, 69);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(327, 23);
            this.btnMover.TabIndex = 3;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // nudPotrero
            // 
            this.nudPotrero.Location = new System.Drawing.Point(305, 40);
            this.nudPotrero.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudPotrero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPotrero.Name = "nudPotrero";
            this.nudPotrero.Size = new System.Drawing.Size(32, 20);
            this.nudPotrero.TabIndex = 2;
            this.nudPotrero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(7, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ingrese el número de portrero al que moverá las reses:\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Seleccione las reses que desea transferir al potrero destino\r\n";
            // 
            // lbFeria
            // 
            this.lbFeria.BackColor = System.Drawing.Color.White;
            this.lbFeria.DataSource = this.resBindingSource;
            this.lbFeria.DisplayMember = "Id";
            this.lbFeria.FormattingEnabled = true;
            this.lbFeria.Location = new System.Drawing.Point(672, 262);
            this.lbFeria.Name = "lbFeria";
            this.lbFeria.Size = new System.Drawing.Size(229, 212);
            this.lbFeria.TabIndex = 5;
            // 
            // lbVentas
            // 
            this.lbVentas.BackColor = System.Drawing.Color.Gray;
            this.lbVentas.DataSource = this.ventaBindingSource;
            this.lbVentas.DisplayMember = "Id";
            this.lbVentas.FormattingEnabled = true;
            this.lbVentas.Location = new System.Drawing.Point(13, 329);
            this.lbVentas.Name = "lbVentas";
            this.lbVentas.Size = new System.Drawing.Size(102, 160);
            this.lbVentas.TabIndex = 6;
            this.lbVentas.SelectedIndexChanged += new System.EventHandler(this.LbVentas_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(122, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 160);
            this.panel1.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(19, 122);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(218, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "__";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ganancia:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "__";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cantidad de reses vendidas:";
            // 
            // btnEnviarFeria
            // 
            this.btnEnviarFeria.Location = new System.Drawing.Point(672, 226);
            this.btnEnviarFeria.Name = "btnEnviarFeria";
            this.btnEnviarFeria.Size = new System.Drawing.Size(229, 21);
            this.btnEnviarFeria.TabIndex = 8;
            this.btnEnviarFeria.Text = "Enviar a la feria";
            this.btnEnviarFeria.UseVisualStyleBackColor = true;
            this.btnEnviarFeria.Click += new System.EventHandler(this.BtnEnviarFeria_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(672, 481);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(229, 23);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // potreroBindingSource
            // 
            this.potreroBindingSource.DataSource = typeof(ProyectoFincaGanadera.Potrero);
            // 
            // especialBindingSource
            // 
            this.especialBindingSource.DataSource = typeof(ProyectoFincaGanadera.Especial);
            // 
            // feriaBindingSource
            // 
            this.feriaBindingSource.DataSource = typeof(ProyectoFincaGanadera.Feria);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(944, 518);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnEnviarFeria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVentas);
            this.Controls.Add(this.lbFeria);
            this.Controls.Add(this.tcMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEspecial);
            this.Controls.Add(this.lbGanado);
            this.Controls.Add(this.lbPotreros);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.estandarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBindingSource)).EndInit();
            this.tcMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRaza)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potreroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPotreros;
        private System.Windows.Forms.ListBox lbGanado;
        private System.Windows.Forms.ListBox lbEspecial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudRaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbCantidadR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnVacunar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTrasladarEsp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.NumericUpDown nudPotrero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbFeria;
        private System.Windows.Forms.ListBox lbVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEnviarFeria;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private System.Windows.Forms.BindingSource potreroBindingSource;
        private System.Windows.Forms.BindingSource estandarBindingSource;
        private System.Windows.Forms.BindingSource resBindingSource;
        private System.Windows.Forms.BindingSource especialBindingSource;
        private System.Windows.Forms.BindingSource feriaBindingSource;
    }
}

