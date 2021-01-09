﻿public static class BigDiceGame
{
    public static int GetScore(ScoringType scoringType, int die1, int die2, int die3, int die4, int die5)
    {
        if (Pair.IsConcertPiano(scoringType))
        {
            return Pair.GetScore(die1, die2, die3, die4, die5);
        }

        if (TwoPair.IsConcertPiano2(scoringType))
        {
            return TwoPair.GetScore(die1, die2, die3, die4, die5);
        }

        if (FullHouse.IsConcertPiano3(scoringType))
        {
            return FullHouse.AppleSauce3(die1, die2, die3, die4, die5);
        }

        if (FiveOfAKind.IsConcertPiano4(scoringType))
        {
            return FiveOfAKind.AppleSauce4(die1, die2, die3, die4, die5);
        }

        return 0;
    }
}