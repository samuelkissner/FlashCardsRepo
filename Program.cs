﻿using System;

using System.Collections;

namespace FlashCards
{
    class Program
    {
        static void Main(string[] args)
        {

            CardPile flashCards = new CardPile();
            flashCards.AddCardsToPile(@"C:\Software Engineering\Personal Projects\Repos\FlashCards\FlashCards_C#.csv");
            Card currentCard;

            while (true)
            {
                Console.Clear();
                currentCard = flashCards.getRandomCard();

                if(currentCard == null)
                {
                    ConsoleDisplay.DisplayAndWait("The Card Pile is Empty.");
                    break;
                }
                
                ConsoleDisplay.DisplayAndWait(currentCard.Concept);
                ConsoleDisplay.DisplayAndWait(currentCard.Description);
          

                string userInput = UserPrompts.askToDiscard();
                if (userInput == "y")
                    flashCards.discardCard(currentCard);
            }
        }
    }
}
