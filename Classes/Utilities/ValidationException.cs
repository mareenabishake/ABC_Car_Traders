using System;

namespace ABC_Car_Traders
{
    // Custom exception class for handling validation-related errors in the application
    // Inherits from the base Exception class to maintain standard exception functionality
    public class ValidationException : Exception
    {
        // Default constructor
        // Used when throwing a validation exception without any specific message
        public ValidationException() : base() { }

        // Constructor that accepts a custom error message
        // Used most commonly to provide specific validation failure details
        // Parameters:
        //   message: Describes the validation error that occurred
        public ValidationException(string message) : base(message) { }

        // Constructor that accepts both a message and an inner exception
        // Used when wrapping another exception within this validation exception
        // Parameters:
        //   message: Describes the validation error that occurred
        //   innerException: The original exception that caused this validation error
        public ValidationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
