using System;

namespace higherLower
{
  class Player
  {
    private int LowerBound = 0;
    private int UpperBound = 101;

    public int GetLowerBound()
    {
      return LowerBound;
    }

    public int GetUpperBound()
    {
      return UpperBound;
    }

    public void SetLowerBound(int lowerBound)
    {
      LowerBound = lowerBound;
    }

    public void SetUpperBound(int upperBound)
    {
      UpperBound = upperBound;
    }

    public void Reset()
    {
      LowerBound = 0;
      UpperBound = 100;
    }

  }
}
