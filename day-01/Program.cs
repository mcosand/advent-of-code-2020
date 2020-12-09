﻿using System;
using System.Linq;

namespace day_01
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] lines = System.IO.File.ReadAllLines("input.txt").Select(f => int.Parse(f)).ToArray();

      for (var i=0;i<lines.Length;i++)
      {
        for (var j=0;j<lines.Length;j++)
        {
          if (lines[i] + lines[j] == 2020)
          {
            Console.WriteLine($"{i} {j} {lines[i] * lines[j]}");
            break;
          }
        }
      }
    }
  }
}
