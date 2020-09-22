using UnityEngine;
using RobotSmash.RuntimeSet;

namespace RobotSmash
{
    namespace NPC
    {
        [CreateAssetMenu(fileName = "New RinoBot profile", menuName = "NPCs/RinoBot")]
        public class RinoBot : ANPC
        {
            #region Variables
            [SerializeField] private RuntimeSetGameObject playerRuntimeSet = default;
            #endregion

            #region Funtions
            //Comportamiento en el movimiento
            public override void Movement(Rigidbody rigidbody, Transform transform)
            {
                
            }

            //Comportamiento en la rotación
            public override void Rotation(Transform transform)
            {
                
            }
            #endregion
        }
    }
}
