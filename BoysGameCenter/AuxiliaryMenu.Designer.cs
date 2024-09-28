namespace BoysGameCenter
{
    partial class AuxiliaryMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuxiliaryMenu));
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.reservation_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.increase_time_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.increase_time_label = new System.Windows.Forms.Label();
            this.reservation_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increase_time_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.Color.ForestGreen;
            this.accept_button.Font = new System.Drawing.Font("Mj_Farah Medium", 12F, System.Drawing.FontStyle.Bold);
            this.accept_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.accept_button.Location = new System.Drawing.Point(299, 227);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(113, 45);
            this.accept_button.TabIndex = 41;
            this.accept_button.Text = "تایید";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Red;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Font = new System.Drawing.Font("Mj_Farah Medium", 12F, System.Drawing.FontStyle.Bold);
            this.cancel_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_button.Location = new System.Drawing.Point(107, 227);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(113, 45);
            this.cancel_button.TabIndex = 40;
            this.cancel_button.Text = "لغو";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // reservation_numericUpDown
            // 
            this.reservation_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_numericUpDown.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.reservation_numericUpDown.Location = new System.Drawing.Point(137, 162);
            this.reservation_numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.reservation_numericUpDown.Name = "reservation_numericUpDown";
            this.reservation_numericUpDown.ReadOnly = true;
            this.reservation_numericUpDown.Size = new System.Drawing.Size(113, 34);
            this.reservation_numericUpDown.TabIndex = 38;
            // 
            // increase_time_numericUpDown
            // 
            this.increase_time_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_time_numericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.increase_time_numericUpDown.Location = new System.Drawing.Point(107, 88);
            this.increase_time_numericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.increase_time_numericUpDown.Name = "increase_time_numericUpDown";
            this.increase_time_numericUpDown.ReadOnly = true;
            this.increase_time_numericUpDown.Size = new System.Drawing.Size(113, 34);
            this.increase_time_numericUpDown.TabIndex = 39;
            // 
            // increase_time_label
            // 
            this.increase_time_label.AutoSize = true;
            this.increase_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_time_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.increase_time_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.increase_time_label.Location = new System.Drawing.Point(237, 87);
            this.increase_time_label.Name = "increase_time_label";
            this.increase_time_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.increase_time_label.Size = new System.Drawing.Size(181, 32);
            this.increase_time_label.TabIndex = 36;
            this.increase_time_label.Text = "اضافه کردن تایم :";
            // 
            // reservation_label
            // 
            this.reservation_label.AutoSize = true;
            this.reservation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservation_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reservation_label.Location = new System.Drawing.Point(267, 161);
            this.reservation_label.Name = "reservation_label";
            this.reservation_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reservation_label.Size = new System.Drawing.Size(130, 32);
            this.reservation_label.TabIndex = 37;
            this.reservation_label.Text = "رزرو وقت :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("TitrZebr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 40);
            this.label1.TabIndex = 34;
            this.label1.Text = "Boys\' Game Center";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("TitrZebr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(368, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 40);
            this.label5.TabIndex = 35;
            this.label5.Text = "منو کمکی";
            // 
            // AuxiliaryMenu
            // 
            this.AcceptButton = this.accept_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(524, 318);
            this.ControlBox = false;
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.reservation_numericUpDown);
            this.Controls.Add(this.increase_time_numericUpDown);
            this.Controls.Add(this.increase_time_label);
            this.Controls.Add(this.reservation_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuxiliaryMenu";
            this.Text = "AuxiliaryMenu";
            ((System.ComponentModel.ISupportInitialize)(this.reservation_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increase_time_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.NumericUpDown reservation_numericUpDown;
        private System.Windows.Forms.NumericUpDown increase_time_numericUpDown;
        private System.Windows.Forms.Label increase_time_label;
        private System.Windows.Forms.Label reservation_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}