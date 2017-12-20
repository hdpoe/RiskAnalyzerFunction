namespace RiskAnalyzerFunction {

  public class Analyzer {

    public static object Anaylze(ResultSet resultSet) {
      double winPrecentage = resultSet.winPrecentage();
      double lossPrecentage = (1.0 - winPrecentage);
      double avgArmiesRemaining = resultSet.avgArmiesRemaining();
      bool attack = winPrecentage > lossPrecentage;
      return new { winPrecentage = winPrecentage,
        lossPrecentage = lossPrecentage,
        avgArmiesRemaining = avgArmiesRemaining,
        attack = attack
      };
    }
  }
}
