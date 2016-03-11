using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinF6
{
    public class Chromosome
    {
        public int[] gene { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double fitness { get; set; }

        public Chromosome(bool aux) {
            if (aux) { constructor(); }
            else { auxConstructor(); }
        }

        private void constructor() {
            gene = new int[44];

            for (int i = 0; i < gene.Length; i++)
            {
                gene[i] = randNumber(i) % 2;
                Console.Write(gene[i]+" ");
            }
            Console.WriteLine(" - Chromosome");
            setFitness();
        }

        private void auxConstructor() {
            gene = new int[44];
            Console.WriteLine("Aux constructor  - Chromosome");
        }

        private int randNumber(int i) {
            Random rg = new Random((int)Math.Pow((int)(DateTime.Now.Millisecond), i));

            return rg.Next((int)(DateTime.Now.Second) - i,  (int)(DateTime.Now.Second) + i);    
        }

        public void setFitness() {
            setXY();
            double xy = (x * x) + (y * y);
            double mant = Math.Pow(Math.Sin(Math.Sqrt(xy)), 2);

            fitness = 0.5 - ((mant - 0.5) / (1 + (0.001 * xy * xy)));
            Console.WriteLine(fitness + " - Chromosome"); 
        }

        private void setXY() {
            double sumX = 0;
            double sumY = 0;

            for (int i = 0; i < 22; i++) {
                sumX += gene[i] * (Math.Pow(2.0, i));
            }

            x = (sumX / 20971.51) - 100;
            Console.Write("X: " + x + " ");

            for (int i = 22; i < 44; i++)
            {
                sumY += gene[i] * (Math.Pow(2.0, (i - 22)));
            }

            y = (sumY / 20971.51) - 100;
            Console.WriteLine("Y: " + y + " - Chromosome");
        }

        public int getGeneI(int i) {
            return gene[i];
        }

        public void setGeneI(int i, int gene) {
            this.gene[i] = gene;
        }

        public string toString() {
            string str = "";
            for (int i = 0; i < gene.Length; i++) {
                Console.Write(gene[i]);
                str += gene[i];
            }
            Console.WriteLine("  - Chromosome");
            return str;
        }
    }
}
