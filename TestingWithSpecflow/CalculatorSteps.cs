using TechTalk.SpecFlow;
using Xunit;

namespace TestingWithSpecflow
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }
    }

    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();

        private int actual;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)

        {
            calculator.FirstNumber = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculator.SecondNumber = p0;
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            actual = calculator.Subtract();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            actual = calculator.Add();
        }

        [When(@"I press Multiply")]
        public void WhenIPressMultiply()
        {
            actual = calculator.Multiply();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            Assert.Equal(expected, actual);
        }
    }
}