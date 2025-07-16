using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace Assets.scripts.input
{
    
    interface IDamage
    {
        
        void TakeDamage(float amount);
        float GetHealth();
    }
    
}
