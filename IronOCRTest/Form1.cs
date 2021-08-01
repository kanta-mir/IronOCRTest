using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronOCRTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.Urdu;
            var imgPath = txtImagePath.Text;
            using (var Input = new OcrInput(imgPath))
            {
                // Input.Deskew();  // use if image not straight
                // Input.DeNoise(); // use if image contains digital noise
                try { 
                    var Result = Ocr.Read(Input);
                    txtOCRText.Text = Result.Text;
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


                
            }
        }
    }
}
