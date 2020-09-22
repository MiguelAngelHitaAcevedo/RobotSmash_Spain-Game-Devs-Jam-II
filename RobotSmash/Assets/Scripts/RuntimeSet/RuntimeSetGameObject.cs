using System.Collections.Generic;
using UnityEngine;

namespace RobotSmash
{
    namespace RuntimeSet
    {
        [CreateAssetMenu(fileName = "New RuntimeSet", menuName = "RuntimeSet")]
        public class RuntimeSetGameObject : ScriptableObject
        {
            #region Variables
            [SerializeField] private string[] SubsList = default;

            private Dictionary<string, GameObject> runtimeSet = default;
            #endregion

            #region Funtions
            public void Subscribe(GameObject gameObject)
            {
                if (!runtimeSet.ContainsKey(gameObject.name))
                    runtimeSet.Add(gameObject.name, gameObject);
            }

            public void UnSubscribe(GameObject gameObject)
            {
                if (runtimeSet.ContainsKey(gameObject.name))
                    runtimeSet.Remove(gameObject.name);
            }

            public GameObject GetGameObject(string name)
            {
                GameObject gameObject = null;

                if (runtimeSet.TryGetValue(name, out GameObject value))
                    gameObject = value;

                return gameObject;
            }

            private void UpdateList()
            {
                SubsList = new string[runtimeSet.Count];
            }
            #endregion
        }
    }
}
