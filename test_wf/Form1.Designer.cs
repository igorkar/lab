namespace test_wf
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.PictureBoxOrig = new System.Windows.Forms.PictureBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBoxTransformed = new System.Windows.Forms.PictureBox();
            this.ImageHistogram = new System.Windows.Forms.PictureBox();
            this.ButtonTransform = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Histogram1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTransformed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxOrig
            // 
            this.PictureBoxOrig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxOrig.Location = new System.Drawing.Point(12, 56);
            this.PictureBoxOrig.Name = "PictureBoxOrig";
            this.PictureBoxOrig.Size = new System.Drawing.Size(500, 500);
            this.PictureBoxOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxOrig.TabIndex = 0;
            this.PictureBoxOrig.TabStop = false;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(12, 12);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoad.TabIndex = 1;
            this.ButtonLoad.Text = "Load image";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(106, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "label1";
            // 
            // PictureBoxTransformed
            // 
            this.PictureBoxTransformed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxTransformed.Location = new System.Drawing.Point(542, 56);
            this.PictureBoxTransformed.Name = "PictureBoxTransformed";
            this.PictureBoxTransformed.Size = new System.Drawing.Size(500, 500);
            this.PictureBoxTransformed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTransformed.TabIndex = 3;
            this.PictureBoxTransformed.TabStop = false;
            // 
            // ImageHistogram
            // 
            this.ImageHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageHistogram.Location = new System.Drawing.Point(1090, 389);
            this.ImageHistogram.Name = "ImageHistogram";
            this.ImageHistogram.Size = new System.Drawing.Size(53, 100);
            this.ImageHistogram.TabIndex = 4;
            this.ImageHistogram.TabStop = false;
            // 
            // ButtonTransform
            // 
            this.ButtonTransform.Location = new System.Drawing.Point(1068, 133);
            this.ButtonTransform.Name = "ButtonTransform";
            this.ButtonTransform.Size = new System.Drawing.Size(75, 23);
            this.ButtonTransform.TabIndex = 5;
            this.ButtonTransform.Text = "Transform";
            this.ButtonTransform.UseVisualStyleBackColor = true;
            this.ButtonTransform.Click += new System.EventHandler(this.ButtonTransform_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1068, 56);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(542, 11);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save image";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(645, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "label2";
            // 
            // Histogram1
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "HistogramArea1";
            this.Histogram1.ChartAreas.Add(chartArea1);
            this.Histogram1.Location = new System.Drawing.Point(230, 405);
            this.Histogram1.Name = "Histogram1";
            this.Histogram1.Size = new System.Drawing.Size(512, 300);
            this.Histogram1.TabIndex = 10;
            this.Histogram1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 731);
            this.Controls.Add(this.Histogram1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.ButtonTransform);
            this.Controls.Add(this.ImageHistogram);
            this.Controls.Add(this.PictureBoxTransformed);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.PictureBoxOrig);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTransformed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxOrig;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBoxTransformed;
        private System.Windows.Forms.PictureBox ImageHistogram;
        private System.Windows.Forms.Button ButtonTransform;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histogram1;
    }
}

