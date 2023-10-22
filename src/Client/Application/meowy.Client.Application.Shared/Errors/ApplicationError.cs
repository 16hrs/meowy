namespace meowy.Client.Application.Shared.Errors;

public record ApplicationError(
    bool Exception,
    string Message
);