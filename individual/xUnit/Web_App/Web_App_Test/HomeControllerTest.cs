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
    public class HomeControllerTest
    {

        //Will check if the result of Viewname is as expected which is "Index".
        [Fact]
        public void Test_Index_ReturnsViewName()
        {
            //Arrange
            var controller = new HomeController();

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal("Index", result?.ViewName);

        }

        //Will check if the result of the ViewData is as expected which is null
        [Fact]
        public void Test_Index_ReturnsViewData()
        {
            //Arrange
            var controller = new HomeController();

            //Act
            var result = controller.Index() as ViewResult;
            var product = (Product?)result?.ViewData.Model;

            //Assert
            Assert.Null(product);
        }

    }
}
