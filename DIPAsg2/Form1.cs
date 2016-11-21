using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DIPAsg2
{
    public partial class Form1 : Form
    {
        //*** VARIABLES ***
        Bitmap img = new Bitmap("1.bmp");
        Bitmap encImg, decImg, img2, bmp;
        
        //*** VARIABLES ***
        public Form1()
        {
            InitializeComponent();
            btnDecEnc.Hide();
            btnSaveDec.Hide();
            btnSaveEnc.Hide();
            btnEncrypt.Hide();
            btnDecrypt.Hide();

            btnExtractText.Hide();
            btnExtractTextFromImage.Hide();
        }

        private void btnOpnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog newImg = new OpenFileDialog();
            //Filter: Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*
            newImg.Filter = "Image Files (*.BMP;*.PNG;*.JPG)|*.BMP;*.PNG;*.JPG";

            if (newImg.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(newImg.FileName);

                picImg.Image = img;

                btnEncrypt.Show();
                btnDecrypt.Show();

                btnExtractText.Hide();
                btnExtractTextFromImage.Show();
                
                btnSaveEnc.Hide();
                btnSaveDec.Hide();

                btnDecEnc.Hide();

                picEncrypt.Image = null;
                picDecrypt.Image = null;
                picImg2.Image = null;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (picImg.Image == null)
            {
                MessageBox.Show("Please Select Image 1 First.");
                return;
            }
            
            //opening Image 2
            OpenFileDialog newImg = new OpenFileDialog();

            newImg.Filter = "Image Files (*.BMP;*.PNG;*.JPG)|*.BMP;*.PNG;*.JPG";

            if (newImg.ShowDialog() == DialogResult.OK)
            {
                img2 = new Bitmap(newImg.FileName);

                picImg2.Image = img2;

                //size chk
                if (picImg.Image.Width != picImg2.Image.Width)
                {
                    MessageBox.Show("Images are not of same size.");
                    return;
                }
                if (picImg.Image.Height != picImg2.Image.Height)
                {
                    MessageBox.Show("Images are not of same size.");
                    return;
                }

              //  img = steganography.grayScale(img);
             //   img2 = steganography.grayScale(img2);

                Cursor.Current = Cursors.WaitCursor;

                //Color or Gray Scale
                //calling image encryption function
                
               
                if (chkColorAlgo.Checked == true)
                {
                    picEncrypt.Image = steganography.encryptImgColor(img, img2);
                }
                else
                {
                    picEncrypt.Image = steganography.encryptImg(img, img2);
                }

                
                
               // picImg2.Image = img2;

                Cursor.Current = Cursors.Default;

                btnSaveEnc.Show();
                btnDecEnc.Show();
            }
        }

        private void btnSaveEnc_Click(object sender, EventArgs e)
        {
            //SAVING ENCRYPTED IMAGE
            if (picEncrypt.Image == null)
            {
                MessageBox.Show("Please Encrypt the Image First.");
                return;
            }

            SaveFileDialog saveEncImg = new SaveFileDialog();

            saveEncImg.Filter = "PNG Image (*.PNG)|*.png ";
            saveEncImg.FileName = "encrypted.png";
            if (saveEncImg.ShowDialog() == DialogResult.OK)
            {
                picEncrypt.Image.Save(saveEncImg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Encrypted Image saved as " + saveEncImg.FileName);
            }            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (picImg.Image == null)
            {
                MessageBox.Show("Please select the Image to Decrypt.");
                return;
            }
            Bitmap dImg = new Bitmap(picImg.Image);

            Cursor.Current = Cursors.WaitCursor;

            //calling image decryption function

            if (chkColorAlgo.Checked == true)
            {
                picDecrypt.Image = steganography.decryptImgColor(dImg);
            }
            else
            {
                picDecrypt.Image = steganography.decryptImg(dImg);
            }            

            Cursor.Current = Cursors.Default;

            btnSaveDec.Show();
        }


        private void btnSaveDec_Click(object sender, EventArgs e)
        {
            //SAVE DECRYPTED IMAGE
            if (picDecrypt.Image == null)
            {
                MessageBox.Show("Please Decrypt the Image First.");
                return;
            }

            SaveFileDialog saveDecImg = new SaveFileDialog();

            saveDecImg.Filter = "PNG Image (*.PNG)|*.png ";
            saveDecImg.FileName = "decrypted.png";
            if (saveDecImg.ShowDialog() == DialogResult.OK)
            {
                picDecrypt.Image.Save(saveDecImg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Decrypted Image saved as " + saveDecImg.FileName);
            }

        }

        private void btnDecEnc_Click(object sender, EventArgs e)
        {
            if (picEncrypt.Image == null)
            {
                MessageBox.Show("Please Encrypt the Image to Decrypt.");
                return;
            }
            Bitmap dImg = (Bitmap)picEncrypt.Image;

            Cursor.Current = Cursors.WaitCursor;

            if (chkColorAlgo.Checked == true)
            {
                picDecrypt.Image = steganography.decryptImgColor(dImg);
            }
            else
            {
                picDecrypt.Image = steganography.decryptImg(dImg);
            }


            Cursor.Current = Cursors.Default;

            btnSaveDec.Show();
        }

        private void btnExtractText_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)picEncrypt.Image;

            string extractedText = steganography.extractText(bmp);

            if (extractedText.Equals(""))
            {
                MessageBox.Show("No text found inside image");
                return;
            }

            txtBox.Text = extractedText;

            MessageBox.Show("Text extracted successfully");
        }

        private void btnExtractTextFromImage_Click(object sender, EventArgs e)
        {
            string extractedText = steganography.extractText(img);

            if (extractedText.Equals(""))
            {
                MessageBox.Show("No text found inside image");
                return;
            }

            txtBox.Text = extractedText;

            MessageBox.Show("Text extracted successfully");
            
            
        }

        private void btnHideText_Click(object sender, EventArgs e)
        {
            if (picImg.Image == null)
            {
                MessageBox.Show("Please Select Image first.");
                return;
            }

            string text = txtBox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("plese enter some shit");
                return;
            }
            else
            {
                img = steganography.embedText(text, img);

                picEncrypt.Image = img;

                MessageBox.Show("Text is hidden in image successfully, You can save it now!");

                btnExtractText.Show();
                btnSaveEnc.Show();
            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkColorAlgo_CheckedChanged(object sender, EventArgs e)
        {
            btnDecEnc.Hide();
            btnSaveDec.Hide();
            btnSaveEnc.Hide();
            btnEncrypt.Hide();
            btnDecrypt.Hide();

            picImg.Image = null;
            picImg2.Image = null;
            picEncrypt.Image = null;
            picDecrypt.Image = null;
        }

       

    }
}
