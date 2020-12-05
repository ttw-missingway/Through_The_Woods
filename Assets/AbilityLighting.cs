﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TTW.Combat
{
    public class AbilityLighting : MonoBehaviour
    {
        [SerializeField] AbilityLightingController lightingController;
        [SerializeField] float intensity;
        [SerializeField] Quaternion rotation;

        Light light;

        // Start is called before the first frame update
        void Start()
        {
            light = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            if (lightingController != null)
            {
                light.intensity = lightingController.lightSourceIntensity;
                light.transform.rotation = lightingController.lightSourceRotation;
            }
        }
    }

}