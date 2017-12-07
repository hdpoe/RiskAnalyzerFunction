using System;
using System.Collections.Generic;
using Xunit;
using RiskAnalyzerFunction;

namespace RiskAnalyzerFunction.Tests
{
    public class SimulationRunnerTest
    {
        [Fact]
        public void TestrunSimluation()
        {
          int defendingArmies = 5;
          int attackingArmies = 5;
          int numberOfSimulations = 3;

          List<Result> result1 = SimulationRunner.runSimulation(attackingArmies, defendingArmies, numberOfSimulations);
          Assert.Equal(result1.Count, 3);

          defendingArmies = 5;
          attackingArmies = 5;
          numberOfSimulations = 30;

          List<Result> result2 = SimulationRunner.runSimulation(attackingArmies, defendingArmies, numberOfSimulations);
          Assert.Equal(result2.Count, 30);

        }
    }
}
