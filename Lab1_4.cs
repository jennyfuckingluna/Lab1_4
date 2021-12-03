
using System;

// IPerson Interface
public interface IPerson
{
  int PayMoney (int toPay);
}

// Person class implements IPerson
public class Person:IPerson
{

// Auto implemented property
  public int Money
  {
    get;
    set;
  }
//   constructor
  public Person ()
  {
    this.Money = 10000;
  }
//   virtual method
  public virtual int PayMoney (int toPay)
  {
    this.Money = this.Money - toPay;
    return this.Money;
  }
}

// Employee Class implements person class
public class Employee:Person
{
  public int EmployeeID;
  // Employee constructor calling Person constructor
  public Employee (int id):base ()
  {
    this.EmployeeID = id;
  }
  // override virtual method
  public override int PayMoney (int toPay)
  {
    int tempMoney = (toPay / 2);
    this.Money = this.Money - tempMoney;
    return this.Money;
  }
}

class MainClass
{

//  static method to add Money
  public static void AddMoney (Person P, int amount)
  {
    P.Money = P.Money + amount;
  }
  static void Main ()
  {
    Console.WriteLine ("-- Person Class Test Case --");
    Console.WriteLine ();
    Person P = new Person ();
    Console.WriteLine ("Initial Money : " + P.Money);
    AddMoney (P, 1000);
    Console.WriteLine ("After Adding Money : " + P.Money);
    int money = P.PayMoney (100);
    Console.WriteLine ("Final Money : " + money);
    Console.WriteLine ();
    Console.WriteLine ("-- Employee Class Test Case --");
    Console.WriteLine ();
    Employee E = new Employee (10);
    Console.WriteLine ("Initial Money : " + E.Money);
    int employeemoney = E.PayMoney (9);
    Console.WriteLine ("Final Money : " + employeemoney);
  }
}
