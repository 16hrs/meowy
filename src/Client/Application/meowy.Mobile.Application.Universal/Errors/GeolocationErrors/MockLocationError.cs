using meowy.Mobile.Application.Universal.Errors;

namespace meowy.Mobile.Application.Universal.Errors.GeolocationErrors;

public record MockLocationError() : ApplicationError(false, "Mock locations are not supported");