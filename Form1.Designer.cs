namespace lab1._2
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
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.labelDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.Location = new System.Drawing.Point(64, 96);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(165, 160);
            this.listBoxVehicles.TabIndex = 0;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(64, 22);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(165, 50);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "Завантажити дані";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDetails.Location = new System.Drawing.Point(281, 40);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(244, 212);
            this.labelDetails.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 301);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.listBoxVehicles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label labelDetails;
    }
}

