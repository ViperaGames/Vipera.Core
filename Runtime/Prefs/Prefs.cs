using System;
using UnityEngine;

namespace Vipera
{
    public class Prefs
    {
        public static string MenuSceneName = "Menu";
        public static bool ShowInterstitialBetweenScenes = false;

        public static System.DateTime FirstOpenTime
        {
            get
            {
                string sDateTime = PlayerPrefs.GetString("FirstOpenTime", string.Empty);

                if (string.IsNullOrEmpty(sDateTime))
                    return System.DateTime.MinValue;

                try
                {
                    long lDateTime = Convert.ToInt64(sDateTime);

                    return DateTime.FromBinary(lDateTime);
                }
                catch (System.Exception)
                {
                    return DateTime.Now;
                }
            }

            set
            {
                if (!PlayerPrefs.HasKey("FirstOpenTime"))
                    PlayerPrefs.SetString("FirstOpenTime", value.ToBinary().ToString());
            }
        }
        public static System.DateTime FirstOpenDay
        {
            get
            {
                string sDateTime = PlayerPrefs.GetString("FirstOpenDay", string.Empty);

                if (string.IsNullOrEmpty(sDateTime))
                    return System.DateTime.MinValue;

                try
                {
                    long lDateTime = Convert.ToInt64(sDateTime);

                    return DateTime.FromBinary(lDateTime);
                }
                catch (System.Exception)
                {
                    return DateTime.Now;
                }
            }

            set
            {
                if (!PlayerPrefs.HasKey("FirstOpenDay"))
                    PlayerPrefs.SetString("FirstOpenDay", value.ToBinary().ToString());
            }
        }

        public static bool IsVR
        {
            get { return PlayerPrefs.GetInt("PrefVRMode", 0) == 1; }
            set { PlayerPrefs.SetInt("PrefVRMode", value ? 1 : 0); }
        }
    }
}