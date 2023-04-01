using LopapaGames.ScriptableObjects;
using UnityEngine;

namespace _Scripts
{
    [RequireComponent(typeof(CharacterController), typeof(DirectionAttribute))]
    public class DirectionInput : MonoBehaviour
    {
        public Camera mainCamera;
        private CharacterController _characterController;
        private DirectionAttribute _directionAttribute;
        public Float speed;
        public bool requiresGrounded;
        private void Start()
        {
            mainCamera = Camera.main;
            _directionAttribute = GetComponent<DirectionAttribute>();
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
                if (!_characterController.enabled) return;
                var transform1 = mainCamera.transform;
                var forward = transform1.forward;
                var right = transform1.right;
                forward.y = 0f;
                right.y = 0f;
                forward.Normalize();
                right.Normalize();
                var horizontal = Input.GetAxis("Horizontal");
                var vertical = Input.GetAxis("Vertical");
                if (!_characterController.isGrounded && !requiresGrounded) return;
                var y = _directionAttribute.direction.y;
                // _newPos = new Vector3(horizontal, 0, vertical);
                _directionAttribute.direction = forward * vertical + horizontal * right;
                _directionAttribute.direction = transform.TransformDirection(_directionAttribute.direction);
                _directionAttribute.direction *= speed.Value;
                _directionAttribute.direction.y = y; //do not influence y here.
                _directionAttribute.directionChanged = horizontal != 0 || vertical != 0;
        }
    }
}
