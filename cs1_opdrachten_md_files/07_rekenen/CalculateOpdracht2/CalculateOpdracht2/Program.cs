﻿using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 2;


            //koop 2 controllers


            //hij is in voorraad snel kopen!
            int ps5 = 1;

            //koop 1 ps5


            //koop de games:

            int eldenRing = 1;

            int shantae = 1;

            int spongebob = 1;


            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            spongebob -= 1;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;
           
            
            // controllersInMandje keer controllerPrijs
            double totaalControllerPrijs = controllerPrijs * controllersInMandje;


            // game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            double totaalGamePrijs = (eldenRing + shantae + spongebob) * gamePrijs;
            
            double totaalps5prijs = ps5 * ps5Prijs;


            double totaalPrijs = totaalps5prijs + totaalGamePrijs + totaalControllerPrijs;// tel hier alles bij elkaar op
            Console.WriteLine(totaalPrijs);
            //er moet nu 759.95 staan
        }
    }
}