using RobotSmash.Variables;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotSmash 
{
    namespace Player
    {
        public class PlayerController : MonoBehaviour
        {
            #region Variables
            [SerializeField] private Rigidbody rb = default;
            //Aquí se almacena la lógica del jugador
            [SerializeField] private PlayerProfile playerProfile = default;
            //Camara del player
            [SerializeField] private Camera playerCamera = default;

            #endregion

            #region MonoBehaviour
            // Start is called before the first frame update
            private void Awake()
            {
                //Devuelve los valores al default
                playerProfile.ResetStats();
            }

            // Update is called once per frame
            void Update()
            {
                //Actualiza los float de los ejes
                playerProfile.MovementAxis = new Vector2(Input.GetAxisRaw("Horizontal") * Time.deltaTime, Input.GetAxisRaw("Vertical"));
                playerProfile.MouseAxis = new Vector2(Input.GetAxis("Mouse X") * playerProfile.MouseSensitivity,
                    Input.GetAxis("Mouse Y") * playerProfile.MouseSensitivity);

                //Llamada a la rotación
                playerProfile.Rotation(transform);
            }

            private void FixedUpdate()
            {
                //Llamada al movimiento
                playerProfile.Movement(rb, transform);
            }
            #endregion
        }
    }
}
