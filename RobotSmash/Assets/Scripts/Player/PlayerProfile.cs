using RobotSmash.Variables;
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
            [SerializeField] private float defaultSpeed = default;
            [SerializeField] private FloatVariable dynamicSpeed = default;
            [SerializeField] private FloatVariable horizontalMove = default;
            [SerializeField] private FloatVariable verticalMove = default;

            public float HorizontalMove { set => horizontalMove.Value = value; }
            public float VerticalMove { set => verticalMove.Value = value; }
            #endregion

            #region Funtions
            //Movimiento del ratón y cruzeta
            public void Movement(Rigidbody rigidbody)
            {
                //Movimiento cardinal W, A, S, D
                Vector3 dirección = new Vector3(horizontalMove.Value * dynamicSpeed.Value, 0, verticalMove.Value * dynamicSpeed.Value);
                rigidbody.velocity = dirección;
            }

            public void LookDirection()
            {

            }

            public void ResetStats() 
            {
                dynamicSpeed.Value = defaultSpeed;
            }
            #endregion
        }
    }
}
