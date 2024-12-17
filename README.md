# Circular Domino Chain Challenge 🚀

## A Task for CHILI publish
## Problem Description

 A circular domino chain is an arrangement where:

1. The dots on one half of a domino match the dots on the neighboring half of an adjacent domino.
2. The chain forms a **circle**, meaning the first and last domino must connect.

For example:
- Given the dominoes `[2|1], [2|3], [1|3]`, a valid circular chain could be:
   - `[1|2] [2|3] [3|1]`  
   - or `[3|2] [2|1] [1|3]`  
   - or any equivalent sequence.

If no valid circular chain is possible, your program should output a message indicating that.

---

## Input

- A set of dominoes represented as pairs of integers.  
- Example: `[(2, 1), (2, 3), (1, 3)]`

---

## Output

- A valid circular domino chain if it exists.  
- Example:
  ```
  Valid Circular Domino Chain:
  [1|2] [2|3] [3|1]
  ```
- If no chain is possible:
  ```
  No valid circular domino chain is possible.
  ```

---

## Example Scenarios

### Example 1: Valid Circular Chain
**Input:**  
```
[ (2, 1), (2, 3), (1, 3) ]
```

**Output:**  
```
Valid Circular Domino Chain:
[2|1] [1|3] [3|2]
```

### Example 2: No Circular Chain
**Input:**  
```
[ (1, 2), (4, 1), (2, 3) ]
```

**Output:**  
```
No valid circular domino chain is possible.
```

---

## Requirements

- **Language**: C#  
- **Skills**:
   - Graph theory
   - Recursive algorithms (Backtracking)
- **Key Constraints**:
   - Dominoes are represented as tuples `(a, b)`.
---

## Code Implementation

Here’s a starting template for your C# implementation:

```csharp
using System;
using System.Collections.Generic;

class DominoCircle
{
    static void Main(string[] args)
    {
        // Example input
        List<(int, int)> dominoes = new List<(int, int)> { (2, 1), (2, 3), (1, 3) };

        // Solve the problem
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

    // Helper methods...
}
```

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/circular-domino-chain.git
   cd circular-domino-chain
   ```

2. Open the project in your favorite C# editor (e.g., Visual Studio, VS Code).

3. Run the program.

4. Modify the `dominoes` input in the `Main` method to test with different sets.

---
