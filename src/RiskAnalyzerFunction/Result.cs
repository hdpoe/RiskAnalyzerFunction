namespace  RiskAnalyzerFunction {

  public class Result {
    private int attackersLeft { get; set; }
    private int defendersLeft { get; set; }
    private bool defenderWon { get; set; }
    private bool attackerWon { get; set; }

    public Result(int attackers, int defenders, string winner) {
      this.attackersLeft = attackers;
      this.defendersLeft = defenders;
      if(winner == "defender") {
        this.defenderWon = true;
        this.attackerWon = false;
      } else if(winner == "attacker") {
        this.defenderWon = false;
        this.attackerWon = true;
      }
    }
  }
}
