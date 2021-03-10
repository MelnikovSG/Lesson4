using UnityEngine;


namespace Asteroids
{
    internal class PlayerDestroy : Player
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
