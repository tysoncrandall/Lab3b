using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a salesperson name");
    var name = Console.ReadLine();
    Console.WriteLine ("Enter sales amount");
    var sales = Console.ReadLine();
    double sales_amount = Convert.ToDouble(sales);
    double sales_commission = (sales_amount * 0.09) + 200;
    

    if (sales_amount < 3000)
    {
      Console.WriteLine ("Sales commison for " + name + " is $" + sales_commission);
      Console.WriteLine("Performance is poor");
    }
    else if (sales_amount < 5000)
    {
      Console.WriteLine ("Sales commison for " + name + " is $" + sales_commission);
      Console.WriteLine("Performance is average");
    }
    else if (sales_amount < 10000)
    {
      Console.WriteLine ("Sales commison for " + name + " is $" + sales_commission);
      Console.WriteLine("Performance is good");
    }
    else if (sales_amount < 15000)
    {
      Console.WriteLine ("Sales commison for " + name + " is $" + sales_commission);
      Console.WriteLine("Performance is excellent");
    }
    else
    {
      Console.WriteLine ("Sales commison for " + name + " is $" + sales_commission);
      Console.WriteLine("Performance is outstanding");
    }
  }
}