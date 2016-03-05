using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinF6
{
    public class Controller
    {
        private Chromosome[] pop;
        private Chromosome[] popAux;

        public Evolution evolution;

        private double mutationRate, crossoverRate, bestFit;
        private int popSize, elit;

        public bool error;

        public String exception { get; set; }


        public Controller(String mutRate, String crossRate, String popSize, int elit, String bestFit) {
            this.elit = elit;
            error = false;
            try
            {
                mutationRate = double.Parse(mutRate);
                crossoverRate = double.Parse(crossRate);
                this.bestFit = double.Parse(bestFit);
                Console.WriteLine("cross/mut/fit" + crossoverRate + " " + mutationRate + " " + this.bestFit + "Parsing Doubles - controller"); 
            }
            catch (FormatException e) {
                exception = "Rates must be doubles.";
                error = true;
                Console.WriteLine("Doubles not parsed - controller");
            }

            try
            {
                this.popSize = Int32.Parse(popSize);
                Console.WriteLine("Parsing popSize - controller");
            }
            catch (FormatException e) {
                exception = "Population size must be an Integer.";
                error = true;
                Console.WriteLine("int not parsed - controller");
            }

            if (!error)
            {
                Console.WriteLine("Generating pop - controller ");
                generatePop();
                Console.WriteLine("Evolving - controller");
                evolution = new Evolution(pop, popAux, mutationRate, crossoverRate, this.bestFit, this.popSize);
                exception = "No Errors";
            }

        }

        public void generatePop() {
            pop = new Chromosome[popSize];
            popAux = new Chromosome[popSize];
            Console.WriteLine("Pop and popAux created - controller");

            for (int i = 0; i < popSize; i++) {
                pop[i]   = new Chromosome(true);
                popAux[i] = new Chromosome(false);
                Console.WriteLine("chrom aux " + i + "Created - controller");

            }
            Console.WriteLine("All pop created");
        }

        public void start() {
            Console.WriteLine("Starting evolve - controller");
            evolution.evolve();
            Console.WriteLine("Evolve finished - controller");
        }

        public Evolution getEvolve() {
            return evolution;
        }
    }
}
