using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fignum.BusinessLogic;
namespace Fignum.Tests
{
    [TestFixture]
    public class FilterServiceTests
    {
        [Test]
        public void Filter_StringWithNonNumbers_ReturnsInputStringNotInteger()
        {
                //arrange
                var input = GetValidStringInput();
                input.InputString = input.InputString + "sometext" ;

                //act
                IFilterService stringService = new FilterService();
                var result = stringService.ProcessFilter(input);

                //assert            
                Assert.AreEqual(StringError.InputStringNotInteger, result.Error);
        }
        [Test]
        public void Filter_EmptyString_ReturnsInputStringRequired()
        {
                //arrange
                var input = GetValidStringInput();
                input.InputString = "";

                //act
                IFilterService stringService = new FilterService();
                var result = stringService.ProcessFilter(input);

                //assert            
                Assert.AreEqual(StringError.InputStringRequired, result.Error);
        }
        [Test]
        public void Filter_ValidString_ReturnsNonPrimeMumbersString()
        {
            //arrange
            var input = GetValidStringInput();            
            //act
            IFilterService stringService = new FilterService();
            var result = stringService.ProcessFilter(input);

            //assert            
            Assert.AreEqual("9", result.InputString);
        }
        [Test]
        public void Sort_StringWithNonNumbers_ReturnsInputStringNotInteger()
        {
            //arrange
            var input = GetValidStringInput();
            input.InputString = input.InputString + "sometext";

            //act
            IFilterService stringService = new FilterService();
            var result = stringService.ProcessSort(input);

            //assert            
            Assert.AreEqual(StringError.InputStringNotInteger, result.Error);
        }
        [Test]
        public void Sort_EmptyString_ReturnsInputStringRequired()
        {
            //arrange
            var input = GetValidStringInput();
            input.InputString = "";

            //act
            IFilterService stringService = new FilterService();
            var result = stringService.ProcessSort(input);

            //assert            
            Assert.AreEqual(StringError.InputStringRequired, result.Error);
        }
        [Test]
        public void Sort_ValidString_ReturnsSortedStringDescending()
        {
            //arrange
            var input = GetValidStringInput();
            //act
            IFilterService stringService = new FilterService();
            var result = stringService.ProcessSort(input);

            //assert            
            Assert.AreEqual("11,9,7,5,2", result.InputString);
        }
        #region Helpers
        private FilterResponse GetValidStringInput()
        {
                var stringInput = "9,2,11,7,5";
                return new FilterResponse(stringInput);
        }
         #endregion
    }   
}



