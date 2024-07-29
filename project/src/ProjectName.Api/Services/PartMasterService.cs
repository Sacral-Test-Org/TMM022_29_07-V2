using ProjectName.Api.Repositories;
using ProjectName.Api.DTOs;

namespace ProjectName.Api.Services
{
    public class PartMasterService
    {
        private readonly PartMasterRepository _partMasterRepository;

        public PartMasterService(PartMasterRepository partMasterRepository)
        {
            _partMasterRepository = partMasterRepository;
        }

        public PartMasterDTO GetPartMasterData()
        {
            // Fetch the initial data required for the PART_MASTER window
            return _partMasterRepository.GetPartMasterData();
        }

        public string GetCurrentDate()
        {
            // Fetch the current date
            return _partMasterRepository.GetCurrentDate();
        }
    }
}