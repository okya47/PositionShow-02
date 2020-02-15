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
        void onMouseDown(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left) {
                for(int i = 0; i < markers.Markers.Count; i++)
                {
                    GMapMarker marker = markers.Markers[i];

                    if (marker.IsMouseOver )
                    {
                        dragTargetMaker = marker;
                        break;
                    }
                }
            }

        }

        // マウスムーブのイベント
        void onMouseMove(object sender, MouseEventArgs e)
        {
            if(dragTargetMaker != null)
            {
                int x = e.X - gmap.Size.Width / 2;
                int y = e.Y - gmap.Size.Height / 2;
                System.Diagnostics.Trace.WriteLine(String.Format("{0}, {0}", x, y));
                dragTargetMaker.LocalPosition = new Point(x, y);
            }
        }

        // マウスアップのイベント
        void onMouseUp(object sender, MouseEventArgs e)
        {
            dragTargetMaker = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            WB_Map.Navigate("https://www.google.co.jp/maps/@36.3713,140.4825,42081m/data=!3m1!1e3?hl=ja&authuser=0");

            WB_Map.Visible = false;
            gmap.Visible = true;
            gmap.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMapProviders.GoogleMap;
            double tarLat = 36.3713;
            double tarLng = 140.4825;
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

        private void Btn_Target_Click(object sender, EventArgs e) {
        }

        private void Btn_MapChange_Click(object sender, EventArgs e) {
        }

        private void Btn_openSerial_Click(object sender, EventArgs e) {
        }

        private void Btn_closeSerial_Click(object sender, EventArgs e) {
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) {
        }

    }
}
