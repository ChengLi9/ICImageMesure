using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using TIS.Imaging;
using System.Drawing.Drawing2D;

namespace ICImageMesure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FrameHandlerSink m_sink;
        private Boolean CoordinatesystemFlag = true;

        private void icImagingControl1_LivePrepared(object sender, EventArgs e)
        {
            if (icImagingControl1.DeviceValid)
            {
                SetupOverlay(icImagingControl1.OverlayBitmapAtPath[PathPositions.Device]);

                // Display a coordinate system on the device overlay
                //DrawCoordinatesystem(icImagingControl1.OverlayBitmapAtPath[PathPositions.Device]);
            }
        }

        private void icImagingControl1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            string location = coordinates + "";
            if (segment.Checked == false && triangle.Checked == false && quadrilateral.Checked == false && cycle.Checked == false)
            {
                MessageBox.Show("Choose a graph first!");
            }
            else if (segment.Checked == true)
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Location = coordinates;
                    textBox1.Text = location;
                    textBox1.Visible = true;
                }
                else
                {
                    textBox2.Location = coordinates;
                    textBox2.Text = location;
                    textBox2.Visible = true;
                    GetDistance(textBox1.Location,textBox2.Location);
                }
            }
            else if (triangle.Checked == true)
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Location = coordinates;
                    textBox1.Text = location;
                    textBox1.Visible = true;
                }
                else if (textBox2.Visible == false)
                {
                    textBox2.Location = coordinates;
                    textBox2.Text = location;
                    textBox2.Visible = true;
                }
                else
                {
                    textBox3.Location = coordinates;
                    textBox3.Text = location;
                    textBox3.Visible = true;
                    GetTriangleArea(textBox1.Location, textBox2.Location,textBox3.Location);
                }
            }
            else if (quadrilateral.Checked == true)
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Location = coordinates;
                    textBox1.Text = location;
                    textBox1.Visible = true;
                }
                else if (textBox2.Visible == false)
                {
                    textBox2.Location = coordinates;
                    textBox2.Text = location;
                    textBox2.Visible = true;
                }
                else if (textBox3.Visible == false)
                {
                    textBox3.Location = coordinates;
                    textBox3.Text = location;
                    textBox3.Visible = true;
                }
                else
                {
                    textBox4.Location = coordinates;
                    textBox4.Text = location;
                    textBox4.Visible = true;
                    GetQuadrilateralArea(textBox1.Location, textBox2.Location, textBox3.Location,textBox4.Location);
                }             
            }
            else 
            {
                if (textBox1.Visible == false)
                {
                    textBox1.Location = coordinates;
                    textBox1.Text = location;
                    textBox1.Visible = true;
                }
                else
                {
                    textBox2.Location = coordinates;
                    textBox2.Text = location;
                    textBox2.Visible = true;
                    GetCycleArea(textBox1.Location, textBox2.Location);
                }            
            }
        }

        private void GetDistance(Point X, Point Y)
        {
            var midX = (X.X + Y.X) / 2;
            var midY = (X.Y + Y.Y) / 2;
            Point midPoint = new Point(midX, midY);
            double distance = Math.Sqrt(Math.Pow((X.X - Y.X), 2) + Math.Pow((X.Y - Y.Y), 2));
            textBox3.Location = midPoint;
            textBox3.Text = distance + "";
            textBox3.Visible = true;
        }

        private void GetTriangleArea(Point P1, Point P2, Point P3)
        {
            var midX = (P1.X + P2.X + P3.X) / 3;
            var midY = (P1.Y + P2.Y + P3.Y) / 3;
            Point centroid = new Point(midX, midY);
            double area = 0.5*Math.Abs(P1.X * P2.Y - P2.X * P1.Y + P2.X * P3.Y - P2.Y * P3.X + P3.X * P1.Y - P1.X * P3.Y);
            textBox4.Location = centroid;
            textBox4.Text = area + "";
            textBox4.Visible = true;
        }

        private void GetQuadrilateralArea(Point P1, Point P2, Point P3, Point P4)
        {
            var midX = (P1.X + P2.X + P3.X + P4.X) / 4;
            var midY = (P1.Y + P2.Y + P3.Y + P4.Y) / 4;
            Point centroid = new Point(midX, midY);
            double area = 0.5 * Math.Abs(P1.X * P2.Y - P2.X * P1.Y + P2.X * P3.Y - P2.Y * P3.X + P3.X * P4.Y - P4.X * P3.Y + P4.X * P1.Y - P1.X * P4.Y);
            textBox5.Location = centroid;
            textBox5.Text = area + "";
            textBox5.Visible = true;
        }

        private void GetCycleArea(Point X, Point Y)
        {
            var midX = (X.X + Y.X) / 2;
            var midY = (X.Y + Y.Y) / 2;
            Point midPoint = new Point(midX, midY);
            double diameter = 0.5*Math.Sqrt(Math.Pow((X.X - Y.X), 2) + Math.Pow((X.Y - Y.Y), 2));
            double area = Math.PI* Math.Pow(diameter, 2);
            textBox3.Location = midPoint;
            textBox3.Text = area + "";
            textBox3.Visible = true;
        }

        private void icImagingControl1_OverlayUpdate(object sender, TIS.Imaging.ICImagingControl.OverlayUpdateEventArgs e)
        {
            TIS.Imaging.OverlayBitmap ob = e.overlay;

            int lineIndex = m_sink.FrameCount % 25;
            if (lineIndex == 0)
            {
                ob.DrawSolidRect(ob.DropOutColor, 10, icImagingControl1.ImageHeight - 70, 62,
                                 icImagingControl1.ImageHeight - 9);
            }

            /*ob.DrawLine(Color.Black, lineIndex * 2 + 10,
                                            icImagingControl1.ImageHeight - 10,
                                            lineIndex * 2 + 10,
                                            icImagingControl1.ImageHeight - 10 - lineIndex);*/

            // Print the current frame number:
            // Set the background color to the current dropout color
            // and make the font opaque.
            ob.FontBackColor = ob.DropOutColor;
            ob.FontTransparent = false;

            // Save the current font.
            Font OldFont = ob.Font;

            // Draw the text.
            ob.Font = new Font("Arial", 8);
            ob.DrawSolidRect(ob.DropOutColor, 0, 0, 1031, 774);

            if (CoordinatesystemFlag==true)
            {
                //DrawCoordinatesystem(icImagingControl1.OverlayBitmapAtPath[PathPositions.Device]);
            }

            ob.DrawText(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox1.Text);
            ob.DrawText(Color.Black, textBox2.Location.X, textBox2.Location.Y, textBox2.Text);
            ob.DrawText(Color.Black, textBox3.Location.X, textBox3.Location.Y, textBox3.Text);
            ob.DrawText(Color.Black, textBox4.Location.X, textBox4.Location.Y, textBox4.Text);
            ob.DrawText(Color.Black, textBox5.Location.X, textBox5.Location.Y, textBox5.Text);

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                ob.DrawSolidRect(ob.DropOutColor, 0, 0, 1031, 774);
                if (CoordinatesystemFlag == true)
                {
                    //DrawCoordinatesystem(icImagingControl1.OverlayBitmapAtPath[PathPositions.Device]);
                }
            }
            else
            {
                if (cycle.Checked == true)
                {
                    ob.DrawFrameEllipse(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox2.Location.X, textBox2.Location.Y);
                    ob.DrawFrameRect(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox2.Location.X, textBox2.Location.Y);
                }
                else
                {
                    ob.DrawLine(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox2.Location.X, textBox2.Location.Y);
                    if (textBox3.Text != "")
                    {
                        if (segment.Checked == true)
                        { }
                        else if (triangle.Checked == true)
                        {
                            ob.DrawLine(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox3.Location.X, textBox3.Location.Y);
                            ob.DrawLine(Color.Black, textBox2.Location.X, textBox2.Location.Y, textBox3.Location.X, textBox3.Location.Y);
                        }
                        else if (quadrilateral.Checked == true && textBox4.Text != "")
                        {
                            ob.DrawLine(Color.Black, textBox1.Location.X, textBox1.Location.Y, textBox4.Location.X, textBox4.Location.Y);
                            ob.DrawLine(Color.Black, textBox2.Location.X, textBox2.Location.Y, textBox3.Location.X, textBox3.Location.Y);
                            ob.DrawLine(Color.Black, textBox3.Location.X, textBox3.Location.Y, textBox4.Location.X, textBox4.Location.Y);
                        }
                    }
                }              
            }
              
            // Restore the previously used font.
            ob.Font = OldFont;
        }

        //Button Device click event
        private void device_Click(object sender, EventArgs e)
        {
            OpenVideoCaptureDevice();
        }

        //Open video capture device
        private void OpenVideoCaptureDevice()
        {
            if (icImagingControl1.DeviceValid)
            {
                icImagingControl1.LiveStop();
            }
            icImagingControl1.ShowDeviceSettingsDialog();
            if (icImagingControl1.DeviceValid)
            {
                icImagingControl1.SaveDeviceStateToFile("device.xml");
            }
            // Update button states
            startstop.Enabled = icImagingControl1.DeviceValid;
            properties.Enabled = icImagingControl1.DeviceValid;
        }

        //Button Properties click event
        private void properties_Click(object sender, EventArgs e)
        {
            ShowDeviceProperties();
        }

        //Show device properties 
        private void ShowDeviceProperties()
        {
            if (icImagingControl1.DeviceValid)
            {
                icImagingControl1.ShowPropertyDialog();
                if (icImagingControl1.DeviceValid)
                {
                    icImagingControl1.SaveDeviceStateToFile("device.xml");
                }

            }
        }

        //Button start or stop click event
        private void startstop_Click(object sender, EventArgs e)
        {
            //setOverlayBitmapColorModes(OverlayColorModes.Color);
            if (icImagingControl1.LiveVideoRunning)
            {
                StopLiveVideo();
            }
            else
            {
                StartLiveVideo();
            }
        }

        //Start live
        private void StartLiveVideo()
        {
            icImagingControl1.LiveStart();
            startstop.Text = "Stop Live";
        }

        //Stop live
        private void StopLiveVideo()
        {
            icImagingControl1.LiveStop();
            startstop.Text = "Start Live";
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (CoordinatesystemFlag == true)
            {
                TIS.Imaging.OverlayBitmap ob = icImagingControl1.OverlayBitmapAtPath[TIS.Imaging.PathPositions.Device];
                ob.DrawSolidRect(ob.DropOutColor, 0, 0,
                        1031, 774);
                CoordinatesystemFlag = false;
                hide.Text = "Show the scale";
            }
            else
            {
                CoordinatesystemFlag = true;
                hide.Text = "Hide the scale";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            icImagingControl1.OverlayBitmapPosition = TIS.Imaging.PathPositions.Device;
            m_sink = new FrameHandlerSink(false, new FrameType("RGB32"));
            icImagingControl1.Sink = m_sink;
            // Try to load the previously used device.
            try
            {
                icImagingControl1.LoadDeviceStateFromFile("device.xml", true);
            }
            catch { }
            // Update button states
            startstop.Enabled = icImagingControl1.DeviceValid;
            properties.Enabled = icImagingControl1.DeviceValid;
            icImagingControl1.LiveCaptureContinuous = true;
        }

        private void SetupOverlay(TIS.Imaging.OverlayBitmap ob)
        {
            // Enable the overlay bitmap for drawing.
            ob.Enable = true;

            // Set magenta as dropout color.
            ob.DropOutColor = Color.Magenta;

            // Fill the overlay bitmap with the dropout color.
            ob.Fill(ob.DropOutColor);

            // Print text in red.
            ob.FontTransparent = true;
            ob.DrawText(Color.Gray, 10, 10, "Graph Measurement");
        }

        private void DrawCoordinatesystem(TIS.Imaging.OverlayBitmap ob)
        {
            // Calculate the center of the video image.
            int Col = icImagingControl1.ImageWidth / 2;
            int Row = icImagingControl1.ImageHeight / 2;

            Font OldFont = ob.Font;
            ob.Font = new Font("Arial", 8);

            ob.DrawLine(Color.Gray, Col, 0, Col, icImagingControl1.ImageHeight);
            ob.DrawLine(Color.Gray, 0, Row, icImagingControl1.ImageWidth, Row);

            for (int i = 0; i < Row; i += 20)
            {
                ob.DrawLine(Color.Gray, Col - 5, Row - i, Col + 5, Row - i);
                ob.DrawLine(Color.Gray, Col - 5, Row + i, Col + 5, Row + i);
                if (i > 0)
                {
                    ob.DrawText(Color.Gray, Col + 10, Row - i - 7, string.Format("{0}", i / 10));
                    ob.DrawText(Color.Gray, Col + 10, Row + i - 7, string.Format("{0}", -i / 10));
                }
            }

            for (int i = 0; i < Col; i += 20)
            {
                ob.DrawLine(Color.Gray, Col - i, Row - 5, Col - i, Row + 5);
                ob.DrawLine(Color.Gray, Col + i, Row - 5, Col + i, Row + 5);
                if (i > 0)
                {
                    ob.DrawText(Color.Gray, Col + i - 5, Row - 17, string.Format("{0}", i / 10));
                    ob.DrawText(Color.Gray, Col - i - 10, Row - 17, string.Format("{0}", -i / 10));
                }
            }

            ob.Font = OldFont;
        }

        private void ShowBitmap(TIS.Imaging.OverlayBitmap ob)
        {
            try
            {
                // path to the overlay image file
                string imgPath = Environment.ExpandEnvironmentVariables("%IC34PATH%") + @"\samples\C# 2010\Creating an Overlay\Creating an Overlay\hardware.bmp";

                // Load the sample bitmap from the project file's directory.
                Image bmp = Bitmap.FromFile(imgPath);

                // Calculate the column to display the bitmap in the
                // upper right corner of Imaging Control.
                int col = icImagingControl1.ImageWidth - 5 - bmp.Width;

                // Retrieve the Graphics object of the OverlayBitmap.
                Graphics g = ob.GetGraphics();

                // Draw the image
                g.DrawImage(bmp, col, 5);

                // Release the Graphics after drawing is finished.
                ob.ReleaseGraphics(g);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("File not found: " + Ex.Message);
            }
        }

        private void EnableOverlayBitmapAtPath(PathPositions pos)
        {
            bool wasLive = icImagingControl1.LiveVideoRunning;
            if (wasLive)
                icImagingControl1.LiveStop();

            PathPositions oldPos = icImagingControl1.OverlayBitmapPosition;

            icImagingControl1.OverlayBitmapPosition = oldPos | pos;

            if (wasLive)
                icImagingControl1.LiveStart();
        }

        private void icImagingControl1_DeviceLost(object sender, ICImagingControl.DeviceLostEventArgs e)
        {
            BeginInvoke(new DeviceLostDelegate(ref DeviceLost));
        }

        private delegate void DeviceLostDelegate();

        private void DeviceLost()
        {
            icImagingControl1.Device = "";
            MessageBox.Show("Device Lost!");
            startstop.Text = "Start Live";
            startstop.Enabled = false;
            properties.Enabled = false;
        }

        private void segment_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "";
            textBox4.Visible = false;
            textBox4.Text = "";
            textBox5.Visible = false;
            textBox5.Text = "";
            if (segment.Checked)
            {
            }
        }

        private void triangle_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "";
            textBox4.Visible = false;
            textBox4.Text = "";
            textBox5.Visible = false;
            textBox5.Text = "";
            if (triangle.Checked)
            {
                //MessageBox.Show("triangle");
            }
        }

        private void quadrilateral_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "";
            textBox4.Visible = false;
            textBox4.Text = "";
            textBox5.Visible = false;
            textBox5.Text = "";
            if (quadrilateral.Checked)
            {
               // MessageBox.Show("rectangle");
            }
        }

        private void cycle_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "";
            textBox4.Visible = false;
            textBox4.Text = "";
            textBox5.Visible = false;
            textBox5.Text = "";
            if (cycle.Checked)
            {
               // MessageBox.Show("cycle");
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox1.Visible == true)
                {
                    textBox1.Visible = false;
                    textBox1.Text = "";
                    if (segment.Checked == true)
                    {
                        textBox3.Visible = false;
                        textBox3.Text = "";
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (triangle.Checked == true)
                    {
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (quadrilateral.Checked == true)
                    {
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (cycle.Checked == true)
                    {
                        textBox3.Visible = false;
                        textBox3.Text = "";
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Visible = false;
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox2.Visible == true)
                {
                    textBox2.Visible = false;
                    textBox2.Text = "";
                    if (segment.Checked == true)
                    {
                        textBox3.Visible = false;
                        textBox3.Text = "";
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (triangle.Checked == true)
                    {
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (quadrilateral.Checked == true)
                    {
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else if (cycle.Checked == true)
                    {
                        textBox3.Visible = false;
                        textBox3.Text = "";
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Visible = false;
            }
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox3.Visible == true)
                {
                    textBox3.Visible = false;
                    textBox3.Text = "";
                    if (quadrilateral.Checked == true)
                    {
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                    else
                    {
                        textBox4.Visible = false;
                        textBox4.Text = "";
                        textBox5.Visible = false;
                        textBox5.Text = "";
                    }
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Visible = false;
            }
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox4.Visible == true)
                {
                    textBox4.Visible = false;
                    textBox4.Text = "";
                    textBox5.Visible = false;
                    textBox5.Text = "";
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Visible = false;
            }
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (textBox5.Visible == true)
                {
                    textBox5.Visible = false;
                    textBox5.Text = "";
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Visible = false;
            }
        }

        private void icImagingControl1_Load(object sender, EventArgs e)
        {

        }

        private void savevideo_Click(object sender, EventArgs e)
        {
            SaveVideoForm frm = new SaveVideoForm(icImagingControl1);
            frm.ShowDialog();
        }
    }
}
