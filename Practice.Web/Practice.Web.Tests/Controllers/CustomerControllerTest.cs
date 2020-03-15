﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice.Web;
using Practice.Web.Controllers;

namespace Practice.Web.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomerController controller = new CustomerController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void About()
        //{
        //    // Arrange
        //    CustomerController controller = new CustomerController();

        //    // Act
        //    //ViewResult result = controller.About() as ViewResult;

        //    // Assert
        //    //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        //}

        //[TestMethod]
        //public void Contact()
        //{
        //    // Arrange
        //    CustomerController controller = new CustomerController();

        //    // Act
        //    //ViewResult result = controller.Contact() as ViewResult;

        //    // Assert
        //    //Assert.IsNotNull(result);
        //}
    }
}
