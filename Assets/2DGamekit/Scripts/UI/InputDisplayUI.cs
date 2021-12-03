using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Gamekit2D
{
    public class InputDisplayUI : MonoBehaviour
    {
        public PlayerInput UIPlayer;

        private void OnEnable()
        {
            TextMeshProUGUI textUI = GetComponent<TextMeshProUGUI>();
            if (UIPlayer == null)
            {
                textUI.SetText("## ERROR ## No PlayerInput detected");
                return;
            }

            StringBuilder builder = new StringBuilder();

            builder.AppendFormat("{0} - Move Left\n", UIPlayer.Horizontal.negative.ToString());
            builder.AppendFormat("{0} - Move Right\n", UIPlayer.Horizontal.positive.ToString());
            builder.AppendFormat("{0} - Look Up\n", UIPlayer.Vertical.positive.ToString());
            builder.AppendFormat("{0} - Crouch\n", UIPlayer.Vertical.negative.ToString());
            builder.AppendFormat("{0} - Jump\n", UIPlayer.Jump.key.ToString());
            builder.AppendFormat("{0} - Fire range weapon\n", UIPlayer.RangedAttack.key.ToString());
            builder.AppendFormat("{0} - Melee Attack\n", UIPlayer.MeleeAttack.key.ToString());
            builder.AppendFormat("{0} - Pause Menu\n", UIPlayer.Pause.key.ToString());

            textUI.SetText(builder);
        }
    }
}