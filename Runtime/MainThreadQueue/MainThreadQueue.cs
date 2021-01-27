using System;
using System.Collections.Generic;
using UnityEngine;

namespace Vipera
{
    public class MainThreadQueue : MonoBehaviour
    {
        Queue<Action> actionsQueue = new Queue<Action>();

        static MainThreadQueue instance;

        static MainThreadQueue Instance
        {
            get
            {
                if (instance == null)
                    Init();

                return instance;
            }
        }

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            if (instance != null)
                return;

            instance = new GameObject("MainThreadQueue").AddComponent<MainThreadQueue>();
            DontDestroyOnLoad(instance.gameObject);

        }

        public static void Enqueue(Action action)
        {
            Instance.actionsQueue.Enqueue(action);
        }

        void Update()
        {
            if (actionsQueue.Count > 0)
                actionsQueue.Dequeue()();
        }
    }
}