using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinF6
{
    public partial class crossRateComboBox : Form
    {
        public Controller controller;
        private int elit;

        public crossRateComboBox()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            checkElitism();
            controller = new Controller(mutRateComboBox.Text, crossRateBox.Text, popSizeBox.Text, elit, fitnessBox.Text, prefCountComboBox.Text);
            Console.WriteLine("Controller Created");
            if (controller.error)
            {
                commentBox.Text = controller.exception
                    + "\n Program could not be initialized"
                    + "\n Try Again";
                Console.WriteLine("Exception");
            }
            else
            {
                Console.WriteLine("Starting COntroller");
                commentBox.Text = "Program started...";
                controller.start();
                commentBox.Text = "Program running";
                Console.WriteLine("Updating Values");
                updateViewValues();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            mutRateComboBox.Text = "0,05";
            crossRateBox.Text = "0,95";
            popSizeBox.Text = "100";
            fitnessBox.Text = "0,999";
            NoElitism.Checked = true;
            Elitism.Checked = false;
            mutPref.Checked = false;
            secBestPref.Checked = false;
            bestFitBox.Text = " ";
            avgFitBox.Text = " ";
            worstFitBox.Text = " ";
            geneBox.Text = " ";
            intCount.Text = " ";
            if (controller != null)
            {
                controller.Finalizer();
                controller = null;
            }
            Console.WriteLine("Reset Button");


        }

        private void mutRateComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void checkElitism() {
            if (NoElitism.Checked) { elit = 0; }
            else if (Elitism.Checked) { elit = 1; }
            else if (mutPref.Checked) { elit = 2; }
            else if (secBestPref.Checked) { elit = 3; }
            else { elit = 0; }
            Console.WriteLine("Elitism = " + elit);
        }

        public void updateViewValues() {
            bestFitBox.Text = controller.getEvolve().bestFitness.ToString().Substring(0,10);
            avgFitBox.Text = controller.getEvolve().avgFitness.ToString().Substring(0, 10);
            worstFitBox.Text = controller.getEvolve().worstFitness.ToString().Substring(0, 10);
            geneBox.Text = controller.getEvolve().pop.ElementAt<Chromosome>(controller.getEvolve().bestGene).toString();
            intCount.Text = controller.getEvolve().intCount.ToString();
            checkError();
            Console.WriteLine("Values Updated");
        }

        public void checkError() {
            if (!controller.error) {
                commentBox.Text = "Program ran without errors.";
            }
        }
    }
}
