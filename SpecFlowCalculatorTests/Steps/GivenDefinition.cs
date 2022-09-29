using ICT3101_Calculator;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class GivenDefinition
{
    
    public GivenDefinition()
    {
        calculator = new Calculator();
    }

    public Calculator calculator { get; set; }
    
    [Given(@"I have a calculator")]
    public void GivenIHaveACalculator()
    {
        calculator = new Calculator();
    }
}