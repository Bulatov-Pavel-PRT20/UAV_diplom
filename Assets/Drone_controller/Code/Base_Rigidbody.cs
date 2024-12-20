﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bulatov
{
    [RequireComponent(typeof(Rigidbody))]
    public class Base_Rigidbody : MonoBehaviour
    {
        #region Variables
        [Header("Rigidbody Properties")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbsToKg = 0.454f;

        protected Rigidbody rb;
        protected float startDrag;
        protected float startAngularDrag;
        #endregion

        #region Main Methods

        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if(rb)
            {
                rb.mass = weightInLbs * lbsToKg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(!rb)
            {
                return;
            }

            HandlePhysics();
        }
        #endregion

        #region Custom Methods
        protected virtual void HandlePhysics() { }
        #endregion
    }
}