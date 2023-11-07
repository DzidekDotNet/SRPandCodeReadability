namespace SRPandCodeReadability.Refactoring;

public interface IService
{
  void DoSomething();
}
public class Type1Service: IService
{
  public void DoSomething() { }
}
public class Type2Service: IService
{
  public void DoSomething() { }
}
public class Type3Service: IService
{
  public void DoSomething() { }
}
public enum ObjectType
{
  Type1,
  Type2,
  Type3
}
public class TwoOrThreeOccuranceRules {
  public ObjectType Type { get; }
  public void Method1()
  {
    switch (Type)
    {
      case ObjectType.Type1:
        //your code with multiple lines
        break;
      case ObjectType.Type2:
        //your code with multiple lines
        break;
      case ObjectType.Type3:
        //your code with multiple lines
        break;
    }
  }
  
  public void Method2()
  {
    if (Type == ObjectType.Type1)
    {
      // your code with multiple lines
      return;
    }
    if (Type == ObjectType.Type2)
    {
      // your code with multiple lines
      return;
    }
    if (Type == ObjectType.Type3)
    {
      // your code with multiple lines
      return;
    }
  }
  
  public void Method3()
  {
    switch (Type)
    {
      case ObjectType.Type1:
        new Type1Service().DoSomething();
        break;
      case ObjectType.Type2:
        new Type2Service().DoSomething();
        break;
      case ObjectType.Type3:
        new Type3Service().DoSomething();
        break;
    }
  }
}
