namespace QRCodeMakerC_
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            dataToQRTextBox = new TextBox();
            instructionLabel = new Label();
            generateQrButton = new Button();
            saveAsImageButton = new Button();
            qrPreviewer = new PictureBox();
            clearTextBoxButton = new Button();
            exitAppButton = new Button();
            saveAsVectorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)qrPreviewer).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(129, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(208, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome to QR Generator";
            // 
            // dataToQRTextBox
            // 
            dataToQRTextBox.BackColor = Color.FromArgb(38, 38, 38);
            dataToQRTextBox.BorderStyle = BorderStyle.None;
            dataToQRTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataToQRTextBox.ForeColor = Color.White;
            dataToQRTextBox.Location = new Point(46, 142);
            dataToQRTextBox.Name = "dataToQRTextBox";
            dataToQRTextBox.Size = new Size(373, 22);
            dataToQRTextBox.TabIndex = 1;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            instructionLabel.ForeColor = Color.White;
            instructionLabel.Location = new Point(31, 105);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(388, 21);
            instructionLabel.TabIndex = 2;
            instructionLabel.Text = "Paste the link or adress you want to convert to QR";
            // 
            // generateQrButton
            // 
            generateQrButton.FlatAppearance.BorderColor = Color.FromArgb(204, 161, 0);
            generateQrButton.FlatStyle = FlatStyle.Flat;
            generateQrButton.ForeColor = Color.White;
            generateQrButton.Location = new Point(46, 181);
            generateQrButton.Name = "generateQrButton";
            generateQrButton.Size = new Size(75, 23);
            generateQrButton.TabIndex = 3;
            generateQrButton.Text = "Generate";
            generateQrButton.UseVisualStyleBackColor = true;
            generateQrButton.Click += generateQrButton_Click;
            // 
            // saveAsImageButton
            // 
            saveAsImageButton.FlatAppearance.BorderColor = Color.FromArgb(204, 161, 0);
            saveAsImageButton.FlatStyle = FlatStyle.Flat;
            saveAsImageButton.ForeColor = Color.White;
            saveAsImageButton.Location = new Point(319, 181);
            saveAsImageButton.Name = "saveAsImageButton";
            saveAsImageButton.Size = new Size(100, 30);
            saveAsImageButton.TabIndex = 4;
            saveAsImageButton.Text = "Save as Image";
            saveAsImageButton.UseVisualStyleBackColor = true;
            saveAsImageButton.Click += saveAsImageButton_Click;
            // 
            // qrPreviewer
            // 
            qrPreviewer.Location = new Point(448, 28);
            qrPreviewer.Name = "qrPreviewer";
            qrPreviewer.Size = new Size(448, 400);
            qrPreviewer.SizeMode = PictureBoxSizeMode.Zoom;
            qrPreviewer.TabIndex = 5;
            qrPreviewer.TabStop = false;
            // 
            // clearTextBoxButton
            // 
            clearTextBoxButton.FlatAppearance.BorderColor = Color.FromArgb(204, 161, 0);
            clearTextBoxButton.FlatStyle = FlatStyle.Flat;
            clearTextBoxButton.ForeColor = Color.White;
            clearTextBoxButton.Location = new Point(186, 181);
            clearTextBoxButton.Name = "clearTextBoxButton";
            clearTextBoxButton.Size = new Size(75, 23);
            clearTextBoxButton.TabIndex = 6;
            clearTextBoxButton.Text = "Clear";
            clearTextBoxButton.UseVisualStyleBackColor = true;
            clearTextBoxButton.Click += clearTextBoxButton_Click;
            // 
            // exitAppButton
            // 
            exitAppButton.FlatAppearance.BorderColor = Color.FromArgb(204, 161, 0);
            exitAppButton.FlatStyle = FlatStyle.Flat;
            exitAppButton.ForeColor = Color.White;
            exitAppButton.Location = new Point(924, 12);
            exitAppButton.Name = "exitAppButton";
            exitAppButton.Size = new Size(23, 24);
            exitAppButton.TabIndex = 7;
            exitAppButton.Text = "X";
            exitAppButton.UseVisualStyleBackColor = true;
            exitAppButton.Click += exitAppButton_Click;
            // 
            // saveAsVectorButton
            // 
            saveAsVectorButton.FlatAppearance.BorderColor = Color.FromArgb(204, 161, 0);
            saveAsVectorButton.FlatStyle = FlatStyle.Flat;
            saveAsVectorButton.ForeColor = Color.White;
            saveAsVectorButton.Location = new Point(319, 224);
            saveAsVectorButton.Name = "saveAsVectorButton";
            saveAsVectorButton.Size = new Size(100, 30);
            saveAsVectorButton.TabIndex = 8;
            saveAsVectorButton.Text = "Save as Vector";
            saveAsVectorButton.UseVisualStyleBackColor = true;
            saveAsVectorButton.Click += saveAsVectorButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 25);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(959, 454);
            Controls.Add(saveAsVectorButton);
            Controls.Add(exitAppButton);
            Controls.Add(clearTextBoxButton);
            Controls.Add(qrPreviewer);
            Controls.Add(saveAsImageButton);
            Controls.Add(generateQrButton);
            Controls.Add(instructionLabel);
            Controls.Add(dataToQRTextBox);
            Controls.Add(titleLabel);
            ForeColor = Color.FromArgb(255, 192, 128);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "MainForm";
            Text = "QR Code Generator";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)qrPreviewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox dataToQRTextBox;
        private Label instructionLabel;
        private Button generateQrButton;
        private Button saveAsImageButton;
        private PictureBox qrPreviewer;
        private Button clearTextBoxButton;
        private Button exitAppButton;
        private Button saveAsVectorButton;
    }
}