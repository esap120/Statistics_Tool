namespace Statistics_Tool
{
    partial class stats_tool_form
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
            this.data = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.average_result = new System.Windows.Forms.TextBox();
            this.average_checkbox = new System.Windows.Forms.CheckBox();
            this.average_label = new System.Windows.Forms.Label();
            this.minimum_checkbox = new System.Windows.Forms.CheckBox();
            this.minimum_result = new System.Windows.Forms.TextBox();
            this.minimum_label = new System.Windows.Forms.Label();
            this.maximum_label = new System.Windows.Forms.Label();
            this.maximum_result = new System.Windows.Forms.TextBox();
            this.mode_label = new System.Windows.Forms.Label();
            this.mode_result = new System.Windows.Forms.TextBox();
            this.maximum_checkbox = new System.Windows.Forms.CheckBox();
            this.mode_checkbox = new System.Windows.Forms.CheckBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.Location = new System.Drawing.Point(60, 46);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(601, 229);
            this.data.TabIndex = 0;
            this.data.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculate_button
            // 
            this.calculate_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculate_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calculate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculate_button.Location = new System.Drawing.Point(267, 357);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(76, 27);
            this.calculate_button.TabIndex = 1;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = false;
            this.calculate_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // average_result
            // 
            this.average_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.average_result.Location = new System.Drawing.Point(152, 417);
            this.average_result.Name = "average_result";
            this.average_result.Size = new System.Drawing.Size(154, 22);
            this.average_result.TabIndex = 2;
            // 
            // average_checkbox
            // 
            this.average_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.average_checkbox.AutoSize = true;
            this.average_checkbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.average_checkbox.Location = new System.Drawing.Point(120, 302);
            this.average_checkbox.Name = "average_checkbox";
            this.average_checkbox.Size = new System.Drawing.Size(83, 21);
            this.average_checkbox.TabIndex = 3;
            this.average_checkbox.Text = "Average";
            this.average_checkbox.UseVisualStyleBackColor = true;
            // 
            // average_label
            // 
            this.average_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.average_label.AutoSize = true;
            this.average_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.average_label.Location = new System.Drawing.Point(77, 417);
            this.average_label.Name = "average_label";
            this.average_label.Size = new System.Drawing.Size(61, 17);
            this.average_label.TabIndex = 4;
            this.average_label.Text = "Average";
            this.average_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // minimum_checkbox
            // 
            this.minimum_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimum_checkbox.AutoSize = true;
            this.minimum_checkbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimum_checkbox.Location = new System.Drawing.Point(247, 302);
            this.minimum_checkbox.Name = "minimum_checkbox";
            this.minimum_checkbox.Size = new System.Drawing.Size(85, 21);
            this.minimum_checkbox.TabIndex = 5;
            this.minimum_checkbox.Text = "Minimum";
            this.minimum_checkbox.UseVisualStyleBackColor = true;
            // 
            // minimum_result
            // 
            this.minimum_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimum_result.Location = new System.Drawing.Point(152, 460);
            this.minimum_result.Name = "minimum_result";
            this.minimum_result.Size = new System.Drawing.Size(154, 22);
            this.minimum_result.TabIndex = 6;
            // 
            // minimum_label
            // 
            this.minimum_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimum_label.AutoSize = true;
            this.minimum_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minimum_label.Location = new System.Drawing.Point(77, 460);
            this.minimum_label.Name = "minimum_label";
            this.minimum_label.Size = new System.Drawing.Size(63, 17);
            this.minimum_label.TabIndex = 7;
            this.minimum_label.Text = "Minimum";
            // 
            // maximum_label
            // 
            this.maximum_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maximum_label.AutoSize = true;
            this.maximum_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maximum_label.Location = new System.Drawing.Point(409, 460);
            this.maximum_label.Name = "maximum_label";
            this.maximum_label.Size = new System.Drawing.Size(66, 17);
            this.maximum_label.TabIndex = 11;
            this.maximum_label.Text = "Maximum";
            // 
            // maximum_result
            // 
            this.maximum_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maximum_result.Location = new System.Drawing.Point(484, 460);
            this.maximum_result.Name = "maximum_result";
            this.maximum_result.Size = new System.Drawing.Size(154, 22);
            this.maximum_result.TabIndex = 10;
            // 
            // mode_label
            // 
            this.mode_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mode_label.AutoSize = true;
            this.mode_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mode_label.Location = new System.Drawing.Point(409, 417);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(43, 17);
            this.mode_label.TabIndex = 9;
            this.mode_label.Text = "Mode";
            // 
            // mode_result
            // 
            this.mode_result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mode_result.Location = new System.Drawing.Point(484, 417);
            this.mode_result.Name = "mode_result";
            this.mode_result.Size = new System.Drawing.Size(154, 22);
            this.mode_result.TabIndex = 8;
            // 
            // maximum_checkbox
            // 
            this.maximum_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maximum_checkbox.AutoSize = true;
            this.maximum_checkbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maximum_checkbox.Location = new System.Drawing.Point(510, 302);
            this.maximum_checkbox.Name = "maximum_checkbox";
            this.maximum_checkbox.Size = new System.Drawing.Size(88, 21);
            this.maximum_checkbox.TabIndex = 13;
            this.maximum_checkbox.Text = "Maximum";
            this.maximum_checkbox.UseVisualStyleBackColor = true;
            // 
            // mode_checkbox
            // 
            this.mode_checkbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mode_checkbox.AutoSize = true;
            this.mode_checkbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mode_checkbox.Location = new System.Drawing.Point(383, 302);
            this.mode_checkbox.Name = "mode_checkbox";
            this.mode_checkbox.Size = new System.Drawing.Size(65, 21);
            this.mode_checkbox.TabIndex = 12;
            this.mode_checkbox.Text = "Mode";
            this.mode_checkbox.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_button.Location = new System.Drawing.Point(361, 357);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(76, 27);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // stats_tool_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(715, 541);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.maximum_checkbox);
            this.Controls.Add(this.mode_checkbox);
            this.Controls.Add(this.maximum_label);
            this.Controls.Add(this.maximum_result);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.mode_result);
            this.Controls.Add(this.minimum_label);
            this.Controls.Add(this.minimum_result);
            this.Controls.Add(this.minimum_checkbox);
            this.Controls.Add(this.average_label);
            this.Controls.Add(this.average_checkbox);
            this.Controls.Add(this.average_result);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "stats_tool_form";
            this.Text = "Statistics Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.TextBox average_result;
        private System.Windows.Forms.CheckBox average_checkbox;
        private System.Windows.Forms.Label average_label;
        private System.Windows.Forms.CheckBox minimum_checkbox;
        private System.Windows.Forms.TextBox minimum_result;
        private System.Windows.Forms.Label minimum_label;
        private System.Windows.Forms.Label maximum_label;
        private System.Windows.Forms.TextBox maximum_result;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.TextBox mode_result;
        private System.Windows.Forms.CheckBox maximum_checkbox;
        private System.Windows.Forms.CheckBox mode_checkbox;
        private System.Windows.Forms.Button clear_button;
    }
}

