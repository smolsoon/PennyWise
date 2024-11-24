using PennyWise.Shared.Abstractions.Exceptions;

namespace PennyWise.Modules.Users.Core.Exceptions;

internal class EmailInUseException() : PennyWiseException("Email is already in use.");