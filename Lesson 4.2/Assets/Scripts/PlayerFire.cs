using UnityEngine;

namespace Asteroids
{
    internal class PlayerFire : Player, IFire
    {
        public void Fire()
        {
            if (Input.GetButtonDown(mean.fire))
            {
                var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
            }
        }
    }
}
