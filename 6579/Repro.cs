using System;
using System.Collections.Generic;

public class Foo {
	public static int Main(string[] args) {
		Console.WriteLine(
			string.Format(
				"Case #0: was: {0}, expected: {1}",
				(typeof(Dictionary<string, object>).GetInterface("System.Collections.IDictionary", true) != null),
				true
			)
		);
		Console.WriteLine(
			string.Format(
				"Case #1: was: {0}, expected: {1}",
				(typeof(Dictionary<string, object>).GetInterface("System.Collections.Idictionary", true) != null),
				true
			)
		);
		Console.WriteLine(
			string.Format(
				"Case #2: was: {0}, expected: {1}",
				(typeof(Dictionary<string, object>).GetInterface("System.Collections.IDictionary", false) != null),
				true
			)
		);
		Console.WriteLine(
			string.Format(
				"Case #3: was: {0}, expected: {1}",
				(typeof(Dictionary<string, object>).GetInterface("System.Collections.Idictionary", false) != null),
				false
			)
		);
		return 0;
	}
}
