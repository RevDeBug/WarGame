using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WarGame
{
    [Activity(Label = "Pick a card", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class GamePlayActivity : Activity
    {
        public string CardDesc1;
        public string CardDesc2;
        public string CardDesc3;
        public string CardDesc4;
        public string CardDesc5;
        public string CardDesc6;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GamePlay);

            //create a new deck of cards
            Deck.CreateDeck();

            //shuffle that deck of cards
            Deck.Shuffle(3);

            ImageView card1 = FindViewById<ImageView>(Resource.Id.card1);
            ImageView card2 = FindViewById<ImageView>(Resource.Id.card2);
            ImageView card3 = FindViewById<ImageView>(Resource.Id.card3);
            ImageView card4 = FindViewById<ImageView>(Resource.Id.card4);
            ImageView card5 = FindViewById<ImageView>(Resource.Id.card5);
            ImageView card6 = FindViewById<ImageView>(Resource.Id.card6);

            Card selectedCard1 = Deck.player1.NextOf(null, 1);
            Card selectedCard2 = Deck.player2.NextOf(null, 1);
            Card selectedCard3 = Deck.player1.NextOf(null, 2);
            Card selectedCard4 = Deck.player2.NextOf(null, 2);
            Card selectedCard5 = Deck.player1.NextOf(null, 3);
            Card selectedCard6 = Deck.player2.NextOf(null, 3);

            card1.SetImageResource(CardID(selectedCard1));
            card2.SetImageResource(CardID(selectedCard2));
            card3.SetImageResource(CardID(selectedCard3));
            card4.SetImageResource(CardID(selectedCard4));
            card5.SetImageResource(CardID(selectedCard5));
            card6.SetImageResource(CardID(selectedCard6));

            CardDesc1 = selectedCard1.FaceValue.ToString() + " of " + selectedCard1.Suit.ToString();
            CardDesc2 = selectedCard2.FaceValue.ToString() + " of " + selectedCard2.Suit.ToString();
            CardDesc3 = selectedCard3.FaceValue.ToString() + " of " + selectedCard3.Suit.ToString();
            CardDesc4 = selectedCard4.FaceValue.ToString() + " of " + selectedCard4.Suit.ToString();
            CardDesc5 = selectedCard5.FaceValue.ToString() + " of " + selectedCard5.Suit.ToString();
            CardDesc6 = selectedCard6.FaceValue.ToString() + " of " + selectedCard6.Suit.ToString();

            card1.Click += Card1_Click;
            card2.Click += Card2_Click;
            card3.Click += Card3_Click;
            card4.Click += Card4_Click;
            card5.Click += Card5_Click;
            card6.Click += Card6_Click;
        }

        private void Card1_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc1);
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc2);
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc3);
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc4);
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc5);
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            throw new Exception(CardDesc6);
        }

        public int CardID(Card card)
        {
            switch (card.FaceValue)
            {
                #region Aces
                case Card.Rank.Ace:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsAce;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsAce;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsAce;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesAce;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;

                    }
                #endregion

                #region Two
                case Card.Rank.Two:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs2;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds2;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts2;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades2;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Three
                case Card.Rank.Three:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs3;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds3;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts3;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades3;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Four
                case Card.Rank.Four:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs4;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds4;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts4;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades4;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Five
                case Card.Rank.Five:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs5;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds5;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts5;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades5;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Six
                case Card.Rank.Six:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs6;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds6;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts6;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades6;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Seven
                case Card.Rank.Seven:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs7;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds7;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts7;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades7;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }

                #endregion

                #region Eight
                case Card.Rank.Eight:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs8;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds8;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts8;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades8;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }

                #endregion

                #region Nine
                case Card.Rank.Nine:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs9;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds9;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts9;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades9;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Ten
                case Card.Rank.Ten:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.Clubs10;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.Diamonds10;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.Hearts10;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.Spades10;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Jack
                case Card.Rank.Jack:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsJ;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsJ;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsJ;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesJ;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region King
                case Card.Rank.King:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsK;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsK;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsK;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesK;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                #region Queen
                case Card.Rank.Queen:
                    {
                        switch (card.Suit)
                        {
                            case Card.SuitType.Clubs:
                                {
                                    return Resource.Drawable.ClubsQ;
                                }
                            case Card.SuitType.Diamonds:
                                {
                                    return Resource.Drawable.DiamondsQ;
                                }
                            case Card.SuitType.Hearts:
                                {
                                    return Resource.Drawable.HeartsQ;
                                }
                            case Card.SuitType.Spades:
                                {
                                    return Resource.Drawable.SpadesQ;
                                }
                            default:
                                {
                                    return Resource.Drawable.Joker;
                                }
                        }
                        break;
                    }
                #endregion

                default:
                    {
                        return Resource.Drawable.Joker;
                    }
            }
        }
    }
}