
namespace AntiAFK
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.DelayInput = new System.Windows.Forms.NumericUpDown();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AFKImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DelayInput)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFKImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Milliseconds",
            "Seconds"});
            this.TypeBox.Location = new System.Drawing.Point(41, 85);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 0;
            // 
            // DelayInput
            // 
            this.DelayInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DelayInput.Location = new System.Drawing.Point(190, 86);
            this.DelayInput.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.DelayInput.Name = "DelayInput";
            this.DelayInput.Size = new System.Drawing.Size(120, 20);
            this.DelayInput.TabIndex = 1;
            this.DelayInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ToggleButton
            // 
            this.ToggleButton.Location = new System.Drawing.Point(138, 156);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(75, 23);
            this.ToggleButton.TabIndex = 2;
            this.ToggleButton.Text = "Enable";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(187, 70);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(34, 13);
            this.DelayLabel.TabIndex = 3;
            this.DelayLabel.Text = "Delay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AFKImage);
            this.panel1.Controls.Add(this.DelayLabel);
            this.panel1.Controls.Add(this.ToggleButton);
            this.panel1.Controls.Add(this.TypeBox);
            this.panel1.Controls.Add(this.DelayInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 237);
            this.panel1.TabIndex = 4;
            // 
            // AFKImage
            // 
            this.AFKImage.BackgroundImage = global::AntiAFK.Properties.Resources.AntiAFKTransparent;
            this.AFKImage.Image = global::AntiAFK.Properties.Resources.AntiAFKTransparent;
            this.AFKImage.InitialImage = global::AntiAFK.Properties.Resources.AntiAFKTransparent;
            this.AFKImage.Location = new System.Drawing.Point(219, 150);
            this.AFKImage.Name = "AFKImage";
            this.AFKImage.Size = new System.Drawing.Size(32, 32);
            this.AFKImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AFKImage.TabIndex = 4;
            this.AFKImage.TabStop = false;
            this.AFKImage.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainWindow";
            this.Text = "AntiAFK";
            ((System.ComponentModel.ISupportInitialize)(this.DelayInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AFKImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.NumericUpDown DelayInput;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AFKImage;
    }
}

