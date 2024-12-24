# Uncommon C# Bug: AccessingUninitializedProperty

This repository demonstrates a subtle bug in C# that can be easily overlooked: accessing a property before it's been assigned a value.

## The Bug
The `Bug.cs` file contains a class with a property `MyProperty`. The `MyMethod` attempts to access `MyProperty` before assigning a value to it.  Depending on the context and how the class is used, this can lead to unexpected results or even exceptions.

## The Solution
The `BugSolution.cs` file shows the corrected code.  The property is now initialized before it's used. Alternatively, you could use null conditional operator or provide a default value in property initialization.

## How to Run
1. Clone this repository.
2. Open the solution in your favorite C# IDE (Visual Studio, Rider).
3. Build and run the project to observe the behavior of both the buggy and corrected code.

This example highlights the importance of initializing properties before using them to prevent unexpected behavior and runtime errors.  