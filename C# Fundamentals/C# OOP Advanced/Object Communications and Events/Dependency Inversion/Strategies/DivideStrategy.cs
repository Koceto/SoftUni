using Dependency_Inversion.Interfaces;

namespace Dependency_Inversion.Strategies
{
    public class DivideStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}