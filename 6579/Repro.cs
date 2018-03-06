using System;
using System.Collections.Generic;

public class Foo {
	public static int Main(string[] args) {
		Console.WriteLine((typeof(Dictionary<string, object>).GetInterface("System.Collections.IDictionary", true) != null));
		return 0;
	}
}
