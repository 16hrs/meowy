using meowy.Client.Application.Shared.Errors;

namespace meowy.Client.Application.Shared.Interfaces;

public interface IApplicationErrorHandler
{
    ApplicationError MapExceptionToError(Exception exception);
}