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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            originalPictureLabel = new System.Windows.Forms.Label();
            resultPictureLabel = new System.Windows.Forms.Label();
            resultPictureBox = new System.Windows.Forms.PictureBox();
            originalPictureBox = new System.Windows.Forms.PictureBox();
            openImageButton = new System.Windows.Forms.Button();
            saveResultButton = new System.Windows.Forms.Button();
            openImageDialog = new System.Windows.Forms.OpenFileDialog();
            saveResultDialog = new System.Windows.Forms.SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(originalPictureLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(resultPictureLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(resultPictureBox, 1, 1);
            tableLayoutPanel1.Controls.Add(originalPictureBox, 0, 1);
            tableLayoutPanel1.Controls.Add(openImageButton, 0, 2);
            tableLayoutPanel1.Controls.Add(saveResultButton, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1209, 1037);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // originalPictureLabel
            // 
            originalPictureLabel.AutoSize = true;
            originalPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            originalPictureLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            originalPictureLabel.Location = new System.Drawing.Point(5, 0);
            originalPictureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            originalPictureLabel.Name = "originalPictureLabel";
            originalPictureLabel.Size = new System.Drawing.Size(594, 103);
            originalPictureLabel.TabIndex = 4;
            originalPictureLabel.Text = "Original";
            originalPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultPictureLabel
            // 
            resultPictureLabel.AutoSize = true;
            resultPictureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            resultPictureLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            resultPictureLabel.Location = new System.Drawing.Point(609, 0);
            resultPictureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            resultPictureLabel.Name = "resultPictureLabel";
            resultPictureLabel.Size = new System.Drawing.Size(595, 103);
            resultPictureLabel.TabIndex = 5;
            resultPictureLabel.Text = "Result";
            resultPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultPictureBox
            // 
            resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resultPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            resultPictureBox.Location = new System.Drawing.Point(609, 107);
            resultPictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            resultPictureBox.Name = "resultPictureBox";
            resultPictureBox.Size = new System.Drawing.Size(595, 821);
            resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            resultPictureBox.TabIndex = 1;
            resultPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            originalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            originalPictureBox.Location = new System.Drawing.Point(5, 107);
            originalPictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new System.Drawing.Size(594, 821);
            originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            originalPictureBox.TabIndex = 0;
            originalPictureBox.TabStop = false;
            // 
            // openImageButton
            // 
            openImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            openImageButton.Location = new System.Drawing.Point(5, 936);
            openImageButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            openImageButton.Name = "openImageButton";
            openImageButton.Size = new System.Drawing.Size(594, 97);
            openImageButton.TabIndex = 2;
            openImageButton.Text = "Open Image";
            openImageButton.UseVisualStyleBackColor = true;
            openImageButton.Click += openImageButton_Click;
            // 
            // saveResultButton
            // 
            saveResultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            saveResultButton.Enabled = false;
            saveResultButton.Location = new System.Drawing.Point(609, 936);
            saveResultButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            saveResultButton.Name = "saveResultButton";
            saveResultButton.Size = new System.Drawing.Size(595, 97);
            saveResultButton.TabIndex = 3;
            saveResultButton.Text = "Save Result";
            saveResultButton.UseVisualStyleBackColor = true;
            saveResultButton.Click += saveResultButton_Click;
            // 
            // openImageDialog
            // 
            openImageDialog.FileName = "openFileDialog1";
            openImageDialog.Filter = "Image Files|*.jpg;*.jpeg;*.bmp;*.png";
            openImageDialog.Title = "Open Image";
            // 
            // saveResultDialog
            // 
            saveResultDialog.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1209, 1037);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Squarify";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ResumeLayout(false);
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

