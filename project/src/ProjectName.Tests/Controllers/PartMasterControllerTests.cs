using Xunit;
using Moq;
using ProjectName.Api.Controllers;
using ProjectName.Api.Services;
using ProjectName.Api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Tests.Controllers
{
    public class PartMasterControllerTests
    {
        private readonly Mock<PartMasterService> _mockService;
        private readonly PartMasterController _controller;

        public PartMasterControllerTests()
        {
            _mockService = new Mock<PartMasterService>();
            _controller = new PartMasterController(_mockService.Object);
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
                CurrentDate = "2023-10-01"
            };
            _mockService.Setup(service => service.GetPartMasterData()).Returns(expectedData);

            // Act
            var result = _controller.GetPartMasterData();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<PartMasterDTO>(okResult.Value);
            Assert.Equal(expectedData, returnValue);
        }

        [Fact]
        public void TestGetCurrentDate()
        {
            // Arrange
            var expectedDate = "2023-10-01";
            _mockService.Setup(service => service.GetCurrentDate()).Returns(expectedDate);

            // Act
            var result = _controller.GetCurrentDate();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<string>(okResult.Value);
            Assert.Equal(expectedDate, returnValue);
        }
    }
}