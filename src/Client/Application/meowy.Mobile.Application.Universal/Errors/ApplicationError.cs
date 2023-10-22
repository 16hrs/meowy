namespace meowy.Mobile.Application.Universal.Errors;

public record ApplicationError(
    bool Exception,
    string Message
);