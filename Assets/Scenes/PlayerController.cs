using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankU.PlayerInput;

namespace TankU.Player{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float playerSpeed;
        [SerializeField] private InputController inputController;


        private Vector3 _currentLooking = Vector3.zero;
        private Vector3 velocity;
        private Rigidbody rb;

        private void Awake()
        {
            rb = gameObject.GetComponent<Rigidbody>();

        }

        private void Update()
        {
            Vector3 _moveInput = inputController.MoveInput();
            rb.velocity = _moveInput * (playerSpeed*10) * Time.fixedDeltaTime;

            if (_currentLooking != _moveInput)
            {
                transform.rotation = Quaternion.LookRotation(_moveInput);
            }


        }
    }
}
