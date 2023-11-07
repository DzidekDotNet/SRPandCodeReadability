namespace SRPandCodeReadability.CohesionExamples
{
    internal class CohesionExample
    {
        private readonly int _lastYearTurnoverRate;
        private readonly int _lastYearIncome;

        private int LastYearTurnoverRate => _lastYearTurnoverRate;
        private int LastYearIncome => _lastYearIncome;

        public CohesionExample(int lastYearTurnoverRate, int lastYearIncome)
        {
            _lastYearTurnoverRate = lastYearTurnoverRate;
            _lastYearIncome = lastYearIncome;
        }

        public int CalculateAvgMonthlyTurnoverRate()
        {
            return LastYearTurnoverRate / 12;
        }
        
        public int CalculateAvgMonthlyIncome()
        {
            return LastYearIncome / 12;
        }

    }
}
