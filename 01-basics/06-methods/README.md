# C# Methods  
**Folder:** 01-basics/06-methods  
**Description:** Practice programs covering C# methods, their declaration, parameters, return types, and usage from `Main()`. Demonstrates how methods help in modularizing code, improving reusability, and keeping logic organized.  

---

## Method Signature  
**Path:** `06-methods/01-method-signature/`  
**Description:** Demonstrates the structure of a method signature, including access modifier, return type, method name, parameters, and body. Shows how to call methods from `Main()` with and without parameters, and how to handle return values.  
**Programs / Examples:**  
- **FullName** → Takes first name and last name as parameters, returns the combined full name string, and prints it from `Main()`.  
- **CalculateAverage** → Accepts three subject marks, calculates the average, and returns it. `Main()` prints the average and checks pass/fail status.  

---

## Parameters – Value Parameters  
**Path:** `06-methods/02-parameters/01-value-parameters/`  
**Description:** Demonstrates how value parameters work in C#. When a value parameter is passed to a method, only a **copy** of the variable is sent. Any changes inside the method do not affect the original variable outside.  
**Programs / Examples:**  
- **Square** → Accepts an integer, calculates its square, and prints the squared value inside the method. Outside, the original variable remains unchanged.  
- **Cube** → Accepts an integer, calculates its cube, and prints the cubed value inside the method. Outside, the original variable remains unchanged.  

---

## Parameters – Ref Parameters  
**Path:** `06-methods/02-parameters/02-ref-parameters/`  
**Description:** Demonstrates how reference parameters (`ref`) work in C#. When a variable is passed with `ref`, the method receives the actual memory reference, allowing it to update the original variable directly. Changes inside the method are reflected outside as well.  
**Programs / Examples:**  
- **DoubleValue** → Takes an integer by reference and multiplies it by 2 inside the method. The original variable is updated after the method call.  
- **SwapNumbers** → Accepts two integers by reference and swaps their values inside the method. The updated values are reflected outside the method.  

---

## Parameters – Out Parameters  
**Path:** `06-methods/02-parameters/03-out-parameters/`  
**Description:** Demonstrates how `out` parameters allow methods to return multiple values. Useful when a method needs to produce more than one output result without using tuples or custom classes.  
**Programs / Examples:**  
- **Divide** → Accepts two integers (dividend, divisor). Returns both quotient and remainder using `out` parameters. Includes validation for invalid inputs and zero divisor.  
- **FindMinMax** → Accepts an integer array. Returns the smallest and largest values in the array using `out` parameters.  

---

## Parameters – In Parameters  
**Path:** `06-methods/02-parameters/04-in-parameters/`  
**Description:** Demonstrates the use of `in` parameters in C#. These parameters are passed **by reference** but are **read-only** inside the method. This ensures that the method can access the original variable without modifying it, providing both performance benefits and immutability guarantees.  
**Programs / Examples:**  
- **ShowCoordinates** → Accepts two integers as `in` parameters and prints them inside the method. Demonstrates that trying to modify them inside the method results in a compile-time error.  
- **CalculateDistance** → Takes two coordinate points `(x1, y1)` and `(x2, y2)` as `in` parameters and calculates the Euclidean distance between them. Confirms that original variables remain unchanged after method execution.  

---

## Return Value  
**Path:** `06-methods/03-return-value/practice/`  
**Description:** Demonstrates how methods can return values in C#. A return type defines what kind of value a method gives back to the caller. If no value is returned, the return type is `void`. Return values make methods more reusable, allow calculations or checks to be passed back to `Main()`, and improve program modularity.  
**Programs / Examples:**  
- **Square** → Accepts an integer and returns its square as an integer.  
- **IsEven** → Accepts an integer and returns a boolean indicating if the number is even or not.  
- **GetFullName** → Accepts first and last names as parameters and returns the combined full name string.  
- **Divide** → Accepts two integers (dividend and divisor) and returns the result as a double. Includes handling for zero divisor.  


---

## Method Overloading  
**Path:** `06-methods/04-method-overloading/`  
**Description:** Demonstrates how multiple methods can share the same name but differ in their parameter lists (number or types of parameters). Method overloading allows writing clean, reusable, and intuitive code without needing separate method names for similar logic.  
**Programs / Examples:**  
- **AreaCalculator** → A class with overloaded methods `CalculateArea`:  
  - `CalculateArea(int side)` → Calculates the area of a square.  
  - `CalculateArea(int length, int width)` → Calculates the area of a rectangle.  
  - `CalculateArea(double radius)` → Calculates the area of a circle.  
  - Demonstrates method overloading by using the same method name with different parameter lists. Includes input validation with retries and default values for robustness.

---

## Instance & Static Methods  
**Path:** `06-methods/05-instance-static/`  
**Description:** Demonstrates the difference between instance methods and static methods in C#. Instance methods are called via an object of the class, while static methods are called using the class name directly. This helps in understanding method accessibility and memory behavior.  
**Programs / Examples:**  
- **Converter.ToFahrenheit** → Instance method. Accepts a Celsius temperature and returns the Fahrenheit equivalent. Called via a `Converter` object.  
- **Converter.ToCelsius** → Static method. Accepts a Fahrenheit temperature and returns the Celsius equivalent. Called using the `Converter` class name without creating an object.  

---

## Access Modifiers  
**Path:** `06-methods/06-access-modifiers/`  
**Description:** Demonstrates the use of access modifiers (`public`, `private`) in C#. Shows how private members are hidden from external access and can only be used internally within the class, while public methods expose controlled functionality to the outside world.  
**Programs / Examples:**  
- **BankAccount** →  
  - `Deposit(double amount)` → Public method. Adds money to the account after validating input. Internally calls `CalculateInterest()` before updating the balance.  
  - `Withdraw(double amount)` → Public method. Deducts money from the account if sufficient funds exist, with input validation.  
  - `DisplayBalance()` → Public method. Shows the current account balance.  
  - `CalculateInterest()` → Private method. Calculates and returns interest, used only within `Deposit`.  
  - Demonstrates how `private` restricts direct access to sensitive data (like `balance`) and ensures that modifications happen only through controlled, validated public methods.  

---

## Recursion & Params Keyword  
**Path:** `06-methods/07-side-topics/01-recursion-params/`  
**Description:** Demonstrates the use of recursion to solve problems that can be broken into smaller sub-problems, and the `params` keyword to allow a method to accept a variable number of arguments. These techniques help write flexible and reusable code.  
**Programs / Examples:**  
- **Factorial** → Uses recursion to calculate the factorial of a number. The base case stops recursion when `n == 0`, otherwise calls itself with `n - 1`.  
- **Average** → Uses the `params` keyword to accept any number of integer arguments and calculate their average. Handles the case when no numbers are passed.  

---

## Optional, Named, Local & Expression-Bodied Methods  
**Path:** `06-methods/07-side-topics/02-optional-named-local-expression-bodied/`  
**Description:** Demonstrates multiple modern method features in C#: optional parameters, named parameters, local functions, and expression-bodied methods. Improves readability, modularity, and compactness of code.  
**Programs / Examples:**  
- **GetUserDetails** → Demonstrates a local function (`FullName`) and an expression-bodied method to return a formatted string of the user’s full name.  
- **InputValidation** → Shows a local function (`Validate`) to check input conditions (e.g., price > 0) and return a boolean for validation status.  
- **OrderPizza** → Uses optional parameters (`size`, `toppings`) with defaults and demonstrates calling with named parameters to override only specific values.  

---
