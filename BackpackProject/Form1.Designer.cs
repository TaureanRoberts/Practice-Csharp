namespace BackpackProject
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(79, 81);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(97, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(79, 81);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(182, 12);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(79, 81);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(12, 99);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(79, 81);
            this.listView4.TabIndex = 3;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.SelectedIndexChanged += new System.EventHandler(this.listView4_SelectedIndexChanged);
            // 
            // listView5
            // 
            this.listView5.Location = new System.Drawing.Point(97, 99);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(79, 81);
            this.listView5.TabIndex = 4;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged);
            // 
            // listView6
            // 
            this.listView6.Location = new System.Drawing.Point(182, 99);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(79, 81);
            this.listView6.TabIndex = 5;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.SelectedIndexChanged += new System.EventHandler(this.listView6_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 385);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
    }
}

