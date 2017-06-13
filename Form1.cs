using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MappingStageOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            double latitude, longitude;

            errProvider.Clear();

            if ((txtName.Text == "") || (!Draw.IsUnique(txtName.Text)))
                errProvider.SetError(txtName, "You must provide a unique name.");
            else if (!double.TryParse(txtLat.Text, out latitude))
                errProvider.SetError(txtLat, "You must provide a latitude.");
            else if (!double.TryParse(txtLong.Text, out longitude))
                errProvider.SetError(txtLong, "You must provide a longitude.");
            else
            {
                if (Draw.drawMode == Draw.DrawingMode.point)
                {
                    Draw.pointList.Add(new MapPoints(txtName.Text, latitude, longitude));
                    updatePointListView();
                }
                else if (Draw.drawMode == Draw.DrawingMode.line)
                {
                    double endLat, endLong;
                    if (lstMidPoints.Items.Count < 1)
                        errProvider.SetError(lstMidPoints, "You must provide at least one midpoint.");
                    else if (!double.TryParse(txtEndLat.Text, out endLat))
                        errProvider.SetError(txtEndLat, "You must provide an end-point latitude.");
                    else if (!double.TryParse(txtEndLong.Text, out endLong))
                        errProvider.SetError(txtEndLat, "You must provide an end-point longitude.");
                    else
                    {
                        List<MapPoints> linePoints = new List<MapPoints>();
                        linePoints.Add(new MapPoints(txtName.Text, latitude, longitude));
                        foreach (string item in lstMidPoints.Items)
                        {
                            string[] location = item.Split(new string[] { ", " }, StringSplitOptions.None);
                            linePoints.Add(new MapPoints(txtName.Text, double.Parse(location[0]), double.Parse(location[1])));
                        }
                        linePoints.Add(new MapPoints(txtName.Text, endLat, endLong));

                        Draw.lineList.Add(new MapLines(linePoints));
                        updateLineListView();
                    }
                }
                else if (Draw.drawMode == Draw.DrawingMode.circle)
                {
                    ushort radius;
                    if (!ushort.TryParse(txtRadius.Text, out radius))
                        errProvider.SetError(txtRadius, "You must provide a radius greater than 0 but less than 65536.");
                    else
                    {
                        Draw.circleList.Add(new MapCircles(txtName.Text, latitude, longitude, radius));
                        updateCircleListView();
                    }
                }
            }
        }

        private void changeDrawingMode(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(CheckBox))
            {
                CheckBox chkSender = (CheckBox)sender;

                Draw.changeDrawingModes(chkSender, e);
                //Uncheck all checkboxes except the one that was clicked
                foreach (CheckBox chkBox in Controls.OfType<CheckBox>())
                    if (chkBox != chkSender)
                        chkBox.Checked = false;

                if (Draw.drawMode != Draw.DrawingMode.none)
                {
                    grpSpecialLines.Visible = false;
                    grpSpecialCircles.Visible = false;

                    btnCreate.Enabled = true;
                    lblName.Enabled = true;
                    lblLat.Enabled = true;
                    lblLong.Enabled = true;
                    txtName.Enabled = true;
                    txtLat.Enabled = true;
                    txtLong.Enabled = true;
                    grpStart.Enabled = true;

                    if (Draw.drawMode == Draw.DrawingMode.line)
                    {
                        grpSpecialLines.Visible = true;
                    }
                    else if (Draw.drawMode == Draw.DrawingMode.circle)
                    {
                        grpSpecialCircles.Visible = true;
                    }
                }
                else
                {
                    btnCreate.Enabled = false;
                    lblName.Enabled = false;
                    lblLat.Enabled = false;
                    lblLong.Enabled = false;
                    txtName.Enabled = false;
                    txtLat.Enabled = false;
                    txtLong.Enabled = false;
                    grpStart.Enabled = false;
                    grpSpecialLines.Visible = false;
                    grpSpecialCircles.Visible = false;
                }
            }
        }

        private void updatePointListView()
        {
            lsvPoints.Items.Clear();

            foreach (MapPoints point in Draw.pointList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = point.Name;
                item.Name = "Name";
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, "Location");
                subItem.Name = "Location";
                subItem.Text = point.Latitude.ToString() + ", " + point.Longitude.ToString();
                item.SubItems.Add(subItem);
                lsvPoints.Items.Add(item);
            }
        }

        private void updateLineListView()
        {
            lsvLines.Items.Clear();
            foreach (MapLines line in Draw.lineList)
            {
                ListViewItem item = new ListViewItem();
                ListViewItem.ListViewSubItem midItem = new ListViewItem.ListViewSubItem(item, "");
                ListViewItem.ListViewSubItem endItem = new ListViewItem.ListViewSubItem(item, "End");
                foreach (MapPoints point in line.GetPointList())
                {
                    if (point == line.GetPointList().First())
                    {
                        item.Text = point.Name;
                        item.Name = "Name";

                        ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, "Begin");
                        subItem.Name = "Begin";
                        subItem.Text = point.Latitude.ToString() + ", " + point.Longitude.ToString();
                        item.SubItems.Add(subItem);
                    }
                    else if (point != line.GetPointList().Last())
                    {
                        midItem.Name = "Mid-points";
                        midItem.Text += point.Latitude.ToString() + ", " + point.Longitude.ToString()
                            + (point != line.GetPointList()[line.GetPointList().Count()-2] ? "; " : "");
                    }
                    else
                    {
                        endItem.Name = "End";
                        endItem.Text = point.Latitude.ToString() + ", " + point.Longitude.ToString();
                    }
                }
                item.SubItems.Add(midItem);
                item.SubItems.Add(endItem);
                lsvLines.Items.Add(item);
            }
        }

        private void updateCircleListView()
        {
            lsvCircles.Items.Clear();

            foreach (MapCircles circle in Draw.circleList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = circle.Name;
                item.Name = "Name";
                ListViewItem.ListViewSubItem circleLocation = new ListViewItem.ListViewSubItem(item, "Location");
                circleLocation.Name = "Location";
                circleLocation.Text = circle.Latitude.ToString() + ", " + circle.Longitude.ToString();
                item.SubItems.Add(circleLocation);
                ListViewItem.ListViewSubItem circleRadius = new ListViewItem.ListViewSubItem(item, "Radius");
                circleRadius.Name = "Radius";
                circleRadius.Text = circle.Radius.ToString();
                item.SubItems.Add(circleRadius);
                lsvCircles.Items.Add(item);
            }
        }

        private void btnAddMidpoint_Click(object sender, EventArgs e)
        {
            double midLat, midLong;
            if (!double.TryParse(txtMidLat.Text, out midLat))
                errProvider.SetError(txtEndLat, "You must provide a mid-point latitude.");
            else if (!double.TryParse(txtMidLong.Text, out midLong))
                errProvider.SetError(txtEndLat, "You must provide a mid-point longitude.");
            else
                lstMidPoints.Items.Add(txtMidLat.Text + ", " + txtMidLong.Text);
        }

        private void btnRemoveMidpoint_Click(object sender, EventArgs e)
        {
            if (lstMidPoints.SelectedIndex != -1)
                lstMidPoints.Items.Remove(lstMidPoints.SelectedItem);
        }

        private void lsvPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPoints.SelectedItems.Count > 0)
                btnDeletePoint.Enabled = true;
            else
                btnDeletePoint.Enabled = false;
        }

        private void btnDeletePoint_Click(object sender, EventArgs e)
        {
            if (lsvPoints.SelectedItems.Count == 1)
            {
                Draw.pointList.Remove(Draw.pointList.First(x => x.Name == lsvPoints.SelectedItems[0].Text));
                lsvPoints.SelectedItems.Clear();
                updatePointListView();
            }
        }

        private void lsvCircles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCircles.SelectedItems.Count > 0)
                btnDeleteCircle.Enabled = true;
            else
                btnDeleteCircle.Enabled = false;
        }

        private void btnDeleteCircle_Click(object sender, EventArgs e)
        {
            if (lsvCircles.SelectedItems.Count == 1)
            {
                Draw.circleList.Remove(Draw.circleList.First(x => x.Name == lsvCircles.SelectedItems[0].Text));
                lsvCircles.SelectedItems.Clear();
                updateCircleListView();
            }
        }

        private void lsvLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLines.SelectedItems.Count > 0)
                btnDeleteLine.Enabled = true;
            else
                btnDeleteLine.Enabled = false;
        }

        private void btnDeleteLines_Click(object sender, EventArgs e)
        {
            if (lsvLines.SelectedItems.Count == 1)
            {
                Draw.lineList.Remove(Draw.lineList.First(x => x.GetPointList()[0].Name == lsvLines.SelectedItems[0].Text));
                lsvLines.SelectedItems.Clear();
                updateLineListView();
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            if (saveXmlFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlSerializer.ExportXML(saveXmlFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem exporting the mission file. Any exported file may be incomplete.\n\n" +
                        "Debug:\n" + ex.Message, "Error Exporting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            if (openXmlFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if (XmlSerializer.ImportXML(openXmlFile.FileName))
                    {
                        updatePointListView();
                        updateLineListView();
                        updateCircleListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem reading the selected mission, it may be corrupted. Any mission data you see may be incomplete.\n\n" +
                        "Debug:\n" + ex.Message, "Error Importing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
