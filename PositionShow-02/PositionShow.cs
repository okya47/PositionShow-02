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



        private void SetTxtbox_glat(string in_str) {
            if (this.tbx_gpsLat.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_glat);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_gpsLat.Text = in_str;
            }

        }

        private void SetTxtbox_glng(string in_str) {
            if (this.tbx_gpsLng.InvokeRequired == true) {
                VoidDeledate temp_del = new VoidDeledate(SetTxtbox_glng);
                this.Invoke(temp_del, new object[] { in_str });
            } else {
                this.tbx_gpsLng.Text = in_str;
            }
        }


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
                    case "glat":
                        SetTxtbox_glat(value);
                        break;
                    case "glng":
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
