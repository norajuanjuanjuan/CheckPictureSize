using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace _400_366_size
{
    public partial class Form1 : Form
    {
        string path = "";// @"\\10.127.0.20\Work\99_Nav2\20161221_16Q4_201720\1_Data\Raw\Auxiliary\400x366";//@"\\Filesvrbj1\gis_data\Argo\Shipping China\400x366";
        int Height;
        int Width;
        List<string> dirs = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        public static BitmapFrame GetBitmap(string _path)
        {
            var decoder = BitmapDecoder.Create(new Uri(_path), BitmapCreateOptions.DelayCreation, BitmapCacheOption.None);
            BitmapFrame frame = decoder.Frames.FirstOrDefault();
            return frame;
        }
        public static void CreateTxtFile(string path)
        {
            if (!System.IO.File.Exists(path))
                System.IO.File.Create(path).Close();
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                System.IO.File.Create(path).Close();
            }
        }
        public static void Append(StreamWriter sw, string content)
        {
            sw.WriteLine(content);
            sw.Flush();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (fbd.SelectedPath != "")
                    txt_Folder.Text = fbd.SelectedPath;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            path = txt_Folder.Text.Trim();
            if (txt_Height.Text.Trim() == "" || txt_Width.Text.Trim() == "")
            {
                MessageBox.Show("请确认Height和Width值！");
                return;
            }
            else
            {
                Height = Convert.ToInt32(txt_Height.Text.Trim());
                Width = Convert.ToInt32(txt_Width.Text.Trim());
            }
          
            if (path != "")
            {
                if (Height == 0 || Width == 0)  return;
                else
                {
                    string log = "D:\\"+Width+"_"+Height+"_log.txt";
                    if ((Directory.GetDirectories(path)).Length != 0)
                    {
                        GetAllDirectoris(path);
                    }
                    if (dirs.Count == 0) dirs.Add(path);
                    CreateTxtFile(log);
                    System.IO.StreamWriter sw = new StreamWriter(log, true, Encoding.ASCII);
                    int n = 0;
                    foreach (string dir in dirs)
                    {
                        string[] files = Directory.GetFiles(dir);
                        foreach (string fi in files)
                        {
                            if (fi.Contains(".png") || fi.Contains(".JPG") || fi.Contains(".jpg"))
                            {
                                if (n % 100 == 0) { richTextBox1.Text = ""; }
                                richTextBox1.AppendText(n.ToString() + ": " + fi + "\r\n");
                                ++n;
                                BitmapFrame frm = GetBitmap(fi);
                                if (frm.PixelHeight != Height && frm.PixelWidth != Width)
                                {
                                    Append(sw, fi);
                                }
                            }
                        }
                    }
                    sw.Close();
                }
            }
            else MessageBox.Show("文件夹不能为空！");
        }

        private void GetAllDirectoris(string pathFolder)
        {
            if (Directory.GetDirectories(pathFolder).Length > 0)
            {
                foreach (string folder in Directory.GetDirectories(pathFolder))
                {
                    dirs.Add(folder);
                    GetAllDirectoris(folder);
                }
            }
        }

       
    }

}