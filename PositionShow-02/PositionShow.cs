using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PositionShow_02 {
    public partial class Map_Show : Form {

        delegate void VoidDeledate(string text);
        GMapOverlay markers = new GMapOverlay("markers");
        GMapMarker dragTargetMaker = null;

        public Map_Show() {
            InitializeComponent();

            // マウスイベントを受け取るための準備
            gmap.MouseMove += new MouseEventHandler(onMouseMove);
            gmap.MouseDown += new MouseEventHandler(onMouseDown);
            gmap.MouseUp += new MouseEventHandler(onMouseUp);
        }

        // マウスダウンのイベント
        void onMouseDown(object sender, MouseEventArgs e) {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left) {
                for (int i = 0; i < markers.Markers.Count; i++) {
                    GMapMarker marker = markers.Markers[i];

                    if (marker.IsMouseOver) {
                        dragTargetMaker = marker;
                        break;
                    }
                }
            }
        }

        // マウスムーブのイベント
        void onMouseMove(object sender, MouseEventArgs e) {
            if (dragTargetMaker != null) {
                int x = e.X - gmap.Size.Width / 2;
                int y = e.Y - gmap.Size.Height / 2;
                System.Diagnostics.Trace.WriteLine(String.Format("{0}, {0}", x, y));
                dragTargetMaker.LocalPosition = new Point(x, y);
            }
        }

        // マウスアップのイベント
        void onMouseUp(object sender, MouseEventArgs e) {
            dragTargetMaker = null;
        }

        private void SetTxtbox_lrlr(string in_str) {    // 0
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_lrlr);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_updn(string in_str) {    // 1
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_updn);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_cont(string in_str) {    // 2
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_cont);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }
        private void SetTxtbox_glat(string in_str) {    // 5
            if (this.tbx_gpsLat.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_glat);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_gpsLat.Text = in_str;
            }

        }

        private void SetTxtbox_glng(string in_str) {    // 6
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_glng);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_wvel(string in_str) {    // 7
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_wvel);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_sbag(string in_str) {    // 8
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_sbag);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_sang(string in_str) {    // 9
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_sang);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_rang(string in_str) {    // 10
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_rang);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_wdeg(string in_str) {    // 11
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_wdeg);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_wtag(string in_str) {    // 12
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_wtag);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_gpsLng.Text = in_str;
            }
        }

        private void SetTxtbox_mang(string in_str) {    // 13
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_mang);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_uwag(string in_str) {    // 14
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_uwag);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_dwag(string in_str) {    // 15
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_dwag);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_drtn(string in_str) {    // 16
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_drtn);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_volt(string in_str) {    // 17
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_volt);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_wadt(string in_str) {    // 18
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_wadt);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                //this.tbx_MachineAngle.Text = in_str;
            }
        }

        private void SetTxtbox_wcdt(string in_str) {    // 19
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_wcdt);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_WindCrossDistance.Text = in_str;
            }
        }

        private void SetTxtbox_pval(string in_str) {    // 20
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_pval);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_PotentioVal.Text = in_str;
            }
        }

        private void SetTxtbox_dtar(string in_str) {    // 21
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_dtar);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_DisTarget.Text = in_str;
            }
        }

        private void SetTxtbox_dlat(string in_str) {    // 22
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_dlat);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_DisLat.Text = in_str;
            }
        }

        private void SetTxtbox_dlng(string in_str) {    // 23
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_dlng);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_DisLong.Text = in_str;
            }
        }

        private void SetTxtbox_tdeg(string in_str) {    // 24
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_tdeg);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_TargetDeg.Text = in_str;
            }
        }

        private void SetTxtbox_cdeg(string in_str) {    // 25
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_cdeg);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_CompassDeg.Text = in_str;
            }
        }

        private void SetTxtbox_tbme(string in_str) {    // 26
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_tbme);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_TempBME280.Text = in_str;
            }
        }

        private void SetTxtbox_hbme(string in_str) {    // 27
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_hbme);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_HumidBME280.Text = in_str;
            }
        }

        private void SetTxtbox_pbme(string in_str) {    // 28
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_pbme);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_PressBME280.Text = in_str;
            }
        }

        private void SetTxtbox_gspd(string in_str) {    // 29
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_gspd);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_dGPSSpdMph.Text = in_str;
            }
        }

        private void SetTxtbox_gcrs(string in_str) {    // 30
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_gcrs);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_dGPSCourse.Text = in_str;
            }
        }

        private void SetTxtbox_gdrc(string in_str) {    // 31
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_gdrc);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_GoDirection.Text = in_str;
            }
        }

        //private void SetTxtbox_pvav(string in_str) {    // 32
        //    if (this.tbx_gpsLng.InvokeRequired == true) {
        //        VoidDeledate temp_del = new VoidDeledate(SetTxtbox_pvav);
        //        this.Invoke(temp_del, new object[] { in_str });
        //    } else {
        //        //this.tbx_GoDirection.Text = in_str;
        //    }
        //}

        //private void SetTxtbox_pvav(string in_str) {    // 33
        //    if (this.tbx_gpsLng.InvokeRequired == true) {
        //        VoidDeledate temp_del = new VoidDeledate(SetTxtbox_pvav);
        //        this.Invoke(temp_del, new object[] { in_str });
        //    } else {
        //        //this.tbx_GoDirection.Text = in_str;
        //    }
        //}




        //TextBox _tbx;
        //private void SetTxtbox(TextBox _tbx, string in_str) {
        //    if (_tbx.InvokeRequired == true) { 
        //    //if (this.tbx_gpsLat.InvokeRequired == true) {
        //        VoidDeledate temp_del = new VoidDeledate(SetTxtbox);
        //        this.Invoke(temp_del, new object[] { in_str });
        //    } else {
        //        _tbx.Text = in_str;
        //    }

        //}

        private void MapShowGps(double lat, double lng) {
            GMap.NET.PointLatLng point2 = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point2, GMarkerGoogleType.blue);

            if (markers.Markers.Count() > 1) {
                markers.Markers.RemoveAt(1);
            }
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        private void Form1_Load(object sender, EventArgs e) {
            //WB_Map.Navigate("C:\\Users\\User\\source\\repos\\PositionShow-02\\PositionShow-02\\map\\index.html");

            WB_Map.Navigate("https://www.google.co.jp/maps/@36.28165,140.4898,42081m/data=!3m1!1e3?hl=ja&authuser=0");

            
        }



        private void Btn_Target_Click(object sender, EventArgs e) {
            WB_Map.Visible = false;

            gmap.Visible = true;
            
            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;
            double tarLat = Convert.ToDouble(tbx_tarLat.Text);
            double tarLng = Convert.ToDouble(tbx_tarLng.Text);
            gmap.Position = new GMap.NET.PointLatLng(tarLat, tarLng);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 50;
            gmap.Zoom = 15;
            // マーカーを追加
            GMap.NET.PointLatLng point1 = new PointLatLng(tarLat, tarLng);
            GMapMarker marker = new GMarkerGoogle(point1, GMarkerGoogleType.red);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }

        private void Btn_MapChange_Click(object sender, EventArgs e) {
            gmap.Visible = false;
            WB_Map.Visible = true;
        }

        private void Btn_openSerial_Click(object sender, EventArgs e) {
            serialPort1.Open();
        }

        private void Btn_closeSerial_Click(object sender, EventArgs e) {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string indata = serialPort1.ReadLine();

            if (indata.Length > 8 && indata.Length < 20) {
                string key = indata.Substring(0, 4);
                string value = indata.Substring(5, indata.Length - 7);

                switch (key) {
                    case "lrlr":    // 0
                        SetTxtbox_lrlr(value);
                        break;
                    case "updn":    // 1
                        SetTxtbox_updn(value);
                        break;
                    case "cont":    // 2
                        SetTxtbox_cont(value);
                        break;
                    case "glat":    // 5
                        SetTxtbox_glat(value);
                        break;
                    case "glng":    // 6
                        SetTxtbox_glng(value);
                        Console.WriteLine(tbx_gpsLng.Text);
                        if(tbx_gpsLat.Text != "" && tbx_gpsLng.Text != "") {
                            Console.WriteLine(tbx_gpsLat.Text);
                            try {
                                double glat = Convert.ToDouble(tbx_gpsLat.Text);
                                double glng = Convert.ToDouble(tbx_gpsLng.Text);

                                // okyaマーク作成
                                Bitmap bmpMarker = (Bitmap)Image.FromFile("img/okya.png");
                                PointLatLng point = new PointLatLng(glat, glng);
                                GMapMarker okya = new GMarkerGoogle(point, bmpMarker);

                                //GMapOverlay markers = new GMapOverlay("markers");
                                Console.WriteLine("markers.Markers.Count() = " + markers.Markers.Count());
                                if(markers.Markers.Count() > 1) {
                                    Console.WriteLine("A");
                                    markers.Markers.RemoveAt(1);
                                    gmap.Overlays.RemoveAt(1);
                                }
                                markers.Markers.Add(okya);
                                gmap.Overlays.Add(markers);

                            } catch(FormatException) {
                                Console.WriteLine("値が異常でした");
                            }
                            catch (System.InvalidOperationException) {
                                Console.WriteLine("シリアル通信を閉じて下さい");
                            }
                        }
                        break;
                    case "wvel":    // 7
                        SetTxtbox_wvel(value);
                        break;
                    case "sbag":    // 8
                        SetTxtbox_sbag(value);
                        break;
                    case "sang":    // 9
                        SetTxtbox_sang(value);
                        break;
                    case "rang":    // 10
                        SetTxtbox_rang(value);
                        break;
                    case "wdeg":    // 11
                        SetTxtbox_wdeg(value);
                        break;
                    case "wtag":    // 12
                        SetTxtbox_wtag(value);
                        break;
                    case "mang":    // 13
                        SetTxtbox_mang(value);
                        break;
                    case "uwag":    // 14
                        SetTxtbox_uwag(value);
                        break;
                    case "dwag":    // 15
                        SetTxtbox_dwag(value);
                        break;
                    case "drtn":    // 16
                        SetTxtbox_drtn(value);
                        break;
                    case "volt":    // 17
                        SetTxtbox_volt(value);
                        break;
                    case "wadt":    // 18
                        SetTxtbox_wadt(value);
                        break;
                    case "wcdt":    // 19
                        SetTxtbox_wcdt(value);
                        break;
                    case "pval":    // 20
                        SetTxtbox_pval(value);
                        break;
                    case "dtar":    // 21
                        SetTxtbox_dtar(value);
                        break;
                    case "dlat":    // 22
                        SetTxtbox_dlat(value);
                        break;
                    case "dlng":    // 23
                        SetTxtbox_dlng(value);
                        break;
                    case "tdeg":    // 24
                        SetTxtbox_tdeg(value);
                        break;
                    case "cdeg":    // 25
                        SetTxtbox_cdeg(value);
                        break;
                    case "tbme":    // 26
                        SetTxtbox_tbme(value);
                        break;
                    case "hbme":    // 27
                        SetTxtbox_hbme(value);
                        break;
                    case "pbme":    // 28
                        SetTxtbox_pbme(value);
                        break;
                    case "gspd":    // 29
                        SetTxtbox_gspd(value);
                        break;
                    case "gcrs":    // 30
                        SetTxtbox_gcrs(value);
                        break;
                    case "gdrc":    // 31
                        SetTxtbox_gdrc(value);
                        break;
                    //case "pvav":    // 32
                    //    SetTxtbox_pvav(value);
                    //    break;
                    //case "year":    // 33
                    //    SetTxtbox_year(value);
                    //    break;
                    //case "mnth":    // 34
                    //    SetTxtbox_mnth(value);
                    //    break;
                    //case "dday":    // 35
                    //    SetTxtbox_dday(value);
                    //    break;
                    //case "hour":    // 36
                    //    SetTxtbox_hour(value);
                    //    break;
                    //case "mnte":    // 37
                    //    SetTxtbox_mnte(value);
                    //    break;
                    //case "scnd":    // 38
                    //    SetTxtbox_scnd(value);
                    //    break;
                    default:
                        return;
                }

            }
        }

        private void WB_Map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void label12_Click(object sender, EventArgs e) {

        }
        //public delegate void DelegateupdateTxtbox();


        //private void UpdateTxtbox(string in_str) {
        //    if (this.InvokeRequired) {
        //        this.Invoke(new DelegateupdateTxtbox(this.UpdateTxtbox()));
        //        return;
        //    }
        //    //tbx_gpsLat.Text = "gpsLat";
        //    string key = in_str.Substring(0, 4);
        //    string value = in_str.Substring(5);
        //    switch (key) {
        //        case "glat":
        //            tbx_gpsLat.Text = value;
        //            break;
        //        case "glng":
        //            tbx_gpsLng.Text = value;
        //            break;
        //    }
        //}
    }
}
