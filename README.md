# PhilsLendingLibrary

The Phils Lending Library is a powerful tool for managing books in a library setting. It provides functionality for adding books to a library, borrowing books, returning books, and keeping track of the library's book collection.

## Features

- Add a book to the library
- Borrow a book from the library
- Return a borrowed book to the library
- Count the number of books in the library

## Installation

To use the Library module, follow these steps:

1. Install the Library from the NuGet Package Manager.
2. Add a reference to the Library in your project.

## Usage

### Adding a Book to the Library

To add a book to the library, use the `Add` method:

```csharp
Library.Library library = new Library.Library();
library.Add("Title", "Author");
```

### Borrowing a Book from the Library
To borrow a book from the library, use the Borrow method:

```csharp
Library.Library library = new Library.Library();
Book borrowedBook = library.Borrow("Title");
```
### Returning a Borrowed Book to the Library
To return a borrowed book to the library, use the Return method:

```csharp

Library.Library library = new Library.Library();
library.Return(borrowedBook);
```
### Counting the Number of Books in the Library
To count the number of books in the library, access the Count property:

```csharp

Library.Library library = new Library.Library();
int bookCount = library.Count;
```
### Example
Here's an example that demonstrates the usage of the Library module:

```csharp

Library.Library library = new Library.Library();
library.Add("1984", "George Orwell");
library.Add("To Kill a Mockingbird", "Harper Lee");

Book borrowedBook = library.Borrow("1984");

library.Return(borrowedBook);

int bookCount = library.Count;
```
In this example, we create a library object, add two books to the library, borrow a book, return the borrowed book, and then get the count of books in the library.

### Conclusion
The Phils Lending Library is a comprehensive solution for managing books in a library. It provides essential functionality for adding, borrowing, and returning books, making it a valuable tool for any library setting.


