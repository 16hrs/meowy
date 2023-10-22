using meowy.Mobile.Application.Universal.Errors;

namespace meowy.Mobile.Application.Universal.Errors.DeviceErrors;

public record FeatureNotSupportedError(string message) : ApplicationError(true, message);