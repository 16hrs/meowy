namespace meowy.Client.Application.Shared.Errors.DeviceErrors;

public record FeatureNotEnabledError(string message) : ApplicationError(true, message);