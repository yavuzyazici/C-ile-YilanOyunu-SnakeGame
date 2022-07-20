
namespace WinFormSnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureUp = new System.Windows.Forms.PictureBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.pictureDown = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnKolayMod = new System.Windows.Forms.Button();
            this.btnOrtaMod = new System.Windows.Forms.Button();
            this.btnZorMod = new System.Windows.Forms.Button();
            this.btnExtremeMod = new System.Windows.Forms.Button();
            this.btnCokKolayMod = new System.Windows.Forms.Button();
            this.btnImkansizMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(14, 15);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(560, 560);
            this.panel.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Location = new System.Drawing.Point(599, 15);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(70, 37);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurdur.Location = new System.Drawing.Point(678, 15);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(70, 37);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.pictureUp, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureLeft, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureRight, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureDown, 1, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(599, 68);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // pictureUp
            // 
            this.pictureUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureUp.Image")));
            this.pictureUp.Location = new System.Drawing.Point(53, 3);
            this.pictureUp.Name = "pictureUp";
            this.pictureUp.Size = new System.Drawing.Size(43, 43);
            this.pictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUp.TabIndex = 0;
            this.pictureUp.TabStop = false;
            this.pictureUp.Click += new System.EventHandler(this.pictureUp_Click);
            // 
            // pictureLeft
            // 
            this.pictureLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureLeft.Image")));
            this.pictureLeft.Location = new System.Drawing.Point(3, 53);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(43, 43);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLeft.TabIndex = 1;
            this.pictureLeft.TabStop = false;
            this.pictureLeft.Click += new System.EventHandler(this.pictureLeft_Click);
            // 
            // pictureRight
            // 
            this.pictureRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureRight.Image")));
            this.pictureRight.Location = new System.Drawing.Point(103, 53);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(44, 43);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRight.TabIndex = 2;
            this.pictureRight.TabStop = false;
            this.pictureRight.Click += new System.EventHandler(this.pictureRight_Click);
            // 
            // pictureDown
            // 
            this.pictureDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureDown.Image")));
            this.pictureDown.Location = new System.Drawing.Point(53, 103);
            this.pictureDown.Name = "pictureDown";
            this.pictureDown.Size = new System.Drawing.Size(43, 44);
            this.pictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDown.TabIndex = 3;
            this.pictureDown.TabStop = false;
            this.pictureDown.Click += new System.EventHandler(this.pictureDown_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.Silver;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(598, 539);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(152, 36);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnKolayMod
            // 
            this.btnKolayMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKolayMod.FlatAppearance.BorderSize = 0;
            this.btnKolayMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKolayMod.Location = new System.Drawing.Point(601, 281);
            this.btnKolayMod.Name = "btnKolayMod";
            this.btnKolayMod.Size = new System.Drawing.Size(147, 37);
            this.btnKolayMod.TabIndex = 6;
            this.btnKolayMod.Text = "Kolay";
            this.btnKolayMod.UseVisualStyleBackColor = false;
            this.btnKolayMod.Click += new System.EventHandler(this.btnKolayMod_Click);
            // 
            // btnOrtaMod
            // 
            this.btnOrtaMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOrtaMod.FlatAppearance.BorderSize = 0;
            this.btnOrtaMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrtaMod.Location = new System.Drawing.Point(601, 324);
            this.btnOrtaMod.Name = "btnOrtaMod";
            this.btnOrtaMod.Size = new System.Drawing.Size(147, 37);
            this.btnOrtaMod.TabIndex = 7;
            this.btnOrtaMod.Text = "Orta";
            this.btnOrtaMod.UseVisualStyleBackColor = false;
            this.btnOrtaMod.Click += new System.EventHandler(this.btnOrtaMod_Click);
            // 
            // btnZorMod
            // 
            this.btnZorMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZorMod.FlatAppearance.BorderSize = 0;
            this.btnZorMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZorMod.Location = new System.Drawing.Point(601, 367);
            this.btnZorMod.Name = "btnZorMod";
            this.btnZorMod.Size = new System.Drawing.Size(147, 37);
            this.btnZorMod.TabIndex = 8;
            this.btnZorMod.Text = "Zor";
            this.btnZorMod.UseVisualStyleBackColor = false;
            this.btnZorMod.Click += new System.EventHandler(this.btnZorMod_Click);
            // 
            // btnExtremeMod
            // 
            this.btnExtremeMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExtremeMod.FlatAppearance.BorderSize = 0;
            this.btnExtremeMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtremeMod.Location = new System.Drawing.Point(599, 410);
            this.btnExtremeMod.Name = "btnExtremeMod";
            this.btnExtremeMod.Size = new System.Drawing.Size(147, 37);
            this.btnExtremeMod.TabIndex = 9;
            this.btnExtremeMod.Text = "Çok Zor";
            this.btnExtremeMod.UseVisualStyleBackColor = false;
            this.btnExtremeMod.Click += new System.EventHandler(this.btnExtremeMod_Click);
            // 
            // btnCokKolayMod
            // 
            this.btnCokKolayMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCokKolayMod.FlatAppearance.BorderSize = 0;
            this.btnCokKolayMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCokKolayMod.Location = new System.Drawing.Point(599, 238);
            this.btnCokKolayMod.Name = "btnCokKolayMod";
            this.btnCokKolayMod.Size = new System.Drawing.Size(147, 37);
            this.btnCokKolayMod.TabIndex = 10;
            this.btnCokKolayMod.Text = "Çok Kolay";
            this.btnCokKolayMod.UseVisualStyleBackColor = false;
            this.btnCokKolayMod.Click += new System.EventHandler(this.btnCokKolayMod_Click);
            // 
            // btnImkansizMod
            // 
            this.btnImkansizMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImkansizMod.FlatAppearance.BorderSize = 0;
            this.btnImkansizMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImkansizMod.Location = new System.Drawing.Point(599, 453);
            this.btnImkansizMod.Name = "btnImkansizMod";
            this.btnImkansizMod.Size = new System.Drawing.Size(147, 37);
            this.btnImkansizMod.TabIndex = 11;
            this.btnImkansizMod.Text = "İmkansız";
            this.btnImkansizMod.UseVisualStyleBackColor = false;
            this.btnImkansizMod.Click += new System.EventHandler(this.btnImkansizMod_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(608, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "©";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yavuz Selim YAZICI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(769, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImkansizMod);
            this.Controls.Add(this.btnCokKolayMod);
            this.Controls.Add(this.btnExtremeMod);
            this.Controls.Add(this.btnZorMod);
            this.Controls.Add(this.btnOrtaMod);
            this.Controls.Add(this.btnKolayMod);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureUp;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.PictureBox pictureDown;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Button btnKolayMod;
        private System.Windows.Forms.Button btnOrtaMod;
        private System.Windows.Forms.Button btnZorMod;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnExtremeMod;
        private System.Windows.Forms.Button btnCokKolayMod;
        private System.Windows.Forms.Button btnImkansizMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

