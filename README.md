# Rectangle Intersections

This console application calculates and displays all intersections between rectangles given in the input file

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

You need:
- .Net Core 3.1 installed to run the program
- NUnit installed to run the unit tests

### Build

Start by opening the command prompt and navigate to the folder where the solution is.
To build the solution, execute the following command:

`dotnet build`

### Run unit tests

Open the command prompt and navigate to the folder where the solution is.
Make sure you built the solution first then execute the following command:

`dotnet test`


### Run the console application

There are two ways to run the application:

#### 1: from the solution folder

Open the command prompt and navigate to the folder where the solution is.
Make sure you built the solution first then execute the following command:

`dotnet run --project RectangleIntersections ./TestFiles/RectangleInput.json`

#### 2: from the project folder
Open the command prompt and navigate to the folder where the RectangleIntersections project is.
Make sure you built the solution first then execute the following command:

`dotnet run ./TestFiles/RectangleInput.json`

#### Arguments

There is only 1 argument needed:
- filename (**mandatory**)

Replace the `./TestFiles/RectangleInput.json` with the file you want to give as input.
3 test files are provided in the `TestFiles` folder:
- RectangleInput.json
- RectangleInput2.json
- RectangleInput3.json

These files are there to help running the application quickly, they are not meant to check the validity of the program


## Author

David Saulnier


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

