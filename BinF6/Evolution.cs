using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinF6
{
    public class Evolution
    {
        public Chromosome[] pop { get; set; }
        public Chromosome[] popAux { get; set; }

        private Random rg;

        private double mutationRate, crossoverRate, bestFit;

        public double bestFitness { get; set; }
        public double secondBestFitness { get; set; }
        public double avgFitness { get; set; }
        public double worstFitness { get; set; }
        public int intCount { get; set; }
        public int bestGene { get; set; }
        public int secondBestGene { get; set; }
        public int popSize { get; set; }
        public int elit { get; set; }
        public int prefCount { get; set; }
        private int count = 0;

        public Chromosome genePref { get; set; }
        
        public StreamWriter writer { get; set; }

        public Evolution(Chromosome[] pop, Chromosome[] popAux, double mutationRate, double crossoverRate, 
            double bestFit, int popSize, int elit, StreamWriter writer, int prefCount) {

            rg = new Random();
            genePref = new Chromosome(false, writer);

            this.writer = writer;
            this.pop           = pop;
            this.popAux        = popAux;
            this.crossoverRate = crossoverRate;
            this.mutationRate  = mutationRate;
            this.bestFit       = bestFit;
            this.popSize = popSize;
            this.elit = elit;
            this.prefCount = prefCount;

            Console.WriteLine("Pop size: " + popSize + " cross rate: " + crossoverRate + " Mut rate: " + mutationRate);

            avgFitness = bestFitness = secondBestFitness = -1;
            worstFitness = 2;
            intCount = 0;
            write();
        }

        public void evolve() {
            bool running = true;
            while (bestFitness < bestFit && running) {
                Console.WriteLine("Evolution count: "+ intCount + " - evolution");
                writer.WriteLine(" ");
                writer.WriteLine("Evolution count: " + intCount);
                setFitness();
                crossover();
                completePop();
                mutate();
                updatePop();
                intCount++;

                if (bestFitness >= bestFit) { running = false; }
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

            if (elit != 0 || elit != 1)
            {
                secondBestDef();
            }

            Console.WriteLine("Fitness: avg = " + avgFitness + " best = " + bestFitness 
                + " worst = " + worstFitness + " - evolution "+intCount);
            writer.WriteLine("Fitness: avg = " + avgFitness + " best = " + bestFitness
                + " worst = " + worstFitness + " - evolution " + intCount);
        }

        public void secondBestDef()
        {
            for (int i = 0; i < pop.Length; i++)
            {
                if (pop[i].fitness > secondBestFitness && pop[i].fitness < bestFitness)
                {
                    secondBestFitness = pop[i].fitness;
                    secondBestGene = i;
                }
            }
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
            if (elit == 0)
            {
                for (int i = (int)(crossoverSize); i < popSize; i++)
                {
                    popAux[i].gene = pop[(rg.Next(0, popSize))].gene;
                }
            }
            else {
                for (int i = (int)(crossoverSize); i < (popSize - 1); i++)
                {
                    popAux[i].gene = pop[(rg.Next(0, popSize))].gene;
                }
            }
            Console.WriteLine("Complete pop - evolution");
        }

        private void mutate() {
            Console.WriteLine("Mutation started - evolution");
            if (elit == 0)
            {
                regularMutation();    
            }
            else {
               elitismMutation();
            }
        }

        public void regularMutation() {
            for (int i = 0; i < popSize; i++)
            {
                for (int g = 0; g < 44; g++)
                {
                    int randMutation = rg.Next(0, 100);
                    double mutationSize = mutationRate * 100;
                    if (randMutation < (mutationSize))
                    {
                        int auxGene = rg.Next(0, (131 + (g * i))) % 2;
                        popAux[i].setGeneI(g, auxGene);
                    }
                }
            }
        }

        public void elitismMutation() {
            for (int i = 0; i < (popSize - 1); i++)
            {
                for (int g = 0; g < 44; g++)
                {
                    int randMutation = rg.Next(0, 100);
                    double mutationSize = mutationRate * 100;
                    if (randMutation < (mutationSize))
                    {
                        int auxGene = rg.Next(0, (131 + (g * i))) % 2;
                        popAux[i].setGeneI(g, auxGene);
                    }
                }
            }
        }

        private void updatePop() {
            switch (elit) {
                case 0: regular(); break;
                case 1: elitism(); break;
                case 2:
                case 3: preferencialism(); break;
                default: regular(); break;
            }

            Console.WriteLine("update pop  - evolution");
        }

        private void regular() {
            for (int i = 0; i < popSize; i++)
            {
                pop[i].gene = popAux[i].gene;
            }
        }

        private void elitism() {
            for (int i = 0; i < (popSize - 1); i++)
            {
                pop[i].gene = popAux[i].gene;
            }
            pop[(popSize - 1)].gene = pop[bestGene].gene;
        }

        public void preferencialism() {
            for (int i = 0; i < (popSize - 1); i++)
            {
                pop[i].gene = popAux[i].gene;
            }

            if (intCount == 0) {
                genePref.gene = pop[bestGene].gene;
            }

            switch (elit) {
                case 2: mutationPref();  break;
                case 3: secondPref();  break;
                default: mutationPref();  break;
            }
        }

        public void mutationPref() {
            if (count < prefCount && genePref.gene == pop[bestGene].gene)
            {
                pop[(popSize - 1)].gene = pop[bestGene].gene;
                count++;
            }
            else {
                if (genePref.gene != pop[bestGene].gene) {
                    count = 0;
                    genePref.gene = pop[bestGene].gene;
                }
                else {
                    pop[(popSize - 1)].gene = pop[bestGene].gene;
                    for (int g = 0; g < 44; g++)
                    {
                        int randMutation = rg.Next(0, 100);
                        double mutationSize = mutationRate * 100;
                        if (randMutation < (mutationSize))
                        {
                            int auxGene = rg.Next(0, (131 + (g * (int)(DateTime.Now.Second)))) % 2;
                            pop[(popSize - 1)].setGeneI(g, auxGene);
                        }
                    }
                    count = 0;
                    setFitness();
                    genePref.gene = pop[bestGene].gene;
                }
            }
        }

        public void secondPref() {
            if (count < prefCount && genePref.gene == pop[bestGene].gene)
            {
                pop[(popSize - 1)].gene = pop[bestGene].gene;
                count++;
            }
            else {
                if (genePref.gene != pop[bestGene].gene)
                {
                    count = 0;
                    genePref.gene = pop[bestGene].gene;
                }
                else
                {
                    pop[(popSize - 1)].gene = pop[secondBestGene].gene;
                    genePref.gene = pop[secondBestGene].gene;
                }
                count = 0;
            }
        }

        public void write() {
            switch (elit) {
                case 0: writer.WriteLine("Regular Elitism"); break;
                case 1: writer.WriteLine("Elitism"); break;
                case 2: writer.WriteLine("Mutation Preferencialism"); break;
                case 3: writer.WriteLine("Second Best Preferencialism"); break;
                default: writer.WriteLine("Regular Elitism"); break;
            }
        }
    }
}
