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
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnFractal = new System.Windows.Forms.Panel();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThreads)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbControls.Size = new System.Drawing.Size(460, 99);
            this.gbControls.TabIndex = 0;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
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
            this.btRun.Location = new System.Drawing.Point(379, 14);
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
            this.btReset.Location = new System.Drawing.Point(379, 67);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 589);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // pnFractal
            // 
            this.pnFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFractal.Location = new System.Drawing.Point(12, 117);
            this.pnFractal.Name = "pnFractal";
            this.pnFractal.Size = new System.Drawing.Size(460, 460);
            this.pnFractal.TabIndex = 3;
            this.pnFractal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnFractal_MouseClick);
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.pnFractal);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbControls);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "MandelbrotForm";
            this.Text = "Mandelbrot";
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmThreads)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControls;
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
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel pnFractal;

    }
}

