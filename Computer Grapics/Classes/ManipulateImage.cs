﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Grapics.Classes
{
    static class ManipulateImage
    {
        public static Bitmap AddImages(string image1Path, string image2Path)
        {
            //Add image and display result in the picture box
            Bitmap imageA = new Bitmap(image1Path);
            Bitmap imageB = new Bitmap(image2Path);

            Color[,] color1 = new Color[imageA.Width, imageA.Height];
            Color[,] color2 = new Color[imageB.Width, imageB.Height];
            Color pixel1, pixel2;

            //Reading image to color array 
            for (int i = 0; i < imageA.Width; i++)
            {
                for (int j = 0; j < imageA.Height; j++)
                {
                    pixel1 = imageA.GetPixel(i, j);
                    color1[i, j] = pixel1;
                }
            }

            for (int i = 0; i < imageB.Width; i++)
            {
                for (int j = 0; j < imageB.Height; j++)
                {
                    pixel2 = imageB.GetPixel(i, j);
                    color2[i, j] = pixel2;
                }
            }
            //declarion of valirables for the final image
            int newImageWidth = (imageA.Width <= imageB.Width) ? imageA.Width : imageB.Width;
            int newImageHeight = (imageA.Height <= imageB.Height) ? imageA.Height : imageB.Height;
            Bitmap finalImage = new Bitmap(newImageWidth, newImageHeight);
            Color pixelColor = new Color();
            int RValue = 0;
            int GValue = 0;
            int BValue = 0;

            //// to add images 
            for (int i = 0; i < newImageWidth; i++)
            {
                for (int j = 0; j < newImageHeight; j++)
                {
                    RValue = color1[i, j].R + color2[i, j].R;
                    RValue = (RValue > 255) ? RValue - 255 : RValue;

                    GValue = color1[i, j].G + color2[i, j].G;
                    GValue = (GValue > 255) ? GValue - 255 : GValue;

                    BValue = color1[i, j].B + color2[i, j].B;
                    BValue = (BValue > 255) ? BValue - 255 : BValue;

                    pixelColor = Color.FromArgb(RValue, GValue, BValue);

                    finalImage.SetPixel(i, j, pixelColor);
                }
            }

            return finalImage;
        }

        public static Bitmap SubtractImages(string image1Path, string image2Path)
        {
            //Add image and display result in the picture box
            Bitmap imageA = new Bitmap(image1Path);
            Bitmap imageB = new Bitmap(image2Path);

            Color[,] color1 = new Color[imageA.Width, imageA.Height];
            Color[,] color2 = new Color[imageB.Width, imageB.Height];
            Color pixel1, pixel2;

            //Reading image to color array 
            for (int i = 0; i < imageA.Width; i++)
            {
                for (int j = 0; j < imageA.Height; j++)
                {
                    pixel1 = imageA.GetPixel(i, j);
                    color1[i, j] = pixel1;
                }
            }

            for (int i = 0; i < imageB.Width; i++)
            {
                for (int j = 0; j < imageB.Height; j++)
                {
                    pixel2 = imageB.GetPixel(i, j);
                    color2[i, j] = pixel2;
                }
            }
            //declarion of valirables for the final image
            int newImageWidth = (imageA.Width <= imageB.Width) ? imageA.Width : imageB.Width;
            int newImageHeight = (imageA.Height <= imageB.Height) ? imageA.Height : imageB.Height;
            Bitmap finalImage = new Bitmap(newImageWidth, newImageHeight);
            Color pixelColor = new Color();
            int RValue = 0;
            int GValue = 0;
            int BValue = 0;

            //to subtract images
            for (int i = 0; i < newImageWidth; i++)
            {
                for (int j = 0; j < newImageHeight; j++)
                {
                    RValue = color1[i, j].R - color2[i, j].R;
                    RValue = (RValue < 0) ? RValue + 255 : RValue;

                    GValue = color1[i, j].G - color2[i, j].G;
                    GValue = (GValue < 0) ? GValue + 255 : GValue;

                    BValue = color1[i, j].B - color2[i, j].B;
                    BValue = (BValue < 0) ? BValue + 255 : BValue;

                    pixelColor = Color.FromArgb(RValue, GValue, BValue);

                    finalImage.SetPixel(i, j, pixelColor);
                }
            }

            return finalImage;
        }

        public static Bitmap MultiplyImage(string image1Path, string image2Path)
        {
            //Add image and display result in the picture box
            Bitmap imageA = new Bitmap(image1Path);
            Bitmap imageB = new Bitmap(image2Path);

            Color[,] color1 = new Color[imageA.Width, imageA.Height];
            Color[,] color2 = new Color[imageB.Width, imageB.Height];
            Color pixel1, pixel2;

            //Reading image to color array 
            for (int i = 0; i < imageA.Width; i++)
            {
                for (int j = 0; j < imageA.Height; j++)
                {
                    pixel1 = imageA.GetPixel(i, j);
                    color1[i, j] = pixel1;
                }
            }

            for (int i = 0; i < imageB.Width; i++)
            {
                for (int j = 0; j < imageB.Height; j++)
                {
                    pixel2 = imageB.GetPixel(i, j);
                    color2[i, j] = pixel2;
                }
            }
            //declarion of valirables for the final image
            int newImageWidth = (imageA.Width <= imageB.Width) ? imageA.Width : imageB.Width;
            int newImageHeight = (imageA.Height <= imageB.Height) ? imageA.Height : imageB.Height;
            Bitmap finalImage = new Bitmap(newImageWidth, newImageHeight);
            Color pixelColor = new Color();
            int RValue = 0;
            int GValue = 0;
            int BValue = 0;

            //to multiply 2 images
            for (int i = 0; i < newImageWidth; i++)
            {
                for (int j = 0; j < newImageHeight; j++)
                {
                    RValue = color1[i, j].R * color2[i, j].R;
                    RValue = (RValue > 255) ? 255 : RValue;

                    GValue = color1[i, j].G * color2[i, j].G;
                    GValue = (GValue > 255) ? 255 : GValue;

                    BValue = color1[i, j].B * color2[i, j].B;
                    BValue = (BValue > 255) ? 255 : BValue;

                    pixelColor = Color.FromArgb(RValue, GValue, BValue);

                    finalImage.SetPixel(i, j, pixelColor);
                }
            }
            return finalImage;
        }
    }
}
