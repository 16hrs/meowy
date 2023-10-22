using LanguageExt;
using meowy.Mobile.Application.Universal.Errors;
using Microsoft.Maui.Devices.Sensors;

namespace meowy.Mobile.Application.Universal.Interfaces;

public interface ILocationService
{
    Task<Either<ApplicationError, Location>> GetDeviceLocation();
}