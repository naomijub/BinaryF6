using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinF6
{
    public class Evolution
    {
        public Chromosome[] pop { get; set; }
        public Chromosome[] popAux { get; set; }

        private Random rg;

        private double mutationRate, crossoverRate, bestFit;

        public double bestFitness { get; set; }
        public double avgFitness { get; set; }
        public double worstFitness { get; set; }
        public int intCount { get; set; }
        public int bestGene { get; set; }
        public int popSize { get; set; }

        public Evolution(Chromosome[] pop, Chromosome[] popAux, double mutationRate, double crossoverRate, 
            double bestFit, int popSize) {

            rg = new Random();

            this.pop           = pop;
            this.popAux        = popAux;
            this.crossoverRate = crossoverRate;
            this.mutationRate  = mutationRate;
            this.bestFit       = bestFit;
            this.popSize = popSize;

            Console.WriteLine("Pop size: " + popSize + " cross rate: " + crossoverRate + " Mut rate: " + mutationRate);

            avgFitness = bestFitness = -1;
            worstFitness = 2;
            intCount = 0;
        }

        public void evolve() {
            while (bestFitness < bestFit) {
                Console.WriteLine("Evolution count: "+ intCount + " - evolution");
                setFitness();
                crossover();
                completePop();
                mutate();
                updatePop();
                intCount++;
            }
        }

        private void setFitness() {
            double sum = 0;
            for (int i = 0; i < pop.Length; i++) {
                pop[i].setFitness();
                sum += pop[i].fitness;
            }
            avgFitness = sum / popSize;
            bestWorstFitness();
        }

        private void bestWorstFitness() {
            for (int i = 0;i < pop.Length;i++) {
                if (pop[i].fitness > bestFitness) {
                    bestFitness = pop[i].fitness;
                    bestGene = i;
                }
                if (pop[i].fitness < worstFitness) {
                    worstFitness = pop[i].fitness;
                }
            }
            Console.WriteLine("Fitness: avg = " + avgFitness + " best = " + bestFitness 
                + " worst = " + worstFitness + " - evolution "+intCount);
        }

        private int tournament() {
            int[] i = new int[5];
            double fit = -1;
            int count = 0;

            for (int j = 0; j < 5; j++) {
                i[j] = rg.Next(0, pop.Length);
            }

            for (int j = 0; j < 5; j++) {
                if (pop[i[j]].fitness > fit) {
                    fit = pop[i[j]].fitness;
                    count = i[j];
                }
            }
            Console.WriteLine("Tournament  - evolution");

            return count;
        }

        private void crossover() {
            Console.WriteLine("Crossover Started  - evolution");
            double crossoverSize = popSize * crossoverRate;
            Console.WriteLine("Crossover Size: "+crossoverSize);
            for (int i = 0; i < (int)(crossoverSize); i++) {
                int i1 = tournament(), i2 = tournament();
                for (int g = 0; g < 22; g++) {
                    popAux[i].setGeneI(g, pop[i1].getGeneI(g));
                    popAux[i].setGeneI((g + 22), pop[i2].getGeneI(g + 22));
                } 
            }
        }

        private void completePop() {
            double crossoverSize = popSize * crossoverRate;
            for (int i = (int)(crossoverSize); i < popSize; i++) {
                popAux[i].gene = pop[(rg.Next(0, popSize))].gene;
            }
            Console.WriteLine("Complete pop - evolution");
        }

        private void mutate() {
            Console.WriteLine("Mutation started - evolution");
            for (int i = 0; i < popSize; i++) {
                for (int g = 0; g < 44; g++) {
                    int randMutation = rg.Next(0, 100);
                    double mutationSize = mutationRate * 100;
                    if (randMutation < (mutationSize)) {
                        int auxGene = rg.Next(0, (131 + (g * i))) % 2;
                        popAux[i].setGeneI(g, auxGene);
                    }
                }
            }
        }

        private void updatePop() {
            for (int i = 0; i < popSize; i++) {
                pop[i].gene = popAux[i].gene;
            }
            Console.WriteLine("update pop  - evolution");
        }
    }
}
