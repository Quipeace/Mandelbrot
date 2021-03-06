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

            nmThreads.Value = Environment.ProcessorCount;   // Aantal threads gelijk aan het aantal logische processoren
        }

        private void InitializeListbox()                    // Namen mooie punten aan listbox toevoegen
        {  
            listBox.Items.Add("Torn Set");                  
            listBox.Items.Add("Spiral Down");
            listBox.Items.Add("Stars");
            listBox.Items.Add("Day at the Beach");
            listBox.Items.Add("Lightning");
        }

        private void drawMandel()       // Niet in een paint-event om te voorkomen dat het scherm kort wit wordt voor het tekenen
        {                               // Daarbij is Graphics van PaintEventArgs alleen geldig terwijl het paint event draait, CreateGraphics blijft geldig zolang de Control bestaat
            int numThreads = (int)nmThreads.Value;                      // Aantal threads ophalen uit invoer      

            Mandelbrot.scale = double.Parse(tbScale.Text);              // Schaal ophalen uit textbox
            Mandelbrot.maxIterations = int.Parse(tbIterations.Text);    // Max. iteraties

            Mandelbrot.mandelOffset[0] = double.Parse(tbCoordX.Text);   // X "coordinaat"
            Mandelbrot.mandelOffset[1] = double.Parse(tbCoordY.Text);   // Y "coordinaat"

            Mandelbrot.colours[0] = (int) trackRed.Value;               // Kleuren opslaan in array
            Mandelbrot.colours[1] = (int) trackGreen.Value;
            Mandelbrot.colours[2] = (int) trackBlue.Value;

            int[] screenSize = { pnFractal.Width, pnFractal.Height };
            int[] halfScreenSize = { pnFractal.Width / 2, pnFractal.Height / 2 };

            if (numThreads == 0)                                        // Geen threads, blokkeert UI
            {
                Mandelbrot.generateImage(pnFractal.CreateGraphics(), 0, 1, screenSize, halfScreenSize);    // graphics, startX, stepSize
            }
            else
            {
                for (int i = 0; i < numThreads; i++)
                {
                    int start = i;                              // Moet in een nieuwe variabele voor generateMandelbrot
                    int stepSize = numThreads;                  // Idem

                    Thread newThread = new Thread(() => Mandelbrot.generateImage(pnFractal.CreateGraphics(), start, stepSize, screenSize, halfScreenSize));
               
                    newThread.Name = i.ToString();              // Naam voor debugging purposes
                    newThread.Start();                          // Draaien maar!
                }
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            drawMandel();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            nmThreads.Value = Environment.ProcessorCount;
            tbCoordX.Text = "0.0";
            tbCoordY.Text = "0.0";
            tbScale.Text = "0.01";
            tbIterations.Text = "100";

            trackRed.Value = 50;
            trackGreen.Value = 65;
            trackBlue.Value = 12;

            drawMandel();
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

            drawMandel();                                     // Renderen met nieuwe waardes
        }

        private void pnFractal_Resize(object sender, EventArgs e)
        {
            drawMandel();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox.SelectedIndex)              // Switch statement om het geselecteerde plaatje te "laden"
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
                    tbCoordX.Text = "0.0578515625";
                    tbCoordY.Text = "-0.656953125";
                    tbScale.Text = "1.953125E-05";
                    tbIterations.Text = "100";
                    break;
                case 3:
                    tbCoordX.Text = "-0,19854736328125";
                    tbCoordY.Text = "-1,0999072265625";
                    tbScale.Text = "6,103515625E-07";
                    tbIterations.Text = "100";
                    break;
                case 4:
                    tbCoordX.Text = "0,161647033691406";     //TODO mooi punt
                    tbCoordY.Text = "0,637026367187501";
                    tbScale.Text = "1,52587890625E-07";
                    tbIterations.Text = "100";
                    break;
                default:
                    break;
            }
            drawMandel();
        }

        private void pnFractal_Paint(object sender, PaintEventArgs e)
        {
            drawMandel();
        }
    }
}
