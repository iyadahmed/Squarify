namespace Squarify
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.originalPictureLabel = new System.Windows.Forms.Label();
            this.resultPictureLabel = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.openImageButton = new System.Windows.Forms.Button();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveResultDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.originalPictureLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultPictureLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultPictureBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openImageButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveResultButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // originalPictureLabel
            // 
            this.originalPictureLabel.AutoSize = true;
            this.originalPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPictureLabel.Location = new System.Drawing.Point(3, 0);
            this.originalPictureLabel.Name = "originalPictureLabel";
            this.originalPictureLabel.Size = new System.Drawing.Size(447, 67);
            this.originalPictureLabel.TabIndex = 4;
            this.originalPictureLabel.Text = "Original";
            this.originalPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultPictureLabel
            // 
            this.resultPictureLabel.AutoSize = true;
            this.resultPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultPictureLabel.Location = new System.Drawing.Point(456, 0);
            this.resultPictureLabel.Name = "resultPictureLabel";
            this.resultPictureLabel.Size = new System.Drawing.Size(448, 67);
            this.resultPictureLabel.TabIndex = 5;
            this.resultPictureLabel.Text = "Result";
            this.resultPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPictureBox.Location = new System.Drawing.Point(456, 70);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(448, 533);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultPictureBox.TabIndex = 1;
            this.resultPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPictureBox.Location = new System.Drawing.Point(3, 70);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(447, 533);
            this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 0;
            this.originalPictureBox.TabStop = false;
            // 
            // openImageButton
            // 
            this.openImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openImageButton.Location = new System.Drawing.Point(3, 609);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(447, 62);
            this.openImageButton.TabIndex = 2;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // saveResultButton
            // 
            this.saveResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveResultButton.Enabled = false;
            this.saveResultButton.Location = new System.Drawing.Point(456, 609);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(448, 62);
            this.saveResultButton.TabIndex = 3;
            this.saveResultButton.Text = "Save Result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            this.openImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png";
            this.openImageDialog.Title = "Open Image";
            // 
            // saveResultDialog
            // 
            this.saveResultDialog.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Squarify";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label resultPictureLabel;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Label originalPictureLabel;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveResultDialog;
    }
}

