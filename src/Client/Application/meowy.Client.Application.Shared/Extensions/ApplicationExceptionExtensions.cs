using meowy.Client.Application.Shared.Errors;
using meowy.Client.Application.Shared.Errors.DeviceErrors;
using Microsoft.Maui.ApplicationModel;

namespace meowy.Client.Application.Shared.Extensions;

public static class ApplicationExceptionExtensions
{
    public static ApplicationError ToApplicationError(this Exception exception)
    {
        //TODO: Refactor, current implementation just a quick and dirty solution
        return exception switch
        {
            FeatureNotEnabledException featureNotEnabledException
                => new FeatureNotEnabledError(featureNotEnabledException.Message),

            FeatureNotSupportedException featureNotSupportedException
                => new FeatureNotSupportedError(featureNotSupportedException.Message),

            PermissionException permissionException
                => new PermissionError(permissionException.Message),

            _ => new ApplicationError(true, exception.Message)
        };
    }
}