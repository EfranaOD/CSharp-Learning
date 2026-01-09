# C# Strings  
**Folder:** 02-midlevel/01-strings  
**Description:** Covers C# string handling, including literals, methods, interpolation, and formatting. Demonstrates manipulation and dynamic output using `string.Format()`.  

---

## String Format  
**Path:** `01-strings/01-basics/01-string-format/`  
**Description:** Shows practical use of `string.Format()` to create flexible, dynamic output. Implements a conversation console program using a class and modular methods to collect user input and print formatted responses.  
**Program / Example:**  
- **Conversation** → Collects topic and detail from the user, generates a format string, and prints the result using `string.Format()`. Highlights modular methods, null/empty handling, and user-driven dynamic formatting.

---

## Escape Sequence  
**Path:** `01-strings/01-basics/02-escape-sequence/`  
**Description:** Shows practical use of escape sequences to represent characters and actions that can’t be typed directly. Implements a console program demonstrating tabular output, colored text, and use of special characters like newline (`\n`), tab (`\t`), backslash (`\\`), backspace (`\b`), and quotes (`\"`).  
**Program / Example:**  
- **Console Formatting + Escape Use Cases** → Displays a table using `\t`, removes characters using `\b`, prints valid Windows path using `\\`, and shows quotes inside text using `\"`, along with colored console output for clarity.

---

## Verbatim String  
**Path:** `01-strings/01-basics/03-verbatim-string/`  
**Description:** Shows how verbatim strings (`@""`) preserve text exactly as written — including newlines, tabs, and backslashes. This removes the need for escape sequences when working with file paths and formatted text blocks. Also demonstrates quoting inside verbatim strings using doubled quotes (`""`).  
**Program / Example:**  
- **File Paths & Multi-line Text** → Uses `@` to cleanly write file paths without `\\` and display text on multiple lines exactly as typed. Also includes quoted dialogue and a rewritten portion of the escape-sequence program to show how verbatim strings improve readability and reduce escaping complexity.

---

## Concatenation  
**Path:** `01-strings/01-basics/04-concatenation/`  
**Description:** Demonstrates different ways to combine strings using `+`, `string.Concat()`, and `string.Join()` for readable and structured output.  
**Program / Example:**  
- Creates strings like full names, comma-separated item lists, and formatted messages (Inventory, Path, Player) using multiple concatenation techniques with console color output.

---

## String Length, Indexing, and Slicing  
**Path:** `01-strings/01-basics/04-length-indexing-slicing/`  
**Description:** Demonstrates how to analyze and extract specific parts of a string using `Length`, `IndexOf()`, `LastIndexOf()`, and `Substring()` by navigating character positions precisely.  
**Program / Example:**  
- Analyzes a paragraph to calculate total character length.  
- Locates specific words using indexed searches, including handling multiple occurrences of the same substring.  
- Extracts a hidden word by calculating start and end positions dynamically using index offsets and substring slicing.  
- Includes validation logic to safely handle cases where search patterns are not found.

---

## String Interpolation & Alignment  
**Path:** `01-strings/02-interpolation/`  
**Description:** Demonstrates embedding variables and expressions directly into strings using C# string interpolation, along with alignment techniques for structured console output.  
**Program / Example:**  
- Displays dynamic player information by embedding variables and arithmetic expressions inside interpolated strings.  
- Calculates derived values inline (e.g., remaining score to next level) without temporary variables.  
- Builds structured console tables using interpolation combined with alignment specifiers for readable output.  
- Applies alignment to simulate inventory lists and scoreboards commonly used in games and logging systems.

---

## String Comparison and Trimming  
**Path:** `01-strings/03-comparison-and-trimming/`  
**Description:** Demonstrates how to compare strings accurately using `Equals()` and `Compare()`, handle case-insensitive comparisons, and clean user input using trimming methods.  
**Program / Example:**  
- Compares strings using `Equals()` and `Compare()` to determine equality and ordering.  
- Performs case-insensitive comparisons to avoid logical errors caused by casing differences.  
- Cleans input data using `Trim()`, `TrimStart()`, and `TrimEnd()` to remove unwanted whitespace.  
- Simulates real-world scenarios like validating usernames, commands, or inputs where formatting inconsistencies are common.

---

## Splitting and Joining Strings  
**Path:** `01-strings/04-split-join/`  
**Description:** Demonstrates how to break a string into parts using `Split()` and rebuild it into a formatted output using `string.Join()`.  
**Program / Example:**  
- Takes a single string containing multiple names separated by commas.  
- Splits the string into an array of individual names.  
- Formats each name properly (capitalizing the first letter).  
- Joins the processed names back into a readable display format using separators like `|`.

---

## Regular Expressions (Regex)  
**Path:** `01-strings/06-regex/`  
**Description:** Demonstrates how to use Regular Expressions for pattern matching, validation, extraction, grouping, and dynamic text masking in real-world scenarios.  
**Program / Example:**  
- Validates whether a paragraph contains at least one email using `Regex.IsMatch()`.  
- Extracts all email addresses from text using `Regex.Matches()`.  
- Separates email **username** and **domain** using regex **groups**.  
- Masks sensitive phone number digits using `Regex.Replace()` with **capturing groups** and **lookaheads**.  
- Simulates practical use cases like handling user contact data securely.

---
