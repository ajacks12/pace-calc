namespace PaceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDist = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.textDist = new System.Windows.Forms.TextBox();
            this.textSplit = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.buttonWeight = new System.Windows.Forms.Button();
            this.textWATime = new System.Windows.Forms.TextBox();
            this.textWADist = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDist
            // 
            this.buttonDist.Location = new System.Drawing.Point(73, 8);
            this.buttonDist.Name = "buttonDist";
            this.buttonDist.Size = new System.Drawing.Size(64, 26);
            this.buttonDist.TabIndex = 0;
            this.buttonDist.Text = "Distance";
            this.buttonDist.UseVisualStyleBackColor = true;
            this.buttonDist.Click += new System.EventHandler(this.buttonDist_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(73, 40);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(64, 26);
            this.buttonSplit.TabIndex = 1;
            this.buttonSplit.Text = "Split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // buttonTime
            // 
            this.buttonTime.Location = new System.Drawing.Point(73, 72);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(64, 26);
            this.buttonTime.TabIndex = 2;
            this.buttonTime.Text = "Time";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // textDist
            // 
            this.textDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDist.ForeColor = System.Drawing.Color.Gray;
            this.textDist.Location = new System.Drawing.Point(12, 12);
            this.textDist.Name = "textDist";
            this.textDist.Size = new System.Drawing.Size(55, 20);
            this.textDist.TabIndex = 3;
            this.textDist.Text = "Metres";
            this.textDist.Enter += new System.EventHandler(this.textDist_Enter);
            this.textDist.Leave += new System.EventHandler(this.textDist_Leave);
            // 
            // textSplit
            // 
            this.textSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSplit.ForeColor = System.Drawing.Color.Gray;
            this.textSplit.Location = new System.Drawing.Point(12, 44);
            this.textSplit.Name = "textSplit";
            this.textSplit.Size = new System.Drawing.Size(55, 20);
            this.textSplit.TabIndex = 4;
            this.textSplit.Text = "mm:ss[.0]";
            this.textSplit.Enter += new System.EventHandler(this.textSplit_Enter);
            this.textSplit.Leave += new System.EventHandler(this.textSplit_Leave);
            // 
            // textTime
            // 
            this.textTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTime.ForeColor = System.Drawing.Color.Gray;
            this.textTime.Location = new System.Drawing.Point(12, 76);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(55, 20);
            this.textTime.TabIndex = 5;
            this.textTime.Text = "mm:ss[.0]";
            this.textTime.Enter += new System.EventHandler(this.textTime_Enter);
            this.textTime.Leave += new System.EventHandler(this.textTime_Leave);
            // 
            // textWeight
            // 
            this.textWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWeight.ForeColor = System.Drawing.Color.Gray;
            this.textWeight.Location = new System.Drawing.Point(12, 108);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(55, 20);
            this.textWeight.TabIndex = 5;
            this.textWeight.Text = "kg";
            this.textWeight.Enter += new System.EventHandler(this.textWeight_Enter);
            this.textWeight.Leave += new System.EventHandler(this.textWeight_Leave);
            // 
            // buttonWeight
            // 
            this.buttonWeight.Location = new System.Drawing.Point(73, 104);
            this.buttonWeight.Name = "buttonWeight";
            this.buttonWeight.Size = new System.Drawing.Size(64, 26);
            this.buttonWeight.TabIndex = 2;
            this.buttonWeight.Text = "Weight";
            this.buttonWeight.UseVisualStyleBackColor = true;
            this.buttonWeight.Click += new System.EventHandler(this.buttonWeight_Click);
            // 
            // textWATime
            // 
            this.textWATime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWATime.ForeColor = System.Drawing.Color.Gray;
            this.textWATime.Location = new System.Drawing.Point(12, 136);
            this.textWATime.Name = "textWATime";
            this.textWATime.ReadOnly = true;
            this.textWATime.Size = new System.Drawing.Size(55, 20);
            this.textWATime.TabIndex = 5;
            this.textWATime.Text = "-";
            // 
            // textWADist
            // 
            this.textWADist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWADist.ForeColor = System.Drawing.Color.Gray;
            this.textWADist.Location = new System.Drawing.Point(12, 162);
            this.textWADist.Name = "textWADist";
            this.textWADist.ReadOnly = true;
            this.textWADist.Size = new System.Drawing.Size(55, 20);
            this.textWADist.TabIndex = 5;
            this.textWADist.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(73, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "WA Time";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(73, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(64, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "WA Dist";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 192);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textWADist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textWATime);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textSplit);
            this.Controls.Add(this.buttonWeight);
            this.Controls.Add(this.textDist);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonSplit);
            this.Controls.Add(this.buttonDist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(160, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(160, 230);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pace Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDist;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.TextBox textDist;
        private System.Windows.Forms.TextBox textSplit;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.Button buttonWeight;
        private System.Windows.Forms.TextBox textWATime;
        private System.Windows.Forms.TextBox textWADist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}

