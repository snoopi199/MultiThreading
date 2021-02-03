using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading {
  class Program {

    static private void Dowork() {

      while (true)
        Console.WriteLine("11");
    }

    static void Main(string[] args) {

      var delegat = new ThreadStart(Dowork);
      var thread = new Thread(delegat);

      thread.Start();
      Console.WriteLine("Method Dowork() is Invoked");
      Console.ReadKey();
    }
  }

  public class Invoker {

    private void Dowork() {

      while (true)
        Console.WriteLine("11");
    }

    public void Main() {

      var delegat = new ThreadStart(Dowork);
      var thread = new Thread(delegat);

      thread.Start();
      Console.WriteLine("Method Dowork() is Invoked");
    }
  }
}
