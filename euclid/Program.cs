﻿using System;

namespace euclid {
	
	class EuclidAlgorithm {
		public static int GreatestCommonDivisor(int m, int n) {
			// Require that both m and n be positive
			if (m < 0 || n < 0) {
				throw new ArgumentException ();
			}

			int r = m % n; // E1 pg2

			if (r == 0) {
				return n; // E2
			} else {
				return GreatestCommonDivisor (n, r); // E3
			}
		}
	}

	class Euclid {
		static void Main() {
			int result = EuclidAlgorithm.GreatestCommonDivisor(35, 110);

			Console.Write(result);

			int fail = EuclidAlgorithm.GreatestCommonDivisor(-3, 22);
		}
	}
}