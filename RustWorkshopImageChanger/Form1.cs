using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustWorkshopImageChanger
{
    public partial class RWIC : Form
    {
        string fileName = "";
        List<string> updatedFolders = new List<string>();
        string[] supportedTypes = { ".png", ".jpg", ".jpeg"};

        public RWIC()
        {
            InitializeComponent();
        }

        private void preview_Click(object sender, EventArgs e)
        {

        }

        private void RWIC_Load(object sender, EventArgs e)
        {
            preview.AllowDrop = true;
            printLog("Waiting for an image to be set!");

            string filter = "Image";
            foreach (string type in supportedTypes)
            {
                filter += "|*" + type;
            }
            openFileDialog1.Filter = filter;
        }

        private void preview_DragDrop(object sender, DragEventArgs e)
        {
            updatePreview(e);
        }

        private void updatePreview(DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {

                    if (supportedTypes.Contains(Path.GetExtension(fileNames[0])))
                    {
                        preview.ImageLocation = fileNames[0];
                        fileName = fileNames[0];
                        printLog("Image selected successfully!");
                    }
                    else
                    {
                        MessageBox.Show("File type not supported!" + Environment.NewLine + "Supported types: " + getTypes());

                    }
                }
            }
        }

        private void preview_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void RWIC_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void RWIC_DragDrop(object sender, DragEventArgs e)
        {
            updatePreview(e);
        }

        private void printLog(string text)
        {
            log.AppendText(text);
            log.AppendText(Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tempDIR = Path.GetTempPath();
            if (fileName != "")
            {
                if (File.Exists(fileName))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(tempDIR);
                    foreach(string dir in subdirectoryEntries)
                    {
                        string iconDIR = dir + @"\icon_background.png";
                        if (!updatedFolders.Contains(dir))
                        {
                            if (dir.EndsWith(".tmp") & Path.GetFileName(dir).StartsWith("tmp"))
                            {
                                if (File.Exists(iconDIR))
                                {
                                    try
                                    {
                                        File.Delete(iconDIR);
                                        File.Copy(fileName, iconDIR);
                                        printLog("Image changed successfully!");
                                        updatedFolders.Add(dir.ToString());
                                    }
                                    catch
                                    {
                                        printLog("Image failed to change!");

                                    }

                                    break;

                                }

                            }
                        }
                            
                    }
                }
            }
        }

        private string getTypes()
        {
            string String = "";
            foreach(string type in supportedTypes)
            {
                String += type + " ";
            }
            return (String.Remove(String.Length - 1));
        }
        private void setImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName != "" & supportedTypes.Contains(Path.GetExtension(openFileDialog1.FileName)))
            {
                fileName = openFileDialog1.FileName;
                preview.ImageLocation = fileName;
                printLog("Image selected successfully!");
            }
            else
            {
                if(openFileDialog1.FileName != "")
                {
                    MessageBox.Show("File type not supported!" + Environment.NewLine + "Supported types: " + getTypes());

                }
            }
        }
    }
}
