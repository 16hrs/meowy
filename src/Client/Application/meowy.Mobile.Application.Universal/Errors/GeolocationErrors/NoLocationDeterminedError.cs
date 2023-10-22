using meowy.Mobile.Application.Universal.Errors;

namespace meowy.Mobile.Application.Universal.Errors.GeolocationErrors;

public record NoLocationDeterminedError() : ApplicationError(false, "No location could be determined");