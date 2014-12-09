namespace AnimationBuilder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowGrid = new System.Windows.Forms.CheckBox();
            this.FramesBox = new System.Windows.Forms.ListBox();
            this.DelNameBtn = new System.Windows.Forms.Button();
            this.NewNameBtn = new System.Windows.Forms.Button();
            this.NameList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveAnims = new System.Windows.Forms.Button();
            this.LoadAnims = new System.Windows.Forms.Button();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.NewAnims = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowGrid);
            this.groupBox1.Controls.Add(this.FramesBox);
            this.groupBox1.Controls.Add(this.DelNameBtn);
            this.groupBox1.Controls.Add(this.NewNameBtn);
            this.groupBox1.Controls.Add(this.NameList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HeightBox);
            this.groupBox1.Controls.Add(this.WidthBox);
            this.groupBox1.Location = new System.Drawing.Point(667, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // ShowGrid
            // 
            this.ShowGrid.AutoSize = true;
            this.ShowGrid.Location = new System.Drawing.Point(6, 106);
            this.ShowGrid.Name = "ShowGrid";
            this.ShowGrid.Size = new System.Drawing.Size(75, 17);
            this.ShowGrid.TabIndex = 10;
            this.ShowGrid.Text = "Show Grid";
            this.ShowGrid.UseVisualStyleBackColor = true;
            this.ShowGrid.CheckedChanged += new System.EventHandler(this.ShowGrid_CheckedChanged);
            // 
            // FramesBox
            // 
            this.FramesBox.FormattingEnabled = true;
            this.FramesBox.Location = new System.Drawing.Point(6, 207);
            this.FramesBox.Name = "FramesBox";
            this.FramesBox.Size = new System.Drawing.Size(188, 186);
            this.FramesBox.TabIndex = 9;
            this.FramesBox.SelectedIndexChanged += new System.EventHandler(this.FramesBox_SelectedIndexChanged);
            // 
            // DelNameBtn
            // 
            this.DelNameBtn.Location = new System.Drawing.Point(87, 46);
            this.DelNameBtn.Name = "DelNameBtn";
            this.DelNameBtn.Size = new System.Drawing.Size(75, 23);
            this.DelNameBtn.TabIndex = 8;
            this.DelNameBtn.Text = "Delete";
            this.DelNameBtn.UseVisualStyleBackColor = true;
            this.DelNameBtn.Click += new System.EventHandler(this.DelNameBtn_Click);
            // 
            // NewNameBtn
            // 
            this.NewNameBtn.Location = new System.Drawing.Point(6, 46);
            this.NewNameBtn.Name = "NewNameBtn";
            this.NewNameBtn.Size = new System.Drawing.Size(75, 23);
            this.NewNameBtn.TabIndex = 7;
            this.NewNameBtn.Text = "New";
            this.NewNameBtn.UseVisualStyleBackColor = true;
            this.NewNameBtn.Click += new System.EventHandler(this.NewNameBtn_Click);
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.Items.AddRange(new object[] {
            "None"});
            this.NameList.Location = new System.Drawing.Point(6, 19);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(121, 21);
            this.NameList.TabIndex = 6;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 181);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "H";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "W";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(6, 155);
            this.HeightBox.MaxLength = 6;
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(44, 20);
            this.HeightBox.TabIndex = 1;
            this.HeightBox.Text = "32";
            this.HeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightBox_KeyPress);
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(6, 129);
            this.WidthBox.MaxLength = 6;
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(44, 20);
            this.WidthBox.TabIndex = 0;
            this.WidthBox.Text = "32";
            this.WidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthBox_KeyPress);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(12, 416);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveAnims
            // 
            this.SaveAnims.Location = new System.Drawing.Point(792, 416);
            this.SaveAnims.Name = "SaveAnims";
            this.SaveAnims.Size = new System.Drawing.Size(75, 23);
            this.SaveAnims.TabIndex = 3;
            this.SaveAnims.Text = "Save";
            this.SaveAnims.UseVisualStyleBackColor = true;
            this.SaveAnims.Click += new System.EventHandler(this.SaveAnims_Click);
            // 
            // LoadAnims
            // 
            this.LoadAnims.Location = new System.Drawing.Point(711, 416);
            this.LoadAnims.Name = "LoadAnims";
            this.LoadAnims.Size = new System.Drawing.Size(75, 23);
            this.LoadAnims.TabIndex = 4;
            this.LoadAnims.Text = "Load";
            this.LoadAnims.UseVisualStyleBackColor = true;
            this.LoadAnims.Click += new System.EventHandler(this.LoadAnims_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.ImageBox);
            this.ImagePanel.Location = new System.Drawing.Point(12, 12);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(649, 398);
            this.ImagePanel.TabIndex = 5;
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(100, 50);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageBox_Paint);
            this.ImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseDown);
            // 
            // NewAnims
            // 
            this.NewAnims.Location = new System.Drawing.Point(630, 416);
            this.NewAnims.Name = "NewAnims";
            this.NewAnims.Size = new System.Drawing.Size(75, 23);
            this.NewAnims.TabIndex = 6;
            this.NewAnims.Text = "New";
            this.NewAnims.UseVisualStyleBackColor = true;
            this.NewAnims.Click += new System.EventHandler(this.NewAnims_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 448);
            this.Controls.Add(this.NewAnims);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.LoadAnims);
            this.Controls.Add(this.SaveAnims);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Animation builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox FramesBox;
        private System.Windows.Forms.Button DelNameBtn;
        private System.Windows.Forms.Button NewNameBtn;
        private System.Windows.Forms.ComboBox NameList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.CheckBox ShowGrid;
        private System.Windows.Forms.Button SaveAnims;
        private System.Windows.Forms.Button LoadAnims;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button NewAnims;

    }
}

