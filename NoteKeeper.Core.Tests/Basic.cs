using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteKeeper.ViewModels;

namespace NoteKeeper.Tests
{
    [TestClass]
    public class Basic
    {
        [TestMethod]
        public void can_do_something_basic()
        {
            var itemDetailViewModel = new ItemDetailViewModel();

            Assert.IsNotNull(itemDetailViewModel);
        }
    }
}
