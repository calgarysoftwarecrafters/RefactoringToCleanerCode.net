﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType scoringType, int dieOne, int dieTwo, int dieThree, int dieFour, int dieFive)
    {
        if (CalculatePairScore.ShouldCalculate(scoringType))
        {
            return CalculatePairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (CalculateTwoPairScore.ShouldCalculate(scoringType))
        {
            return CalculateTwoPairScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        if (CalculateFullHouseScore.Nonsense3(scoringType))
        {
            return CalculateFullHouseScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }
        if (CalculateFiveOfAKindScore.Nonsense4(scoringType))
        {
            return CalculateFiveOfAKindScore.Calculate(dieOne, dieTwo, dieThree, dieFour, dieFive);
        }

        return 0;
    }
}