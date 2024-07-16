namespace DashBoardTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelluces = new System.Windows.Forms.Panel();
            this.btnServoAir = new System.Windows.Forms.Button();
            this.btnServoTemp = new System.Windows.Forms.Button();
            this.btnServoRPM = new System.Windows.Forms.Button();
            this.btnServokm = new System.Windows.Forms.Button();
            this.btnServoFuel = new System.Windows.Forms.Button();
            this.btnServoOil = new System.Windows.Forms.Button();
            this.DashBoardImg = new System.Windows.Forms.PictureBox();
            this.btnEncender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.groupBoxLuces = new System.Windows.Forms.GroupBox();
            this.groupBoxServos = new System.Windows.Forms.GroupBox();
            this.btn180 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.cmbPuertoCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblCOM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardImg)).BeginInit();
            this.groupBoxLuces.SuspendLayout();
            this.groupBoxServos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelluces);
            this.panel1.Controls.Add(this.btnServoAir);
            this.panel1.Controls.Add(this.btnServoTemp);
            this.panel1.Controls.Add(this.btnServoRPM);
            this.panel1.Controls.Add(this.btnServokm);
            this.panel1.Controls.Add(this.btnServoFuel);
            this.panel1.Controls.Add(this.btnServoOil);
            this.panel1.Controls.Add(this.DashBoardImg);
            this.panel1.Location = new System.Drawing.Point(12, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 465);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(486, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 50);
            this.panel2.TabIndex = 16;
            // 
            // panelluces
            // 
            this.panelluces.BackColor = System.Drawing.Color.White;
            this.panelluces.Location = new System.Drawing.Point(327, 29);
            this.panelluces.Name = "panelluces";
            this.panelluces.Size = new System.Drawing.Size(618, 77);
            this.panelluces.TabIndex = 15;
            // 
            // btnServoAir
            // 
            this.btnServoAir.BackColor = System.Drawing.Color.Green;
            this.btnServoAir.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServoAir.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServoAir.Location = new System.Drawing.Point(1100, 318);
            this.btnServoAir.Name = "btnServoAir";
            this.btnServoAir.Size = new System.Drawing.Size(126, 45);
            this.btnServoAir.TabIndex = 14;
            this.btnServoAir.Text = "Test";
            this.btnServoAir.UseVisualStyleBackColor = false;
            this.btnServoAir.Click += new System.EventHandler(this.btnServoAir_Click);
            // 
            // btnServoTemp
            // 
            this.btnServoTemp.BackColor = System.Drawing.Color.Green;
            this.btnServoTemp.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServoTemp.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServoTemp.Location = new System.Drawing.Point(1100, 94);
            this.btnServoTemp.Name = "btnServoTemp";
            this.btnServoTemp.Size = new System.Drawing.Size(126, 45);
            this.btnServoTemp.TabIndex = 13;
            this.btnServoTemp.Text = "Test";
            this.btnServoTemp.UseVisualStyleBackColor = false;
            this.btnServoTemp.Click += new System.EventHandler(this.btnServoTemp_Click);
            // 
            // btnServoRPM
            // 
            this.btnServoRPM.BackColor = System.Drawing.Color.Green;
            this.btnServoRPM.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServoRPM.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServoRPM.Location = new System.Drawing.Point(784, 262);
            this.btnServoRPM.Name = "btnServoRPM";
            this.btnServoRPM.Size = new System.Drawing.Size(126, 45);
            this.btnServoRPM.TabIndex = 12;
            this.btnServoRPM.Text = "Test";
            this.btnServoRPM.UseVisualStyleBackColor = false;
            this.btnServoRPM.Click += new System.EventHandler(this.btnServoRPM_Click);
            // 
            // btnServokm
            // 
            this.btnServokm.BackColor = System.Drawing.Color.Green;
            this.btnServokm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServokm.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServokm.Location = new System.Drawing.Point(348, 262);
            this.btnServokm.Name = "btnServokm";
            this.btnServokm.Size = new System.Drawing.Size(126, 45);
            this.btnServokm.TabIndex = 11;
            this.btnServokm.Text = "Test";
            this.btnServokm.UseVisualStyleBackColor = false;
            this.btnServokm.Click += new System.EventHandler(this.btnServokm_Click);
            // 
            // btnServoFuel
            // 
            this.btnServoFuel.BackColor = System.Drawing.Color.Green;
            this.btnServoFuel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServoFuel.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServoFuel.Location = new System.Drawing.Point(45, 107);
            this.btnServoFuel.Name = "btnServoFuel";
            this.btnServoFuel.Size = new System.Drawing.Size(126, 45);
            this.btnServoFuel.TabIndex = 10;
            this.btnServoFuel.Text = "Test";
            this.btnServoFuel.UseVisualStyleBackColor = false;
            this.btnServoFuel.Click += new System.EventHandler(this.btnServoFuel_Click);
            // 
            // btnServoOil
            // 
            this.btnServoOil.BackColor = System.Drawing.Color.Green;
            this.btnServoOil.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnServoOil.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnServoOil.Location = new System.Drawing.Point(45, 318);
            this.btnServoOil.Name = "btnServoOil";
            this.btnServoOil.Size = new System.Drawing.Size(126, 45);
            this.btnServoOil.TabIndex = 4;
            this.btnServoOil.Text = "Test";
            this.btnServoOil.UseVisualStyleBackColor = false;
            this.btnServoOil.Click += new System.EventHandler(this.btnServoOil_Click);
            // 
            // DashBoardImg
            // 
            this.DashBoardImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DashBoardImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DashBoardImg.BackgroundImage")));
            this.DashBoardImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("DashBoardImg.InitialImage")));
            this.DashBoardImg.Location = new System.Drawing.Point(16, 17);
            this.DashBoardImg.Name = "DashBoardImg";
            this.DashBoardImg.Size = new System.Drawing.Size(1243, 428);
            this.DashBoardImg.TabIndex = 0;
            this.DashBoardImg.TabStop = false;
            // 
            // btnEncender
            // 
            this.btnEncender.BackColor = System.Drawing.Color.Green;
            this.btnEncender.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncender.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnEncender.Location = new System.Drawing.Point(7, 28);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(206, 45);
            this.btnEncender.TabIndex = 1;
            this.btnEncender.Text = "Enceder luces";
            this.btnEncender.UseVisualStyleBackColor = false;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "DashBoard Test";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Crimson;
            this.btnApagar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApagar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnApagar.Location = new System.Drawing.Point(228, 28);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(206, 45);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar luces";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // groupBoxLuces
            // 
            this.groupBoxLuces.BackColor = System.Drawing.Color.Crimson;
            this.groupBoxLuces.Controls.Add(this.btnEncender);
            this.groupBoxLuces.Controls.Add(this.btnApagar);
            this.groupBoxLuces.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLuces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLuces.Location = new System.Drawing.Point(360, 51);
            this.groupBoxLuces.Name = "groupBoxLuces";
            this.groupBoxLuces.Size = new System.Drawing.Size(445, 91);
            this.groupBoxLuces.TabIndex = 4;
            this.groupBoxLuces.TabStop = false;
            this.groupBoxLuces.Text = "Probar luces";
            this.groupBoxLuces.Visible = false;
            // 
            // groupBoxServos
            // 
            this.groupBoxServos.BackColor = System.Drawing.Color.Crimson;
            this.groupBoxServos.Controls.Add(this.btn180);
            this.groupBoxServos.Controls.Add(this.btn0);
            this.groupBoxServos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxServos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxServos.Location = new System.Drawing.Point(826, 51);
            this.groupBoxServos.Name = "groupBoxServos";
            this.groupBoxServos.Size = new System.Drawing.Size(445, 91);
            this.groupBoxServos.TabIndex = 5;
            this.groupBoxServos.TabStop = false;
            this.groupBoxServos.Text = "Probar Servos";
            this.groupBoxServos.Visible = false;
            // 
            // btn180
            // 
            this.btn180.BackColor = System.Drawing.Color.Green;
            this.btn180.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn180.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn180.Location = new System.Drawing.Point(7, 28);
            this.btn180.Name = "btn180";
            this.btn180.Size = new System.Drawing.Size(206, 45);
            this.btn180.TabIndex = 1;
            this.btn180.Text = "Mover 180°";
            this.btn180.UseVisualStyleBackColor = false;
            this.btn180.Click += new System.EventHandler(this.btn180_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Crimson;
            this.btn0.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn0.Location = new System.Drawing.Point(228, 28);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(206, 45);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "Volver a 0°";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // cmbPuertoCom
            // 
            this.cmbPuertoCom.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbPuertoCom.FormattingEnabled = true;
            this.cmbPuertoCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cmbPuertoCom.Location = new System.Drawing.Point(37, 101);
            this.cmbPuertoCom.Name = "cmbPuertoCom";
            this.cmbPuertoCom.Size = new System.Drawing.Size(172, 37);
            this.cmbPuertoCom.TabIndex = 6;
            this.cmbPuertoCom.Text = "Puertos COM";
            this.cmbPuertoCom.SelectedIndexChanged += new System.EventHandler(this.cmbPuertoCom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elija un puerto COM";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Green;
            this.btnConectar.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnConectar.Location = new System.Drawing.Point(215, 97);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(126, 45);
            this.btnConectar.TabIndex = 15;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCOM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCOM.Location = new System.Drawing.Point(215, 141);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(55, 20);
            this.lblCOM.TabIndex = 16;
            this.lblCOM.Text = "lblCOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Puerto seleccionado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1298, 656);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCOM);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPuertoCom);
            this.Controls.Add(this.groupBoxServos);
            this.Controls.Add(this.groupBoxLuces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FullBaster403 - DashBoardTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashBoardImg)).EndInit();
            this.groupBoxLuces.ResumeLayout(false);
            this.groupBoxServos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnServoAir;
        private Button btnServoTemp;
        private Button btnServoRPM;
        private Button btnServokm;
        private Button btnServoFuel;
        private Button btnServoOil;
        private PictureBox DashBoardImg;
        private Button btnEncender;
        private Label label1;
        private Button btnApagar;
        private GroupBox groupBoxLuces;
        private GroupBox groupBoxServos;
        private Button btn180;
        private Button btn0;
        private ComboBox cmbPuertoCom;
        private Label label2;
        private Button btnConectar;
        private Label lblCOM;
        private Label label3;
        private Panel panelluces;
        private Panel panel2;
    }
}