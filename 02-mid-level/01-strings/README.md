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