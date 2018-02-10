namespace YzmSnmOdev2_23._10_11._30
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbx_ControlPanel = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaldir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_AddCheese = new System.Windows.Forms.Button();
            this.btn_AddMouse = new System.Windows.Forms.Button();
            this.btn_AddWalls = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DrawMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_Labyrinth = new System.Windows.Forms.GroupBox();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.gbx_ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbx_ControlPanel
            // 
            this.gbx_ControlPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbx_ControlPanel.Controls.Add(this.numHeight);
            this.gbx_ControlPanel.Controls.Add(this.numWidth);
            this.gbx_ControlPanel.Controls.Add(this.lblDurum);
            this.gbx_ControlPanel.Controls.Add(this.label4);
            this.gbx_ControlPanel.Controls.Add(this.btn_Kaldir);
            this.gbx_ControlPanel.Controls.Add(this.label3);
            this.gbx_ControlPanel.Controls.Add(this.btn_Start);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddCheese);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddMouse);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddWalls);
            this.gbx_ControlPanel.Controls.Add(this.label2);
            this.gbx_ControlPanel.Controls.Add(this.btn_DrawMap);
            this.gbx_ControlPanel.Controls.Add(this.label1);
            this.gbx_ControlPanel.Location = new System.Drawing.Point(517, 11);
            this.gbx_ControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_ControlPanel.Name = "gbx_ControlPanel";
            this.gbx_ControlPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_ControlPanel.Size = new System.Drawing.Size(375, 441);
            this.gbx_ControlPanel.TabIndex = 1;
            this.gbx_ControlPanel.TabStop = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(165, 393);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(2, 19);
            this.lblDurum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Durum :";
            // 
            // btn_Kaldir
            // 
            this.btn_Kaldir.Location = new System.Drawing.Point(80, 299);
            this.btn_Kaldir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Kaldir.Name = "btn_Kaldir";
            this.btn_Kaldir.Size = new System.Drawing.Size(100, 60);
            this.btn_Kaldir.TabIndex = 10;
            this.btn_Kaldir.Text = "Nesne Kaldır";
            this.btn_Kaldir.UseVisualStyleBackColor = true;
            this.btn_Kaldir.Click += new System.EventHandler(this.btn_Kaldir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(121, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kontrol Paneli";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(211, 299);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 60);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Başla";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_AddCheese
            // 
            this.btn_AddCheese.Location = new System.Drawing.Point(211, 231);
            this.btn_AddCheese.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddCheese.Name = "btn_AddCheese";
            this.btn_AddCheese.Size = new System.Drawing.Size(100, 60);
            this.btn_AddCheese.TabIndex = 7;
            this.btn_AddCheese.Text = "Peynir Ekle";
            this.btn_AddCheese.UseVisualStyleBackColor = true;
            this.btn_AddCheese.Click += new System.EventHandler(this.btn_AddCheese_Click);
            // 
            // btn_AddMouse
            // 
            this.btn_AddMouse.Location = new System.Drawing.Point(80, 231);
            this.btn_AddMouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddMouse.Name = "btn_AddMouse";
            this.btn_AddMouse.Size = new System.Drawing.Size(100, 60);
            this.btn_AddMouse.TabIndex = 6;
            this.btn_AddMouse.Text = "Fare Ekle";
            this.btn_AddMouse.UseVisualStyleBackColor = true;
            this.btn_AddMouse.Click += new System.EventHandler(this.btn_AddMouse_Click);
            // 
            // btn_AddWalls
            // 
            this.btn_AddWalls.Location = new System.Drawing.Point(211, 162);
            this.btn_AddWalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddWalls.Name = "btn_AddWalls";
            this.btn_AddWalls.Size = new System.Drawing.Size(100, 60);
            this.btn_AddWalls.TabIndex = 4;
            this.btn_AddWalls.Text = "Duvarları Ekle";
            this.btn_AddWalls.UseVisualStyleBackColor = true;
            this.btn_AddWalls.Click += new System.EventHandler(this.btn_AddWalls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boy";
            // 
            // btn_DrawMap
            // 
            this.btn_DrawMap.Location = new System.Drawing.Point(80, 162);
            this.btn_DrawMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DrawMap.Name = "btn_DrawMap";
            this.btn_DrawMap.Size = new System.Drawing.Size(100, 60);
            this.btn_DrawMap.TabIndex = 3;
            this.btn_DrawMap.Text = "Haritayı Çiz";
            this.btn_DrawMap.UseVisualStyleBackColor = true;
            this.btn_DrawMap.Click += new System.EventHandler(this.btn_DrawMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "En";
            // 
            // gbx_Labyrinth
            // 
            this.gbx_Labyrinth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbx_Labyrinth.Location = new System.Drawing.Point(9, 11);
            this.gbx_Labyrinth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_Labyrinth.Name = "gbx_Labyrinth";
            this.gbx_Labyrinth.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_Labyrinth.Size = new System.Drawing.Size(500, 441);
            this.gbx_Labyrinth.TabIndex = 2;
            this.gbx_Labyrinth.TabStop = false;
            // 
            // numWidth
            // 
            this.numWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWidth.Location = new System.Drawing.Point(165, 60);
            this.numWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(132, 22);
            this.numWidth.TabIndex = 13;
            // 
            // numHeight
            // 
            this.numHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHeight.Location = new System.Drawing.Point(165, 121);
            this.numHeight.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(132, 22);
            this.numHeight.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(908, 466);
            this.Controls.Add(this.gbx_Labyrinth);
            this.Controls.Add(this.gbx_ControlPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Labirent Fare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_ControlPanel.ResumeLayout(false);
            this.gbx_ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbx_ControlPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_AddCheese;
        private System.Windows.Forms.Button btn_AddMouse;
        private System.Windows.Forms.Button btn_AddWalls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DrawMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_Labyrinth;
        private System.Windows.Forms.Button btn_Kaldir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
    }
}

