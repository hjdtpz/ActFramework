using UnityEngine;
using System.Collections;

public class MonoSingleton<T> : MonoBehaviour where T:MonoBehaviour
{

    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject gameObject = new GameObject(typeof(T).ToString());
                gameObject.AddComponent<T>();
            }
            return instance;
        }
    }

    protected virtual void Awake()
    {
        print("Awake");
        if (instance != null)
        {
            throw new System.Exception("重复的单例实例:" + typeof(T));
        }

        instance =GetComponent<T>();
    }

    protected virtual void OnDestroy()
    {
        instance = null;
    }

    public static T Check()
    {
        return Instance;
    }
}
