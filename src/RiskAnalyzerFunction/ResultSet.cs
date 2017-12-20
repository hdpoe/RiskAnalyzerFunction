using System.Collections.Generic;
using System;

namespace RiskAnalyzerFunction {

  public class ResultSet {
    private List<Result> wins { get; set; }
    private List<Result> losses { get; set; }

    public ResultSet() {
      wins = new List<Result>();
      losses = new List<Result>();
    }

    public void Add(Result result) {
      if(result.attackerWon) {
        wins.Add(result);
      } else {
        losses.Add(result);
      }
    }

    public int Count() {
      return wins.Count + losses.Count;
    }

    public double winPrecentage() {
      return Convert.ToDouble(wins.Count) / Convert.ToDouble(this.Count());
    }

    public double avgArmiesRemaining() {
      double remaining = 0.0;
      foreach(var result in wins) {
        remaining += result.attackersLeft;
      }
     return remaining / Convert.ToDouble(this.Count());
    }
  }
}
