#region

using TMPro;
using UnityEngine;

#endregion

namespace MVP_C
{
    public class PlayerMoveView
    {
    #region Private Variables

        private TMP_Text positionText;

    #endregion

    #region Unity events

        public void Update(Vector2 movement)
        {
            positionText.text = movement.ToString();
        }

    #endregion
    }
}