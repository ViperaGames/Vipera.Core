namespace Vipera
{
    public class BoolPP : BasePP<bool>
    {
        bool cachedValue;

        public BoolPP(string key) : base(key)
        {
        }

        protected override bool GetValueByKey(string key)
        {
            return UnityEngine.PlayerPrefs.GetInt(key).Equals(1);
        }

        protected override void SetValueByKey(string key, bool value)
        {
            var result = value ? 1 : 0;
            UnityEngine.PlayerPrefs.SetInt(key, result);
        }

        public void SetDefaultValue(bool defaultValue)
        {
            this.defaultValue = defaultValue;
        }
    }
}