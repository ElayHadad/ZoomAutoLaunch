
namespace ZoomOpener
{
    partial class Load
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
            this.components = new System.ComponentModel.Container();
            this.classes = new System.Windows.Forms.ListView();
            this.edit = new System.Windows.Forms.Button();
            this.today = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // classes
            // 
            this.classes.HideSelection = false;
            this.classes.Location = new System.Drawing.Point(12, 12);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(577, 198);
            this.classes.TabIndex = 0;
            this.classes.UseCompatibleStateImageBehavior = false;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(468, 216);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(121, 23);
            this.edit.TabIndex = 1;
            this.edit.Text = "Modify selected value";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.Location = new System.Drawing.Point(12, 221);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(154, 13);
            this.today.TabIndex = 2;
            this.today.Text = "Current classes present of DAY";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 5000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 247);
            this.Controls.Add(this.today);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.classes);
            this.Name = "Load";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView classes;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Timer clock;
    }
}

