// See https://aka.ms/new-console-template for more information

using Exercise1;
var datas = new Repository().getCustomerFinancialDatas(1, 12);
var reportGenerator = new CalculateReport(datas.Select(x => x.Income).ToList(), datas.Select(x => x.Expenses).ToList());
Console.WriteLine($"Avg incomes: {reportGenerator.CalculateAvgIncomes()}{reportGenerator.CalculateAvgExpenses()}");
