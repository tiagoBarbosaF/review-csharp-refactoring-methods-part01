using Caelum.Stella.CSharp.Http;
using Caelum.Stella.CSharp.Http.Exceptions;
using Xunit;

namespace Caelum.Stella.CSharp.Test.Http
{
    //[TestClass]
    public class CEPTest
    {
        [Fact]
        public void ZipCodeShouldBeNull()
        {
            CEP cep = new CEP();
            Assert.True(cep.IsNull);
        }

        [Fact]
        public void EmptyZipCodeShouldBeInvalid()
        {
            var cep = "";
            Assert.Throws<InvalidZipCodeFormat>(() => new CEP(cep));
        }

        [Fact]
        public void ShorterZipCodeShouldBeInvalid()
        {
            var cep = "123456";
            
            Assert.Throws<InvalidZipCodeFormat>(() => new CEP(cep));
        }

        [Fact]
        public void LongerZipCodeShouldBeInvalid()
        {
            var cep = "123456789";
            Assert.Throws<InvalidZipCodeFormat>(() => new CEP(cep));
        }

        [Fact]
        public void AlphaNumericShouldBeInvalid()
        {
            var cep = "12a4b6c8";
            Assert.Throws<InvalidZipCodeFormat>(() => new CEP(cep));
        }

        [Fact]
        public void ShouldBeComparable()
        {
            CEP cepA = "04101-300";
            var cepB = cepA;

            Assert.Equal(0, cepA.CompareTo(cepB));
        }

        [Fact]
        public void ShouldBeEqual()
        {
            CEP cepA = "04101-300";
            var cepB = cepA;

            Assert.Equal(cepA, cepB);

            CEP cepC = "04101-300";
            Assert.Equal(cepA, cepC);
        }
    }
}
