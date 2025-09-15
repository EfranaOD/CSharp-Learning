# C# Data Types  
**Folder:** 01-basics/05-datatypes  
**Description:** Practice programs covering different C# data types, their memory behavior, ranges, and literal usage. Demonstrates how value types and reference types differ, and how integral/floating types behave with limits, suffixes, and casting.  

---

## Value Types vs Reference Types  
**Path:** `05-datatypes/01-value-vs-reference/`  
**Description:** Demonstrates the difference between value types (which copy values independently) and reference types (which share memory references).  
**Programs / Examples:**  
- **ValueTypeCopyBehavior** → Assign one value type to another and show changes don’t affect the copy.  
- **ReferenceTypeSharedBehavior** → Assign one reference type to another and show changes reflect in both.  
- **StructVsClassBehavior** → Compare a custom `struct` (value type) and `class` (reference type) assignment side by side.  

---

## Integral Types  
**Path:** `05-datatypes/02-integral-types/`  
**Description:** Covers integral data types, their ranges, overflow behavior, and literal suffixes. Shows how C# handles small and large numeric values.  
**Programs / Examples:**  
- **OverflowByte** → Assign a value beyond `byte` range, handle with casting, and show the wrapped result.  
- **ValueAndType** → Declare variables of all integral types and print both their value and type using `GetType()`.  
- **LiteralSuffixes** → Demonstrate suffixes with literals (`L`, `U`, `UL`, `F`, `D`, `M`).  

---

## Floating Point Types  
**Path:** `05-datatypes/03-floating-point-types/`  
**Description:** Demonstrates floating-point behavior, precision limits, and why `decimal` is preferred for financial calculations.  
**Programs / Examples:**  
- **DoubleVsDecimal** → Shows `0.1 + 0.2` rounding issue with `double`, fixed by using `decimal`.  
- **TypesPrecision** → Declares the same number as `float`, `double`, and `decimal`, then prints with `ToString("G20")` to compare precision.  
- **MoneyCalcUsingDecimal** → Performs a money addition with `decimal` and explains why it avoids rounding issues, making it the correct choice for financial calculations.

---

## Boolean & Conditions  
**Path:** `05-datatypes/04-boolean-types/`  
**Description:** Demonstrates usage of boolean values, logical operators, and conditions to control program flow.  
**Programs / Examples:**  
- **LoginSimulation** → Asks for username and password. Grants access only if both match predefined values (`admin` / `1234`). Shows case-sensitive password validation.  
- **AgeCitizenshipCheck** → Takes user input for age and citizenship (`true/false`), validates it, and checks voting eligibility (`age >= 18 && isCitizen`).  
- **LightToggle** → Simulates toggling a light switch using the `!` (NOT) operator. Prints state changes multiple times, with colored output when the light is On.  

---

## Characters & Strings  
**Path:** `05-datatypes/05-text-types/`  
**Description:** Demonstrates manipulation of individual characters and strings, covering classification, ASCII conversion, palindrome check, word counting, and vowel replacement.  
**Programs / Examples:**  
- **CharCategoryChecker** → Takes a character input and identifies if it’s a letter, digit, whitespace, or special symbol. Uses `char` helper methods like `IsLetter`, `IsDigit`, and `IsWhiteSpace`.  
- **ConvCharToASCII** → Converts a character into its corresponding ASCII (Unicode) integer value using casting.  
- **PalindromeChecker** → Checks if a given word is a palindrome by comparing characters from both ends toward the center.  
- **WordCounter** → Splits a sentence into words and counts them. Handles extra spaces safely by removing empty entries.  
- **VowelReplacer** → Replaces all vowels in a word with `*` by converting the string into a character array and looping through each character.  

---

## Object Types  
**Path:** `05-datatypes/06-object-types/`  
**Description:** Demonstrates usage of `object` to store different types, inspecting runtime types, safe type casting, and handling type-safety issues.  
**Programs / Examples:**  
- **ObjectInfoPrinter** → Stores variables of different types (`int`, `double`, `string`, `bool`) in objects. Prints each object’s value and type using `GetType()`. Demonstrates casting back to the original type for performing operations.  
- **MixedDataStorage** → Uses an `object[]` array to store multiple types. Loops through the array and prints each element along with its runtime type.  
- **TypeSafety** → Shows the consequences of unboxing/casting an object to the wrong type. Demonstrates safe conversion using `Convert.ToDouble()` to avoid exceptions.  

---

## Nullable Types  
**Path:** `05-datatypes/07-nullable-types/`  
**Description:** Demonstrates usage of nullable value types, null checks, null-coalescing operators, and safe handling of optional user input.  
**Programs / Examples:**  
- **NullableCheck** → Declares a nullable `int?`. Checks if it has a value using `.HasValue` and prints messages accordingly. Assigns a value later and prints the updated result.  
- **NullCoalescing** → Declares a nullable `double?` and uses the null-coalescing operator `??` to assign a default value if the variable is `null`. Prints the final result.  
- **NullableUserInput** → Reads user input for a number. Stores it in a nullable `int?` if provided, or `null` if empty. Calculates the square safely using nullable operations (`?.`) and prints a default value (`0`) using `??` if the input was invalid or empty.  

---

## Default Values  
**Path:** `05-datatypes/08-default-values/`  
**Description:** Demonstrates default values for class fields and the rules for local variables. Covers nullable fields, uninitialized primitives, and compiler behavior for unassigned locals.  
**Programs / Examples:**  
- **FieldDefaults** → Creates a class with uninitialized fields (`int`, `bool`, `char`, `string`, `int?`). Uses a method to print each field, showing the default values assigned by the runtime.  
- **LocalVariableCheck** → Declares local variables inside `Main()` (`int` and `double`). Attempts to print them uninitialized, causing compiler errors. Then assigns values and prints them, including performing addition. Demonstrates that local variables must be explicitly initialized.  
- **NullableDefault** → Declares a nullable integer (`int?`) as a field in a class. Prints the value before and after assignment, confirming that uninitialized nullable fields default to `null`.  

---

## Student Performance Analyzer  
**Path:** `05-datatypes/StudentPerformanceAnalyzer/`  
**Description:** Demonstrates usage of multiple data types, nullable types, default values, and object-oriented principles in C#. Collects student information, computes totals, percentages, and grades, and prints a formatted report. Covers user input validation, nullable handling, arithmetic operations, and encapsulation in classes.  
**Programs / Examples:**  
- **Student Class** → Defines a `Student` class with fields (`string`, `int`, `int?`, `bool`, `double`, `char`) to store personal details, marks, total, percentage, and grade. Includes a method to compute the student grade based on total marks.  
- **Input Loop** → Collects multiple student details dynamically, handles invalid input safely using `TryParse`, and computes total marks and percentages. Demonstrates use of nullable integers and null-coalescing operators (`??`) for extra marks.  
- **Printing Loop** → Iterates over a `List<Student>` and prints all student details in a formatted table. Handles nullable fields (`extraMarks`) gracefully and displays them as `N/A` when null. Formats percentages with two decimal places and displays grades and active status.  

---
