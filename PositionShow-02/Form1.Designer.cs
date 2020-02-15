namespace PositionShow_02 {
    partial class Map_Show {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.WB_Map = new System.Windows.Forms.WebBrowser();
            this.tbx_tarLat = new System.Windows.Forms.TextBox();
            this.tbx_tarLng = new System.Windows.Forms.TextBox();
            this.Lbl_Lat = new System.Windows.Forms.Label();
            this.Lbl_Lng = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_gpsLng = new System.Windows.Forms.TextBox();
            this.tbx_gpsLat = new System.Windows.Forms.TextBox();
            this.btn_Target = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btn_MapChange = new System.Windows.Forms.Button();
            this.btn_closeSerial = new System.Windows.Forms.Button();
            this.btn_openSerial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // WB_Map
            // 
            this.WB_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB_Map.Location = new System.Drawing.Point(0, 0);
            this.WB_Map.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_Map.Name = "WB_Map";
            this.WB_Map.Size = new System.Drawing.Size(609, 450);
            this.WB_Map.TabIndex = 0;
            this.WB_Map.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_Map_DocumentCompleted);
            // 
            // tbx_tarLat
            // 
            this.tbx_tarLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tarLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_tarLat.Location = new System.Drawing.Point(391, 25);
            this.tbx_tarLat.Name = "tbx_tarLat";
            this.tbx_tarLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_tarLat.TabIndex = 2;
            // 
            // tbx_tarLng
            // 
            this.tbx_tarLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tarLng.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_tarLng.Location = new System.Drawing.Point(494, 25);
            this.tbx_tarLng.Name = "tbx_tarLng";
            this.tbx_tarLng.Size = new System.Drawing.Size(84, 22);
            this.tbx_tarLng.TabIndex = 3;
            // 
            // Lbl_Lat
            // 
            this.Lbl_Lat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lat.AutoSize = true;
            this.Lbl_Lat.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Lat.Location = new System.Drawing.Point(389, 10);
            this.Lbl_Lat.Name = "Lbl_Lat";
            this.Lbl_Lat.Size = new System.Drawing.Size(25, 13);
            this.Lbl_Lat.TabIndex = 4;
            this.Lbl_Lat.Text = "Lat";
            // 
            // Lbl_Lng
            // 
            this.Lbl_Lng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lng.AutoSize = true;
            this.Lbl_Lng.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Lng.Location = new System.Drawing.Point(492, 9);
            this.Lbl_Lng.Name = "Lbl_Lng";
            this.Lbl_Lng.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Lng.TabIndex = 5;
            this.Lbl_Lng.Text = "Lng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(332, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(332, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Machine";
            // 
            // tbx_gpsLng
            // 
            this.tbx_gpsLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLng.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLng.Location = new System.Drawing.Point(494, 50);
            this.tbx_gpsLng.Name = "tbx_gpsLng";
            this.tbx_gpsLng.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLng.TabIndex = 8;
            // 
            // tbx_gpsLat
            // 
            this.tbx_gpsLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLat.Location = new System.Drawing.Point(391, 50);
            this.tbx_gpsLat.Name = "tbx_gpsLat";
            this.tbx_gpsLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLat.TabIndex = 7;
            // 
            // btn_Target
            // 
            this.btn_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Target.Location = new System.Drawing.Point(483, 392);
            this.btn_Target.Name = "btn_Target";
            this.btn_Target.Size = new System.Drawing.Size(95, 39);
            this.btn_Target.TabIndex = 10;
            this.btn_Target.Text = "Set Target";
            this.btn_Target.UseVisualStyleBackColor = true;
            this.btn_Target.Click += new System.EventHandler(this.Btn_Target_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(609, 450);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            // 
            // btn_MapChange
            // 
            this.btn_MapChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapChange.Location = new System.Drawing.Point(368, 392);
            this.btn_MapChange.Name = "btn_MapChange";
            this.btn_MapChange.Size = new System.Drawing.Size(96, 40);
            this.btn_MapChange.TabIndex = 12;
            this.btn_MapChange.Text = "Map Change";
            this.btn_MapChange.UseVisualStyleBackColor = true;
            this.btn_MapChange.Click += new System.EventHandler(this.Btn_MapChange_Click);
            // 
            // btn_closeSerial
            // 
            this.btn_closeSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeSerial.Location = new System.Drawing.Point(482, 346);
            this.btn_closeSerial.Name = "btn_closeSerial";
            this.btn_closeSerial.Size = new System.Drawing.Size(95, 40);
            this.btn_closeSerial.TabIndex = 14;
            this.btn_closeSerial.Text = "Close Serial";
            this.btn_closeSerial.UseVisualStyleBackColor = true;
            this.btn_closeSerial.Click += new System.EventHandler(this.Btn_closeSerial_Click);
            // 
            // btn_openSerial
            // 
            this.btn_openSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openSerial.Location = new System.Drawing.Point(369, 346);
            this.btn_openSerial.Name = "btn_openSerial";
            this.btn_openSerial.Size = new System.Drawing.Size(95, 40);
            this.btn_openSerial.TabIndex = 15;
            this.btn_openSerial.Text = "Open Serial";
            this.btn_openSerial.UseVisualStyleBackColor = true;
            this.btn_openSerial.Click += new System.EventHandler(this.Btn_openSerial_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Map_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.btn_openSerial);
            this.Controls.Add(this.btn_closeSerial);
            this.Controls.Add(this.btn_MapChange);
            this.Controls.Add(this.btn_Target);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_gpsLng);
            this.Controls.Add(this.tbx_gpsLat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Lng);
            this.Controls.Add(this.Lbl_Lat);
            this.Controls.Add(this.tbx_tarLng);
            this.Controls.Add(this.tbx_tarLat);
            this.Controls.Add(this.WB_Map);
            this.Controls.Add(this.gmap);
            this.Name = "Map_Show";
            this.Text = "Map_Show";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WB_Map;
        private System.Windows.Forms.TextBox tbx_tarLat;
        private System.Windows.Forms.TextBox tbx_tarLng;
        private System.Windows.Forms.Label Lbl_Lat;
        private System.Windows.Forms.Label Lbl_Lng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_gpsLng;
        private System.Windows.Forms.TextBox tbx_gpsLat;
        private System.Windows.Forms.Button btn_Target;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_MapChange;
        private System.Windows.Forms.Button btn_closeSerial;
        private System.Windows.Forms.Button btn_openSerial;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

