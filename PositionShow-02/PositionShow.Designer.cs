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
            this.tbx_WndSpeed = new System.Windows.Forms.TextBox();
            this.lblWindCrossDistance = new System.Windows.Forms.Label();
            this.tbx_WindCrossDistance = new System.Windows.Forms.TextBox();
            this.lblPotentioVal = new System.Windows.Forms.Label();
            this.tbx_PotentioVal = new System.Windows.Forms.TextBox();
            this.lblDisTarget = new System.Windows.Forms.Label();
            this.tbx_DisTarget = new System.Windows.Forms.TextBox();
            this.lblDisLat = new System.Windows.Forms.Label();
            this.tbx_DisLat = new System.Windows.Forms.TextBox();
            this.lblDisLong = new System.Windows.Forms.Label();
            this.tbx_DisLong = new System.Windows.Forms.TextBox();
            this.lblTargetDeg = new System.Windows.Forms.Label();
            this.tbx_TargetDeg = new System.Windows.Forms.TextBox();
            this.lblCompassDeg = new System.Windows.Forms.Label();
            this.tbx_CompassDeg = new System.Windows.Forms.TextBox();
            this.lblTempBME280 = new System.Windows.Forms.Label();
            this.tbx_TempBME280 = new System.Windows.Forms.TextBox();
            this.lblHumidBME280 = new System.Windows.Forms.Label();
            this.tbx_HumidBME280 = new System.Windows.Forms.TextBox();
            this.lblPressBME280 = new System.Windows.Forms.Label();
            this.tbx_PressBME280 = new System.Windows.Forms.TextBox();
            this.lbldGPSSpdMph = new System.Windows.Forms.Label();
            this.tbx_dGPSSpdMph = new System.Windows.Forms.TextBox();
            this.lbldGPSCourse = new System.Windows.Forms.Label();
            this.tbx_dGPSCourse = new System.Windows.Forms.TextBox();
            this.lblMachineAngle = new System.Windows.Forms.Label();
            this.tbx_MachineAngle = new System.Windows.Forms.TextBox();
            this.lblGoDirection = new System.Windows.Forms.Label();
            this.tbx_GoDirection = new System.Windows.Forms.TextBox();
            this.lblSailAngle = new System.Windows.Forms.Label();
            this.tbx_SailAngle = new System.Windows.Forms.TextBox();
            this.trbSailBaseAngle = new System.Windows.Forms.TrackBar();
            this.lblValueSailBaseAngle = new System.Windows.Forms.Label();
            this.lblSailBaseAngle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbBRudderAngle = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbDistanceReturn = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trbUpWindAngle = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trbDownWindAngle = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbSailBaseAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBRudderAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDistanceReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpWindAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDownWindAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // WB_Map
            // 
            this.WB_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB_Map.Location = new System.Drawing.Point(0, 0);
            this.WB_Map.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_Map.Name = "WB_Map";
            this.WB_Map.Size = new System.Drawing.Size(609, 570);
            this.WB_Map.TabIndex = 0;
            this.WB_Map.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_Map_DocumentCompleted);
            // 
            // tbx_tarLat
            // 
            this.tbx_tarLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_tarLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_tarLat.Location = new System.Drawing.Point(403, 22);
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
            this.Lbl_Lat.Location = new System.Drawing.Point(401, 7);
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
            this.lblTarget.Location = new System.Drawing.Point(353, 28);
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
            this.lblMachine.Location = new System.Drawing.Point(343, 51);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(54, 13);
            this.lblMachine.TabIndex = 9;
            this.lblMachine.Text = "Machine";
            // 
            // tbx_gpsLng
            // 
            this.tbx_gpsLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLng.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLng.Location = new System.Drawing.Point(494, 46);
            this.tbx_gpsLng.Name = "tbx_gpsLng";
            this.tbx_gpsLng.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLng.TabIndex = 8;
            // 
            // tbx_gpsLat
            // 
            this.tbx_gpsLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_gpsLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_gpsLat.Location = new System.Drawing.Point(403, 46);
            this.tbx_gpsLat.Name = "tbx_gpsLat";
            this.tbx_gpsLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_gpsLat.TabIndex = 7;
            // 
            // btn_Target
            // 
            this.btn_Target.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Target.Location = new System.Drawing.Point(483, 512);
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
            this.gmap.Size = new System.Drawing.Size(609, 570);
            this.gmap.TabIndex = 11;
            this.gmap.Zoom = 0D;
            // 
            // btn_MapChange
            // 
            this.btn_MapChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapChange.Location = new System.Drawing.Point(368, 512);
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
            this.btn_closeSerial.Location = new System.Drawing.Point(482, 466);
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
            this.btn_openSerial.Location = new System.Drawing.Point(369, 466);
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
            // lblWindSpeed
            // 
            this.lblWindSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.White;
            this.lblWindSpeed.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWindSpeed.Location = new System.Drawing.Point(417, 75);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(67, 13);
            this.lblWindSpeed.TabIndex = 18;
            this.lblWindSpeed.Text = "WindSpeed";
            // 
            // tbx_WndSpeed
            // 
            this.tbx_WndSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_WndSpeed.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_WndSpeed.Location = new System.Drawing.Point(494, 70);
            this.tbx_WndSpeed.Name = "tbx_WndSpeed";
            this.tbx_WndSpeed.Size = new System.Drawing.Size(84, 22);
            this.tbx_WndSpeed.TabIndex = 17;
            // 
            // lblWindCrossDistance
            // 
            this.lblWindCrossDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWindCrossDistance.AutoSize = true;
            this.lblWindCrossDistance.BackColor = System.Drawing.Color.White;
            this.lblWindCrossDistance.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWindCrossDistance.Location = new System.Drawing.Point(369, 98);
            this.lblWindCrossDistance.Name = "lblWindCrossDistance";
            this.lblWindCrossDistance.Size = new System.Drawing.Size(115, 13);
            this.lblWindCrossDistance.TabIndex = 21;
            this.lblWindCrossDistance.Text = "WindCrossDistance";
            // 
            // tbx_WindCrossDistance
            // 
            this.tbx_WindCrossDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_WindCrossDistance.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_WindCrossDistance.Location = new System.Drawing.Point(494, 94);
            this.tbx_WindCrossDistance.Name = "tbx_WindCrossDistance";
            this.tbx_WindCrossDistance.Size = new System.Drawing.Size(84, 22);
            this.tbx_WindCrossDistance.TabIndex = 20;
            // 
            // lblPotentioVal
            // 
            this.lblPotentioVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPotentioVal.AutoSize = true;
            this.lblPotentioVal.BackColor = System.Drawing.Color.White;
            this.lblPotentioVal.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPotentioVal.Location = new System.Drawing.Point(411, 122);
            this.lblPotentioVal.Name = "lblPotentioVal";
            this.lblPotentioVal.Size = new System.Drawing.Size(73, 13);
            this.lblPotentioVal.TabIndex = 24;
            this.lblPotentioVal.Text = "PotentioVal";
            // 
            // tbx_PotentioVal
            // 
            this.tbx_PotentioVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_PotentioVal.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_PotentioVal.Location = new System.Drawing.Point(494, 118);
            this.tbx_PotentioVal.Name = "tbx_PotentioVal";
            this.tbx_PotentioVal.Size = new System.Drawing.Size(84, 22);
            this.tbx_PotentioVal.TabIndex = 23;
            // 
            // lblDisTarget
            // 
            this.lblDisTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisTarget.AutoSize = true;
            this.lblDisTarget.BackColor = System.Drawing.Color.White;
            this.lblDisTarget.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisTarget.Location = new System.Drawing.Point(425, 146);
            this.lblDisTarget.Name = "lblDisTarget";
            this.lblDisTarget.Size = new System.Drawing.Size(59, 13);
            this.lblDisTarget.TabIndex = 27;
            this.lblDisTarget.Text = "disTarget";
            // 
            // tbx_DisTarget
            // 
            this.tbx_DisTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_DisTarget.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_DisTarget.Location = new System.Drawing.Point(494, 142);
            this.tbx_DisTarget.Name = "tbx_DisTarget";
            this.tbx_DisTarget.Size = new System.Drawing.Size(84, 22);
            this.tbx_DisTarget.TabIndex = 26;
            // 
            // lblDisLat
            // 
            this.lblDisLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisLat.AutoSize = true;
            this.lblDisLat.BackColor = System.Drawing.Color.White;
            this.lblDisLat.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisLat.Location = new System.Drawing.Point(444, 169);
            this.lblDisLat.Name = "lblDisLat";
            this.lblDisLat.Size = new System.Drawing.Size(40, 13);
            this.lblDisLat.TabIndex = 30;
            this.lblDisLat.Text = "disLat";
            // 
            // tbx_DisLat
            // 
            this.tbx_DisLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_DisLat.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_DisLat.Location = new System.Drawing.Point(494, 166);
            this.tbx_DisLat.Name = "tbx_DisLat";
            this.tbx_DisLat.Size = new System.Drawing.Size(84, 22);
            this.tbx_DisLat.TabIndex = 29;
            // 
            // lblDisLong
            // 
            this.lblDisLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisLong.AutoSize = true;
            this.lblDisLong.BackColor = System.Drawing.Color.White;
            this.lblDisLong.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisLong.Location = new System.Drawing.Point(435, 193);
            this.lblDisLong.Name = "lblDisLong";
            this.lblDisLong.Size = new System.Drawing.Size(49, 13);
            this.lblDisLong.TabIndex = 33;
            this.lblDisLong.Text = "disLong";
            // 
            // tbx_DisLong
            // 
            this.tbx_DisLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_DisLong.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_DisLong.Location = new System.Drawing.Point(494, 190);
            this.tbx_DisLong.Name = "tbx_DisLong";
            this.tbx_DisLong.Size = new System.Drawing.Size(84, 22);
            this.tbx_DisLong.TabIndex = 32;
            // 
            // lblTargetDeg
            // 
            this.lblTargetDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetDeg.AutoSize = true;
            this.lblTargetDeg.BackColor = System.Drawing.Color.White;
            this.lblTargetDeg.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTargetDeg.Location = new System.Drawing.Point(422, 217);
            this.lblTargetDeg.Name = "lblTargetDeg";
            this.lblTargetDeg.Size = new System.Drawing.Size(62, 13);
            this.lblTargetDeg.TabIndex = 36;
            this.lblTargetDeg.Text = "targetDeg";
            // 
            // tbx_TargetDeg
            // 
            this.tbx_TargetDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_TargetDeg.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_TargetDeg.Location = new System.Drawing.Point(494, 214);
            this.tbx_TargetDeg.Name = "tbx_TargetDeg";
            this.tbx_TargetDeg.Size = new System.Drawing.Size(84, 22);
            this.tbx_TargetDeg.TabIndex = 35;
            // 
            // lblCompassDeg
            // 
            this.lblCompassDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompassDeg.AutoSize = true;
            this.lblCompassDeg.BackColor = System.Drawing.Color.White;
            this.lblCompassDeg.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCompassDeg.Location = new System.Drawing.Point(408, 242);
            this.lblCompassDeg.Name = "lblCompassDeg";
            this.lblCompassDeg.Size = new System.Drawing.Size(76, 13);
            this.lblCompassDeg.TabIndex = 39;
            this.lblCompassDeg.Text = "compassDeg";
            // 
            // tbx_CompassDeg
            // 
            this.tbx_CompassDeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_CompassDeg.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_CompassDeg.Location = new System.Drawing.Point(494, 238);
            this.tbx_CompassDeg.Name = "tbx_CompassDeg";
            this.tbx_CompassDeg.Size = new System.Drawing.Size(84, 22);
            this.tbx_CompassDeg.TabIndex = 38;
            // 
            // lblTempBME280
            // 
            this.lblTempBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempBME280.AutoSize = true;
            this.lblTempBME280.BackColor = System.Drawing.Color.White;
            this.lblTempBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTempBME280.Location = new System.Drawing.Point(403, 267);
            this.lblTempBME280.Name = "lblTempBME280";
            this.lblTempBME280.Size = new System.Drawing.Size(81, 13);
            this.lblTempBME280.TabIndex = 42;
            this.lblTempBME280.Text = "tempBME280";
            // 
            // tbx_TempBME280
            // 
            this.tbx_TempBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_TempBME280.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_TempBME280.Location = new System.Drawing.Point(494, 262);
            this.tbx_TempBME280.Name = "tbx_TempBME280";
            this.tbx_TempBME280.Size = new System.Drawing.Size(84, 22);
            this.tbx_TempBME280.TabIndex = 41;
            // 
            // lblHumidBME280
            // 
            this.lblHumidBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHumidBME280.AutoSize = true;
            this.lblHumidBME280.BackColor = System.Drawing.Color.White;
            this.lblHumidBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHumidBME280.Location = new System.Drawing.Point(398, 291);
            this.lblHumidBME280.Name = "lblHumidBME280";
            this.lblHumidBME280.Size = new System.Drawing.Size(86, 13);
            this.lblHumidBME280.TabIndex = 45;
            this.lblHumidBME280.Text = "humidBME280";
            // 
            // tbx_HumidBME280
            // 
            this.tbx_HumidBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_HumidBME280.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_HumidBME280.Location = new System.Drawing.Point(494, 286);
            this.tbx_HumidBME280.Name = "tbx_HumidBME280";
            this.tbx_HumidBME280.Size = new System.Drawing.Size(84, 22);
            this.tbx_HumidBME280.TabIndex = 44;
            // 
            // lblPressBME280
            // 
            this.lblPressBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPressBME280.AutoSize = true;
            this.lblPressBME280.BackColor = System.Drawing.Color.White;
            this.lblPressBME280.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPressBME280.Location = new System.Drawing.Point(407, 316);
            this.lblPressBME280.Name = "lblPressBME280";
            this.lblPressBME280.Size = new System.Drawing.Size(77, 13);
            this.lblPressBME280.TabIndex = 48;
            this.lblPressBME280.Text = "presBME280";
            // 
            // tbx_PressBME280
            // 
            this.tbx_PressBME280.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_PressBME280.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_PressBME280.Location = new System.Drawing.Point(494, 310);
            this.tbx_PressBME280.Name = "tbx_PressBME280";
            this.tbx_PressBME280.Size = new System.Drawing.Size(84, 22);
            this.tbx_PressBME280.TabIndex = 47;
            // 
            // lbldGPSSpdMph
            // 
            this.lbldGPSSpdMph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldGPSSpdMph.AutoSize = true;
            this.lbldGPSSpdMph.BackColor = System.Drawing.Color.White;
            this.lbldGPSSpdMph.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbldGPSSpdMph.Location = new System.Drawing.Point(403, 340);
            this.lbldGPSSpdMph.Name = "lbldGPSSpdMph";
            this.lbldGPSSpdMph.Size = new System.Drawing.Size(81, 13);
            this.lbldGPSSpdMph.TabIndex = 51;
            this.lbldGPSSpdMph.Text = "dGPSSpdMph";
            // 
            // tbx_dGPSSpdMph
            // 
            this.tbx_dGPSSpdMph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_dGPSSpdMph.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_dGPSSpdMph.Location = new System.Drawing.Point(494, 334);
            this.tbx_dGPSSpdMph.Name = "tbx_dGPSSpdMph";
            this.tbx_dGPSSpdMph.Size = new System.Drawing.Size(84, 22);
            this.tbx_dGPSSpdMph.TabIndex = 50;
            // 
            // lbldGPSCourse
            // 
            this.lbldGPSCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldGPSCourse.AutoSize = true;
            this.lbldGPSCourse.BackColor = System.Drawing.Color.White;
            this.lbldGPSCourse.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbldGPSCourse.Location = new System.Drawing.Point(405, 364);
            this.lbldGPSCourse.Name = "lbldGPSCourse";
            this.lbldGPSCourse.Size = new System.Drawing.Size(79, 13);
            this.lbldGPSCourse.TabIndex = 54;
            this.lbldGPSCourse.Text = "dGPSCourse";
            // 
            // tbx_dGPSCourse
            // 
            this.tbx_dGPSCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_dGPSCourse.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_dGPSCourse.Location = new System.Drawing.Point(494, 358);
            this.tbx_dGPSCourse.Name = "tbx_dGPSCourse";
            this.tbx_dGPSCourse.Size = new System.Drawing.Size(84, 22);
            this.tbx_dGPSCourse.TabIndex = 53;
            // 
            // lblMachineAngle
            // 
            this.lblMachineAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMachineAngle.AutoSize = true;
            this.lblMachineAngle.BackColor = System.Drawing.Color.White;
            this.lblMachineAngle.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMachineAngle.Location = new System.Drawing.Point(399, 388);
            this.lblMachineAngle.Name = "lblMachineAngle";
            this.lblMachineAngle.Size = new System.Drawing.Size(85, 13);
            this.lblMachineAngle.TabIndex = 57;
            this.lblMachineAngle.Text = "machineAngle";
            // 
            // tbx_MachineAngle
            // 
            this.tbx_MachineAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_MachineAngle.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_MachineAngle.Location = new System.Drawing.Point(494, 382);
            this.tbx_MachineAngle.Name = "tbx_MachineAngle";
            this.tbx_MachineAngle.Size = new System.Drawing.Size(84, 22);
            this.tbx_MachineAngle.TabIndex = 56;
            // 
            // lblGoDirection
            // 
            this.lblGoDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoDirection.AutoSize = true;
            this.lblGoDirection.BackColor = System.Drawing.Color.White;
            this.lblGoDirection.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGoDirection.Location = new System.Drawing.Point(412, 412);
            this.lblGoDirection.Name = "lblGoDirection";
            this.lblGoDirection.Size = new System.Drawing.Size(72, 13);
            this.lblGoDirection.TabIndex = 60;
            this.lblGoDirection.Text = "goDirection";
            // 
            // tbx_GoDirection
            // 
            this.tbx_GoDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_GoDirection.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_GoDirection.Location = new System.Drawing.Point(494, 406);
            this.tbx_GoDirection.Name = "tbx_GoDirection";
            this.tbx_GoDirection.Size = new System.Drawing.Size(84, 22);
            this.tbx_GoDirection.TabIndex = 59;
            // 
            // lblSailAngle
            // 
            this.lblSailAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSailAngle.AutoSize = true;
            this.lblSailAngle.BackColor = System.Drawing.Color.White;
            this.lblSailAngle.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSailAngle.Location = new System.Drawing.Point(426, 436);
            this.lblSailAngle.Name = "lblSailAngle";
            this.lblSailAngle.Size = new System.Drawing.Size(58, 13);
            this.lblSailAngle.TabIndex = 63;
            this.lblSailAngle.Text = "SailAngle";
            // 
            // tbx_SailAngle
            // 
            this.tbx_SailAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_SailAngle.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbx_SailAngle.Location = new System.Drawing.Point(494, 430);
            this.tbx_SailAngle.Name = "tbx_SailAngle";
            this.tbx_SailAngle.Size = new System.Drawing.Size(84, 22);
            this.tbx_SailAngle.TabIndex = 62;
            // 
            // trbSailBaseAngle
            // 
            this.trbSailBaseAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbSailBaseAngle.Location = new System.Drawing.Point(6, 7);
            this.trbSailBaseAngle.Maximum = 90;
            this.trbSailBaseAngle.Name = "trbSailBaseAngle";
            this.trbSailBaseAngle.Size = new System.Drawing.Size(95, 45);
            this.trbSailBaseAngle.TabIndex = 64;
            // 
            // lblValueSailBaseAngle
            // 
            this.lblValueSailBaseAngle.AutoSize = true;
            this.lblValueSailBaseAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblValueSailBaseAngle.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValueSailBaseAngle.Location = new System.Drawing.Point(109, 13);
            this.lblValueSailBaseAngle.Name = "lblValueSailBaseAngle";
            this.lblValueSailBaseAngle.Size = new System.Drawing.Size(39, 13);
            this.lblValueSailBaseAngle.TabIndex = 65;
            this.lblValueSailBaseAngle.Text = "label1";
            // 
            // lblSailBaseAngle
            // 
            this.lblSailBaseAngle.AutoSize = true;
            this.lblSailBaseAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSailBaseAngle.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSailBaseAngle.Location = new System.Drawing.Point(151, 14);
            this.lblSailBaseAngle.Name = "lblSailBaseAngle";
            this.lblSailBaseAngle.Size = new System.Drawing.Size(93, 13);
            this.lblSailBaseAngle.TabIndex = 66;
            this.lblSailBaseAngle.Text = "Sail Base Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(150, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "BRudderAngle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(109, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "label4";
            // 
            // trbBRudderAngle
            // 
            this.trbBRudderAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbBRudderAngle.Location = new System.Drawing.Point(6, 36);
            this.trbBRudderAngle.Maximum = 45;
            this.trbBRudderAngle.Name = "trbBRudderAngle";
            this.trbBRudderAngle.Size = new System.Drawing.Size(95, 45);
            this.trbBRudderAngle.SmallChange = 5;
            this.trbBRudderAngle.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(150, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "DistanceReturn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(109, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "label6";
            // 
            // trbDistanceReturn
            // 
            this.trbDistanceReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbDistanceReturn.Location = new System.Drawing.Point(6, 65);
            this.trbDistanceReturn.Maximum = 50;
            this.trbDistanceReturn.Name = "trbDistanceReturn";
            this.trbDistanceReturn.Size = new System.Drawing.Size(95, 45);
            this.trbDistanceReturn.SmallChange = 5;
            this.trbDistanceReturn.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(150, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "UpWindAngle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(109, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "label8";
            // 
            // trbUpWindAngle
            // 
            this.trbUpWindAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbUpWindAngle.Location = new System.Drawing.Point(6, 94);
            this.trbUpWindAngle.Maximum = 45;
            this.trbUpWindAngle.Name = "trbUpWindAngle";
            this.trbUpWindAngle.Size = new System.Drawing.Size(95, 45);
            this.trbUpWindAngle.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(150, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "DownWindAngle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(109, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "label10";
            // 
            // trbDownWindAngle
            // 
            this.trbDownWindAngle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trbDownWindAngle.Location = new System.Drawing.Point(6, 123);
            this.trbDownWindAngle.Maximum = 45;
            this.trbDownWindAngle.Name = "trbDownWindAngle";
            this.trbDownWindAngle.Size = new System.Drawing.Size(95, 45);
            this.trbDownWindAngle.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(11, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(109, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(151, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Battery";
            // 
            // Map_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 570);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trbDownWindAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trbUpWindAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trbDistanceReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbBRudderAngle);
            this.Controls.Add(this.lblSailBaseAngle);
            this.Controls.Add(this.lblValueSailBaseAngle);
            this.Controls.Add(this.trbSailBaseAngle);
            this.Controls.Add(this.lblSailAngle);
            this.Controls.Add(this.tbx_SailAngle);
            this.Controls.Add(this.lblGoDirection);
            this.Controls.Add(this.tbx_GoDirection);
            this.Controls.Add(this.lblMachineAngle);
            this.Controls.Add(this.tbx_MachineAngle);
            this.Controls.Add(this.lbldGPSCourse);
            this.Controls.Add(this.tbx_dGPSCourse);
            this.Controls.Add(this.lbldGPSSpdMph);
            this.Controls.Add(this.tbx_dGPSSpdMph);
            this.Controls.Add(this.lblPressBME280);
            this.Controls.Add(this.tbx_PressBME280);
            this.Controls.Add(this.lblHumidBME280);
            this.Controls.Add(this.tbx_HumidBME280);
            this.Controls.Add(this.lblTempBME280);
            this.Controls.Add(this.tbx_TempBME280);
            this.Controls.Add(this.lblCompassDeg);
            this.Controls.Add(this.tbx_CompassDeg);
            this.Controls.Add(this.lblTargetDeg);
            this.Controls.Add(this.tbx_TargetDeg);
            this.Controls.Add(this.lblDisLong);
            this.Controls.Add(this.tbx_DisLong);
            this.Controls.Add(this.lblDisLat);
            this.Controls.Add(this.tbx_DisLat);
            this.Controls.Add(this.lblDisTarget);
            this.Controls.Add(this.tbx_DisTarget);
            this.Controls.Add(this.lblPotentioVal);
            this.Controls.Add(this.tbx_PotentioVal);
            this.Controls.Add(this.lblWindCrossDistance);
            this.Controls.Add(this.tbx_WindCrossDistance);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.tbx_WndSpeed);
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
            ((System.ComponentModel.ISupportInitialize)(this.trbSailBaseAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBRudderAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDistanceReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpWindAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbDownWindAngle)).EndInit();
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
        private System.Windows.Forms.TextBox tbx_WndSpeed;
        private System.Windows.Forms.Label lblWindCrossDistance;
        private System.Windows.Forms.TextBox tbx_WindCrossDistance;
        private System.Windows.Forms.Label lblPotentioVal;
        private System.Windows.Forms.TextBox tbx_PotentioVal;
        private System.Windows.Forms.Label lblDisTarget;
        private System.Windows.Forms.TextBox tbx_DisTarget;
        private System.Windows.Forms.Label lblDisLat;
        private System.Windows.Forms.TextBox tbx_DisLat;
        private System.Windows.Forms.Label lblDisLong;
        private System.Windows.Forms.TextBox tbx_DisLong;
        private System.Windows.Forms.Label lblTargetDeg;
        private System.Windows.Forms.TextBox tbx_TargetDeg;
        private System.Windows.Forms.Label lblCompassDeg;
        private System.Windows.Forms.TextBox tbx_CompassDeg;
        private System.Windows.Forms.Label lblTempBME280;
        private System.Windows.Forms.TextBox tbx_TempBME280;
        private System.Windows.Forms.Label lblHumidBME280;
        private System.Windows.Forms.TextBox tbx_HumidBME280;
        private System.Windows.Forms.Label lblPressBME280;
        private System.Windows.Forms.TextBox tbx_PressBME280;
        private System.Windows.Forms.Label lbldGPSSpdMph;
        private System.Windows.Forms.TextBox tbx_dGPSSpdMph;
        private System.Windows.Forms.Label lbldGPSCourse;
        private System.Windows.Forms.TextBox tbx_dGPSCourse;
        private System.Windows.Forms.Label lblMachineAngle;
        private System.Windows.Forms.TextBox tbx_MachineAngle;
        private System.Windows.Forms.Label lblGoDirection;
        private System.Windows.Forms.TextBox tbx_GoDirection;
        private System.Windows.Forms.Label lblSailAngle;
        private System.Windows.Forms.TextBox tbx_SailAngle;
        private System.Windows.Forms.TrackBar trbSailBaseAngle;
        private System.Windows.Forms.Label lblValueSailBaseAngle;
        private System.Windows.Forms.Label lblSailBaseAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbBRudderAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbDistanceReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trbUpWindAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trbDownWindAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

