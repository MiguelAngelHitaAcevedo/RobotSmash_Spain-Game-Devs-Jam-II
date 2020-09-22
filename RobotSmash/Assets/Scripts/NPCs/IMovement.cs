using UnityEngine;

namespace RobotSmash
{
    namespace NPC
    {
        public interface IMovement
        {
            #region Funtions
            void Movement(Rigidbody rigidbody, Transform transform);
            void Rotation(Transform transform);
            #endregion
        }
    }
}
