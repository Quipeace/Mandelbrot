﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class MandelbrotForm : Form
    {
        public MandelbrotForm()
        {
            InitializeComponent();

            InitializeListbox();

            pnFractal.Paint += drawScreen;
        }

        private void InitializeListbox()
        {
            listBox.Items.Add("Tear and Pillars");
            listBox.Items.Add("Spiral Down");
            listBox.Items.Add("Landmark 3");
            listBox.Items.Add("Landmark 4");
            listBox.Items.Add("Landmark 5");
        }
        
        private void drawScreen(object sender, PaintEventArgs e)
        {
            int numThreads = (int)nmThreads.Value;          
            if (numThreads == 0)                            // Geen threads, geen render                      
            {
                return;
            }

            Stopwatch stopwatch = new Stopwatch();          // Nieuwe stopwatch voor het meten van de tijd
            stopwatch.Start();

            Graphics graphics = e.Graphics;                 // Convenience

            double scale = double.Parse(tbScale.Text);      // Schaal ophalen uit textbox
            int iterations = int.Parse(tbIterations.Text);  // Max. iteraties
            double xOffset = double.Parse(tbCoordX.Text);   // X "coordinaat"
            double yOffset = double.Parse(tbCoordY.Text);   // Y "coordinaat"

            int width = pnFractal.Width;                    // Breedte/hoogte van het scherm
            int height = pnFractal.Height;

            int halfWidth = width / 2;                      // In een variabele om dubbel uitrekenen te voorkomen
            int halfHeight = height / 2;

            Mandelbrot.mandel = new Bitmap(width, height);  // Nieuwe bitmap voor de fractal

            Thread[] threads = new Thread[numThreads];      // Array om draaiende threads in op te slaan
            for (int i = 0; i < numThreads; i++)
            {
                int start = i;                              // Moet in een nieuwe variabele voor generateMandelbrot
                int stepSize = numThreads;                  // Idem

                Thread newThread = new Thread(() => Mandelbrot.generateMandelbrot(graphics, start, stepSize, width, height, halfWidth, halfHeight, scale, xOffset, yOffset, iterations));
               
                newThread.Name = i.ToString();              // Naam voor debugging purposes
                newThread.Start();                          // Draaien maar!
                threads[i] = newThread;                     // Thread opslaan in array
            }
            for (int i = 0; i < numThreads; i++)            // Wachten op alle threads
            {
                threads[i].Join();
            }

            stopwatch.Stop();                               // Performance report in statusbar en "console"
            statusLabel.Text = "Done in " + stopwatch.ElapsedMilliseconds + " millis";
            Console.WriteLine(statusLabel.Text);
        }


        private void btRun_Click(object sender, EventArgs e)
        {
            pnFractal.Invalidate();                         // Invalidate panel om opnieuw te renderen
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbCoordX.Text = "0.0";
            tbCoordY.Text = "0.0";
            tbScale.Text = "0.01";
            tbIterations.Text = "100";

            pnFractal.Invalidate();                         // Invalidate panel om opnieuw te renderen na resetten waarden 
        }

        private String oldIterations = "100";               
        private void tbIterations_TextChanged(object sender, EventArgs eventArgs)
        {
            int i;
            if(!int.TryParse(tbIterations.Text, out i))             // Als de nieuwe waarde geen valid double is, terugzetten
            {
                tbIterations.Text = oldIterations;
                tbIterations.SelectionStart = oldIterations.Length; // Cursor naar het einde van de nieuwe string
            }
            else
            {
                oldIterations = tbIterations.Text;
            }
        }

        private String oldScale = "0.01";
        private void tbScale_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbScale.SelectionStart;
            tbScale.Text = tbScale.Text.Replace(".", ",");          // Punten vervangen voor comma's

            double i;
            if (!double.TryParse(tbScale.Text, out i))
            {
                tbScale.Text = oldScale;
                tbScale.SelectionStart = oldScale.Length;
            }
            else
            {
                oldScale = tbScale.Text;
                tbScale.SelectionStart = selectionStart;
            }
        }

        private String oldCoordX = "0.0";
        private void tbCoordX_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbCoordX.SelectionStart;
            tbCoordX.Text = tbCoordX.Text.Replace(".", ",");

            double i;
            if (!double.TryParse(tbCoordX.Text, out i))
            {
                tbCoordX.Text = oldCoordX;
                tbCoordX.SelectionStart = oldScale.Length;
            }
            else
            {
                oldCoordX = tbCoordX.Text;
                tbCoordX.SelectionStart = selectionStart;
            }
        }

        private String oldCoordY = "0.0";
        private void tbCoordY_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = tbCoordY.SelectionStart;
            tbCoordY.Text = tbCoordY.Text.Replace(".", ",");

            double i;
            if (!double.TryParse(tbCoordY.Text, out i))
            {
                tbCoordY.Text = oldCoordY;
                tbCoordY.SelectionStart = oldScale.Length;
            }
            else
            {
                oldCoordY = tbCoordY.Text;
                tbCoordY.SelectionStart = selectionStart;
            }
        }

        private void pnFractal_MouseClick(object sender, MouseEventArgs e)
        {
            double scale = double.Parse(tbScale.Text);                  // Waardes ophalen
            double currentX = double.Parse(tbCoordX.Text);              
            double currentY = double.Parse(tbCoordY.Text);

            int halfWidth = pnFractal.Width / 2;
            int halfHeight = pnFractal.Height / 2;

            double correctedX = (e.X - halfWidth) * scale + currentX;   // Mouseclick omzetten naar mandelbrot-coordinaten 
            double correctedY = (e.Y - halfHeight) * scale + currentY;  // Oude scale gebruiken, anders verschuift het beeld minder dan verwacht wordt

            if (e.Button == MouseButtons.Right)                         // Als de klik met rechts was
            {
                scale = scale / 2;
                tbScale.Text = scale.ToString();                        // Scale verkleinen (inzoomen)
            }

            tbCoordX.Text = correctedX.ToString();
            tbCoordY.Text = correctedY.ToString();

            pnFractal.Invalidate();                                     // Renderen met nieuwe waardes
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox.SelectedIndex)
            {
                case 0:
                    tbCoordX.Text = "-1,25340576171876";
                    tbCoordY.Text = "0,382695922851563";
                    tbScale.Text = "3,0517578125E-07";
                    tbIterations.Text = "100";
                    break;
                case 1:
                    tbCoordX.Text = "-0,22625";
                    tbCoordY.Text = "0,7003515625";
                    tbScale.Text = "1,953125E-05";
                    tbIterations.Text = "100";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
            pnFractal.Invalidate();
        }
    }
}
