using System;
using Caelum.Stella.CSharp.Vault;
using System.Globalization;
using Xunit;

namespace Caelum.Stella.CSharp.Inwords.Test
{
    public class MoedaBRLTest
    {
        public void Initialize()
        {
        }

        [Fact]
        public void ShouldNotTransformNegativeDouble()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MoedaBRL(-1).Extenso());
        }

        [Fact]
        public void ShouldTransform0InWords()
        {
            string extenso = new MoedaBRL(0).Extenso();
            Assert.Equal("zero real", extenso);
        }

        [Fact]
        public void ShouldTransform99CentsInWords()
        {
            string extenso = new MoedaBRL(0.99).Extenso();
            Assert.Equal("noventa e nove centavos", extenso);
        }

        [Fact]
        public void ShouldTransform1InWords()
        {
            string extenso = new MoedaBRL(1).Extenso();
            Assert.Equal("um real", extenso);
        }

        [Fact]
        public void ShouldTransform1and37CentsInWords()
        {
            string extenso = new MoedaBRL(1.37).Extenso();
            Assert.Equal("um real e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform2InWords()
        {
            string extenso = new MoedaBRL(2).Extenso();
            Assert.Equal("dois reais", extenso);
        }

        [Fact]
        public void ShouldTransform2and37CentsInWords()
        {
            string extenso = new MoedaBRL(2.37).Extenso();
            Assert.Equal("dois reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform14InWords()
        {
            string extenso = new MoedaBRL(14).Extenso();
            Assert.Equal("quatorze reais", extenso);
        }

        [Fact]
        public void ShouldTransform14and37CentsInWords()
        {
            string extenso = new MoedaBRL(14.37).Extenso();
            Assert.Equal("quatorze reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform53InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(53).Extenso();
            Assert.Equal("cinquenta e três reais", extenso);
        }

        [Fact]
        public void ShouldTransform53and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(53.37).Extenso();
            Assert.Equal("cinquenta e três reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform99InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(99).Extenso();
            Assert.Equal("noventa e nove reais", extenso);
        }

        [Fact]
        public void ShouldTransform99and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(99.37).Extenso();
            Assert.Equal("noventa e nove reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformOneHundredInWords()
        {
            string extenso = new MoedaBRL(100).Extenso();
            Assert.Equal("cem reais", extenso);
        }

        [Fact]
        public void ShouldTransformOneHundredand37CentsInWords()
        {
            string extenso = new MoedaBRL(100.37).Extenso();
            Assert.Equal("cem reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform101InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(101).Extenso();
            Assert.Equal("cento e um reais", extenso);
        }

        [Fact]
        public void ShouldTransform101and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(101.37).Extenso();
            Assert.Equal("cento e um reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform199InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(199).Extenso();
            Assert.Equal("cento e noventa e nove reais", extenso);
        }

        [Fact]
        public void ShouldTransform199and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(199.37).Extenso();
            Assert.Equal("cento e noventa e nove reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform200InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(200).Extenso();
            Assert.Equal("duzentos reais", extenso);
        }

        [Fact]
        public void ShouldTransform200and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(200.37).Extenso();
            Assert.Equal("duzentos reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform201InWordsUsingAnd()
        {
            string extenso = new MoedaBRL(201).Extenso();
            Assert.Equal("duzentos e um reais", extenso);
        }

        [Fact]
        public void ShouldTransform201and37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(201.37).Extenso();
            Assert.Equal("duzentos e um reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform999InWords()
        {
            string extenso = new MoedaBRL(999).Extenso();
            Assert.Equal("novecentos e noventa e nove reais", extenso);
        }

        [Fact]
        public void ShouldTransform999and37CentsInWords()
        {
            string extenso = new MoedaBRL(999.37).Extenso();
            Assert.Equal("novecentos e noventa e nove reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformThousandInWords()
        {
            string extenso = new MoedaBRL(1000).Extenso();
            Assert.Equal("um mil reais", extenso);
        }

        [Fact]
        public void ShouldTransformThousandand37CentsInWords()
        {
            string extenso = new MoedaBRL(1000.37).Extenso();
            Assert.Equal("um mil reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform1001InWords()
        {
            string extenso = new MoedaBRL(1001).Extenso();
            Assert.Equal("um mil e um reais", extenso);
        }

        [Fact]
        public void ShouldTransform1001and37CentsInWords()
        {
            string extenso = new MoedaBRL(1001.37).Extenso();
            Assert.Equal("um mil e um reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformThousandInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(1031).Extenso();
            Assert.Equal("um mil e trinta e um reais", extenso);
        }

        [Fact]
        public void ShouldTransformThousandand37CentsInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(1031.37).Extenso();
            Assert.Equal("um mil e trinta e um reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform3108InWords()
        {
            string extenso = new MoedaBRL(3108).Extenso();
            Assert.Equal("três mil cento e oito reais", extenso);
        }

        [Fact]
        public void ShouldTransform3108and37CentsInWords()
        {
            string extenso = new MoedaBRL(3108.37).Extenso();
            Assert.Equal("três mil cento e oito reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformAMillionIntoNumberInWordsUsingSingular()
        {
            string extenso = new MoedaBRL(1000000).Extenso();
            Assert.Equal("um milhão de reais", extenso);
        }

        [Fact]
        public void ShouldTransformAMillionand37CentsIntoNumberInWordsUsingSingular()
        {
            string extenso = new MoedaBRL(1000000.37).Extenso();
            Assert.Equal("um milhão de reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformAMillionIntoNumberInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(1000150.99).Extenso();
            Assert.Equal("um milhão e cento e cinquenta reais e noventa e nove centavos", extenso);
        }

        [Fact]
        public void ShouldTransformAMillionAndThousandIntoNumberInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(1023850).Extenso();
            Assert.Equal("um milhão, vinte e três mil oitocentos e cinquenta reais", extenso);
        }

        [Fact]
        public void ShouldTransformAMillionAndThousandand37CentsIntoNumberInWordsUsingAnd()
        {
            string extenso = new MoedaBRL(1023850.37).Extenso();
            Assert.Equal("um milhão, vinte e três mil oitocentos e cinquenta reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransformTwoMillionUsingPlural()
        {
            string extenso = new MoedaBRL(2e6).Extenso();
            Assert.Equal("dois milhões de reais", extenso);
        }

        [Fact]
        public void ShouldTransformANumberInWordsUsingFraction()
        {
            string extenso = new MoedaBRL(222).Extenso();
            Assert.Equal("duzentos e vinte e dois reais", extenso);
        }

        [Fact]
        public void ShouldTransformANumberand37CentsInWordsUsingFraction()
        {
            string extenso = new MoedaBRL(222.37).Extenso();
            Assert.Equal("duzentos e vinte e dois reais e trinta e sete centavos", extenso);
        }

        [Fact]
        public void ShouldTransform1E21()
        {
            string extenso = new MoedaBRL(1E21).Extenso();
            Assert.Equal("um sextilhão de reais", extenso);
        }

        [Fact]
        public void ShouldTransform2E21()
        {
            string extenso = new MoedaBRL(2E21).Extenso();
            Assert.Equal("dois sextilhões de reais", extenso);
        }

        [Fact]
        public void ShouldTransformReais1and37CentsInWords()
        {
            Money money = new Money(new CultureInfo("pt-BR"), 1.37);
            string extenso = new MoedaBRL(money).Extenso();
            Assert.Equal("um real e trinta e sete centavos", extenso);
        }

        //[Fact]
        //public void ShouldTransformDollars1and37CentsInWords()
        //{
        //    string extenso = new MoedaBRL(new Money(new CultureInfo("en-US"), 1.37)).Extenso();
        //    Assert.Equal("um dólar e trinta e sete centavos", extenso);
        //}
    }
}
