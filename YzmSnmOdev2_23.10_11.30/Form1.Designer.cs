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
            this.btn_Kaldir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_AddCheese = new System.Windows.Forms.Button();
            this.btn_AddMouse = new System.Windows.Forms.Button();
            this.btn_AddWalls = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DrawMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.gbx_Labyrinth = new System.Windows.Forms.GroupBox();
            this.gbx_ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbx_ControlPanel
            // 
            this.gbx_ControlPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbx_ControlPanel.Controls.Add(this.btn_Kaldir);
            this.gbx_ControlPanel.Controls.Add(this.label3);
            this.gbx_ControlPanel.Controls.Add(this.btn_Start);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddCheese);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddMouse);
            this.gbx_ControlPanel.Controls.Add(this.btn_AddWalls);
            this.gbx_ControlPanel.Controls.Add(this.label2);
            this.gbx_ControlPanel.Controls.Add(this.btn_DrawMap);
            this.gbx_ControlPanel.Controls.Add(this.label1);
            this.gbx_ControlPanel.Controls.Add(this.txt_Height);
            this.gbx_ControlPanel.Controls.Add(this.txt_Width);
            this.gbx_ControlPanel.Location = new System.Drawing.Point(508, -8);
            this.gbx_ControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_ControlPanel.Name = "gbx_ControlPanel";
            this.gbx_ControlPanel.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_ControlPanel.Size = new System.Drawing.Size(375, 440);
            this.gbx_ControlPanel.TabIndex = 1;
            this.gbx_ControlPanel.TabStop = false;
            // 
            // btn_Kaldir
            // 
            this.btn_Kaldir.Location = new System.Drawing.Point(80, 299);
            this.btn_Kaldir.Margin = new System.Windows.Forms.Padding(4);
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
            this.label3.Location = new System.Drawing.Point(121, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kontrol Paneli";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(210, 299);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(100, 60);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Başla";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_AddCheese
            // 
            this.btn_AddCheese.Location = new System.Drawing.Point(210, 231);
            this.btn_AddCheese.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_AddMouse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddMouse.Name = "btn_AddMouse";
            this.btn_AddMouse.Size = new System.Drawing.Size(100, 60);
            this.btn_AddMouse.TabIndex = 6;
            this.btn_AddMouse.Text = "Fare Ekle";
            this.btn_AddMouse.UseVisualStyleBackColor = true;
            this.btn_AddMouse.Click += new System.EventHandler(this.btn_AddMouse_Click);
            // 
            // btn_AddWalls
            // 
            this.btn_AddWalls.Location = new System.Drawing.Point(210, 163);
            this.btn_AddWalls.Margin = new System.Windows.Forms.Padding(4);
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
            this.btn_DrawMap.Location = new System.Drawing.Point(80, 163);
            this.btn_DrawMap.Margin = new System.Windows.Forms.Padding(4);
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
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(165, 121);
            this.txt_Height.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(132, 22);
            this.txt_Height.TabIndex = 2;
            this.txt_Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(165, 60);
            this.txt_Width.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(132, 22);
            this.txt_Width.TabIndex = 1;
            this.txt_Width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // gbx_Labyrinth
            // 
            this.gbx_Labyrinth.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbx_Labyrinth.Location = new System.Drawing.Point(0, -8);
            this.gbx_Labyrinth.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_Labyrinth.Name = "gbx_Labyrinth";
            this.gbx_Labyrinth.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_Labyrinth.Size = new System.Drawing.Size(500, 440);
            this.gbx_Labyrinth.TabIndex = 2;
            this.gbx_Labyrinth.TabStop = false;
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
            this.Name = "Form1";
            this.Text = "Labirent Fare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_ControlPanel.ResumeLayout(false);
            this.gbx_ControlPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.GroupBox gbx_Labyrinth;
        private System.Windows.Forms.Button btn_Kaldir;
    }
}

