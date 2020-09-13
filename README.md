# Rectangle Intersections

This console application takes a list of rectangles as input and calculates and displays all intersectiong rectangles between them.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

You need .Net Core 3.1 installed
You can download it [here](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### Build

Open the command prompt and navigate to the folder where the solution is.
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

This is free and unencumbered software released into the public domain.
Anyone is free to copy, modify, publish, use, compile, sell, or distribute this software, either in source code form or as a compiled binary, for any purpose, commercial or non-commercial, and by any means.
In jurisdictions that recognize copyright laws, the author or authors of this software dedicate any and all copyright interest in the software to the public domain. We make this dedication for the benefit of the public at large and to the detriment of our heirs and successors. We intend this dedication to be an overt act of relinquishment in perpetuity of all present and future rights to this software under copyright law.
THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND,EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF\ ERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
For more information, please refer to <https://unlicense.org>

