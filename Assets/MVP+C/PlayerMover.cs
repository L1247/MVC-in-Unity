#region

using UnityEngine;

#endregion

namespace MVP_C
{
    public class PlayerMover
    {
    #region Private Variables

        private Transform transform;

    #endregion

    #region Public Methods

        public void Move(Vector2 movement)
        {
            transform.position += (Vector3)movement;
        }

    #endregion
    }
}