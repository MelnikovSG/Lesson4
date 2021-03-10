using UnityEngine;

namespace Asteroids
{
    internal class PlayerMove : Player
    {
        internal void Move()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _rotation.Rotation(direction);

            _moveTransform.Move(Input.GetAxis(mean.hor), Input.GetAxis(mean.ver), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (_moveTransform is AccelerationMove accelerationMove)
                {
                    accelerationMove.AddAcceleration();
                }
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                if (_moveTransform is AccelerationMove accelerationMove)
                {
                    accelerationMove.RemoveAcceleration();
                }
            }
        }
    }
}
