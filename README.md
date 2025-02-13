# .NET Media and Salon Management

## Introduction
This repository contains two .NET solutions for a college project:
1. **Media Management Console Application**
2. **Hair Salon Pricing Windows Form App**

---

## Solution A: Media Management Console Application

### Overview
This application implements an object-oriented approach to managing media files. It utilizes interfaces, abstract classes, and file handling to store and retrieve media information.

### Features
- Implements `IEncryptable` interface for encryption and decryption (Rot13 algorithm)
- Implements `ISearchable` interface for searching media objects
- Uses an abstract class `Media` as a base for different media types:
  - `Book` (Author, Summary)
  - `Movie` (Director, Summary)
  - `Song` (Album, Artist)
- Reads data from `Data.txt` and stores up to 100 media objects
- Displays media objects through a menu-driven system:
  - List All Books (without Summary)
  - List All Movies (without Summary)
  - List All Songs
  - List All Media (without Summary)
  - Search All Media by Title (displays decrypted Summary where applicable)
- Implements exception handling for file operations
- Ensures proper user input validation

### How to Run
1. Ensure `.NET` is installed on your system.
2. Clone the repository and navigate to the project directory.
3. Open the solution in Visual Studio.
2. Build and run the project.

---

## Solution B: Hair Salon Pricing Windows Form App

### Overview
A Windows Forms application that allows users to calculate hair salon service pricing based on the selected hairdresser and services.

### Features
- **Hairdresser Selection:** Choose from a dropdown list, each with different base rates
- **Service Selection:** Select one or more services from a list
- **Dynamic UI Behavior:**
  - "Add Service" button adds selected services and displays pricing.
  - "Calculate Total Price" button shows the final cost.
  - "Reset" button clears selections and resets the UI.
  - Proper enabling/disabling of UI elements to prevent invalid selections.

### How to Run
1. Ensure `.NET` is installed on your system.
2. Clone the repository and navigate to the project directory.
3. Open the solution in Visual Studio.
4. Build and run the project.
3. Use the form to select a hairdresser and services, then calculate pricing.

---

## Sample Output

### Solution A:
![image](https://github.com/user-attachments/assets/65d5e78b-9b1e-4cb9-8561-946b0ddad74d)

### Solution B:
![image](https://github.com/user-attachments/assets/db77af6e-1b3e-40e7-ac82-13bc5b9d1cc6)

## License
This project is for educational purposes.
