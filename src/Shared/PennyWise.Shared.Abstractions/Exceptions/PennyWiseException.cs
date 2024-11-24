namespace PennyWise.Shared.Abstractions.Exceptions;

public abstract class PennyWiseException(string message) : Exception(message);