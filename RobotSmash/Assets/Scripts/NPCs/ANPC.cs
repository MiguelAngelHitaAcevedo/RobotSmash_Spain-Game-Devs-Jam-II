using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotSmash
{
    namespace NPC
    {
        public abstract class ANPC : ScriptableObject, IMovement
        {
            #region Variables
            [Header("Stats")]
            //Velocidad base del juagdor
            [SerializeField] protected float defaultSpeed = default;
            //Velocidad actual del jugador
            [SerializeField] private float dynamicSpeed = default;

            public float DynamicSpeed { set => dynamicSpeed = value; }
            #endregion

            #region Funtions
            //Movimiento cardinal W, A, S, D, teniendo en cuenta rotación local
            public abstract void Movement(Rigidbody rigidbody, Transform transform);

            //Rotación camara eje x
            public abstract void Rotation(Transform transform);

            //Devuelve los valores al default
            protected void ResetStats() { dynamicSpeed = defaultSpeed; }
            #endregion
        }

    }
}