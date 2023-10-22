namespace meowy.Client.Application.Shared.Errors.GeolocationErrors;

public record MockLocationError() : ApplicationError(false, "Mock locations are not supported");