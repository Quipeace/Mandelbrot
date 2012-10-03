namespace Mandelbrot
{
    partial class MandelbrotForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.nmThreads = new System.Windows.Forms.NumericUpDown();
            this.btRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIterations = new System.Windows.Forms.TextBox();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.tbCoordY = new System.Windows.Forms.TextBox();
            this.tbCoordX = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.pnFractal = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.colourBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmThreads)).BeginInit();
            this.gbControls.SuspendLayout();
            this.colourBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Threads";
            // 
            // nmThreads
            // 
            this.nmThreads.Location = new System.Drawing.Point(341, 18);
            this.nmThreads.Name = "nmThreads";
            this.nmThreads.Size = new System.Drawing.Size(32, 20);
            this.nmThreads.TabIndex = 9;
            this.nmThreads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btRun
            // 
            this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRun.Location = new System.Drawing.Point(381, 14);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 46);
            this.btRun.TabIndex = 8;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iterations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coordinates";
            // 
            // tbIterations
            // 
            this.tbIterations.Location = new System.Drawing.Point(118, 66);
            this.tbIterations.Name = "tbIterations";
            this.tbIterations.Size = new System.Drawing.Size(132, 20);
            this.tbIterations.TabIndex = 4;
            this.tbIterations.Text = "100";
            this.tbIterations.TextChanged += new System.EventHandler(this.tbIterations_TextChanged);
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(118, 40);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(132, 20);
            this.tbScale.TabIndex = 3;
            this.tbScale.Text = "0,01";
            this.tbScale.TextChanged += new System.EventHandler(this.tbScale_TextChanged);
            // 
            // tbCoordY
            // 
            this.tbCoordY.Location = new System.Drawing.Point(187, 14);
            this.tbCoordY.Name = "tbCoordY";
            this.tbCoordY.Size = new System.Drawing.Size(63, 20);
            this.tbCoordY.TabIndex = 2;
            this.tbCoordY.Text = "0,0";
            this.tbCoordY.TextChanged += new System.EventHandler(this.tbCoordY_TextChanged);
            // 
            // tbCoordX
            // 
            this.tbCoordX.Location = new System.Drawing.Point(118, 14);
            this.tbCoordX.Name = "tbCoordX";
            this.tbCoordX.Size = new System.Drawing.Size(63, 20);
            this.tbCoordX.TabIndex = 1;
            this.tbCoordX.Text = "0,0";
            this.tbCoordX.TextChanged += new System.EventHandler(this.tbCoordX_TextChanged);
            // 
            // btReset
            // 
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btReset.Location = new System.Drawing.Point(381, 67);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // pnFractal
            // 
            this.pnFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFractal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnFractal.Location = new System.Drawing.Point(12, 117);
            this.pnFractal.Name = "pnFractal";
            this.pnFractal.Size = new System.Drawing.Size(772, 482);
            this.pnFractal.TabIndex = 3;
            this.pnFractal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFractal_Paint);
            this.pnFractal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnFractal_MouseClick);
            this.pnFractal.Resize += new System.EventHandler(this.pnFractal_Resize);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(260, 43);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(113, 43);
            this.listBox.TabIndex = 11;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.listBox);
            this.gbControls.Controls.Add(this.label4);
            this.gbControls.Controls.Add(this.nmThreads);
            this.gbControls.Controls.Add(this.btRun);
            this.gbControls.Controls.Add(this.label3);
            this.gbControls.Controls.Add(this.label2);
            this.gbControls.Controls.Add(this.label1);
            this.gbControls.Controls.Add(this.tbIterations);
            this.gbControls.Controls.Add(this.tbScale);
            this.gbControls.Controls.Add(this.tbCoordY);
            this.gbControls.Controls.Add(this.tbCoordX);
            this.gbControls.Controls.Add(this.btReset);
            this.gbControls.Location = new System.Drawing.Point(12, 12);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(462, 99);
            this.gbControls.TabIndex = 0;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // colourBox
            // 
            this.colourBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colourBox.Controls.Add(this.label13);
            this.colourBox.Controls.Add(this.label12);
            this.colourBox.Controls.Add(this.label11);
            this.colourBox.Controls.Add(this.label10);
            this.colourBox.Controls.Add(this.label9);
            this.colourBox.Controls.Add(this.label8);
            this.colourBox.Controls.Add(this.trackGreen);
            this.colourBox.Controls.Add(this.trackRed);
            this.colourBox.Controls.Add(this.trackBlue);
            this.colourBox.Controls.Add(this.label7);
            this.colourBox.Controls.Add(this.label6);
            this.colourBox.Controls.Add(this.label5);
            this.colourBox.Location = new System.Drawing.Point(483, 12);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(301, 99);
            this.colourBox.TabIndex = 4;
            this.colourBox.TabStop = false;
            this.colourBox.Text = "Colours";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "+";
            // 
            // trackGreen
            // 
            this.trackGreen.AutoSize = false;
            this.trackGreen.Location = new System.Drawing.Point(80, 43);
            this.trackGreen.Maximum = 240;
            this.trackGreen.Minimum = 2;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(196, 21);
            this.trackGreen.TabIndex = 19;
            this.trackGreen.Value = 65;
            // 
            // trackRed
            // 
            this.trackRed.AutoSize = false;
            this.trackRed.Location = new System.Drawing.Point(80, 14);
            this.trackRed.Maximum = 240;
            this.trackRed.Minimum = 2;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(196, 24);
            this.trackRed.TabIndex = 18;
            this.trackRed.Value = 50;
            // 
            // trackBlue
            // 
            this.trackBlue.AutoSize = false;
            this.trackBlue.Location = new System.Drawing.Point(80, 66);
            this.trackBlue.Maximum = 240;
            this.trackBlue.Minimum = 2;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(196, 20);
            this.trackBlue.TabIndex = 17;
            this.trackBlue.Value = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Red";
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 611);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.pnFractal);
            this.Controls.Add(this.gbControls);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MandelbrotForm";
            this.Text = "Mandelbrot";
            ((System.ComponentModel.ISupportInitialize)(this.nmThreads)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.colourBox.ResumeLayout(false);
            this.colourBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tbIterations;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.TextBox tbCoordY;
        private System.Windows.Forms.TextBox tbCoordX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmThreads;
        private System.Windows.Forms.Panel pnFractal;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.GroupBox colourBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

