Duplicate Source File Finder

Language:
C# (.NET)

Description:
This application scans a directory tree recursively and identifies duplicate source files across projects.

Supported File Types:
- .c
- .cpp
- .h
- .rc

Features:
- Recursive folder scanning
- Duplicate file detection
- SHA256 content comparison
- Console output
- Output file generation

How Duplicate Detection Works:
Files are considered duplicates only if:
1. File names match
2. File contents match using SHA256 hashing

Usage:
dotnet run -- <FolderPath>

Example:
dotnet run -- "E:\Tieto Assignment\TestProject1"

Output File Example:
dotnet run -- "E:\Tieto Assignment\TestProject1" output.txt

Design Considerations:
- Uses Dictionary collections for efficient lookup
- Uses SHA256 hashing for optimized file comparison
- Portable implementation using standard C# libraries
- Object-oriented design for maintainability
- Recursive scanning supports deeply nested folders

Performance:
The application is designed to efficiently handle
large numbers of files and folders using hashing
and optimized dictionary lookups.

Limitations:
- Multithreading is not implemented
- Binary files are not scanned
- Only specified source file extensions are supported

Coding Style:
The code is written to be:
- Simple and readable
- Object oriented
- Portable
- Easy to maintain

Comments are added where they improve readability and explain important logic.