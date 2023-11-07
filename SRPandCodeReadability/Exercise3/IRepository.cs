namespace Exercise3;

internal interface IRepository
{
}

internal sealed class Repository : IRepository
{
  private IList<CustomerFinancialData> _data = new List<CustomerFinancialData>();
  public Repository()
  {
    List<Customer> customers = new List<Customer>();
    Random random = new Random();
    for (int i = 0; i < 10; i++)
    {
      customers.Add(new Customer(i, $"customer {i}", $"group {i % 3}"));
    }
    for (int i = 0; i < 1000; i++)
    {
      var customer = customers[i % 10];
      _data.Add(new CustomerFinancialData(customer, DateTime.Now.AddMonths(-i % 12),
        random.Next(1000, customer.Group == "group 0" ? 2000 : 100000),
        random.Next(1000, 10000)));
    }
  }
}

internal struct CustomerFinancialData
{
  internal Customer Customer { get; }
  internal DateTime Date { get; }
  internal decimal Income { get; }
  internal decimal Expenses { get; }
  public CustomerFinancialData(Customer customer, DateTime date, decimal income, decimal expenses)
  {
    Customer = customer;
    Date = date;
    Income = income;
    Expenses = expenses;
  }
}

internal struct Customer
{
  internal int Id { get; }
  internal string Name { get; }
  internal string Group { get; }
  public Customer(int id, string name, string group)
  {
    Id = id;
    Name = name;
    Group = group;
  }
}
