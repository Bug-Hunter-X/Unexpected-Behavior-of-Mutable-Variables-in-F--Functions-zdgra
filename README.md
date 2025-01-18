# F# Mutable Variable Bug

This repository demonstrates a common issue with mutable variables in F# functions. When mutable variables are passed as arguments, the function may not modify the original variables if they are not passed by reference.

The file `bug.fs` contains code exhibiting this unexpected behavior. The file `bugSolution.fs` provides a solution to this problem, clearly illustrating how to correctly work with mutable variables and references in F# functions.  This example highlights the importance of understanding the difference between value passing and reference passing in F#.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` and examine the code.
3. Compile and run the code, observing the unexpected output.
4. Open `bugSolution.fs` and see how the issue is resolved by using references.