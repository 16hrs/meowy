using meowy.Mobile.Application.Universal.Errors;

namespace meowy.Mobile.Application.Universal.Interfaces;

public interface IApplicationErrorHandler
{
    ApplicationError MapExceptionToError(Exception exception);
}