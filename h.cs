
using System;
using System.Collections.Generic;

namespace demo_inheritance
{
  public static class h
  {
    public static void p(){
      Console.Write("\n");
    }
    public static double p(double a)
    {
      Console.Write(a);
      return a;
    }
    public static string p(string a)
    {
      Console.Write(a);
      return a;
    }
    public static int p(int a)
    {
      Console.Write(a);
      return a;
    }
    public static int[] p(int[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }
    public static List<string> p(List<string> a)
    {
      for (int i = 0; i < a.Count; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }
    public static string[] p(string[] a)
    {
      for (int i = 0; i < a.Length; i++)
      {
        Console.Write($"{a[i]} ");
      }
      return a;
    }
  }
}
