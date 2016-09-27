﻿using System;
using UnityEngine;

namespace Assets.scripts.monster
{
    public class Monster : MonoBehaviour
    {
        public MonsterState State = null;
        private static Vector3 SpawnCoordinates { get { return new Vector3(-30.0f, 0.5f, 0.0f); } }

        void Start () {
            this.gameObject.transform.position = SpawnCoordinates;
            State = new EnteringState(this);
            State.Enter();
        }
	
        void Update ()
        {
            this.gameObject.transform.Translate(0.05f, 0.0f, 0.0f);
        }
    }
}