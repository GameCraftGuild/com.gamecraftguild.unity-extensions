using UnityEngine;

namespace GameCraftGuild.UnityExtensions.MonoBehaviours
{
    public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        private static T _Instance = null;

        public static T Instance => _Instance;

        private void Awake()
        {
            if (_Instance != null && _Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                _Instance = (T) this;
                //DontDestroyOnLoad(this);
            }
        }
    }
}
