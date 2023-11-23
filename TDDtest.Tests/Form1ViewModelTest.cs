using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using TDD.UI;

namespace TDDtest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var mock = new Mock<IDB>();

            mock.Setup(x => x.GetDBValue()).Returns(100);

            var viewModel = new Form1ViewModel(mock.Object);
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CalculationAction();
            Assert.AreEqual("107", viewModel.ResultLabelText);

        }

        // Moqを使わない場合
        //internal class DBMock: IDB
        //{
        //    public int GetDBValue()
        //    {
        //        return 100;
        //    }
        //}
    }
}
