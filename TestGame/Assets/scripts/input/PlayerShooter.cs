using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.scripts.input
{
    public class PlayerShooter : MonoBehaviour
    {
        [SerializeField] private ProjectBullet bulletPrefab;
        [SerializeField] private Transform bulletSpawnPoint;
        [SerializeField] private int cooldownTime = 1;
        [SerializeField] private Target target;
        [SerializeField] private Button shootButton;
        
            
        private float lastShotTime;


        public void Start()
        {
            

            shootButton.onClick.AddListener(Shoot);
            lastShotTime = -cooldownTime; // Allow shooting immediately on start
        }

        public void Shoot()
        {
            if (Time.time - lastShotTime >= cooldownTime)
            {
                
                Transform enemy = target.GetTarget();
                if (enemy == null)
                {
                    
                    return;
                }
                lastShotTime = Time.time;
                ProjectBullet bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.Init(enemy.position);
            }
           
        }



    }
}
