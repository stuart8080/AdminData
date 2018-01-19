using Xunit;
using Microsoft.AspNetCore.Mvc;
using AdminData.Controllers;

namespace AdminData.Tests
{
    public class SuppliersControllerSpec
    {
        [Fact]
        public void GetSpreadsheetDetail_NoState_ReturnsOkResult()
        {
            var sut = new SuppliersController();
            var result = sut.GetSpreadsheetDetail();
            Assert.IsType<OkResult>(result);
        }

    }
}