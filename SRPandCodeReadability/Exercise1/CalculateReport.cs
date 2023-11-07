namespace Exercise1;

internal sealed class CalculateReport
{
  private readonly IList<decimal> _incomes;
  private readonly IList<decimal> _expenses;
  public CalculateReport(IList<decimal> incomes, IList<decimal> expenses)
  {
    _incomes = incomes;
    _expenses = expenses;

  }
  public decimal CalculateAvgIncomes()
  {
    return _incomes.Sum() / _incomes.Count;
  }
        
  public decimal CalculateAvgExpenses()
  {
    return _expenses.Sum() / _expenses.Count;
  }
}
