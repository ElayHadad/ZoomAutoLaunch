
namespace ZoomOpener
{
    partial class Setup
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
            this.name = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(127, 20);
            this.name.TabIndex = 10;
            this.name.Text = "Class\'s name";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(12, 38);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(394, 20);
            this.link.TabIndex = 9;
            this.link.Text = "Zoom link";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(170, 110);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(139, 65);
            this.time.Mask = "00:00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 20);
            this.time.TabIndex = 7;
            this.time.ValidatingType = typeof(System.DateTime);
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.day.Location = new System.Drawing.Point(12, 64);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(121, 21);
            this.day.TabIndex = 6;
            this.day.Text = "Day of the week";
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(331, 110);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 11;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 141);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.name);
            this.Controls.Add(this.link);
            this.Controls.Add(this.save);
            this.Controls.Add(this.time);
            this.Controls.Add(this.day);
            this.Name = "Setup";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox link;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Button finish;
    }
}