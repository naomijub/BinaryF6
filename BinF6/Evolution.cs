﻿using System;
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
        public double avgFitness { get; set; }
        public double worstFitness { get; set; }
        public int intCount { get; set; }
        public int bestGene { get; set; }
        public int popSize { get; set; }
        public int elit { get; set; }
        
        public StreamWriter writer { get; set; }

        public Evolution(Chromosome[] pop, Chromosome[] popAux, double mutationRate, double crossoverRate, 
            double bestFit, int popSize, int elit, StreamWriter writer) {

            rg = new Random();

            this.writer = writer;
            this.pop           = pop;
            this.popAux        = popAux;
            this.crossoverRate = crossoverRate;
            this.mutationRate  = mutationRate;
            this.bestFit       = bestFit;
            this.popSize = popSize;
            this.elit = elit;

            Console.WriteLine("Pop size: " + popSize + " cross rate: " + crossoverRate + " Mut rate: " + mutationRate);

            avgFitness = bestFitness = -1;
            worstFitness = 2;
            intCount = 0;
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
            Console.WriteLine("Fitness: avg = " + avgFitness + " best = " + bestFitness 
                + " worst = " + worstFitness + " - evolution "+intCount);
            writer.WriteLine("Fitness: avg = " + avgFitness + " best = " + bestFitness
                + " worst = " + worstFitness + " - evolution " + intCount);
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
    }
}
