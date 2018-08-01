using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToLEDService.Tests
{
    [TestClass]
    public class LEDTest
    {

        [TestMethod]
        public void Test_Zero_Pass()
        {
            var result = Service.LED.GetDisplayInfo(0);
            Assert.IsTrue(!result[0].Dot && result.Length == 1 && result[0].Top && result[0].TopLeft && result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Zero_Fail()
        {
            var result = Service.LED.GetDisplayInfo(0);  
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom); 
        }

        [TestMethod]
        public void Test_One_Pass()
        {
            var result = Service.LED.GetDisplayInfo(1);
            Assert.IsTrue(!result[0].Dot && !result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && !result[0].Bottom);
        }


        [TestMethod]
        public void Test_One_Fail()
        {
            var result = Service.LED.GetDisplayInfo(1);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && !result[0].BottomLeft && !result[0].BottomRight && !result[0].Bottom);
        }

        [TestMethod]
        public void Test_Two_Pass()
        {
            var result = Service.LED.GetDisplayInfo(2);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && result[0].Middle && result[0].BottomLeft && !result[0].BottomRight && result[0].Bottom);
        }


        [TestMethod]
        public void Test_Two_Fail()
        {
            var result = Service.LED.GetDisplayInfo(2);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && result[0].BottomLeft && !result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Three_Pass()
        {
            var result = Service.LED.GetDisplayInfo(3);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Three_Fail()
        {
            var result = Service.LED.GetDisplayInfo(3);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Four_Pass()
        {
            var result = Service.LED.GetDisplayInfo(4);
            Assert.IsTrue(!result[0].Dot && !result[0].Top && result[0].TopLeft && result[0].TopRight && result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && !result[0].Bottom);
        }

        [TestMethod]
        public void Test_Four_Fail()
        {
            var result = Service.LED.GetDisplayInfo(4);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Five_Pass()
        {
            var result = Service.LED.GetDisplayInfo(5);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }


        [TestMethod]
        public void Test_Five_Fail()
        {
            var result = Service.LED.GetDisplayInfo(5);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && result[0].BottomLeft && !result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Six_Pass()
        {
            var result = Service.LED.GetDisplayInfo(6);
            Assert.IsTrue(!result[0].Dot && !result[0].Top && result[0].TopLeft && !result[0].TopRight && result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Six_Fail()
        {
            var result = Service.LED.GetDisplayInfo(6);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Seven_Pass()
        {
            var result = Service.LED.GetDisplayInfo(7);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && !result[0].Bottom);
        }  


        [TestMethod]
        public void Test_Seven_Fail()
        {
            var result = Service.LED.GetDisplayInfo(7);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && !result[0].BottomLeft && !result[0].BottomRight && !result[0].Bottom);
        }

        [TestMethod]
        public void Test_Eight_Pass()
        {
            var result = Service.LED.GetDisplayInfo(8);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && result[0].TopRight && result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }

        [TestMethod]
        public void Test_Eight_Fail()
        {
            var result = Service.LED.GetDisplayInfo(8);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && !result[0].TopRight && !result[0].Middle && result[0].BottomLeft && result[0].BottomRight && result[0].Bottom);
        }


        [TestMethod]
        public void Test_Nine_Pass()
        {
            var result = Service.LED.GetDisplayInfo(9);
            Assert.IsTrue(!result[0].Dot && result[0].Top && result[0].TopLeft && result[0].TopRight && result[0].Middle && !result[0].BottomLeft && result[0].BottomRight && !result[0].Bottom);
        }


        [TestMethod]
        public void Test_Nine_Fail()
        {
            var result = Service.LED.GetDisplayInfo(9);
            Assert.IsTrue(!result[0].Dot && result[0].Top && !result[0].TopLeft && result[0].TopRight && !result[0].Middle && !result[0].BottomLeft && !result[0].BottomRight && !result[0].Bottom);
        }


        [TestMethod]
        public void Test_ValidDecimal_Pass()
        {
            var result = Service.LED.GetDisplayInfo(-100);
            Assert.IsTrue(result.Length == 4 &&
                (!result[0].Dot && !result[0].Top && !result[0].TopLeft && !result[0].TopRight && result[0].Middle && !result[0].BottomLeft && !result[0].BottomRight && !result[0].Bottom) &&
                (!result[1].Dot && !result[1].Top && !result[1].TopLeft && result[1].TopRight && !result[1].Middle && !result[1].BottomLeft && result[1].BottomRight && !result[1].Bottom) &&
                (!result[2].Dot && result[2].Top && result[2].TopLeft && result[2].TopRight && !result[2].Middle && result[2].BottomLeft && result[2].BottomRight && result[2].Bottom) &&
                (!result[3].Dot && result[3].Top && result[3].TopLeft && result[3].TopRight && !result[3].Middle && result[3].BottomLeft && result[3].BottomRight && result[3].Bottom)
                );
        }

        [TestMethod]
        public void Test_ValidDecimal2_Pass()
        {
            var result = Service.LED.GetDisplayInfo(-1.00m);
            Assert.IsTrue(result.Length == 4 &&
                (!result[0].Dot && !result[0].Top && !result[0].TopLeft && !result[0].TopRight && result[0].Middle && !result[0].BottomLeft && !result[0].BottomRight && !result[0].Bottom) &&
                (result[1].Dot && !result[1].Top && !result[1].TopLeft && result[1].TopRight && !result[1].Middle && !result[1].BottomLeft && result[1].BottomRight && !result[1].Bottom) &&
                (!result[2].Dot && result[2].Top && result[2].TopLeft && result[2].TopRight && !result[2].Middle && result[2].BottomLeft && result[2].BottomRight && result[2].Bottom) &&
                (!result[3].Dot && result[3].Top && result[3].TopLeft && result[3].TopRight && !result[3].Middle && result[3].BottomLeft && result[3].BottomRight && result[3].Bottom)
                );
        }
    }
}
