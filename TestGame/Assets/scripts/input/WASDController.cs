using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input 
{
    internal class WASDController : MonoBehaviour
    {
        private Vector2 direction;

        public Vector2 Direction { get => direction; }

        private void Update()
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");
        }




    }
}
