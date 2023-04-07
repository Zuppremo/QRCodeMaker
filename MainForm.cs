using QRCoder;
using System.Reflection.Emit;

namespace QRCodeMakerC_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateQrButton_Click(object sender, EventArgs e)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(dataToQRTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qRCode.GetGraphic(20);
            qrPreviewer.Image = qrCodeImage;
        }

        private void clearTextBoxButton_Click(object sender, EventArgs e)
        {
            qrPreviewer.Image = null;
            dataToQRTextBox.Text = string.Empty;
        }

        private void saveAsImageButton_Click(object sender, EventArgs e)
        {
            if (qrPreviewer.Image != null)
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Directory.CreateDirectory(Path.Combine(path, "MyDirectory"));
                var finalPath = Path.Combine(path, "MyDirectory");
                qrPreviewer.Image.Save(Path.Combine(finalPath, $"{dataToQRTextBox.Text} QR Code.png"));
            }
        }

        private void saveAsVectorButton_Click(object sender, EventArgs e)
        {
            using var qrGenerator = new QRCodeGenerator();
            using var qrCodeData = qrGenerator.CreateQrCode(dataToQRTextBox.Text, QRCodeGenerator.ECCLevel.Q);
            SvgQRCode qrCodeVector = new SvgQRCode(qrCodeData);
            string svgQrCodeAsSvg = qrCodeVector.GetGraphic(20); 

            if (qrPreviewer.Image != null)
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Directory.CreateDirectory(Path.Combine(path, "MyDirectory"));
                var finalPath = Path.Combine(path, "MyDirectory");
                File.WriteAllText(Path.Combine(finalPath, $"{dataToQRTextBox.Text} SVG-QR-Code.svg"), svgQrCodeAsSvg);
            }
        }
    }
}