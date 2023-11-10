using System;

using static System.Math;

namespace Zetavers.Game.User
{
    internal partial class User
    {
        public static string PlayerName = Environment.UserName;
        public static double Spart;
        public static int Fragments;

        public static double XP;
        public static int Level;

        public static double UpgradeXP = Floor(150 * Sqrt(Level));
        public static string XPPercent = Floor(XP / UpgradeXP * 100) + "%";
    }
}
