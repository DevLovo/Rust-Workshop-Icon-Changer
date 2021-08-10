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
        string fileNameBG = "";
        List<string> updatedFolders = new List<string>();
        string[] supportedTypes = { ".png", ".jpg", ".jpeg"};

        public RWIC()
        {
            InitializeComponent();
        }

        private void preview_Click(object sender, EventArgs e)
        {
            setImageDialog(true);
        }

        private void RWIC_Load(object sender, EventArgs e)
        {
            preview.AllowDrop = true;
            preview2.AllowDrop = true;
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
            updatePreview(e, true);
        }

        private void updatePreview(DragEventArgs e, bool isBackground)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {

                    if (supportedTypes.Contains(Path.GetExtension(fileNames[0])))
                    {
                        if (isBackground)
                        {
                            preview.ImageLocation = fileNames[0];
                            fileNameBG = fileNames[0];
                            printLog("Icon_BG Image selected successfully!");
                        }
                        else
                        {
                            preview2.ImageLocation = fileNames[0];
                            fileName = fileNames[0];
                            printLog("Icon Image selected successfully!");
                        }
                        
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

        private void printLog(string text)
        {
            log.AppendText(text);
            log.AppendText(Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tempDIR = Path.GetTempPath();
            if (fileName != "" || fileNameBG != "")
            {
                if (File.Exists(fileName) || File.Exists(fileNameBG))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(tempDIR);
                    foreach(string dir in subdirectoryEntries)
                    {
                        string iconBGDIR = dir + @"\icon_background.png";
                        string iconDIR = dir + @"\icon.png";
                        if (dir.EndsWith(".tmp") & Path.GetFileName(dir).StartsWith("tmp"))
                        {
                            if (File.Exists(iconDIR))
                            {
                                if(!updatedFolders.Contains(dir))
                                {
                                    if (fileName == "")
                                    {
                                        preview2.ImageLocation = fileNameBG;

                                        fileName = fileNameBG;
                                        printLog("No Icon Image set using Icon_BG as Icon image!");
                                    }


                                    try
                                    {
                                        File.Delete(iconDIR);
                                        File.Copy(fileName, iconDIR);
                                        printLog("Icon Image changed successfully!");
                                        updatedFolders.Add(dir.ToString());
                                    }
                                    catch
                                    {
                                        printLog("Icon Image failed to change!");

                                    }
                                }

                                    

                                    

                            }

                            if (File.Exists(iconBGDIR))
                            {
                                if (!updatedFolders.Contains(dir + "BG"))
                                {
                                    if (fileNameBG == "")
                                    {
                                        preview.ImageLocation = fileName;
                                        fileNameBG = fileName;
                                        printLog("No Icon_BG Image set using Icon as Icon_BG image!");

                                    }

                                    try
                                    {
                                        File.Delete(iconBGDIR);
                                        File.Copy(fileNameBG, iconBGDIR);
                                        printLog("Icon_BG Image changed successfully!");
                                        updatedFolders.Add(dir.ToString() + "BG");
                                    }
                                    catch
                                    {
                                        printLog("Icon_BG Image failed to change!");

                                    }
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

        private void setImageDialog(bool isBackground)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" & supportedTypes.Contains(Path.GetExtension(openFileDialog1.FileName)))
            {
                if (isBackground)
                {
                    fileNameBG = openFileDialog1.FileName;
                    preview.ImageLocation = fileNameBG;
                    printLog("Icon_BG Image selected successfully!");

                }
                else
                {
                    fileName = openFileDialog1.FileName;
                    preview2.ImageLocation = fileName;
                    printLog("Icon Image selected successfully!");

                }
            }
            else
            {
                if (openFileDialog1.FileName != "")
                {
                    MessageBox.Show("File type not supported!" + Environment.NewLine + "Supported types: " + getTypes());

                }
            }
        }
        private void setImage_Click(object sender, EventArgs e)
        {
            setImageDialog(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setImageDialog(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setImageDialog(false);
        }

        private void preview2_DragDrop(object sender, DragEventArgs e)
        {
            updatePreview(e, false);

        }

        private void preview2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
