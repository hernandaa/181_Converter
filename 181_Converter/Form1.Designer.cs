namespace _181_Converter
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
            this.fileTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.beginProcessBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pdfOfd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // fileTextbox
            // 
            this.fileTextbox.BackColor = System.Drawing.Color.NavajoWhite;
            this.fileTextbox.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTextbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.fileTextbox.Location = new System.Drawing.Point(7, 41);
            this.fileTextbox.Name = "fileTextbox";
            this.fileTextbox.Size = new System.Drawing.Size(431, 32);
            this.fileTextbox.TabIndex = 0;
            this.fileTextbox.Click += new System.EventHandler(this.fileTextbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konfirmasi Perubahan Arahan Investasi (FM)";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageActive = null;
            this.searchBtn.Location = new System.Drawing.Point(444, 41);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(38, 32);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 2;
            this.searchBtn.TabStop = false;
            this.searchBtn.Zoom = 10;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(465, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // beginProcessBtn
            // 
            this.beginProcessBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.beginProcessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.beginProcessBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beginProcessBtn.BorderRadius = 0;
            this.beginProcessBtn.ButtonText = " Begin Process";
            this.beginProcessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginProcessBtn.DisabledColor = System.Drawing.Color.Gray;
            this.beginProcessBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.beginProcessBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("beginProcessBtn.Iconimage")));
            this.beginProcessBtn.Iconimage_right = null;
            this.beginProcessBtn.Iconimage_right_Selected = null;
            this.beginProcessBtn.Iconimage_Selected = null;
            this.beginProcessBtn.IconMarginLeft = 0;
            this.beginProcessBtn.IconMarginRight = 0;
            this.beginProcessBtn.IconRightVisible = true;
            this.beginProcessBtn.IconRightZoom = 0D;
            this.beginProcessBtn.IconVisible = true;
            this.beginProcessBtn.IconZoom = 70D;
            this.beginProcessBtn.IsTab = false;
            this.beginProcessBtn.Location = new System.Drawing.Point(352, 122);
            this.beginProcessBtn.Name = "beginProcessBtn";
            this.beginProcessBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.beginProcessBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(224)))));
            this.beginProcessBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.beginProcessBtn.selected = false;
            this.beginProcessBtn.Size = new System.Drawing.Size(130, 36);
            this.beginProcessBtn.TabIndex = 4;
            this.beginProcessBtn.Text = " Begin Process";
            this.beginProcessBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beginProcessBtn.Textcolor = System.Drawing.Color.White;
            this.beginProcessBtn.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginProcessBtn.Click += new System.EventHandler(this.beginProcessBtn_Click);
            // 
            // pdfOfd
            // 
            this.pdfOfd.FileName = "PDF File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(494, 170);
            this.Controls.Add(this.beginProcessBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTextbox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton searchBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton beginProcessBtn;
        private System.Windows.Forms.OpenFileDialog pdfOfd;
    }
}

