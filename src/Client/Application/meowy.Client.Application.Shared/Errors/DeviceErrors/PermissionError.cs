namespace meowy.Client.Application.Shared.Errors.DeviceErrors;

public record PermissionError(string message) : ApplicationError(true, message);