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
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.tbx_gpsLng = new System.Windows.Forms.TextBox();
            this.tbx_gpsLat = new System.Windows.Forms.TextBox();
            this.btn_Target = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btn_MapChange = new System.Windows.Forms.Button();
            this.btn_closeSerial = new System.Windows.Forms.Button();
            this.btn_openSerial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblWindCrossDistance = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblPotentioVal = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblDisTarget = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblDisLat = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblDisLong = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.lblTargetDeg = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lblCompassDeg = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.lblTempBME280 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.lblHumidBME280 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.lblPressBME280 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.lbldGPSSpdMph = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WB_Map
            // 
            this.WB_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB_Map.Location = new System.Drawing.Point(0, 0);
            this.WB_Map.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_Map.Name = "WB_Map";
            this.WB_Map.Size = new System.Drawing.Size(609, 544);
            this.WB_Map.TabIndex = 0;
            this.WB_Map.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_Map_DocumentCompleted);
            // 
            // tbx_tarLat
            // 
            this.tbx_tarLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tarLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_tarLat.Location = new System.Drawing.Point(391, 22);
            this.tbx_tarLat.Name = "tbx_tarLat";
            this.tbx_tarLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_tarLat.TabIndex = 2;
            // 
            // tbx_tarLng
            // 
            this.tbx_tarLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tarLng.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_tarLng.Location = new System.Drawing.Point(494, 22);
            this.tbx_tarLng.Name = "tbx_tarLng";
            this.tbx_tarLng.Size = new System.Drawing.Size(84, 22);
            this.tbx_tarLng.TabIndex = 3;
            // 
            // Lbl_Lat
            // 
            this.Lbl_Lat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lat.AutoSize = true;
            this.Lbl_Lat.BackColor = System.Drawing.Color.White;
            this.Lbl_Lat.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Lat.Location = new System.Drawing.Point(389, 7);
            this.Lbl_Lat.Name = "Lbl_Lat";
            this.Lbl_Lat.Size = new System.Drawing.Size(25, 13);
            this.Lbl_Lat.TabIndex = 4;
            this.Lbl_Lat.Text = "Lat";
            // 
            // Lbl_Lng
            // 
            this.Lbl_Lng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lng.AutoSize = true;
            this.Lbl_Lng.BackColor = System.Drawing.Color.White;
            this.Lbl_Lng.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Lng.Location = new System.Drawing.Point(492, 6);
            this.Lbl_Lng.Name = "Lbl_Lng";
            this.Lbl_Lng.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Lng.TabIndex = 5;
            this.Lbl_Lng.Text = "Lng";
            // 
            // lblTarget
            // 
            this.lblTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarget.AutoSize = true;
            this.lblTarget.BackColor = System.Drawing.Color.White;
            this.lblTarget.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTarget.Location = new System.Drawing.Point(332, 28);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(44, 13);
            this.lblTarget.TabIndex = 6;
            this.lblTarget.Text = "Target";
            // 
            // lblMachine
            // 
            this.lblMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMachine.AutoSize = true;
            this.lblMachine.BackColor = System.Drawing.Color.White;
            this.lblMachine.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMachine.Location = new System.Drawing.Point(332, 51);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(54, 13);
            this.lblMachine.TabIndex = 9;
            this.lblMachine.Text = "Machine";
            // 
            // tbx_gpsLng
            // 
            this.tbx_gpsLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLng.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLng.Location = new System.Drawing.Point(494, 45);
            this.tbx_gpsLng.Name = "tbx_gpsLng";
            this.tbx_gpsLng.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLng.TabIndex = 8;
            // 
            // tbx_gpsLat
            // 
            this.tbx_gpsLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLat.Location = new System.Drawing.Point(391, 45);
            this.tbx_gpsLat.Name = "tbx_gpsLat";
            this.tbx_gpsLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLat.TabIndex = 7;
            // 
            // btn_Target
            // 
            this.btn_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Target.Location = new System.Drawing.Point(483, 486);
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
            this.gmap.Size = new System.Drawing.Size(609, 544);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            // 
            // btn_MapChange
            // 
            this.btn_MapChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapChange.Location = new System.Drawing.Point(368, 486);
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
            this.btn_closeSerial.Location = new System.Drawing.Point(482, 440);
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
            this.btn_openSerial.Location = new System.Drawing.Point(369, 440);
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
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.White;
            this.lblWindSpeed.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWindSpeed.Location = new System.Drawing.Point(333, 75);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(67, 13);
            this.lblWindSpeed.TabIndex = 18;
            this.lblWindSpeed.Text = "WindSpeed";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(494, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 22);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(391, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 22);
            this.textBox2.TabIndex = 16;
            // 
            // lblWindCrossDistance
            // 
            this.lblWindCrossDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindCrossDistance.AutoSize = true;
            this.lblWindCrossDistance.BackColor = System.Drawing.Color.White;
            this.lblWindCrossDistance.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWindCrossDistance.Location = new System.Drawing.Point(333, 98);
            this.lblWindCrossDistance.Name = "lblWindCrossDistance";
            this.lblWindCrossDistance.Size = new System.Drawing.Size(115, 13);
            this.lblWindCrossDistance.TabIndex = 21;
            this.lblWindCrossDistance.Text = "WindCrossDistance";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(494, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(391, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 22);
            this.textBox4.TabIndex = 19;
            // 
            // lblPotentioVal
            // 
            this.lblPotentioVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotentioVal.AutoSize = true;
            this.lblPotentioVal.BackColor = System.Drawing.Color.White;
            this.lblPotentioVal.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPotentioVal.Location = new System.Drawing.Point(333, 122);
            this.lblPotentioVal.Name = "lblPotentioVal";
            this.lblPotentioVal.Size = new System.Drawing.Size(73, 13);
            this.lblPotentioVal.TabIndex = 24;
            this.lblPotentioVal.Text = "PotentioVal";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(494, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 22);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox6.Location = new System.Drawing.Point(391, 115);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(84, 22);
            this.textBox6.TabIndex = 22;
            // 
            // lblDisTarget
            // 
            this.lblDisTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisTarget.AutoSize = true;
            this.lblDisTarget.BackColor = System.Drawing.Color.White;
            this.lblDisTarget.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisTarget.Location = new System.Drawing.Point(333, 146);
            this.lblDisTarget.Name = "lblDisTarget";
            this.lblDisTarget.Size = new System.Drawing.Size(59, 13);
            this.lblDisTarget.TabIndex = 27;
            this.lblDisTarget.Text = "disTarget";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox7.Location = new System.Drawing.Point(494, 139);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(84, 22);
            this.textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox8.Location = new System.Drawing.Point(391, 139);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 22);
            this.textBox8.TabIndex = 25;
            // 
            // lblDisLat
            // 
            this.lblDisLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisLat.AutoSize = true;
            this.lblDisLat.BackColor = System.Drawing.Color.White;
            this.lblDisLat.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisLat.Location = new System.Drawing.Point(332, 169);
            this.lblDisLat.Name = "lblDisLat";
            this.lblDisLat.Size = new System.Drawing.Size(40, 13);
            this.lblDisLat.TabIndex = 30;
            this.lblDisLat.Text = "disLat";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox9.Location = new System.Drawing.Point(494, 163);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(84, 22);
            this.textBox9.TabIndex = 29;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox10.Location = new System.Drawing.Point(391, 163);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(84, 22);
            this.textBox10.TabIndex = 28;
            // 
            // lblDisLong
            // 
            this.lblDisLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisLong.AutoSize = true;
            this.lblDisLong.BackColor = System.Drawing.Color.White;
            this.lblDisLong.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisLong.Location = new System.Drawing.Point(333, 193);
            this.lblDisLong.Name = "lblDisLong";
            this.lblDisLong.Size = new System.Drawing.Size(49, 13);
            this.lblDisLong.TabIndex = 33;
            this.lblDisLong.Text = "disLong";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox11.Location = new System.Drawing.Point(495, 187);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(84, 22);
            this.textBox11.TabIndex = 32;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox12.Location = new System.Drawing.Point(392, 187);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(84, 22);
            this.textBox12.TabIndex = 31;
            // 
            // lblTargetDeg
            // 
            this.lblTargetDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetDeg.AutoSize = true;
            this.lblTargetDeg.BackColor = System.Drawing.Color.White;
            this.lblTargetDeg.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTargetDeg.Location = new System.Drawing.Point(333, 217);
            this.lblTargetDeg.Name = "lblTargetDeg";
            this.lblTargetDeg.Size = new System.Drawing.Size(62, 13);
            this.lblTargetDeg.TabIndex = 36;
            this.lblTargetDeg.Text = "targetDeg";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox13.Location = new System.Drawing.Point(495, 211);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(84, 22);
            this.textBox13.TabIndex = 35;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox14.Location = new System.Drawing.Point(392, 211);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(84, 22);
            this.textBox14.TabIndex = 34;
            // 
            // lblCompassDeg
            // 
            this.lblCompassDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompassDeg.AutoSize = true;
            this.lblCompassDeg.BackColor = System.Drawing.Color.White;
            this.lblCompassDeg.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCompassDeg.Location = new System.Drawing.Point(333, 242);
            this.lblCompassDeg.Name = "lblCompassDeg";
            this.lblCompassDeg.Size = new System.Drawing.Size(76, 13);
            this.lblCompassDeg.TabIndex = 39;
            this.lblCompassDeg.Text = "compassDeg";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox15.Location = new System.Drawing.Point(495, 236);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(84, 22);
            this.textBox15.TabIndex = 38;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox16.Location = new System.Drawing.Point(392, 236);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(84, 22);
            this.textBox16.TabIndex = 37;
            // 
            // lblTempBME280
            // 
            this.lblTempBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempBME280.AutoSize = true;
            this.lblTempBME280.BackColor = System.Drawing.Color.White;
            this.lblTempBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTempBME280.Location = new System.Drawing.Point(333, 267);
            this.lblTempBME280.Name = "lblTempBME280";
            this.lblTempBME280.Size = new System.Drawing.Size(81, 13);
            this.lblTempBME280.TabIndex = 42;
            this.lblTempBME280.Text = "tempBME280";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox17.Location = new System.Drawing.Point(495, 261);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(84, 22);
            this.textBox17.TabIndex = 41;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox18.Location = new System.Drawing.Point(392, 261);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(84, 22);
            this.textBox18.TabIndex = 40;
            // 
            // lblHumidBME280
            // 
            this.lblHumidBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHumidBME280.AutoSize = true;
            this.lblHumidBME280.BackColor = System.Drawing.Color.White;
            this.lblHumidBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHumidBME280.Location = new System.Drawing.Point(333, 292);
            this.lblHumidBME280.Name = "lblHumidBME280";
            this.lblHumidBME280.Size = new System.Drawing.Size(86, 13);
            this.lblHumidBME280.TabIndex = 45;
            this.lblHumidBME280.Text = "humidBME280";
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox19.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox19.Location = new System.Drawing.Point(495, 286);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(84, 22);
            this.textBox19.TabIndex = 44;
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox20.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox20.Location = new System.Drawing.Point(392, 286);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(84, 22);
            this.textBox20.TabIndex = 43;
            // 
            // lblPressBME280
            // 
            this.lblPressBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPressBME280.AutoSize = true;
            this.lblPressBME280.BackColor = System.Drawing.Color.White;
            this.lblPressBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPressBME280.Location = new System.Drawing.Point(333, 317);
            this.lblPressBME280.Name = "lblPressBME280";
            this.lblPressBME280.Size = new System.Drawing.Size(77, 13);
            this.lblPressBME280.TabIndex = 48;
            this.lblPressBME280.Text = "presBME280";
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox21.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox21.Location = new System.Drawing.Point(495, 311);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(84, 22);
            this.textBox21.TabIndex = 47;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox22.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox22.Location = new System.Drawing.Point(392, 311);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(84, 22);
            this.textBox22.TabIndex = 46;
            // 
            // lbldGPSSpdMph
            // 
            this.lbldGPSSpdMph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldGPSSpdMph.AutoSize = true;
            this.lbldGPSSpdMph.BackColor = System.Drawing.Color.White;
            this.lbldGPSSpdMph.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbldGPSSpdMph.Location = new System.Drawing.Point(333, 342);
            this.lbldGPSSpdMph.Name = "lbldGPSSpdMph";
            this.lbldGPSSpdMph.Size = new System.Drawing.Size(81, 13);
            this.lbldGPSSpdMph.TabIndex = 51;
            this.lbldGPSSpdMph.Text = "dGPSSpdMph";
            // 
            // textBox23
            // 
            this.textBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox23.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox23.Location = new System.Drawing.Point(495, 336);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(84, 22);
            this.textBox23.TabIndex = 50;
            // 
            // textBox24
            // 
            this.textBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox24.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox24.Location = new System.Drawing.Point(392, 336);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(84, 22);
            this.textBox24.TabIndex = 49;
            // 
            // Map_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 544);
            this.Controls.Add(this.lbldGPSSpdMph);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.lblPressBME280);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.lblHumidBME280);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.lblTempBME280);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.lblCompassDeg);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.lblTargetDeg);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.lblDisLong);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.lblDisLat);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.lblDisTarget);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.lblPotentioVal);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblWindCrossDistance);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_openSerial);
            this.Controls.Add(this.btn_closeSerial);
            this.Controls.Add(this.btn_MapChange);
            this.Controls.Add(this.btn_Target);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.tbx_gpsLng);
            this.Controls.Add(this.tbx_gpsLat);
            this.Controls.Add(this.lblTarget);
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
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.TextBox tbx_gpsLng;
        private System.Windows.Forms.TextBox tbx_gpsLat;
        private System.Windows.Forms.Button btn_Target;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btn_MapChange;
        private System.Windows.Forms.Button btn_closeSerial;
        private System.Windows.Forms.Button btn_openSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblWindCrossDistance;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblPotentioVal;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblDisTarget;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblDisLat;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblDisLong;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label lblTargetDeg;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label lblCompassDeg;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label lblTempBME280;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label lblHumidBME280;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label lblPressBME280;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label lbldGPSSpdMph;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
    }
}

