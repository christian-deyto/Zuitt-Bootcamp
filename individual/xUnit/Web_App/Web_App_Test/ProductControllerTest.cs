using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_App.Controllers;
using Web_App.Models;
using Xunit;

namespace Web_App_Test
{
    public class ProductControllerTest
    {

        //Checks if product's count is 3.
        [Fact]
        public void Test_Index_Returns_ProductCount()
        {
            //Arrange
            var controller = new ProductController();
            var result = controller.Index() as ViewResult;

            //Act
            var productList = (List<Product>?)result?.ViewData.Model;

            //Assert
            Assert.Equal(3, productList?.Count);
        }

        //Checks the ViewName
        [Fact]
        public void Test_Details_Returns_ViewName()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.Equal("Details", result?.ViewName);
        }

        // Checks if Id is less than 1 and redirects to Index view
        [Fact]
        public void Test_Details_RedirectToIndex_IfIdLessThanOne()
        {
            var controller = new ProductController();
            var result = (RedirectToActionResult)controller.Details(-1);
            Assert.Equal("Index", result.ActionName);
        }

        //Check if id(3) is React JS (this will result to failed)
        [Fact]
        public void Test_Details_ReturnViewData()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            var product = result?.ViewData?.Model;

            Assert.Equal("ReactJS", product?.ToString());
        }

        [Fact]
        public void Test_Details_ReturnViewData_IfContainsName()
        {
            var controller = new ProductController();
            var result = controller.Details_Description(2) as ViewResult;
            var product = result?.ViewData?.Model as string;

            Assert.Contains("Free", product);
        }


        [Fact]
        public void Test_Details_ReturnViewData_Length()
        {
            var controller = new ProductController();

            var result = controller.Details(1) as ViewResult;
            var product = result?.ViewData?.Model as string;

            Assert.Equal(6, product?.Length);
        }

        [Fact]
        public void Test_Details_ReturnViewData_Price()
        {
            var controller = new ProductController();
            var result = controller.Details_Price(1) as ViewResult;
            var product = result?.ViewData?.Model as int?;

            Assert.Equal(40, product);
        }



    }
}
