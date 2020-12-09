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
        string code = f[2];
        char c = f[1][0];
        int[] range = f[0].Split('-').Select(g => int.Parse(g)).ToArray();
        return code[range[0] - 1] == c ^ code[range[1] - 1] == c ? 1 : 0;
      }).Sum();

      Console.WriteLine(count);

      }
  }
}
