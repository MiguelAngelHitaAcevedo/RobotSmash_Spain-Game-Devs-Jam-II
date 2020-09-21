using RobotSmash.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotSmash
{
    namespace Player
    {
        [CreateAssetMenu (fileName = "New player profile", menuName = "Profiles/Player")]
        public class PlayerProfile : ScriptableObject
        {
            #region Variables
            [Header("Stats")]
            [SerializeField] private readonly float defaultSpeed = default;
            [SerializeField] private FloatVariable dynamicSpeed = default;
            [SerializeField] private FloatVariable horizontalMove = default;
            [SerializeField] private FloatVariable verticalMove = default;
            #endregion

            #region Funtions
            //Movimiento del ratón y cruzeta
            public void Movement(Rigidbody rigidbody, Transform transform )
            {
                //Movimiento cardinal W, A, S, D
                Vector3 dirección = new Vector3(transform.right * horizontalMove.Value, 0,transform.forward * verticalMove.Value);
                //rigidbody.MovePosition(rigidbody.position + vector2EnCamino * dynamicSpeed.Value * Time.fixedDeltaTime);


            }

            public void ResetStats() 
            {
                dynamicSpeed.Value = defaultSpeed;
            }
            #endregion
        }
    }
}
