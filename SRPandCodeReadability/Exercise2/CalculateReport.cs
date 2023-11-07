namespace Exercise2;

internal sealed class CalculateReport
{
  private readonly IRepository _repository = new Repository();
  /// <summary>
  /// 
  /// </summary>
  /// <param name="customerId"></param>
  /// <param name="forLastMonths"></param>
  /// <returns>[CustomerId]: Total Profit: [TotalProfit], Total Income: [Total Income], Avg Profit: [AvgProfit]</returns>
  internal string GenerateReport(int customerId, int forLastMonths = 12)
  {
    return $@"{customerId} 
Total Profit: {_repository.getCustomerFinancialDatas(customerId, forLastMonths).Sum(x => x.Income) - _repository.getCustomerFinancialDatas(customerId, forLastMonths).Sum(x => x.Expenses):n}
Total Income: {_repository.getCustomerFinancialDatas(customerId, forLastMonths).Sum(x => x.Income):n}
Avg Profit: {(_repository.getCustomerFinancialDatas(customerId, forLastMonths).Sum(x => x.Income) - _repository.getCustomerFinancialDatas(customerId, forLastMonths).Sum(x => x.Expenses)) / forLastMonths:n}";
  }
}
