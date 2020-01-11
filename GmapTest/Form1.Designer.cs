namespace GmapTest
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lbl_Latitude = new System.Windows.Forms.Label();
            this.txt_Latitude = new System.Windows.Forms.TextBox();
            this.lbl_Longitude = new System.Windows.Forms.Label();
            this.txt_Longitude = new System.Windows.Forms.TextBox();
            this.btn_LoadMap = new System.Windows.Forms.Button();
            this.lst_Aircraft = new System.Windows.Forms.ListBox();
            this.lbl_aircraft = new System.Windows.Forms.Label();
            this.tmr_timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ULLatTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ULLngTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LRLatTxt = new System.Windows.Forms.TextBox();
            this.LRLngTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(434, 596);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(749, 596);
            this.map.TabIndex = 1;
            this.map.Zoom = 13D;
            this.map.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.Map_OnMapZoomChanged);
            this.map.Load += new System.EventHandler(this.map_Load);
            this.map.DragDrop += new System.Windows.Forms.DragEventHandler(this.map_DragDrop);
            this.map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.map_MouseUp);
            // 
            // lbl_Latitude
            // 
            this.lbl_Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Latitude.AutoSize = true;
            this.lbl_Latitude.Location = new System.Drawing.Point(848, 132);
            this.lbl_Latitude.Name = "lbl_Latitude";
            this.lbl_Latitude.Size = new System.Drawing.Size(45, 13);
            this.lbl_Latitude.TabIndex = 2;
            this.lbl_Latitude.Text = "Latitude";
            this.lbl_Latitude.Click += new System.EventHandler(this.lbl_Latitude_Click);
            // 
            // txt_Latitude
            // 
            this.txt_Latitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Latitude.Location = new System.Drawing.Point(908, 132);
            this.txt_Latitude.Name = "txt_Latitude";
            this.txt_Latitude.Size = new System.Drawing.Size(141, 20);
            this.txt_Latitude.TabIndex = 3;
            this.txt_Latitude.Text = "33.777";
            this.txt_Latitude.TextChanged += new System.EventHandler(this.txt_Latitude_TextChanged);
            // 
            // lbl_Longitude
            // 
            this.lbl_Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Longitude.AutoSize = true;
            this.lbl_Longitude.Location = new System.Drawing.Point(848, 158);
            this.lbl_Longitude.Name = "lbl_Longitude";
            this.lbl_Longitude.Size = new System.Drawing.Size(54, 13);
            this.lbl_Longitude.TabIndex = 4;
            this.lbl_Longitude.Text = "Longitude";
            this.lbl_Longitude.Click += new System.EventHandler(this.lbl_Longitude_Click);
            // 
            // txt_Longitude
            // 
            this.txt_Longitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Longitude.Location = new System.Drawing.Point(908, 158);
            this.txt_Longitude.Name = "txt_Longitude";
            this.txt_Longitude.Size = new System.Drawing.Size(141, 20);
            this.txt_Longitude.TabIndex = 5;
            this.txt_Longitude.Text = "-118.198";
            this.txt_Longitude.TextChanged += new System.EventHandler(this.txt_Longitude_TextChanged);
            // 
            // btn_LoadMap
            // 
            this.btn_LoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadMap.Location = new System.Drawing.Point(755, 155);
            this.btn_LoadMap.Name = "btn_LoadMap";
            this.btn_LoadMap.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadMap.TabIndex = 6;
            this.btn_LoadMap.Text = "Update Map";
            this.btn_LoadMap.UseVisualStyleBackColor = true;
            this.btn_LoadMap.Click += new System.EventHandler(this.btn_LoadMap_Click);
            // 
            // lst_Aircraft
            // 
            this.lst_Aircraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Aircraft.FormattingEnabled = true;
            this.lst_Aircraft.Location = new System.Drawing.Point(756, 209);
            this.lst_Aircraft.Name = "lst_Aircraft";
            this.lst_Aircraft.Size = new System.Drawing.Size(317, 381);
            this.lst_Aircraft.TabIndex = 7;
            // 
            // lbl_aircraft
            // 
            this.lbl_aircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aircraft.AutoSize = true;
            this.lbl_aircraft.Location = new System.Drawing.Point(753, 193);
            this.lbl_aircraft.Name = "lbl_aircraft";
            this.lbl_aircraft.Size = new System.Drawing.Size(126, 13);
            this.lbl_aircraft.TabIndex = 8;
            this.lbl_aircraft.Text = "Current Aircraft Locations";
            // 
            // tmr_timer1
            // 
            this.tmr_timer1.Enabled = true;
            this.tmr_timer1.Interval = 2000;
            this.tmr_timer1.Tick += new System.EventHandler(this.tmr_timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "UL-Lat";
            // 
            // ULLatTxt
            // 
            this.ULLatTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ULLatTxt.Location = new System.Drawing.Point(821, 71);
            this.ULLatTxt.Name = "ULLatTxt";
            this.ULLatTxt.Size = new System.Drawing.Size(100, 20);
            this.ULLatTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UL-Lng";
            // 
            // ULLngTxt
            // 
            this.ULLngTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ULLngTxt.Location = new System.Drawing.Point(821, 100);
            this.ULLngTxt.Name = "ULLngTxt";
            this.ULLngTxt.Size = new System.Drawing.Size(100, 20);
            this.ULLngTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "LR-Lat";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(933, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "LR-Lng";
            // 
            // LRLatTxt
            // 
            this.LRLatTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LRLatTxt.Location = new System.Drawing.Point(981, 74);
            this.LRLatTxt.Name = "LRLatTxt";
            this.LRLatTxt.Size = new System.Drawing.Size(100, 20);
            this.LRLatTxt.TabIndex = 16;
            // 
            // LRLngTxt
            // 
            this.LRLngTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LRLngTxt.Location = new System.Drawing.Point(981, 100);
            this.LRLngTxt.Name = "LRLngTxt";
            this.LRLngTxt.Size = new System.Drawing.Size(100, 20);
            this.LRLngTxt.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 596);
            this.Controls.Add(this.LRLngTxt);
            this.Controls.Add(this.LRLatTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ULLngTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ULLatTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_aircraft);
            this.Controls.Add(this.lst_Aircraft);
            this.Controls.Add(this.btn_LoadMap);
            this.Controls.Add(this.txt_Longitude);
            this.Controls.Add(this.lbl_Longitude);
            this.Controls.Add(this.txt_Latitude);
            this.Controls.Add(this.lbl_Latitude);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "ADLINK FACE Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl_Latitude;
        private System.Windows.Forms.TextBox txt_Latitude;
        private System.Windows.Forms.Label lbl_Longitude;
        private System.Windows.Forms.TextBox txt_Longitude;
        private System.Windows.Forms.Button btn_LoadMap;
        private System.Windows.Forms.ListBox lst_Aircraft;
        private System.Windows.Forms.Label lbl_aircraft;
        private System.Windows.Forms.Timer tmr_timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ULLatTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ULLngTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LRLatTxt;
        private System.Windows.Forms.TextBox LRLngTxt;
    }
}

