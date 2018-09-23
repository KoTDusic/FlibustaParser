namespace FlibustaParser
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.load_picturebox = new System.Windows.Forms.PictureBox();
            this.book_name_field = new System.Windows.Forms.RichTextBox();
            this.download_button = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.annotation_text = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer1_Panel1_Scroll);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.load_picturebox);
            this.splitContainer1.Panel2.Controls.Add(this.book_name_field);
            this.splitContainer1.Panel2.Controls.Add(this.download_button);
            this.splitContainer1.Panel2.Controls.Add(this.picture_box);
            this.splitContainer1.Panel2.Controls.Add(this.annotation_text);
            this.splitContainer1.Size = new System.Drawing.Size(944, 530);
            this.splitContainer1.SplitterDistance = 529;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 505);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(411, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // load_picturebox
            // 
            this.load_picturebox.Location = new System.Drawing.Point(108, -29);
            this.load_picturebox.Name = "load_picturebox";
            this.load_picturebox.Size = new System.Drawing.Size(300, 300);
            this.load_picturebox.TabIndex = 0;
            this.load_picturebox.TabStop = false;
            // 
            // book_name_field
            // 
            this.book_name_field.Location = new System.Drawing.Point(12, 12);
            this.book_name_field.Name = "book_name_field";
            this.book_name_field.ReadOnly = true;
            this.book_name_field.Size = new System.Drawing.Size(243, 64);
            this.book_name_field.TabIndex = 3;
            this.book_name_field.Text = "";
            // 
            // download_button
            // 
            this.download_button.Enabled = false;
            this.download_button.Location = new System.Drawing.Point(261, 222);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(138, 23);
            this.download_button.TabIndex = 2;
            this.download_button.Text = "Скачать";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.DownloadButtonClick);
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(261, 12);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(140, 200);
            this.picture_box.TabIndex = 1;
            this.picture_box.TabStop = false;
            // 
            // annotation_text
            // 
            this.annotation_text.Location = new System.Drawing.Point(12, 82);
            this.annotation_text.Name = "annotation_text";
            this.annotation_text.ReadOnly = true;
            this.annotation_text.Size = new System.Drawing.Size(243, 387);
            this.annotation_text.TabIndex = 0;
            this.annotation_text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Flibusta Downloader";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.RichTextBox annotation_text;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.RichTextBox book_name_field;
        private System.Windows.Forms.PictureBox load_picturebox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;



    }
}

