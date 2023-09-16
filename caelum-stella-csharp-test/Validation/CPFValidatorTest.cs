using Caelum.Stella.CSharp.Error;
using Caelum.Stella.CSharp.Validation.Error;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Caelum.Stella.CSharp.Validation.Test
{
    // [TestClass]
    public class CPFValidatorTest : BaseDocumentValidatorTest
    {
        private CPFValidator cpfValidator = new CPFValidator();

        [Fact]
        public void DeveValidarCPFValido()
        {
            cpfValidator.AssertValid("11144477735");
            cpfValidator.AssertValid("88641577947");
            cpfValidator.AssertValid("34608514300");
            cpfValidator.AssertValid("47393545608");
        }

        [Fact]
        public void DeveValidarCPFNulo()
        {
            cpfValidator.AssertValid(null);
        }

        [Fact]
        public void DeveValidarCPFComZerosIniciais()
        {
            cpfValidator.AssertValid("01169538452");
        }

        [Fact]
        public void NaoDeveValidarCPFComMenosDigitosQueOExigido()
        {
            try
            {
                cpfValidator.AssertValid("1234567890");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                AssertMessage(e, DocumentError.InvalidDigits);
            }
        }

        [Fact]
        public void NaoDeveValidarCPFComMaisDigitosQueOExigido()
        {
            try
            {
                cpfValidator.AssertValid("123456789012");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                AssertMessage(e, DocumentError.InvalidDigits);
            }
        }

        [Fact]
        public void NaoDeveValidarCPFComCaracterInvalido()
        {
            try
            {
                cpfValidator.AssertValid("1111111a111");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                Assert.IsTrue(e.GetErrors().Count == 1);
                AssertMessage(e, DocumentError.InvalidDigits);
            }
        }

        [Fact]
        public void NaoDeveValidarDVComPrimeiroDVErrado()
        {
            // VALID CPF = 248.438.034-80
            try
            {
                cpfValidator.AssertValid("24843803470");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                Assert.IsTrue(e.GetErrors().Count == 1);
                AssertMessage(e, DocumentError.InvalidCheckDigits);
            }
        }

        [Fact]
        public void NaoDeveValidarDVComSegundoDVErrado()
        {
            // VALID CPF = 099.075.865-60
            try
            {
                cpfValidator.AssertValid("09907586561");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                Assert.IsTrue(e.GetErrors().Count == 1);
                AssertMessage(e, DocumentError.InvalidCheckDigits);
            }
        }

        [Fact]
        public void DeveValidarCPFValidoFormatado()
        {
            CPFValidator cpfValidator = new CPFValidator(true);
            cpfValidator.AssertValid("356.296.825-63");
        }

        [Fact]
        public void NaoDeveValidarCPFValidoNaoFormatado()
        {
            CPFValidator validator = new CPFValidator(true);
            // VALID CPF = 332.375.322-40
            try
            {
                validator.AssertValid("33237532240");
                Assert.Fail();
            }
            catch (InvalidStateException e)
            {
                Assert.IsTrue(e.GetErrors().Count == 1);
                AssertMessage(e, DocumentError.InvalidFormat);
            }
        }

        [Fact]
        public void NaoDeveValidarCPFComDigitosRepetidos()
        {
            string[] cpfs = new string[]
            {
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };

            CPFValidator validator = new CPFValidator();
            foreach (var cpf in cpfs)
            {
                try
                {
                    validator.AssertValid("22222222222");
                    Assert.Fail();
                }
                catch (InvalidStateException e)
                {
                    Assert.IsTrue(e.GetErrors().Count == 1);
                    AssertMessage(e, DocumentError.RepeatedDigits);
                }
            }
        }
    }
}
