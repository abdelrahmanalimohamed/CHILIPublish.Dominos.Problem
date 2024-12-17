namespace CHILIPublish.Dominos.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int, int)> dominoes = new List<(int, int)> { (2, 1), (2, 3), (1, 3) };

            if (FindCircularDominoChain(dominoes, out List<(int, int)> chain))
            {
                Console.WriteLine("Valid Circular Domino Chain:");
                foreach (var domino in chain)
                    Console.Write($"[{domino.Item1}|{domino.Item2}] ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No valid circular domino chain is possible.");
            }
        }

        static bool FindCircularDominoChain(List<(int, int)> dominoes, out List<(int, int)> chain)
        {
            chain = new List<(int, int)>();

            var degreeCount = new Dictionary<int, int>();
            foreach (var (a, b) in dominoes)
            {
                if (!degreeCount.ContainsKey(a)) degreeCount[a] = 0;
                if (!degreeCount.ContainsKey(b)) degreeCount[b] = 0;
                degreeCount[a]++;
                degreeCount[b]++;
            }

            if (degreeCount.Values.Any(degree => degree % 2 != 0))
            {
                return false;
            }

            var used = new bool[dominoes.Count];
            foreach (var (startA, startB) in dominoes)
            {
                used[0] = true;
                chain.Add((startA, startB));
                if (Backtrack(dominoes, chain, used, startB, startA))
                    return true;
                chain.RemoveAt(chain.Count - 1);
                used[0] = false;
            }

            return false;
        }

        static bool Backtrack(List<(int, int)> dominoes, List<(int, int)> chain, bool[] used, int currentEnd, int start)
        {
            if (chain.Count == dominoes.Count)
            {
                return chain[0].Item1 == currentEnd || chain[0].Item2 == currentEnd;
            }

            for (int i = 0; i < dominoes.Count; i++)
            {
                if (used[i]) continue;
                var (a, b) = dominoes[i];

                if (a == currentEnd || b == currentEnd)
                {
                    used[i] = true;
                    chain.Add(a == currentEnd ? (a, b) : (b, a));
                    if (Backtrack(dominoes, chain, used, a == currentEnd ? b : a, start))
                        return true;
                    chain.RemoveAt(chain.Count - 1);
                    used[i] = false;
                }
            }

            return false;
        }
    }
}
