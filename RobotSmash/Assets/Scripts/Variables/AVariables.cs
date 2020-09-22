using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotSmash
{
    namespace Variables
    {
        public abstract class AVariables<T> : ScriptableObject
        {
            #region Variables
            [SerializeField] private T value = default;
            [TextArea(3, 7)]
            [SerializeField] private string description = default;

            public T Value { get => value; set => this.value = value; }
            #endregion
        }
    }
}
