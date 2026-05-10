# Duplicate Source File Finder

Overview
This project is a C# console application developed as part of the Tieto Banktech assignment.

The application scans a given directory recursively and identifies duplicate source files based on file content hashing. It helps detect files with identical content.

Supported source file types:
- .cpp
- .h
- .cs

--------------------------------------------------

## Technologies Used
- C#
- .NET 8
- SHA256 Hashing
- Visual Studio Code

--------------------------------------------------

## Project Structure

Tieto Assignment
│
├── DevelopmentTest
│   ├── Program.cs
│   ├── FileScanner.cs
│   ├── HashUtility.cs
│   ├── DevelopmentTest.csproj
│   ├── DevelopmentTest.sln
│   └── output.txt
│
├── TestProject1
│
└── TestProjects

--------------------------------------------------

## How the Project Works

1. The user provides a folder path as command line input.
2. The application scans all subdirectories recursively.
3. Source files are read and hashed using SHA256.
4. Files having identical hashes are grouped together.
5. Duplicate files are displayed in console output.

--------------------------------------------------

## Build and Run Instructions

Open terminal inside DevelopmentTest folder and run:

dotnet build

Then execute:

dotnet run -- "E:\Tieto Assignment\TestProject1"

OR

dotnet run -- "E:\Tieto Assignment\TestProjects"

--------------------------------------------------

## Sample Output 1

Command:
dotnet run -- "E:\Tieto Assignment\TestProjects"

Output:
<img width="878" height="450" alt="image" src="https://github.com/user-attachments/assets/4aaf890e-2c6a-47ca-b43d-46b2f717db9e" />

--------------------------------------------------

## Sample Output 2

Command:
dotnet run -- "E:\Tieto Assignment\TestProject1"

Output:

<img width="897" height="446" alt="image" src="https://github.com/user-attachments/assets/851e19e7-b320-459c-aec3-902363e8509e" />

--------------------------------------------------

## Features
- Recursive folder scanning
- Duplicate file detection
- SHA256 based hashing
- Fast and efficient processing
- Console-based clean output
- Supports multiple source file types

--------------------------------------------------
