namespace Exercise2;
internal interface IRepository
{
  IReadOnlyList<CustomerFinancialData> getCustomerFinancialDatas(int customerId, int forLastMonths);
}

internal sealed class Repository: IRepository
{
  private IList<CustomerFinancialData> _data = new List<CustomerFinancialData>();
  public Repository()
  {
    Random random = new Random();
    for (int i = 0; i < 1000; i++)
    {
      _data.Add(new CustomerFinancialData(i%3, DateTime.Now.AddMonths(-i%12), random.Next(1000, 100000), random.Next(1000, 10000)));
    }
  }
  public IReadOnlyList<CustomerFinancialData> getCustomerFinancialDatas(int customerId, int forLastMonths)
  {
    DateTime fromDate = DateTime.Now.AddMonths(-forLastMonths).AddHours(-1);
    return _data.Where(x => x.CustomerId == customerId && x.Date >= fromDate).ToList().AsReadOnly();
  }
}

internal struct CustomerFinancialData
{
  internal int CustomerId { get; }
  internal DateTime Date { get; }
  internal decimal Income { get; }
  internal decimal Expenses { get; }
  public CustomerFinancialData(int customerId, DateTime date, decimal income, decimal expenses)
  {
    CustomerId = customerId;
    Date = date;
    Income = income;
    Expenses = expenses;
  }
}
