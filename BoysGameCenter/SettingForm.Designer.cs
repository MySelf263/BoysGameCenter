namespace BoysGameCenter
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveLocationButton = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.Ps5_No_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Ps5_price_label = new System.Windows.Forms.Label();
            this.Ps5_No_label = new System.Windows.Forms.Label();
            this.Ps5_ctrlr_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Ps4_ctrlr_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Ps4_Price_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Ps4_No_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.Ps5_ctrlr_label = new System.Windows.Forms.Label();
            this.Ps4_ctrlr_label = new System.Windows.Forms.Label();
            this.Ps4_price_label = new System.Windows.Forms.Label();
            this.Ps4_No_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveLocationButton
            // 
            resources.ApplyResources(this.saveLocationButton, "saveLocationButton");
            this.saveLocationButton.Name = "saveLocationButton";
            this.saveLocationButton.UseVisualStyleBackColor = true;
            this.saveLocationButton.Click += new System.EventHandler(this.saveLocationButton_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Red;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancel_button, "cancel_button");
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.accept_button, "accept_button");
            this.accept_button.Name = "accept_button";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Name = "label5";
            // 
            // domainUpDown2
            // 
            resources.ApplyResources(this.domainUpDown2, "domainUpDown2");
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.ReadOnly = true;
            // 
            // Ps5_No_domainUpDown
            // 
            resources.ApplyResources(this.Ps5_No_domainUpDown, "Ps5_No_domainUpDown");
            this.Ps5_No_domainUpDown.Name = "Ps5_No_domainUpDown";
            this.Ps5_No_domainUpDown.ReadOnly = true;
            // 
            // Ps5_price_label
            // 
            resources.ApplyResources(this.Ps5_price_label, "Ps5_price_label");
            this.Ps5_price_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps5_price_label.Name = "Ps5_price_label";
            // 
            // Ps5_No_label
            // 
            resources.ApplyResources(this.Ps5_No_label, "Ps5_No_label");
            this.Ps5_No_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps5_No_label.Name = "Ps5_No_label";
            // 
            // Ps5_ctrlr_domainUpDown
            // 
            resources.ApplyResources(this.Ps5_ctrlr_domainUpDown, "Ps5_ctrlr_domainUpDown");
            this.Ps5_ctrlr_domainUpDown.Name = "Ps5_ctrlr_domainUpDown";
            this.Ps5_ctrlr_domainUpDown.ReadOnly = true;
            // 
            // Ps4_ctrlr_domainUpDown
            // 
            resources.ApplyResources(this.Ps4_ctrlr_domainUpDown, "Ps4_ctrlr_domainUpDown");
            this.Ps4_ctrlr_domainUpDown.Name = "Ps4_ctrlr_domainUpDown";
            this.Ps4_ctrlr_domainUpDown.ReadOnly = true;
            // 
            // Ps4_Price_domainUpDown
            // 
            resources.ApplyResources(this.Ps4_Price_domainUpDown, "Ps4_Price_domainUpDown");
            this.Ps4_Price_domainUpDown.Name = "Ps4_Price_domainUpDown";
            this.Ps4_Price_domainUpDown.ReadOnly = true;
            // 
            // Ps4_No_domainUpDown
            // 
            resources.ApplyResources(this.Ps4_No_domainUpDown, "Ps4_No_domainUpDown");
            this.Ps4_No_domainUpDown.Name = "Ps4_No_domainUpDown";
            this.Ps4_No_domainUpDown.ReadOnly = true;
            // 
            // Ps5_ctrlr_label
            // 
            resources.ApplyResources(this.Ps5_ctrlr_label, "Ps5_ctrlr_label");
            this.Ps5_ctrlr_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps5_ctrlr_label.Name = "Ps5_ctrlr_label";
            // 
            // Ps4_ctrlr_label
            // 
            resources.ApplyResources(this.Ps4_ctrlr_label, "Ps4_ctrlr_label");
            this.Ps4_ctrlr_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps4_ctrlr_label.Name = "Ps4_ctrlr_label";
            // 
            // Ps4_price_label
            // 
            resources.ApplyResources(this.Ps4_price_label, "Ps4_price_label");
            this.Ps4_price_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps4_price_label.Name = "Ps4_price_label";
            // 
            // Ps4_No_label
            // 
            resources.ApplyResources(this.Ps4_No_label, "Ps4_No_label");
            this.Ps4_No_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ps4_No_label.Name = "Ps4_No_label";
            // 
            // SettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ControlBox = false;
            this.Controls.Add(this.saveLocationButton);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.Ps5_No_domainUpDown);
            this.Controls.Add(this.Ps5_price_label);
            this.Controls.Add(this.Ps5_No_label);
            this.Controls.Add(this.Ps5_ctrlr_domainUpDown);
            this.Controls.Add(this.Ps4_ctrlr_domainUpDown);
            this.Controls.Add(this.Ps4_Price_domainUpDown);
            this.Controls.Add(this.Ps4_No_domainUpDown);
            this.Controls.Add(this.Ps5_ctrlr_label);
            this.Controls.Add(this.Ps4_ctrlr_label);
            this.Controls.Add(this.Ps4_price_label);
            this.Controls.Add(this.Ps4_No_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button saveLocationButton;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown Ps5_No_domainUpDown;
        private System.Windows.Forms.Label Ps5_price_label;
        private System.Windows.Forms.Label Ps5_No_label;
        private System.Windows.Forms.DomainUpDown Ps5_ctrlr_domainUpDown;
        private System.Windows.Forms.DomainUpDown Ps4_ctrlr_domainUpDown;
        private System.Windows.Forms.DomainUpDown Ps4_Price_domainUpDown;
        private System.Windows.Forms.DomainUpDown Ps4_No_domainUpDown;
        private System.Windows.Forms.Label Ps5_ctrlr_label;
        private System.Windows.Forms.Label Ps4_ctrlr_label;
        private System.Windows.Forms.Label Ps4_price_label;
        private System.Windows.Forms.Label Ps4_No_label;
    }
}