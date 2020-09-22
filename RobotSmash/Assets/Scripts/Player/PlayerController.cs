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
                playerProfile.HorizontalMove = Input.GetAxisRaw("Horizontal");
                playerProfile.VerticalMove = Input.GetAxisRaw("Vertical");
            }

            private void FixedUpdate()
            {
                //Llamada al movimiento
                playerProfile.Movement(rb);
            }
            #endregion

            #region Funtions

            #endregion
        }
    }
}
