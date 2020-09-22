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
            //Velocidad base del juagdor
            [SerializeField] private float defaultSpeed = default;
            //Velocidad actual del jugador
            [SerializeField] private FloatVariable dynamicSpeed = default;
            //Sensibilidad ratón
            [SerializeField] private FloatVariable mouseSensitivity = default;
            //Ejes
            [SerializeField] private Vector2Variable movementAxis = default;
            //Posición del ratón en el mundo
            [SerializeField] private Vector2Variable mouseAxis = default;

            public Vector2 MovementAxis { set => movementAxis.Value = value; }
            public Vector2 MouseAxis { set => mouseAxis.Value = value; }
            public float MouseSensitivity { get => mouseSensitivity.Value;  }
            #endregion

            #region Funtions
            //Movimiento cardinal W, A, S, D, teniendo en cuenta rotación local
            public void Movement(Rigidbody rigidbody, Transform transform)
            {
                Vector3 dirección = new Vector3(x: movementAxis.Value.x, y: 0, z: movementAxis.Value.y).normalized;
                rigidbody.velocity = transform.TransformDirection(dirección * dynamicSpeed.Value) * Time.fixedDeltaTime;
            }

            //Rotación camara eje x
            public void Rotation(Transform transform) { transform.Rotate(Vector3.up * mouseAxis.Value.x * mouseSensitivity.Value * Time.deltaTime); }

            //Devuelve los valores al default
            public void ResetStats() { dynamicSpeed.Value = defaultSpeed; }
            #endregion
        }
    }
}
