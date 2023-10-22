namespace meowy.Client.Application.Shared.Errors.GeolocationErrors;

public record NoLocationDeterminedError() : ApplicationError(false, "No location could be determined");