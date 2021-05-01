using Geekymon2.CarsApi.Cars.API.Models;
using Geekymon2.CarsApi.Cars.DAL.DataAccess.Entities;

namespace Geekymon2.CarsApi.Cars.API.Mappers
{
    public class TransmissionMapper
    {
        public TransmissionDTO MapToTransmissionDTO(Transmission transmission)
        {
            var transmissionDTO = new TransmissionDTO();
            transmissionDTO.ID = transmission.ID;
            transmissionDTO.TransmissionTypeDTO = (TransmissionTypeDTO)transmission.Type;
            transmissionDTO.TransmissionTypeDetailDTO = (TransmissionTypeDetailDTO)transmission.Detail;
            transmissionDTO.Gears = transmission.Gears;

            return transmissionDTO;
        }
    }
}