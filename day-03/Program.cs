using System;
using System.Linq;

namespace day_03
{
  class Program
  {
    static void Main(string[] args)
    {
      int count = System.IO.File.ReadAllLines("input.txt")
        .Skip(1)
        .Select((line, idx) =>
        {
          bool isTree = line[((idx + 1) * 3) % line.Length] == '#';
          Console.WriteLine(isTree);
          return isTree ? 1 : 0;
        })
    .Sum();
    }
  }
}
