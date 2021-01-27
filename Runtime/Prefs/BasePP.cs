namespace Vipera
{
    public abstract class BasePP<T>
    {
        protected T defaultValue;

        readonly string key;

        bool isCached;
        T cachedValue;

        public T Value
        {
            get
            {
                if (!isCached)
                {
                    if (UnityEngine.PlayerPrefs.HasKey(key))
                        cachedValue = GetValueByKey(key);
                    else
                        cachedValue = defaultValue;

                    isCached = true;
                }

                return cachedValue;
            }

            set
            {
                SetValueByKey(key, value);
                cachedValue = value;
                isCached = true;
            }
        }

        protected BasePP(string key)
        {
            this.key = key;
        }

        protected abstract T GetValueByKey(string key);
        protected abstract void SetValueByKey(string key, T value);
    }
}

