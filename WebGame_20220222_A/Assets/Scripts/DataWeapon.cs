using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    [CreateAssetMenu(menuName = "KID/Data Weapon", fileName ="Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("FlySpeed"), Range(0, 3500)]
        public float speedFly = 500;
        [Header("AttackDamage"), Range(0, 1000)]
        public float attack = 10;
        [Header("count"), Range(1, 5)]
        public int countStart = 1;
        [Header("Max"), Range(1, 50)]
        public int countMax = 20;
        [Header("Gap"), Range(0, 5)]
        public float interval = 3.5f;
        [Header("SpawnLocation")]
        public Vector3[] v2SpawnPoint;
        [Header("武器物件")]
        public GameObject goWeapon;
        [Header("FlyDirection")]
        public Vector3 v3Direction;
        
      
    }

}
