﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Bulatov
{
    [RequireComponent(typeof(PlayerInput))]

    public class Drone_Inputs : MonoBehaviour
    {
        #region Varaiables
        private Vector2 cyclic;
        private float pedals;
        private float throttle;

        public Vector2 Cyclic { get => cyclic; }
        public global::System.Single Pedals { get => pedals; }
        public global::System.Single Throttle { get => throttle; }



        #endregion

        #region Main Methods



        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Input Methods
        private void OnCyclic(InputValue value)
        {
            cyclic = value.Get<Vector2>();
        }

        private void OnPedals(InputValue value)
        {
            pedals = value.Get<float>();
        }

        private void OnThrottle(InputValue value)
        {
            throttle = value.Get<float>();
        }
        #endregion
    }
}