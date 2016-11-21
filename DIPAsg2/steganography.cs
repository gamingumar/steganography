using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DIPAsg2
{
    class steganography
    {
        //*** HIDE IMAGE IN ANOTHER IMAGE (ENCRYPTION) ***
        /* 
         * FOR GRAY SCALE IMAGE
         * ---------------------
         * Saving total of 8 Bits of Image 2
         * 2 Bits from A, 2 from R, 2 from G, 2 from B
         * Saving Algo 
         * -----------
         * 2 Bits in Alpha 
         * 2 Bits in Red
         * 2 Bits in Green
         * 2 Bits in Blue
         * 
         * Encrypted Image Saves 8 bits of Red Color
         * and then use this to make a Gray Scal Image
         * 
         * FOR COLORED IMAGE
         * ------------------
         * Saving total of 9 Bits of Image 2
         * 3 Bits from R, 3 from G, 3 from B
         * Saving Algo 
         * -----------
         * 3 Bits in Alpha 
         * 2 Bits in Red
         * 2 Bits in Green
         * 2 Bits in Blue
         */
        public static Bitmap encryptImg(Bitmap img1, Bitmap img2)
        {
            Bitmap encImg = (Bitmap)img1.Clone();
            
            int y, x, a, r1, r2, g1, b1;
            int r, g, b;

            string aBits;
            string r1Bits, r2Bits;
            string g1Bits;
            string b1Bits;
            
            Color img1pxl, img2pxl, newPxl;

            for (y = 0; y < img1.Height; y++)
            {
                for (x = 0; x < img1.Width; x++)
                {
                    img1pxl = img1.GetPixel(x, y);//save img1 pixel
                    img2pxl = img2.GetPixel(x, y);//save img2 pixel

                    //RED initialize
                    r1 = img1pxl.R;//save red pixel of img1
                    r2 = img2pxl.R;//save red pixel of img2
                    r1Bits = getBits(r1);//save red pixel bits of img1
                    r2Bits = getBits(r2);//save red pixel bits of img2

                    //GREEN initialize
                    g1 = img1pxl.G;
                    //g2 = img2pxl.G;
                    g1Bits = getBits(g1);
                   // g2Bits = getBits(g2);

                    //BLUE initialize
                    b1 = img1pxl.B;
                   // b2 = img2pxl.B;
                    b1Bits = getBits(b1);
                    //b2Bits = getBits(b2);

                    //ALPHA (Saving Bit 0 & 1 of Red)
                        
                    a = img1pxl.A;
                    aBits = getBits(a);
                  
                    aBits = changeBit(aBits, 6, int.Parse(r2Bits[0].ToString()));
                    aBits = changeBit(aBits, 7, int.Parse(r2Bits[1].ToString()));

                    //RED (Saving Bit 2 & 3 of Red)
                     
                    r1Bits = changeBit(r1Bits, 6, int.Parse(r2Bits[2].ToString())); 
                    r1Bits = changeBit(r1Bits, 7, int.Parse(r2Bits[3].ToString())); 

                    //GREEN (Saving Bit 4 & 5 of Red)
                    
                    g1Bits = changeBit(g1Bits, 6, int.Parse(r2Bits[4].ToString())); 
                    g1Bits = changeBit(g1Bits, 7, int.Parse(r2Bits[5].ToString()));

                    //BLUE (Saving Bit 6 & 7 of Red)
                    
                    b1Bits = changeBit(b1Bits, 6, int.Parse(r2Bits[6].ToString())); 
                    b1Bits = changeBit(b1Bits, 7, int.Parse(r2Bits[7].ToString())); 
                    
                    //now converting bits to integers
                    a = getInt(aBits);
                    r = getInt(r1Bits);
                    g = getInt(g1Bits);
                    b = getInt(b1Bits);

                    //making new pixel
                    newPxl = Color.FromArgb(a, r, g, b);
                    
                    //setting new pixel
                    encImg.SetPixel(x, y, newPxl);

                }
            }           

            return encImg;
        }


        //*** EXTRACT HIDDEN IMAGE FROM ANOTHER IMAGE ***
        public static Bitmap decryptImg(Bitmap img)
        {
            /*
             * Get bit 0 of r,g,b from Alpha 
             * Get 2 r bits from Red
             * Get 2 g bits from Green
             * Get 2 b bits from Blue
             */
            int y, x, a, r, g, b;

            Color decPxl, imgPxl, newPxl;

            string aBits;
            string r1Bits, r2Bits;
            string g1Bits;
            string b1Bits;

            Bitmap decImg = (Bitmap)img.Clone();

            for (y = 0; y < img.Height; y++)
            {
                for (x = 0; x < img.Width; x++)
                {
                    //get input image pixel
                    imgPxl = img.GetPixel(x, y);

                    //get output image pixel
                    decPxl = decImg.GetPixel(x, y);

                    //r1,g1,b1 belongs to input image
                    //r2,g2,b2 belongs to output image

                    
                    //get input image pixel bits]
                    aBits = getBits(imgPxl.A);
                    r1Bits = getBits(imgPxl.R);
                    g1Bits = getBits(imgPxl.G);
                    b1Bits = getBits(imgPxl.B);

                    //get output image pixel bits
                    
                    r2Bits = "00000000";
                    
                    /* get bit 6 & 7 of input image &
                    put in bit 0 & 1 of output image 
                     * get bits from r,g,b and put in r of image
                     * to get grayscale image
                     */

                   
                    //ALPHA (bit 0,1 of hidden Image)
                  
                    r2Bits = changeBit(r2Bits, 0, int.Parse(aBits[6].ToString()));
                    r2Bits = changeBit(r2Bits, 1, int.Parse(aBits[7].ToString()));

                    //RED (bit 2,3 of hidden Image)
                    r2Bits = changeBit(r2Bits, 2, int.Parse(r1Bits[6].ToString()));
                    r2Bits = changeBit(r2Bits, 3, int.Parse(r1Bits[7].ToString()));

                    //GREEN (bit 4,5 of hidden Image)
                    r2Bits = changeBit(r2Bits, 4, int.Parse(g1Bits[6].ToString()));
                    r2Bits = changeBit(r2Bits, 5, int.Parse(g1Bits[7].ToString()));

                    //BLUE (bit 6,7 of hidden Image)
                    r2Bits = changeBit(r2Bits, 6, int.Parse(b1Bits[6].ToString()));
                    r2Bits = changeBit(r2Bits, 7, int.Parse(b1Bits[7].ToString()));
                   
                    r = getInt(r2Bits);
                    
                    newPxl = Color.FromArgb(255, r, r, r);

                    //setting values of new pixel
                    decImg.SetPixel(x, y, newPxl);
                    
                }
            }
            

            return decImg;
        }


        //(GET BITS) CONVERT INTEGER TO BITS STRING
        public static string getBits(int val)
        {
            int i;
            
            string strBits = Convert.ToString(val, 2);

            if (strBits.Length < 8)
            {
                for (i = strBits.Length; i < 8; i++)
                {
                    strBits = "0" + strBits;
                }
            }

            return strBits;
        }

        //(GET INT) CONVERT BITS TO INTEGER
        public static int getInt(string strBits)
        {
            return Convert.ToInt32(strBits, 2);
        }

        //(CHANGE BIT) CHANGE SPECIFIC BIT AND RETURN BIT STRING
        //ARGUMENTS: string, index, newValue
        public static string changeBit(string strBits, int index, int newVal)
        {
            char[] bits = new char[8];
            int i;
            for (i = 0; i < 8; i++)
            {
                if (i == index)
                {
                    if (newVal == 0)
                    {
                        bits[i] = '0';
                    }
                    else if (newVal == 1)
                    {
                        bits[i] = '1';
                    }
                    else
                    {
                        MessageBox.Show("Error Occured from Bits Conversion "+ newVal.ToString());
                      //  break;
                    }
                    
                }
                else
                {
                    bits[i] = strBits[i];
                }
                
            }
            string newBits = new string(bits);

            return newBits;
        }

        public static Bitmap grayScale(Bitmap img)
        {
            int grayScale;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color newColor;
                    Color pxlColor = img.GetPixel(x, y);

                    grayScale = (int)((pxlColor.R * 0.3) + (pxlColor.G * 0.59) + (pxlColor.B * 0.11));

                    newColor = Color.FromArgb(grayScale, grayScale, grayScale);

                    img.SetPixel(x, y, newColor);
                }
            }
            return img;
        }
        
        

        //Color Encrypted Image Function

        public static Bitmap encryptImgColor(Bitmap img1, Bitmap img2)
        {
            Bitmap encImg = (Bitmap)img1.Clone();

            int y, x, a, r1, r2, g1, g2, b1, b2;
            int r, g, b;

            string aBits;
            string r1Bits, r2Bits;
            string g1Bits, g2Bits;
            string b1Bits, b2Bits;

            Color img1pxl, img2pxl, newPxl;

            for (y = 0; y < img1.Height; y++)
            {
                for (x = 0; x < img1.Width; x++)
                {
                    img1pxl = img1.GetPixel(x, y);//save img1 pixel
                    img2pxl = img2.GetPixel(x, y);//save img2 pixel

                    //RED initialize
                    r1 = img1pxl.R;//save red pixel of img1
                    r2 = img2pxl.R;//save red pixel of img2
                    r1Bits = getBits(r1);//save red pixel bits of img1
                    r2Bits = getBits(r2);//save red pixel bits of img2

                    //GREEN initialize
                    g1 = img1pxl.G;
                    g2 = img2pxl.G;
                    g1Bits = getBits(g1);
                    g2Bits = getBits(g2);

                    //BLUE initialize
                    b1 = img1pxl.B;
                    b2 = img2pxl.B;
                    b1Bits = getBits(b1);
                    b2Bits = getBits(b2);

                    //ALPHA (3 bITS Changing)
                    //1 red, 1 green, 1 blue
                    //index 0 of r,g,b
                    a = img1pxl.A;
                    aBits = getBits(a);
                    aBits = changeBit(aBits, 5, int.Parse(r2Bits[0].ToString()));
                    aBits = changeBit(aBits, 6, int.Parse(g2Bits[0].ToString()));
                    aBits = changeBit(aBits, 7, int.Parse(b2Bits[0].ToString()));

                    //RED (2 bITS Changing, both red)

                    r1Bits = changeBit(r1Bits, 6, int.Parse(r2Bits[1].ToString())); //change 7th bit with 1st bit of 2nd image
                    r1Bits = changeBit(r1Bits, 7, int.Parse(r2Bits[2].ToString())); //change 8th bit with 2nd bit of 2nd image

                    //GREEN (2 bITS Changing, both green)

                    g1Bits = changeBit(g1Bits, 6, int.Parse(g2Bits[1].ToString())); //change 7th bit with 3rd bit of 2nd image
                    g1Bits = changeBit(g1Bits, 7, int.Parse(g2Bits[2].ToString())); //change 8th bit with 4th bit of 2nd image

                    //BLUE (2 bITS Changing)

                    b1Bits = changeBit(b1Bits, 6, int.Parse(b2Bits[1].ToString())); //change 7th bit with 4th bit of 2nd image
                    b1Bits = changeBit(b1Bits, 7, int.Parse(b2Bits[2].ToString())); //change 8th bit with 5th bit of 2nd image

                    //now converting bits to integers
                    a = getInt(aBits);
                    r = getInt(r1Bits);
                    g = getInt(g1Bits);
                    b = getInt(b1Bits);

                    //making new pixel
                    newPxl = Color.FromArgb(a, r, g, b);

                    //setting new pixel
                    encImg.SetPixel(x, y, newPxl);



                }
            }

            return encImg;
        }


        //Color Decrypt Image Function

        //*** EXTRACT HIDDEN IMAGE FROM ANOTHER IMAGE ***
        public static Bitmap decryptImgColor(Bitmap img)
        {
            /*
             * Get bit 0 of r,g,b from Alpha 
             * Get 2 r bits from Red
             * Get 2 g bits from Green
             * Get 2 b bits from Blue
             */
            int y, x, a, r, g, b;

            Color decPxl, imgPxl, newPxl;

            string aBits;
            string r1Bits, r2Bits;
            string g1Bits, g2Bits;
            string b1Bits, b2Bits;

            Bitmap decImg = (Bitmap)img.Clone();

            for (y = 0; y < img.Height; y++)
            {
                for (x = 0; x < img.Width; x++)
                {
                    //get input image pixel
                    imgPxl = img.GetPixel(x, y);

                    //get output image pixel
                    decPxl = decImg.GetPixel(x, y);

                    //r1,g1,b1 belongs to input image
                    //r2,g2,b2 belongs to output image


                    //get input image pixel bits]
                    aBits = getBits(imgPxl.A);
                    r1Bits = getBits(imgPxl.R);
                    g1Bits = getBits(imgPxl.G);
                    b1Bits = getBits(imgPxl.B);

                    //get output image pixel bits
                    //r2Bits = getBits(decPxl.R);
                    //g2Bits = getBits(decPxl.G);
                    //b2Bits = getBits(decPxl.B);

                    r2Bits = "11111000";
                    g2Bits = "11111000";
                    b2Bits = "11111000";

                    /* get bit 6 & 7 of input image &
                    put in bit 0 & 1 of output image */


                    //ALPHA
                    r2Bits = changeBit(r2Bits, 0, int.Parse(aBits[5].ToString()));
                    g2Bits = changeBit(g2Bits, 0, int.Parse(aBits[6].ToString()));
                    b2Bits = changeBit(b2Bits, 0, int.Parse(aBits[7].ToString()));

                    //RED
                    r2Bits = changeBit(r2Bits, 1, int.Parse(r1Bits[6].ToString()));
                    r2Bits = changeBit(r2Bits, 2, int.Parse(r1Bits[7].ToString()));
                    r2Bits = changeBit(r2Bits, 3, 0);
                    r2Bits = changeBit(r2Bits, 4, 0);


                    //GREEN
                    g2Bits = changeBit(g2Bits, 1, int.Parse(g1Bits[6].ToString()));
                    g2Bits = changeBit(g2Bits, 2, int.Parse(g1Bits[7].ToString()));
                    g2Bits = changeBit(g2Bits, 3, 0);
                    g2Bits = changeBit(g2Bits, 4, 0);

                    //BLUE
                    b2Bits = changeBit(b2Bits, 1, int.Parse(b1Bits[6].ToString()));
                    b2Bits = changeBit(b2Bits, 2, int.Parse(b1Bits[7].ToString()));
                    b2Bits = changeBit(b2Bits, 3, 0);
                    b2Bits = changeBit(b2Bits, 4, 0);

                    r = getInt(r2Bits);
                    g = getInt(g2Bits);
                    b = getInt(b2Bits);

                    newPxl = Color.FromArgb(255, r, g, b);

                    //setting values of new pixel
                    decImg.SetPixel(x, y, newPxl);

                }
            }
            return decImg;
        }















        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };

        public static Bitmap embedText(string text, Bitmap bmp)
        {
            // initially, we'll be hiding characters in the image
            State state = State.Hiding;

            // holds the index of the character that is being hidden
            int charIndex = 0;

            // holds the value of the character converted to integer
            int charValue = 0;

            // holds the index of the color element (R or G or B) that is currently being processed
            long pixelElementIndex = 0;

            // holds the number of trailing zeros that have been added when finishing the process
            int zeros = 0;

            // hold pixel elements
            int R = 0, G = 0, B = 0;

            // pass through the rows
            for (int i = 0; i < bmp.Height; i++)
            {
                // pass through each row
                for (int j = 0; j < bmp.Width; j++)
                {
                    // holds the pixel that is currently being processed
                    Color pixel = bmp.GetPixel(j, i);

                    // now, clear the least significant bit (LSB) from each pixel element
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    // for each pixel, pass through its elements (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        // check if new 8 bits has been processed
                        if (pixelElementIndex % 8 == 0)
                        {
                            // check if the whole process has finished
                            // we can say that it's finished when 8 zeros are added
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                // apply the last pixel on the image
                                // even if only a part of its elements have been affected
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                // return the bitmap with the text hidden in
                                return bmp;
                            }

                            // check if all characters has been hidden
                            if (charIndex >= text.Length)
                            {
                                // start adding zeros to mark the end of the text
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                // move to the next character and process again
                                charValue = text[charIndex++];
                            }
                        }

                        // check which pixel element has the turn to hide a bit in its LSB
                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        // the rightmost bit in the character will be (charValue % 2)
                                        // to put this value instead of the LSB of the pixel element
                                        // just add it to it
                                        // recall that the LSB of the pixel element had been cleared
                                        // before this operation
                                        R += charValue % 2;

                                        // removes the added rightmost bit of the character
                                        // such that next time we can reach the next one
                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {
                            // increment the value of zeros until it is 8
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }

        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            // holds the text that will be extracted from the image
            string extractedText = String.Empty;

            // pass through the rows
            for (int i = 0; i < bmp.Height; i++)
            {
                // pass through each row
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    // for each pixel, pass through its elements (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    // get the LSB from the pixel element (will be pixel.R % 2)
                                    // then add one bit to the right of the current character
                                    // this can be done by (charValue = charValue * 2)
                                    // replace the added bit (which value is by default 0) with
                                    // the LSB of the pixel element, simply by addition
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        // if 8 bits has been added, then add the current character to the result text
                        if (colorUnitIndex % 8 == 0)
                        {
                            // reverse? of course, since each time the process happens on the right (for simplicity)
                            charValue = reverseBits(charValue);

                            // can only be 0 if it is the stop character (the 8 zeros)
                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            // convert the character value from int to char
                            char c = (char)charValue;

                            // add the current character to the result text
                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }


    }
}
