namespace meowy.Client.Application.Shared.Errors.DeviceErrors;

public record FeatureNotSupportedError(string message) : ApplicationError(true, message);