using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input
{
    internal class MvementAgriagtor : MonoBehaviour
    {
        [SerializeField]private PlayerControlOld playerControlold;
        [SerializeField]private WASDController wasdController;
        [SerializeField]private JoysticController joystickController;

        private void Update()
        {
            playerControlold.setMovement(joystickController.Direction);

            
        }


    }
}
