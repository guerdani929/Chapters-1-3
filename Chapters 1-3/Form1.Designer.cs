namespace Chapters_1_3
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.lblState = new System.Windows.Forms.Label();
            this.lblStateA = new System.Windows.Forms.Label();
            this.lblStateH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Please Enter Your Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 54);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(117, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Please Enter Your Age:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 112);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(159, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Please Enter Your Height in CM:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(184, 109);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(98, 151);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 50);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Data";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(204, 52);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(54, 20);
            this.numUD.TabIndex = 7;
            this.numUD.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 222);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 8;
            // 
            // lblStateA
            // 
            this.lblStateA.AutoSize = true;
            this.lblStateA.Location = new System.Drawing.Point(12, 245);
            this.lblStateA.Name = "lblStateA";
            this.lblStateA.Size = new System.Drawing.Size(0, 13);
            this.lblStateA.TabIndex = 9;
            // 
            // lblStateH
            // 
            this.lblStateH.AutoSize = true;
            this.lblStateH.Location = new System.Drawing.Point(12, 270);
            this.lblStateH.Name = "lblStateH";
            this.lblStateH.Size = new System.Drawing.Size(0, 13);
            this.lblStateH.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 324);
            this.Controls.Add(this.lblStateH);
            this.Controls.Add(this.lblStateA);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "Data Input";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStateA;
        private System.Windows.Forms.Label lblStateH;
    }
}

