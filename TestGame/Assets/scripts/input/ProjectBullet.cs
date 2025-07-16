using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input
{
    internal class ProjectBullet : MonoBehaviour
    {
        [SerializeField] private int speed = 10;
        [SerializeField] private int lifeTime = 5;
        [SerializeField] private int Demage = 1;
        [SerializeField] private Vector2 direction;


        public void Init(Vector3 targetDirection)
        {
            direction = (targetDirection - transform.position).normalized;
            Destroy(gameObject, lifeTime);
        }


        public void Update()
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            
            if (collision.TryGetComponent(out Enemy enemy))
            {
                enemy.HealPoints.TakeDamage(Demage);

                Destroy(gameObject);
            }
            
        }
    }
}
