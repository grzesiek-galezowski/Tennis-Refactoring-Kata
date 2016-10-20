namespace Tennis
{
  public class TennisGame3 : ITennisGame
  {
    private int _p2;
    private int _p1;
    private readonly string _p1N;
    private readonly string _p2N;

    public TennisGame3(string player1Name, string player2Name)
    {
      this._p1N = player1Name;
      this._p2N = player2Name;
    }

    public string GetScore()
    {
      string s;
      if ((_p1 < 4 && _p2 < 4) && (_p1 + _p2 < 6))
      {
        string[] p = {"Love", "Fifteen", "Thirty", "Forty"};
        s = p[_p1];
        return (_p1 == _p2) ? s + "-All" : s + "-" + p[_p2];
      }
      else
      {
        if (_p1 == _p2)
          return "Deuce";
        s = _p1 > _p2 ? _p1N : _p2N;
        return ((_p1 - _p2)*(_p1 - _p2) == 1) ? "Advantage " + s : "Win for " + s;
      }
    }

    public void WonPoint(string playerName)
    {
      if (playerName == "player1")
        this._p1 += 1;
      else
        this._p2 += 1;
    }

  }
}

