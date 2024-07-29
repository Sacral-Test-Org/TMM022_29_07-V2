using System;
using Xunit;
using Moq;
using ProjectName.Api.Services;
using ProjectName.Api.Repositories;
using ProjectName.Api.DTOs;

namespace ProjectName.Tests.Services
{
    public class PartMasterServiceTests
    {
        private readonly PartMasterService _partMasterService;
        private readonly Mock<PartMasterRepository> _mockPartMasterRepository;

        public PartMasterServiceTests()
        {
            _mockPartMasterRepository = new Mock<PartMasterRepository>();
            _partMasterService = new PartMasterService(_mockPartMasterRepository.Object);
        }

        [Fact]
        public void TestGetPartMasterData()
        {
            // Arrange
            var expectedData = new PartMasterDTO
            {
                GroupId = "G1",
                PartNo = "P1",
                PartStatus = "Active",
                PartDesc = "Part Description",
                LineId = "L1",
                UnitId = "U1",
                CurrentFormName = "PART_MASTER",
                CurrentDate = DateTime.Now.ToString("yyyy-MM-dd")
            };
            _mockPartMasterRepository.Setup(repo => repo.GetPartMasterData()).Returns(expectedData);

            // Act
            var result = _partMasterService.GetPartMasterData();

            // Assert
            Assert.Equal(expectedData, result);
        }

        [Fact]
        public void TestGetCurrentDate()
        {
            // Arrange
            var expectedDate = DateTime.Now.ToString("yyyy-MM-dd");
            _mockPartMasterRepository.Setup(repo => repo.GetCurrentDate()).Returns(expectedDate);

            // Act
            var result = _partMasterService.GetCurrentDate();

            // Assert
            Assert.Equal(expectedDate, result);
        }
    }
}