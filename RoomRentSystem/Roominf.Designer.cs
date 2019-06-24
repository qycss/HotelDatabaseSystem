namespace RoomRentSystem
{
    partial class Roominf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roominf));
            this.roomdataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageinfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPageadd = new System.Windows.Forms.TabPage();
            this.buttonadd = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPagedel = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roomdataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageinfo.SuspendLayout();
            this.tabPageadd.SuspendLayout();
            this.tabPagedel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomdataGridView
            // 
            this.roomdataGridView.AllowUserToAddRows = false;
            this.roomdataGridView.AllowUserToDeleteRows = false;
            this.roomdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.roomdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomdataGridView.Location = new System.Drawing.Point(12, 162);
            this.roomdataGridView.MultiSelect = false;
            this.roomdataGridView.Name = "roomdataGridView";
            this.roomdataGridView.ReadOnly = true;
            this.roomdataGridView.RowTemplate.Height = 23;
            this.roomdataGridView.Size = new System.Drawing.Size(659, 308);
            this.roomdataGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageinfo);
            this.tabControl1.Controls.Add(this.tabPageadd);
            this.tabControl1.Controls.Add(this.tabPagedel);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 136);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageinfo
            // 
            this.tabPageinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageinfo.BackgroundImage")));
            this.tabPageinfo.Controls.Add(this.label2);
            this.tabPageinfo.Controls.Add(this.button1);
            this.tabPageinfo.Controls.Add(this.label1);
            this.tabPageinfo.Controls.Add(this.textBox1);
            this.tabPageinfo.Controls.Add(this.comboBox1);
            this.tabPageinfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageinfo.Name = "tabPageinfo";
            this.tabPageinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageinfo.Size = new System.Drawing.Size(651, 110);
            this.tabPageinfo.TabIndex = 0;
            this.tabPageinfo.Text = "查询客房信息";
            this.tabPageinfo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("腾祥铁山楷书繁", 20F);
            this.label2.Location = new System.Drawing.Point(146, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "查询，查询条件：";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.button1.Location = new System.Drawing.Point(570, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("腾祥铁山楷书繁", 20F);
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "按";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("黑体", 12F);
            this.textBox1.Location = new System.Drawing.Point(380, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 26);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("黑体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "客房号",
            "客房类型",
            "客房状态"});
            this.comboBox1.Location = new System.Drawing.Point(53, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // tabPageadd
            // 
            this.tabPageadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageadd.BackgroundImage")));
            this.tabPageadd.Controls.Add(this.buttonadd);
            this.tabPageadd.Controls.Add(this.textBox9);
            this.tabPageadd.Controls.Add(this.label13);
            this.tabPageadd.Controls.Add(this.comboBox4);
            this.tabPageadd.Controls.Add(this.label12);
            this.tabPageadd.Controls.Add(this.textBox8);
            this.tabPageadd.Controls.Add(this.label11);
            this.tabPageadd.Controls.Add(this.comboBox3);
            this.tabPageadd.Controls.Add(this.label10);
            this.tabPageadd.Controls.Add(this.textBox2);
            this.tabPageadd.Controls.Add(this.label3);
            this.tabPageadd.Location = new System.Drawing.Point(4, 22);
            this.tabPageadd.Name = "tabPageadd";
            this.tabPageadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageadd.Size = new System.Drawing.Size(651, 110);
            this.tabPageadd.TabIndex = 1;
            this.tabPageadd.Text = "添加客房信息";
            this.tabPageadd.UseVisualStyleBackColor = true;
            // 
            // buttonadd
            // 
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonadd.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.buttonadd.Location = new System.Drawing.Point(482, 60);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(90, 30);
            this.buttonadd.TabIndex = 22;
            this.buttonadd.Text = "添加";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(69, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(246, 21);
            this.textBox9.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.label13.Location = new System.Drawing.Point(7, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "备注：";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "未住",
            "已住"});
            this.comboBox4.Location = new System.Drawing.Point(333, 38);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 20);
            this.comboBox4.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.label12.Location = new System.Drawing.Point(249, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "客房状态：";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(333, 11);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(80, 21);
            this.textBox8.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.label11.Location = new System.Drawing.Point(249, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "日单价：";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "单人间",
            "标准间",
            "大床房",
            "商务间",
            "套间"});
            this.comboBox3.Location = new System.Drawing.Point(91, 38);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 20);
            this.comboBox3.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.label10.Location = new System.Drawing.Point(7, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "客房类型：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("腾祥铁山楷书繁", 12F);
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "客房号：";
            // 
            // tabPagedel
            // 
            this.tabPagedel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagedel.BackgroundImage")));
            this.tabPagedel.Controls.Add(this.button4);
            this.tabPagedel.Controls.Add(this.textBox18);
            this.tabPagedel.Controls.Add(this.label25);
            this.tabPagedel.Location = new System.Drawing.Point(4, 22);
            this.tabPagedel.Name = "tabPagedel";
            this.tabPagedel.Size = new System.Drawing.Size(651, 110);
            this.tabPagedel.TabIndex = 3;
            this.tabPagedel.Text = "客房信息删除";
            this.tabPagedel.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("腾祥铁山楷书繁", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(414, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 38);
            this.button4.TabIndex = 26;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("黑体", 20F);
            this.textBox18.Location = new System.Drawing.Point(185, 58);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(168, 38);
            this.textBox18.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("腾祥铁山楷书繁", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(32, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 29);
            this.label25.TabIndex = 24;
            this.label25.Text = "客房号：";
            // 
            // Roominf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.roomdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Roominf";
            this.Text = "客房信息管理";
            this.Load += new System.EventHandler(this.Roominf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomdataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageinfo.ResumeLayout(false);
            this.tabPageinfo.PerformLayout();
            this.tabPageadd.ResumeLayout(false);
            this.tabPageadd.PerformLayout();
            this.tabPagedel.ResumeLayout(false);
            this.tabPagedel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView roomdataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPageadd;
        private System.Windows.Forms.TabPage tabPagedel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
    }
}