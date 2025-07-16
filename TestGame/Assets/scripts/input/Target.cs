using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input
{
    public class Target : MonoBehaviour
    {
        [SerializeField] private float AttackRange;
        [SerializeField] private LayerMask enemylayer;
        

        public Transform GetTarget()
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange, enemylayer);
            if (colliders.Length > 0)
            {
                return colliders[0].transform;
            }
            return null;
        }
    }
}
