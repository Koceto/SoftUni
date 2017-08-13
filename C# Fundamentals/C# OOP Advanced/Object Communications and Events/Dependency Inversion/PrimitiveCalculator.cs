using Dependency_Inversion.Interfaces;
using System;
using System.Linq;
using System.Reflection;

namespace Dependency_Inversion
{
    public class PrimitiveCalculator
    {
        private IStrategy mathStrategy;

        public PrimitiveCalculator(IStrategy strategy)
        {
            this.mathStrategy = strategy;
        }

        public void ChangeStrategy(char strategyOperator)
        {
            string strategyName = String.Empty;

            switch (strategyOperator)
            {
                case '+':
                    strategyName = "Addition";
                    break;

                case '-':
                    strategyName = "Subtraction";
                    break;

                case '*':
                    strategyName = "Multiply";
                    break;

                case '/':
                    strategyName = "Divide";
                    break;
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type strategyClassType = assembly.GetTypes().FirstOrDefault(s => s.Name.StartsWith(strategyName));
            this.mathStrategy = Activator.CreateInstance(strategyClassType) as IStrategy;
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.mathStrategy.Calculate(firstOperand, secondOperand);
        }
    }
}