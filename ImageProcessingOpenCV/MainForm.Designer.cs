namespace ImageProcessingOpenCV
{
    partial class MainForm
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
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btImageProcess = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btn_FirstApproximation = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nupd_FirstApproxP20 = new System.Windows.Forms.NumericUpDown();
            this.nupd_FirstApproxP10 = new System.Windows.Forms.NumericUpDown();
            this.nupd_FirstApproxPan = new System.Windows.Forms.NumericUpDown();
            this.nupd_FirstApproxTilt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupd_FirstApproxP11 = new System.Windows.Forms.NumericUpDown();
            this.nupd_FirstApproxP21 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nupd_FinalParams_Tilt = new System.Windows.Forms.NumericUpDown();
            this.nupd_FinalParams_Pan = new System.Windows.Forms.NumericUpDown();
            this.btn_FinalParams = new System.Windows.Forms.Button();
            this.nupd_FinalParams_Zoom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FinalParams_R_Load = new System.Windows.Forms.TextBox();
            this.btn_FinalParams_R_Load = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_FinalParams_P_Load = new System.Windows.Forms.Button();
            this.txt_FinalParams_P_Load = new System.Windows.Forms.TextBox();
            this.pb_RImage = new System.Windows.Forms.PictureBox();
            this.pb_PImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP21)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Tilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Pan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(18, 18);
            this.pbMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(452, 464);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // btImageProcess
            // 
            this.btImageProcess.Location = new System.Drawing.Point(904, 20);
            this.btImageProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btImageProcess.Name = "btImageProcess";
            this.btImageProcess.Size = new System.Drawing.Size(145, 35);
            this.btImageProcess.TabIndex = 1;
            this.btImageProcess.Text = "Process";
            this.btImageProcess.UseVisualStyleBackColor = true;
            this.btImageProcess.Click += new System.EventHandler(this.btImageProcess_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(784, 20);
            this.btLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(112, 35);
            this.btLoad.TabIndex = 2;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(482, 23);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(292, 26);
            this.tbPath.TabIndex = 3;
            // 
            // btn_FirstApproximation
            // 
            this.btn_FirstApproximation.Location = new System.Drawing.Point(-6, 349);
            this.btn_FirstApproximation.Name = "btn_FirstApproximation";
            this.btn_FirstApproximation.Size = new System.Drawing.Size(330, 51);
            this.btn_FirstApproximation.TabIndex = 4;
            this.btn_FirstApproximation.Text = "First Approximation";
            this.btn_FirstApproximation.UseVisualStyleBackColor = true;
            this.btn_FirstApproximation.Click += new System.EventHandler(this.btn_FirstApproximation_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nupd_FirstApproxTilt);
            this.panel1.Controls.Add(this.nupd_FirstApproxPan);
            this.panel1.Controls.Add(this.nupd_FirstApproxP21);
            this.panel1.Controls.Add(this.nupd_FirstApproxP20);
            this.panel1.Controls.Add(this.nupd_FirstApproxP11);
            this.panel1.Controls.Add(this.nupd_FirstApproxP10);
            this.panel1.Controls.Add(this.btn_FirstApproximation);
            this.panel1.Location = new System.Drawing.Point(482, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 405);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "P2[0]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "P1[0]";
            // 
            // nupd_FirstApproxP20
            // 
            this.nupd_FirstApproxP20.Location = new System.Drawing.Point(222, 15);
            this.nupd_FirstApproxP20.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_FirstApproxP20.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxP20.Name = "nupd_FirstApproxP20";
            this.nupd_FirstApproxP20.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxP20.TabIndex = 5;
            // 
            // nupd_FirstApproxP10
            // 
            this.nupd_FirstApproxP10.Location = new System.Drawing.Point(54, 15);
            this.nupd_FirstApproxP10.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_FirstApproxP10.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxP10.Name = "nupd_FirstApproxP10";
            this.nupd_FirstApproxP10.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxP10.TabIndex = 5;
            // 
            // nupd_FirstApproxPan
            // 
            this.nupd_FirstApproxPan.DecimalPlaces = 5;
            this.nupd_FirstApproxPan.Location = new System.Drawing.Point(54, 79);
            this.nupd_FirstApproxPan.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nupd_FirstApproxPan.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxPan.Name = "nupd_FirstApproxPan";
            this.nupd_FirstApproxPan.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxPan.TabIndex = 5;
            // 
            // nupd_FirstApproxTilt
            // 
            this.nupd_FirstApproxTilt.DecimalPlaces = 5;
            this.nupd_FirstApproxTilt.Location = new System.Drawing.Point(222, 79);
            this.nupd_FirstApproxTilt.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nupd_FirstApproxTilt.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxTilt.Name = "nupd_FirstApproxTilt";
            this.nupd_FirstApproxTilt.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxTilt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tilt";
            // 
            // nupd_FirstApproxP11
            // 
            this.nupd_FirstApproxP11.Location = new System.Drawing.Point(54, 47);
            this.nupd_FirstApproxP11.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_FirstApproxP11.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxP11.Name = "nupd_FirstApproxP11";
            this.nupd_FirstApproxP11.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxP11.TabIndex = 5;
            // 
            // nupd_FirstApproxP21
            // 
            this.nupd_FirstApproxP21.Location = new System.Drawing.Point(222, 47);
            this.nupd_FirstApproxP21.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupd_FirstApproxP21.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupd_FirstApproxP21.Name = "nupd_FirstApproxP21";
            this.nupd_FirstApproxP21.Size = new System.Drawing.Size(103, 26);
            this.nupd_FirstApproxP21.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "P1[1]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "P2[1]";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pb_PImage);
            this.panel2.Controls.Add(this.pb_RImage);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_FinalParams_P_Load);
            this.panel2.Controls.Add(this.txt_FinalParams_R_Load);
            this.panel2.Controls.Add(this.btn_FinalParams_P_Load);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btn_FinalParams_R_Load);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.nupd_FinalParams_Zoom);
            this.panel2.Controls.Add(this.nupd_FinalParams_Tilt);
            this.panel2.Controls.Add(this.nupd_FinalParams_Pan);
            this.panel2.Controls.Add(this.btn_FinalParams);
            this.panel2.Location = new System.Drawing.Point(818, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 405);
            this.panel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tilt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Pan";
            // 
            // nupd_FinalParams_Tilt
            // 
            this.nupd_FinalParams_Tilt.DecimalPlaces = 5;
            this.nupd_FinalParams_Tilt.Location = new System.Drawing.Point(120, 312);
            this.nupd_FinalParams_Tilt.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nupd_FinalParams_Tilt.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nupd_FinalParams_Tilt.Name = "nupd_FinalParams_Tilt";
            this.nupd_FinalParams_Tilt.Size = new System.Drawing.Size(103, 26);
            this.nupd_FinalParams_Tilt.TabIndex = 5;
            // 
            // nupd_FinalParams_Pan
            // 
            this.nupd_FinalParams_Pan.DecimalPlaces = 5;
            this.nupd_FinalParams_Pan.Location = new System.Drawing.Point(10, 312);
            this.nupd_FinalParams_Pan.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nupd_FinalParams_Pan.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nupd_FinalParams_Pan.Name = "nupd_FinalParams_Pan";
            this.nupd_FinalParams_Pan.Size = new System.Drawing.Size(103, 26);
            this.nupd_FinalParams_Pan.TabIndex = 5;
            // 
            // btn_FinalParams
            // 
            this.btn_FinalParams.Location = new System.Drawing.Point(3, 349);
            this.btn_FinalParams.Name = "btn_FinalParams";
            this.btn_FinalParams.Size = new System.Drawing.Size(341, 51);
            this.btn_FinalParams.TabIndex = 4;
            this.btn_FinalParams.Text = "Final Params";
            this.btn_FinalParams.UseVisualStyleBackColor = true;
            this.btn_FinalParams.Click += new System.EventHandler(this.btn_FinalParams_Click);
            // 
            // nupd_FinalParams_Zoom
            // 
            this.nupd_FinalParams_Zoom.Location = new System.Drawing.Point(229, 312);
            this.nupd_FinalParams_Zoom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupd_FinalParams_Zoom.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nupd_FinalParams_Zoom.Name = "nupd_FinalParams_Zoom";
            this.nupd_FinalParams_Zoom.Size = new System.Drawing.Size(103, 26);
            this.nupd_FinalParams_Zoom.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Zoom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "RPath";
            // 
            // txt_FinalParams_R_Load
            // 
            this.txt_FinalParams_R_Load.Location = new System.Drawing.Point(65, 14);
            this.txt_FinalParams_R_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FinalParams_R_Load.Name = "txt_FinalParams_R_Load";
            this.txt_FinalParams_R_Load.Size = new System.Drawing.Size(156, 26);
            this.txt_FinalParams_R_Load.TabIndex = 3;
            // 
            // btn_FinalParams_R_Load
            // 
            this.btn_FinalParams_R_Load.Location = new System.Drawing.Point(229, 14);
            this.btn_FinalParams_R_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FinalParams_R_Load.Name = "btn_FinalParams_R_Load";
            this.btn_FinalParams_R_Load.Size = new System.Drawing.Size(112, 27);
            this.btn_FinalParams_R_Load.TabIndex = 2;
            this.btn_FinalParams_R_Load.Text = "Load";
            this.btn_FinalParams_R_Load.UseVisualStyleBackColor = true;
            this.btn_FinalParams_R_Load.Click += new System.EventHandler(this.btn_FinalParams_R_Load_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "PPath";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btn_FinalParams_P_Load
            // 
            this.btn_FinalParams_P_Load.Location = new System.Drawing.Point(229, 51);
            this.btn_FinalParams_P_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FinalParams_P_Load.Name = "btn_FinalParams_P_Load";
            this.btn_FinalParams_P_Load.Size = new System.Drawing.Size(112, 27);
            this.btn_FinalParams_P_Load.TabIndex = 2;
            this.btn_FinalParams_P_Load.Text = "Load";
            this.btn_FinalParams_P_Load.UseVisualStyleBackColor = true;
            this.btn_FinalParams_P_Load.Click += new System.EventHandler(this.btn_FinalParams_P_Load_Click);
            // 
            // txt_FinalParams_P_Load
            // 
            this.txt_FinalParams_P_Load.Location = new System.Drawing.Point(65, 51);
            this.txt_FinalParams_P_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FinalParams_P_Load.Name = "txt_FinalParams_P_Load";
            this.txt_FinalParams_P_Load.Size = new System.Drawing.Size(156, 26);
            this.txt_FinalParams_P_Load.TabIndex = 3;
            // 
            // pb_RImage
            // 
            this.pb_RImage.Location = new System.Drawing.Point(13, 99);
            this.pb_RImage.Name = "pb_RImage";
            this.pb_RImage.Size = new System.Drawing.Size(147, 156);
            this.pb_RImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_RImage.TabIndex = 7;
            this.pb_RImage.TabStop = false;
            // 
            // pb_PImage
            // 
            this.pb_PImage.Location = new System.Drawing.Point(185, 99);
            this.pb_PImage.Name = "pb_PImage";
            this.pb_PImage.Size = new System.Drawing.Size(147, 156);
            this.pb_PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PImage.TabIndex = 7;
            this.pb_PImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btImageProcess);
            this.Controls.Add(this.pbMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FirstApproxP21)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Tilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Pan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_FinalParams_Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_RImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btImageProcess;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btn_FirstApproximation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxP20;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxP10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxTilt;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxPan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxP21;
        private System.Windows.Forms.NumericUpDown nupd_FirstApproxP11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupd_FinalParams_Tilt;
        private System.Windows.Forms.NumericUpDown nupd_FinalParams_Pan;
        private System.Windows.Forms.Button btn_FinalParams;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_FinalParams_P_Load;
        private System.Windows.Forms.TextBox txt_FinalParams_R_Load;
        private System.Windows.Forms.Button btn_FinalParams_P_Load;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_FinalParams_R_Load;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupd_FinalParams_Zoom;
        private System.Windows.Forms.PictureBox pb_PImage;
        private System.Windows.Forms.PictureBox pb_RImage;
    }
}