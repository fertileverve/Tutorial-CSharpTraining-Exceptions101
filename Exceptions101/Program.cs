//=================================================================
// Create and throw and exception Challenge
//=================================================================
// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// //string overallStatusMessage = "";

// //overallStatusMessage = Workflow1(userEnteredValues);
// try
// {
//     Workflow1(userEnteredValues);
//     Console.WriteLine("'Workflow1' completed successfully.");
// }
// catch (DivideByZeroException ex)
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(ex.Message);
// }

// // if (overallStatusMessage == "operating procedure complete")
// // {
// //     Console.WriteLine("'Workflow1' completed successfully.");
// // }
// // else
// // {
// //     Console.WriteLine("An error occurred during 'Workflow1'.");
// //     Console.WriteLine(overallStatusMessage);
// // }

// static void Workflow1(string[][] userEnteredValues)
// {
//     //string operationStatusMessage = "good";
//     //string processStatusMessage = "";

//     foreach (string[] userEntries in userEnteredValues)
//     {
//         //processStatusMessage = Process1(userEntries);
//         try
//         {
//             Process1(userEntries);
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         catch (FormatException ex)
//         {
//             Console.WriteLine($"'Process1' encountered an issue, process aborted. {ex.Message}");
//             Console.WriteLine();
//         }

//         // if (processStatusMessage == "process complete")
//         // {
//         //     Console.WriteLine("'Process1' completed successfully.");
//         //     Console.WriteLine();
//         // }
//         // else
//         // {
//         //     Console.WriteLine("'Process1' encountered an issue, process aborted.");
//         //     Console.WriteLine(processStatusMessage);
//         //     Console.WriteLine();
//         //     operationStatusMessage = processStatusMessage;
//         // }
//     }

//     // if (operationStatusMessage == "good")
//     // {
//     //     operationStatusMessage = "operating procedure complete";
//     // }

//     // return operationStatusMessage;
// }

// static void Process1(String[] userEntries)
// {
//     //string processStatus = "clean";
//     //string returnMessage = "";
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 //returnMessage = "Invalid data. User input values must be non-zero values.";
//                 //processStatus = "error";
//                 throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
//             }
//         }
//         else
//         {
//             //returnMessage = "Invalid data. User input values must be valid integers.";
//             //processStatus = "error";
//             throw new FormatException("Invalid data. User input values must be valid integers.");
//         }
//     }

//     // if (processStatus == "clean")
//     // {
//     //     returnMessage = "process complete";
//     // }

//     //return returnMessage;
// }


//=================================================================
// Exercise - Create and throw and exception
//=================================================================
// Prompt the user for the lower and upper bounds
// Console.Write("Enter the lower bound: ");
// int lowerBound = int.Parse(Console.ReadLine());

// Console.Write("Enter the upper bound: ");
// int upperBound = int.Parse(Console.ReadLine());

// decimal averageValue = 0;

// bool exit = false;

// do
// {
//     try
//     {
//         // Calculate the sum of the even numbers between the bounds
//         averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

//         // Display the value returned by AverageOfEvenNumbers in the console
//         Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

//         exit = true;
//     }
//     catch (ArgumentOutOfRangeException ex)
//     {
//         Console.WriteLine("An eeror has occurred.");
//         Console.WriteLine(ex.Message);
//         Console.WriteLine($"The upper bound must be greater than {lowerBound}");
//         Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
//         string? userResponse = Console.ReadLine();
//         if (userResponse.ToLower().Contains("exit"))
//         {
//             exit = true;
//         }
//         else
//         {
//             upperBound = int.Parse(userResponse);
//         }
//     }
// } while (exit == false);

// // Wait for user input
//     Console.ReadLine();

// static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
// {
//     if (lowerBound >= upperBound)
//     {
//         throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
//     }

//     int sum = 0;
//     int count = 0;
//     decimal average = 0;

//     for (int i = lowerBound; i <= upperBound; i++)
//     {
//         if (i % 2 == 0)
//         {
//             sum += i;
//             count++;
//         }
//     }

//     average = (decimal)sum / count;

//     return average;
// }


//=================================================================
// Throw and Custom Message Tutorial
//=================================================================
// try
// {
//     OperatingProcedure1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
//     Console.WriteLine("Exiting application.");
// }

// static void OperatingProcedure1()
// {
//     string[][] userEnteredValues = new string[][]
//     {
//         new string[] { "1", "two", "3"},
//         new string[] { "0", "1", "2"}
//     };

//     foreach(string[] userEntries in userEnteredValues)
//     {
//         try
//         {
//             BusinessProcess1(userEntries);
//         }
//         catch (Exception ex)
//         {
//             if (ex.StackTrace.Contains("BusinessProcess1"))
//             {
//                 if (ex is FormatException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
//                 }
//                 else if (ex is DivideByZeroException)
//                 {
//                     Console.WriteLine(ex.Message);
//                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

//                     // re-throw the original exception
//                     throw;
//                 }
//                 else
//                 {
//                     // create a new exception object that wraps the original exception
//                     throw new ApplicationException("An error occurred - ", ex);
//                 }
//             }
//         }

//     }
// }

// static void BusinessProcess1(string[] userEntries)
// {
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         try
//         {
//             valueEntered = int.Parse(userValue);

//             checked
//             {
//                 int calculatedValue = 4 / valueEntered;
//             }
//         }
//         catch (FormatException)
//         {
//             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
//             throw invalidFormatException;
//         }
//         catch (DivideByZeroException)
//         {
//             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
//             throw unexpectedDivideByZeroException;

//         }
//     }
// }


//=================================================================
// Catch Challenge
//=================================================================
// checked
// {
//     try
//     {
//         int num1 = int.MaxValue;
//         int num2 = int.MaxValue;
//         int result = num1 + num2;
//         Console.WriteLine("Result: " + result);
//     }
//     catch (OverflowException ex)
//     {
//         Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
//     }

//     try
//     {
//         string str = null;
//         int length = str.Length;
//         Console.WriteLine("String Length: " + length);
//     }
//     catch (NullReferenceException ex)
//     {
//         Console.WriteLine("Error: The reference is null." + ex.Message);
//     }

//     try
//     {
//         int[] numbers = new int[5];
//         numbers[5] = 10;
//         Console.WriteLine("Number at index 5: " + numbers[5]);
//     }
//     catch (IndexOutOfRangeException ex)
//     {
//         Console.WriteLine("Error: Index out of range." + ex.Message);
//     }

//     try
//     {
//         int num3 = 10;
//         int num4 = 0;
//         int result2 = num3 / num4;
//         Console.WriteLine("Result: " + result2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
//     }
// }

// Console.WriteLine("Exiting program.");


//=================================================================
// Catch separate exception types in a code block
//=================================================================
// inputValues is used to store numeric values entered by a user
// string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch(Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }


//=================================================================
// Catch specific exception types
//=================================================================
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//     }

//     checked
//     {
//         try
//         {
//             smallNumber = (byte)number1;
//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//     }
// }


//=================================================================
// Try-Catch Challenge
// I went and looked up the error output since I want to see that too
//=================================================================
// try
// {
//     Process1();
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"An exception has occurred: {ex.Message}");
//     Console.WriteLine($"{ex.GetType().Name}");
//     Console.WriteLine($"{ex.StackTrace}");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (Exception ex)
// {
//     Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     Console.WriteLine($"{ex.GetType().Name}");
//     Console.WriteLine($"{ex.StackTrace}");
// }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }


//=================================================================
// Called Method thrown
//=================================================================
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }


//=================================================================
// First Try-Catch
//=================================================================
// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }

// Console.WriteLine("Exit program");