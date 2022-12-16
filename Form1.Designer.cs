namespace Restudent_Managment_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Label();
            this.btnManu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.SlidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.Slidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Slidebar
            // 
            this.Slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Slidebar.Controls.Add(this.panel2);
            this.Slidebar.Controls.Add(this.panel1);
            this.Slidebar.Controls.Add(this.panel3);
            this.Slidebar.Controls.Add(this.panel4);
            this.Slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidebar.Location = new System.Drawing.Point(0, 0);
            this.Slidebar.MaximumSize = new System.Drawing.Size(203, 441);
            this.Slidebar.MinimumSize = new System.Drawing.Size(57, 441);
            this.Slidebar.Name = "Slidebar";
            this.Slidebar.Size = new System.Drawing.Size(203, 441);
            this.Slidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Controls.Add(this.btnManu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 75);
            this.panel2.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(57, 34);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(63, 30);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnManu
            // 
            this.btnManu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManu.Image = global::Restudent_Managment_System.Properties.Resources.icons8_menu_rounded_48;
            this.btnManu.Location = new System.Drawing.Point(17, 31);
            this.btnManu.Name = "btnManu";
            this.btnManu.Size = new System.Drawing.Size(32, 32);
            this.btnManu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManu.TabIndex = 0;
            this.btnManu.TabStop = false;
            this.btnManu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 75);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Restudent_Managment_System.Properties.Resources.layers;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(197, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "       Dash Bord";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 75);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Restudent_Managment_System.Properties.Resources.shield_icon_012;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(197, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "       Role";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 75);
            this.panel4.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::Restudent_Managment_System.Properties.Resources.layers;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(197, 75);
            this.button3.TabIndex = 2;
            this.button3.Text = "       Dash Bord";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SlidebarTimer
            // 
            this.SlidebarTimer.Interval = 1;
            this.SlidebarTimer.Tick += new System.EventHandler(this.SlidebarTimer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.Slidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Restudent Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Slidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Slidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox btnManu;
        private System.Windows.Forms.Label Menu;
        protected internal System.Windows.Forms.Timer SlidebarTimer;
    }
}

