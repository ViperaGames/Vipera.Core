namespace Vipera
{
    public class StringPP : BasePP<string>
    {
        string cachedValue;

        public StringPP(string key) : base(key)
        {
        }

        protected override string GetValueByKey(string key)
        {
            return UnityEngine.PlayerPrefs.GetString(key);
        }

        protected override void SetValueByKey(string key, string value)
        {
            UnityEngine.PlayerPrefs.SetString(key, value);
        }
    }
}