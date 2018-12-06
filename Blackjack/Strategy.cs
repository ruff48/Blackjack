﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Strategy : IComparable<Strategy>
    {
        private List<string> playerCards = new List<string>();
        private string dealerCard { get; set; }

        public Strategy() { }

        /// <summary>
        /// List of basic strategy to guide the player in their decision.
        /// This method strictly utilizes the first two cards in the list of 'handVals'
        /// to determine which strategy to provide to the player.
        /// 
        /// Strategy Reference: https://www.blackjackapprenticeship.com/blackjack-strategy-charts/
        /// Feel free to change this method of strategy if you feel that there is a better approach.
        /// 
        /// </summary>
        /// <returns></returns>
        public string Hints(string playerC0, string playerC1, string dealerC1)
        {
            playerCards.Add(playerC0);
            playerCards.Add(playerC1);
            dealerCard = dealerC1;
            string hint = "";

            if (playerCards[0] == "Assets/A_C.png" && playerCards[1] == "Assets/T_C.png" && dealerCard == "Assets/5_C.png")
            {
                hint = "Tip: Doubledown";
            }

            //if (playerCar < 17 && dealer.handValue >= 17)
            //{
            //    strategy = "Book says to hit";
            //}

            //else if (player.handValue == 11)
            //{
            //    strategy = "Book says to double down";
            //}

            //else if (player.handValue >= 9 && player.handValue <= 11 && dealer.handValue == 5 || dealer.handValue == 6)
            //{
            //    strategy = "Book says to double down";
            //}

            playerCards.Clear();
            return hint;
        }

        public int CompareTo(Strategy other)
        {
            throw new NotImplementedException();
        }
    }
}
