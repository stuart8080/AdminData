using Xunit;
using Microsoft.AspNetCore.Mvc;
using AdminData.Controllers;

namespace AdminData.Tests
{
    public class SuppliersControllerSpec
    {
        [Fact]
        public void GetSpreadsheetDetail_ValidSupplierAndStatus_ReturnsOkResult()
        {
            var sut = new SuppliersController();
            var result = sut.GetSpreadsheetDetail("Enotria","New Vintage");
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void GetSpreadsheetDetail_EmptySupplier_ReturnsBadRequestObjectResult()
        {
            var sut = new SuppliersController();
            var result = sut.GetSpreadsheetDetail("","New Vintage");
            Assert.IsType<BadRequestObjectResult>(result);
        }
        [Fact]
        public void GetSpreadsheetDetail_EmptyStatus_ReturnsBadRequestObjectResult()
        {
            var sut = new SuppliersController();
            
            var result = sut.GetSpreadsheetDetail("","New Vintage");
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}