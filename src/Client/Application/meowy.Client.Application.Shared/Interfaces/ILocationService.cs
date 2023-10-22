using LanguageExt;
using meowy.Client.Application.Shared.Errors;
using Microsoft.Maui.Devices.Sensors;

namespace meowy.Client.Application.Shared.Interfaces;

public interface ILocationService
{
    Task<Either<ApplicationError, Location>> GetDeviceLocation();
}