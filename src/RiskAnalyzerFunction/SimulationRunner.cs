using System;
using System.Collections.Generic;

namespace RiskAnalyzerFunction {

  public class SimulationRunner {

    public static Random die = new Random();

    public static List<Result> runSimulation(int attackingArmies, int defendingArmies, int numberOfIterations) {
      var resultSet = new List<Result>();
       for(int i = 0; i < numberOfIterations; i++) {
         resultSet.Add(executeScenario(attackingArmies, defendingArmies));
       }
       return resultSet;
    }

    private static Result executeScenario(int attackingArmies, int defendingArmies) {
      while(attackingArmies > 0 && defendingArmies > 0) {
        int[] defendingRoll =  rollDice(Math.Min(2, defendingArmies));
        int[] attackingRoll =  rollDice(Math.Min(3, attackingArmies));
        for(int i = 0; defendingRoll[i] != 0; i++) {
          if(defendingRoll[i] < attackingRoll[i]) {
            defendingArmies--;
          } else {
            attackingArmies--;
          }
        }
      }
      String winner = null;
      if(defendingArmies > 0) {
        winner = "defender";
      } else {
        winner = "attacker";
      }

      return new Result(attackingArmies, defendingArmies, winner);
    }

    private static int[] rollDice(int numberOfDice) {
      int[] result  = new int[numberOfDice];
      for(int i = 0; i <numberOfDice; i++) {
        result[i] = die.Next(1,7);
      }
      return result;
    }
  }
}

