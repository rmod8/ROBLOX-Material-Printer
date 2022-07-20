namespace ROBLOX_Material_Printer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericR = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericG = new System.Windows.Forms.NumericUpDown();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTextureType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textIntense = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBrowse = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.colorPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // numericR
            // 
            this.numericR.Location = new System.Drawing.Point(35, 91);
            this.numericR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericR.Name = "numericR";
            this.numericR.Size = new System.Drawing.Size(63, 20);
            this.numericR.TabIndex = 4;
            this.numericR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericR.ValueChanged += new System.EventHandler(this.NumericChange);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Color Picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red:";
            // 
            // numericG
            // 
            this.numericG.Location = new System.Drawing.Point(104, 91);
            this.numericG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericG.Name = "numericG";
            this.numericG.Size = new System.Drawing.Size(63, 20);
            this.numericG.TabIndex = 5;
            this.numericG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericG.ValueChanged += new System.EventHandler(this.NumericChange);
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(173, 91);
            this.numericB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(63, 20);
            this.numericB.TabIndex = 6;
            this.numericB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericB.ValueChanged += new System.EventHandler(this.NumericChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blue:";
            // 
            // comboTextureType
            // 
            this.comboTextureType.FormattingEnabled = true;
            this.comboTextureType.Items.AddRange(new object[] {
            "Wood",
            "Wood Planks",
            "Slate",
            "Concrete",
            "Metal",
            "Corroded Metal",
            "Diamond Plate",
            "Grass",
            "Brick",
            "Sand",
            "Fabric",
            "Granite",
            "Marble",
            "Pebble",
            "Cobblestone"});
            this.comboTextureType.Location = new System.Drawing.Point(35, 172);
            this.comboTextureType.Name = "comboTextureType";
            this.comboTextureType.Size = new System.Drawing.Size(201, 21);
            this.comboTextureType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Image Type:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update Preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateImage);
            // 
            // textIntense
            // 
            this.textIntense.Location = new System.Drawing.Point(97, 227);
            this.textIntense.Name = "textIntense";
            this.textIntense.Size = new System.Drawing.Size(70, 20);
            this.textIntense.TabIndex = 13;
            this.textIntense.Text = "1.0";
            this.textIntense.TextChanged += new System.EventHandler(this.textIntense_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(19, 295);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(237, 23);
            this.progressBar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Intensity: (e.g 0.55)";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(19, 22);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 16;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Controls.Add(this.textBoxBrowse);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Location = new System.Drawing.Point(22, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 109);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturePreview);
            this.groupBox2.Controls.Add(this.numericR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.colorPreview);
            this.groupBox2.Controls.Add(this.textIntense);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.numericG);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericB);
            this.groupBox2.Controls.Add(this.comboTextureType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 329);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup:";
            // 
            // textBoxBrowse
            // 
            this.textBoxBrowse.BackColor = System.Drawing.Color.White;
            this.textBoxBrowse.Location = new System.Drawing.Point(104, 22);
            this.textBoxBrowse.Name = "textBoxBrowse";
            this.textBoxBrowse.ReadOnly = true;
            this.textBoxBrowse.Size = new System.Drawing.Size(460, 20);
            this.textBoxBrowse.TabIndex = 17;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(19, 63);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(545, 40);
            this.buttonExport.TabIndex = 18;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // picturePreview
            // 
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePreview.Image = global::ROBLOX_Material_Printer.Properties.Resources.wood;
            this.picturePreview.Location = new System.Drawing.Point(272, 16);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(300, 300);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePreview.TabIndex = 0;
            this.picturePreview.TabStop = false;
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.Color.White;
            this.colorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreview.Location = new System.Drawing.Point(133, 32);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(123, 26);
            this.colorPreview.TabIndex = 3;
            this.colorPreview.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROBLOX Material Printer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.NumericUpDown numericR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox colorPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericG;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTextureType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textIntense;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxBrowse;
        private System.Windows.Forms.Button buttonExport;
    }
}

