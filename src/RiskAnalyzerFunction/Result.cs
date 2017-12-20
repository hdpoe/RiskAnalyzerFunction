namespace RiskAnalyzerFunction {

  public class Result {
    public int attackersLeft { get; set; }
    public int defendersLeft { get; set; }
    public bool defenderWon { get; set; }
    public bool attackerWon { get; set; }

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
