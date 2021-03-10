using UnityEngine;


namespace Asteroids
{
    abstract class Player : MonoBehaviour
    {
        [SerializeField] internal float _speed;
        [SerializeField] internal float _acceleration;
        [SerializeField] internal float _hp;
        [SerializeField] internal Rigidbody2D _bullet;
        [SerializeField] internal Transform _barrel;
        [SerializeField] internal float _force;
        internal Rigidbody2D rb;
        internal Camera _camera;
        internal IMove _moveTransform;
        internal IRotation _rotation;

        internal PlayerMove move = new PlayerMove();
        internal Meaning mean = new Meaning();

        private void Start()
        {
            _camera = Camera.main;
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            _rotation = new RotationShip(transform);
        }

        private void Update()
        {
            move.Move();
        }
    }
}

