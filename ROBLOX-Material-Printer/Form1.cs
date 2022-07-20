using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ROBLOX_Material_Printer
{
    public partial class Form1 : Form
    {
        //Base image textures, stored in an array for convience
        static Bitmap[] BaseImages = { 
            Properties.Resources.wood,
            Properties.Resources.woodplanks,
            Properties.Resources.slate,
            Properties.Resources.concrete,
            Properties.Resources.metal,
            Properties.Resources.corrodedmetal,
            Properties.Resources.diamondplate,
            Properties.Resources.grass,
            Properties.Resources.brick,
            Properties.Resources.sand,
            Properties.Resources.fabric,
            Properties.Resources.granite,
            Properties.Resources.marble,
            Properties.Resources.pebble,
            Properties.Resources.cobblestone};

        //Enums of available texture types
        enum MaterialTypes
        {
            Wood,
            WoodPlanks,
            Slate,
            Concrete,
            Metal,
            CorrodedMetal,
            DiamondPlate,
            Grass,
            Brick,
            Sand,
            Fabric,
            Granite,
            Marble,
            Pebble,
            Cobblestone
        }

        //Used to define where the program's path data is stored, here its in appdata
        static string SettingsFile = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\rmod8\ROBLOX-Material-Imprinter\" + @"path.ini";

        public Form1()
        {
            InitializeComponent();
        }

        //Color Picker Button - Opens color picking dialog for user to pick color
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.Color = colorPreview.BackColor = Color.FromArgb(Convert.ToInt32(numericR.Value), Convert.ToInt32(numericG.Value), Convert.ToInt32(numericB.Value));
            cd.ShowDialog();
            cd.Dispose();
            colorPreview.BackColor = cd.Color;
            numericR.Value = Convert.ToDecimal(cd.Color.R);
            numericG.Value = Convert.ToDecimal(cd.Color.G);
            numericB.Value = Convert.ToDecimal(cd.Color.B);
        }

        //Updates color preview
        private void NumericChange(object sender, EventArgs e)
        {
            colorPreview.BackColor = Color.FromArgb(Convert.ToInt32(numericR.Value), Convert.ToInt32(numericG.Value), Convert.ToInt32(numericB.Value));
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Load export path into the export path text box
            if (!File.Exists(@SettingsFile))
            {
                Directory.CreateDirectory(@Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\rmod8\ROBLOX-Material-Imprinter\");
                File.Create(@SettingsFile).Close();
                File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\rmod8\ROBLOX-Material-Imprinter\info.txt", Properties.Resources.info);
            }
            string FolderPath = @File.ReadAllText(@SettingsFile);
            if (Directory.Exists(@FolderPath))
            {
                textBoxBrowse.Text = FolderPath;
            }
            //Default combo box to first option
            comboTextureType.SelectedIndex = 0;
        }

        //This generates the image and sets the preview image to the results.
        private void UpdateImage(object send, EventArgs e)
        {
            progressBar.Value = 0;

            //Prevent the user from modifying stuff as we're accessing it
            this.Enabled = false;

            //Base value, used as a fallback
            byte ImageTweak = 126;

            //This might not be neccesary, but this allows for minor adjustments
            //for each image, as some are darker or lighter.
            switch ((MaterialTypes)comboTextureType.SelectedIndex)
            {
                case MaterialTypes.Wood:
                    ImageTweak = 244;
                    break;
                case MaterialTypes.WoodPlanks:
                    ImageTweak = 247;
                    break;
                case MaterialTypes.Slate:
                    ImageTweak = 217;
                    break;
                case MaterialTypes.Concrete:
                    ImageTweak = 203;
                    break;
                case MaterialTypes.Metal:
                    ImageTweak = 195;
                    break;
                case MaterialTypes.CorrodedMetal:
                    ImageTweak = 148;
                    break;
                case MaterialTypes.DiamondPlate:
                    ImageTweak = 230;
                    break;
                case MaterialTypes.Grass:
                    ImageTweak = 198;
                    break;
                case MaterialTypes.Brick:
                    ImageTweak = 222;
                    break;
                case MaterialTypes.Sand:
                    ImageTweak = 238;
                    break;
                case MaterialTypes.Fabric:
                    ImageTweak = 132;
                    break;
                case MaterialTypes.Granite:
                    ImageTweak = 255;
                    break;
                case MaterialTypes.Marble:
                    ImageTweak = 197;
                    break;
                case MaterialTypes.Pebble:
                    ImageTweak = 239;
                    break;
                case MaterialTypes.Cobblestone:
                    ImageTweak = 238;
                    break;
            }

            //The template image we need, selected using the combo box
            Bitmap TemplateImage = BaseImages[comboTextureType.SelectedIndex];

            //Output image, blank at the moment
            Bitmap ExitImage = new Bitmap(1024, 1024);
            int NumberOfPixels = 1024 * 1024;
            int DeltaX = 0;
            int DeltaY = 0;
            byte localR;
            byte localG;
            byte localB;
            for (int i = 0; i < NumberOfPixels; i++)
            {
                //This is really expensive, other methods don't work for me because i'm stupid so
                //this is the best i can do at the moment.
                if (i == 262144)
                    progressBar.Value = 25;
                else if(i == 524288)
                    progressBar.Value = 50;
                else if (i == 786432)
                    progressBar.Value = 75;


                localR = colorPreview.BackColor.R;
                localG = colorPreview.BackColor.G;
                localB = colorPreview.BackColor.B;
                if (DeltaX == 1024)
                {
                    DeltaX = 0;
                    DeltaY++;
                }
                Color ImprintPixel = TemplateImage.GetPixel(DeltaX, DeltaY);

                if (ImprintPixel.R > ImageTweak)
                {
                    byte offset = Convert.ToByte(ImprintPixel.R - ImageTweak);
                    try
                    {
                        offset = Convert.ToByte(offset * Convert.ToSingle(textIntense.Text));
                    }
                    catch
                    {
                        offset = 255;
                    }
                    if ((localR + offset) > 255)
                        localR = 255;
                    else
                        localR += offset;
                    if ((localG + offset) > 255)
                        localG = 255;
                    else
                        localG += offset;
                    if ((localB + offset) > 255)
                        localB = 255;
                    else
                        localB += offset;

                }
                if (ImprintPixel.R < ImageTweak)
                {
                    byte offset = Convert.ToByte(ImageTweak - ImprintPixel.R);
                    try
                    {
                        offset = Convert.ToByte(offset * Convert.ToSingle(textIntense.Text));
                    }
                    catch
                    {
                        offset = 255;
                    }
                    if ((localR - offset) < 0)
                        localR = 0;
                    else
                        localR -= offset;
                    if ((localG - offset) < 0)
                        localG = 0;
                    else
                        localG -= offset;
                    if ((localB - offset) < 0)
                        localB = 0;
                    else
                        localB -= offset;
                }
                ExitImage.SetPixel(DeltaX, DeltaY, Color.FromArgb(255, localR, localG, localB));
                

                DeltaX++;
            }


            //This allows for other images to be overlayed on top, useful for the brick and cmetal materials
            Graphics Overlay = Graphics.FromImage(ExitImage);
            switch ((MaterialTypes)comboTextureType.SelectedIndex)
            {
                case MaterialTypes.CorrodedMetal:
                    Overlay.DrawImage(Properties.Resources.corrodedmetal_overlay, 0, 0, 1024, 1024);
                    break;
                case MaterialTypes.Brick:
                    Overlay.DrawImage(Properties.Resources.brick_overlay, 0, 0, 1024, 1024);
                    break;
            }

            //We don't need it anymore
            Overlay.Dispose();

            //This is something i only just learned i needed to do, which is why TextureUnstitcher takes up so much memory.
            picturePreview.Image.Dispose();
            //Set preview image to the newly generated imag.
            picturePreview.Image = ExitImage;
            progressBar.Value = 100;
            this.Enabled = true;
        }

        private void textIntense_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToSingle(textIntense.Text) > 1)
                    throw new Exception();
                button2.Enabled = true;
                buttonExport.Enabled = true;
            }
            catch
            {
                button2.Enabled = false;
                buttonExport.Enabled = false;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.FileName = "[FOLDER SELECTION]";
            ofd.CheckFileExists = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxBrowse.Text = ofd.FileName.Substring(0, ofd.FileName.Length - ofd.SafeFileName.Length);
                    File.WriteAllText(@SettingsFile, textBoxBrowse.Text);
                }
                catch
                {
                    textBoxBrowse.Text += " [Failed to save]";
                }
            }
            ofd.Dispose();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (!Directory.Exists(textBoxBrowse.Text))
            {
                MessageBox.Show("Please selected a valid folder!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateImage(null, null);
                string SavedFileName = "";
                switch ((MaterialTypes)comboTextureType.SelectedIndex)
                {
                    case MaterialTypes.Wood:
                        SavedFileName = "wood";
                        break;
                    case MaterialTypes.WoodPlanks:
                        SavedFileName = "woodplanks";
                        break;
                    case MaterialTypes.Slate:
                        SavedFileName = "slate";
                        break;
                    case MaterialTypes.Concrete:
                        SavedFileName = "concrete";
                        break;
                    case MaterialTypes.Metal:
                        SavedFileName = "metal";
                        break;
                    case MaterialTypes.CorrodedMetal:
                        SavedFileName = "corrodedmetal";
                        break;
                    case MaterialTypes.DiamondPlate:
                        SavedFileName = "diamondplate";
                        break;
                    case MaterialTypes.Grass:
                        SavedFileName = "grass";
                        break;
                    case MaterialTypes.Brick:
                        SavedFileName = "brick";
                        break;
                    case MaterialTypes.Sand:
                        SavedFileName = "sand";
                        break;
                    case MaterialTypes.Fabric:
                        SavedFileName = "fabric";
                        break;
                    case MaterialTypes.Granite:
                        SavedFileName = "granite";
                        break;
                    case MaterialTypes.Marble:
                        SavedFileName = "marble";
                        break;
                    case MaterialTypes.Pebble:
                        SavedFileName = "pebble";
                        break;
                    case MaterialTypes.Cobblestone:
                        SavedFileName = "cobblestone";
                        break;
                }
                SavedFileName += "_"+numericR.Value+"_"+numericG.Value+"_"+numericB.Value+".png";
                picturePreview.Image.Save(textBoxBrowse.Text + SavedFileName);
            }
            this.Enabled = true;
        }
    }
}
