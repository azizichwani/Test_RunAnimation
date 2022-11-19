using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankU.PlayerInput{
    [System.Serializable]
    public struct InputKey
    {
        [SerializeField] private KeyCode _leftKey;
        [SerializeField] private KeyCode _rightKey;
        [SerializeField] private KeyCode _upKey;
        [SerializeField] private KeyCode _downKey;


        public KeyCode LeftKey => _leftKey;
        public KeyCode RightKey => _rightKey;
        public KeyCode UpKey => _upKey;
        public KeyCode DownKey => _downKey;

    }
}
