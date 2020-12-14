using System;
using System.Collections.Generic;
using System.Linq;

namespace day_03
{
  class Program
  {
    static void Main(string[] args)
    {
      var tests = new List<Tuple<int, int>>()
      {
        new Tuple<int,int>(1, 1),
        new Tuple<int,int>(3, 1),
        new Tuple<int,int>(5, 1),
        new Tuple<int,int>(7, 1),
        new Tuple<int,int>(1, 2)
      };

      var lines = System.IO.File.ReadAllLines("input.txt");

      long mult = 1;
      for (int i=0;i<tests.Count;i++)
      {
        int x = 0, y = 0;
        int count = 0;

        while (true)
        {
          x = (x + tests[i].Item1) % lines[0].Length;
          y += tests[i].Item2;
          if (y >= lines.Length) break;

          count += lines[y][x] == '#' ? 1 : 0;
        };

        Console.WriteLine(count);
        mult *= count;
      }
      Console.WriteLine(mult);
    }
  }
}
