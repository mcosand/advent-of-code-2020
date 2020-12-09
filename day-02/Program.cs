using System;
using System.Linq;

namespace day_02
{
  class Program
  {
    static void Main(string[] args)
    {
      string[][] lines = System.IO.File.ReadAllLines("input.txt").Select(f => f.Split(' ')).ToArray();

      int count = lines.Select(f =>
      {
        int c = f[2].Where(g => g == f[1][0]).Count();
        int[] range = f[0].Split('-').Select(g => int.Parse(g)).ToArray();
        return c >= range[0] && c <= range[1] ? 1 : 0;
      }).Sum();

      Console.WriteLine(count);

      }
  }
}
