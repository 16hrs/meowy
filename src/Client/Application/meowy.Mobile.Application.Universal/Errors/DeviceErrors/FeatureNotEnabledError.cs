using meowy.Mobile.Application.Universal.Errors;

namespace meowy.Mobile.Application.Universal.Errors.DeviceErrors;

public record FeatureNotEnabledError(string message) : ApplicationError(true, message);