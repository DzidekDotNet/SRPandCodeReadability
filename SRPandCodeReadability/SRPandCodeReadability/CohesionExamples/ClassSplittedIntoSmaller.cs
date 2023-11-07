namespace SRPandCodeReadability.CohesionExamples
{
    internal class TurnoverRate
    {
        private readonly int _lastYearTurnoverRate;

        private int LastYearTurnoverRate => _lastYearTurnoverRate;

        public TurnoverRate(int lastYearTurnoverRate)
        {
            _lastYearTurnoverRate = lastYearTurnoverRate;
        }

        public int CalculateAvgMonthlyTurnoverRate()
        {
            return LastYearTurnoverRate / 12;
        }
    }

    internal class Income
    {
        private readonly int _lastYearIncome;

        private int LastYearIncome => _lastYearIncome;

        public Income(int lastYearIncome)
        {
            _lastYearIncome = lastYearIncome;
        }

        public int CalculateAvgMonthlyIncome()
        {
            return LastYearIncome / 12;
        }

    }
}
