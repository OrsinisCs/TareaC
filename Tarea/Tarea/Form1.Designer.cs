namespace Tarea
{
    partial class FrmATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmATM));
            this.lbl0 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn300 = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.aux = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lbl0)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl0
            // 
            this.lbl0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl0.Image = ((System.Drawing.Image)(resources.GetObject("lbl0.Image")));
            this.lbl0.Location = new System.Drawing.Point(0, 0);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(977, 705);
            this.lbl0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lbl0.TabIndex = 0;
            this.lbl0.TabStop = false;
            this.lbl0.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(258, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 223);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(269, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(61, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = false;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su PIN:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage2.Controls.Add(this.btnTransfer);
            this.tabPage2.Controls.Add(this.btnExit);
            this.tabPage2.Controls.Add(this.btnBalance);
            this.tabPage2.Controls.Add(this.btnWithDraw);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(269, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(294, 478);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 29);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "1";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(351, 478);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 29);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "2";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.White;
            this.lbl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(406, 395);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(27, 29);
            this.lbl9.TabIndex = 6;
            this.lbl9.Text = "9";
            this.lbl9.Click += new System.EventHandler(this.lbl9_Click);
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.White;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.Location = new System.Drawing.Point(351, 395);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(27, 29);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "8";
            this.lbl8.Click += new System.EventHandler(this.lbl8_Click);
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(294, 395);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(27, 29);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = "7";
            this.lbl7.Click += new System.EventHandler(this.lbl7_Click);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(406, 436);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(27, 29);
            this.lbl6.TabIndex = 9;
            this.lbl6.Text = "6";
            this.lbl6.Click += new System.EventHandler(this.lbl6_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(351, 436);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(27, 29);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "5";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(294, 436);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(27, 29);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "4";
            this.lbl4.Click += new System.EventHandler(this.label11_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(406, 478);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(27, 29);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "3";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.Color.White;
            this.lblEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(465, 403);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(48, 18);
            this.lblEnter.TabIndex = 13;
            this.lblEnter.Text = "Enter";
            this.lblEnter.Click += new System.EventHandler(this.lblEnter_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.White;
            this.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(462, 446);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(49, 15);
            this.lblDelete.TabIndex = 14;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.White;
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(462, 488);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(51, 15);
            this.lblCancel.TabIndex = 15;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione tipo de transferencia";
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.AutoSize = true;
            this.btnWithDraw.BackColor = System.Drawing.Color.White;
            this.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithDraw.FlatAppearance.BorderSize = 3;
            this.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithDraw.Location = new System.Drawing.Point(7, 41);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(96, 47);
            this.btnWithDraw.TabIndex = 3;
            this.btnWithDraw.Text = "Retiro";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.AutoSize = true;
            this.btnBalance.BackColor = System.Drawing.Color.White;
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.FlatAppearance.BorderSize = 3;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.Black;
            this.btnBalance.Location = new System.Drawing.Point(7, 119);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(96, 51);
            this.btnBalance.TabIndex = 4;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(140, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Cancelar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.AutoSize = true;
            this.btnTransfer.BackColor = System.Drawing.Color.White;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 3;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Location = new System.Drawing.Point(140, 41);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(109, 50);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transferir";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.lblBalance);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(269, 197);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(103, 123);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(55, 36);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Su balance es:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tabPage4.Controls.Add(this.aux);
            this.tabPage4.Controls.Add(this.btn100);
            this.tabPage4.Controls.Add(this.btnOther);
            this.tabPage4.Controls.Add(this.btn300);
            this.tabPage4.Controls.Add(this.btn1000);
            this.tabPage4.Controls.Add(this.btn500);
            this.tabPage4.Controls.Add(this.btn2000);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(269, 197);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Seleccione la cantidad";
            // 
            // btn2000
            // 
            this.btn2000.AutoSize = true;
            this.btn2000.BackColor = System.Drawing.Color.White;
            this.btn2000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2000.FlatAppearance.BorderSize = 3;
            this.btn2000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.ForeColor = System.Drawing.Color.Black;
            this.btn2000.Location = new System.Drawing.Point(6, 36);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(79, 38);
            this.btn2000.TabIndex = 4;
            this.btn2000.Text = "2,000";
            this.btn2000.UseVisualStyleBackColor = false;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
            // 
            // btn500
            // 
            this.btn500.AutoSize = true;
            this.btn500.BackColor = System.Drawing.Color.White;
            this.btn500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn500.FlatAppearance.BorderSize = 3;
            this.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.Color.Black;
            this.btn500.Location = new System.Drawing.Point(6, 93);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(79, 36);
            this.btn500.TabIndex = 5;
            this.btn500.Text = "500";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn1000
            // 
            this.btn1000.AutoSize = true;
            this.btn1000.BackColor = System.Drawing.Color.White;
            this.btn1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1000.FlatAppearance.BorderSize = 3;
            this.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.ForeColor = System.Drawing.Color.Black;
            this.btn1000.Location = new System.Drawing.Point(6, 153);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(79, 36);
            this.btn1000.TabIndex = 6;
            this.btn1000.Text = "1000";
            this.btn1000.UseVisualStyleBackColor = false;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn300
            // 
            this.btn300.AutoSize = true;
            this.btn300.BackColor = System.Drawing.Color.White;
            this.btn300.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn300.FlatAppearance.BorderSize = 3;
            this.btn300.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn300.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn300.ForeColor = System.Drawing.Color.Black;
            this.btn300.Location = new System.Drawing.Point(169, 36);
            this.btn300.Name = "btn300";
            this.btn300.Size = new System.Drawing.Size(94, 38);
            this.btn300.TabIndex = 7;
            this.btn300.Text = "300";
            this.btn300.UseVisualStyleBackColor = false;
            this.btn300.Click += new System.EventHandler(this.btn300_Click);
            // 
            // btnOther
            // 
            this.btnOther.AutoSize = true;
            this.btnOther.BackColor = System.Drawing.Color.White;
            this.btnOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOther.FlatAppearance.BorderSize = 3;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.ForeColor = System.Drawing.Color.Black;
            this.btnOther.Location = new System.Drawing.Point(169, 153);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(94, 38);
            this.btnOther.TabIndex = 8;
            this.btnOther.Text = "Otra";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btn100
            // 
            this.btn100.AutoSize = true;
            this.btn100.BackColor = System.Drawing.Color.White;
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.FlatAppearance.BorderSize = 3;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.Black;
            this.btn100.Location = new System.Drawing.Point(169, 93);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(94, 36);
            this.btn100.TabIndex = 9;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // aux
            // 
            this.aux.AutoSize = true;
            this.aux.CausesValidation = false;
            this.aux.Location = new System.Drawing.Point(4, 187);
            this.aux.Name = "aux";
            this.aux.Size = new System.Drawing.Size(13, 13);
            this.aux.TabIndex = 10;
            this.aux.Text = "0";
            // 
            // FrmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 705);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl0)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lbl0;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btn300;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label aux;
    }
}

