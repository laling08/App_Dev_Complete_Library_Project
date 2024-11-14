# Complete Library Project: Data Structures

## Overview
The **Complete Library** project implements a library management system, handling various functionalities like user management, media checkouts, holds, search, and library operations. This document provides an overview of the data structures used across the different classes and interfaces.

## Data Structures

### 1. User Class and Subclasses (`Member`, `Librarian`)
   - **Data Structure**: `List<Media>`
     - **Properties**:
       - `_currentCheckouts`: Stores the list of `Media` objects that a user currently has checked out.
       - `_currentHolds`: Stores the list of `Media` objects currently on hold for the user.
     - **Purpose**: The `List<Media>` data structure is used to dynamically store and manage the collection of media items for each user. This allows flexible resizing, efficient retrieval, and management of checked-out and held media items.

### 2. Librarian Class Media Collection
   - **Data Structure**: `List<Media>`
     - **Property**:
       - `libraryMedia`: Stores a list of all `Media` items available in the library collection.
     - **Purpose**: The librarian can manage library media through this collection, enabling operations like adding, removing, and modifying `Media` items. Using a `List<Media>` allows the library collection to be dynamically managed and ensures straightforward access and updates.

### 3. Search Functionality in User Class
   - **Data Structure**: `List<Media>` or `Dictionary<string, Media>`
     - **Purpose**: The search methods (e.g., `SearchByGenre`, `SearchByTitle`, `SearchByAuthor`) operate on collections of `Media`. 
     - **Implementation Recommendations**:
       - **List**: A `List<Media>` allows searches based on attributes and LINQ-based querying.
       - **Dictionary**: If media items have unique identifiers (e.g., ISBN), a `Dictionary<string, Media>` provides efficient lookups based on these keys.

### 4. Media Adapter Pattern
   - **Data Structure**: None (Direct Composition)
     - **Classes**: `AudiobookAdapter`, `BookAdapter`, `MagazineAdapter`, `MovieAdapter`
     - **Purpose**: Each adapter class contains a reference to the specific `Media` subclass (e.g., `Book`, `Movie`) and implements the `MediaAdapter` interface. This allows standardization of methods across media types without additional data structure needs.

### 5. Custom Exception Handling
   - **Data Structure**: Custom Exception (`TooYoungException`)
     - **Purpose**: `TooYoungException` inherits from `Exception` and is used to manage age-restriction errors in borrowing. This custom exception encapsulates specific error messages related to age restrictions.

## Suggested Data Structure Enhancements

- **Dictionary for Media Collection**: In cases where lookups by unique attributes like `ISBN` or `title` are required, using a `Dictionary<string, Media>` can improve search efficiency. This could be used in addition to the `List<Media>` for specific search cases.
- **Additional Lists for Media History**: To store historical records of checkouts or holds, consider maintaining a `List<Loan>` in the `User` or `Librarian` class.

## Project Repository

For further details and implementation code, visit the [Complete Library Project on GitHub](https://github.com/laling08/App_Dev_Complete_Library_Project).
