﻿using DemoQAExecise.Tests;
using NUnit.Framework;
using System.Threading;
using DemoQAExercise.Pages.Interaction.Resizable;

namespace DemoQAExercise.Tests.InteractionsPanel
{
    [TestFixture]
    public class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();

            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigationToPage("Resizable");
            _resizablePage.PageLoad();
        }

        [Test]
        public void Test3_1_Resizable_MinimumCheck()
        {
            Thread.Sleep(500);
            Builder.ClickAndHold(_resizablePage.ResizableHandle).MoveByOffset(-50, -50).Release().Perform();

            _resizablePage.AssertResizableHandlePositionToMinimum();
        }


        [Test]
        public void Test3_2_Resizable_MaximumCheck()
        {
            Thread.Sleep(500);
            Builder.ClickAndHold(_resizablePage.ResizableHandle).MoveByOffset(300, 100).Release().Perform();

            _resizablePage.AssertResizableHandlePositionToMaximum();

        }

        [TearDown]
        public void TearDown()
        {
            ScreenshotToScreenshotDirectory();

            Driver.Quit();
        }
    }
}
