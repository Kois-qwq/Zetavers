namespace Zetavers.Game
{
    internal partial class GameScore
    {
        public int Score { get; set; }
        public int Combo { get; set; }
        public int MaxCombo { get; set; }
        public int Perfect_X { get; set; } // Perfect+
        public int Perfect { get; set; }   // Perfect
        public int Great { get; set; }
        public int Good { get; set; }
        public int Bad { get; set; }
        public int Miss { get; set; }
        public GameScore()
        {
            Score = 0;
            Combo = 0;
            MaxCombo = 0;
            Perfect_X = 0;
            Perfect = 0;
            Great = 0;
            Good = 0;
            Bad = 0;
            Miss = 0;
        }
        public void CalcCore(int n)
        {
            switch (n)
            {
                case 0:
                    Score += 100 + Combo;
                    Perfect_X++;
                    Combo++;
                    break;
                case 1:
                    Score += 100 + Combo;
                    Perfect++;
                    Combo++;
                    break;
                case 2:
                    Score += 80 + (int)(Combo * 0.5);
                    Great++;
                    Combo++;
                    break;
                case 3:
                    Score += 50 + (int)(Combo * 0.5);
                    Good++;
                    Combo++;
                    break;
                case 4:
                    Score += 20 + (int)(Combo * 0.5);
                    Bad++;
                    Combo = 0;
                    break;
                case 5:
                    Miss++;
                    Combo = 0;
                    break;
            }
            if (MaxCombo < Combo)
            {
                MaxCombo = Combo;
            }
        }
        public void Reset()
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(GameScore).GetProperties())
            {
                if (prop.CanWrite && prop.GetSetMethod() != null)
                {
                    prop.SetValue(this, 0);
                }
            }
        }
    }
}
