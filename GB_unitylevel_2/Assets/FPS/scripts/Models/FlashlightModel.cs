using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class FlashlightModel : MonoBehaviour
    {
        private Light _light;
        public float BatteryMax = 20;
        public float FlashBattery;
        public bool IsOn
        {
            get
            {
                if (!_light) return false;
                return _light.enabled;
            }
        }

        private void Awake()
        {
            _light = GetComponent<Light>();
        }

        public void On()
        {
            if(FlashBattery>BatteryMax/3)
            _light.enabled = true;
        }

        public void Off()
        {
            _light.enabled = false;
        }

        public void Switch()
        {
            if (IsOn)
                Off();
            else
                On();
        }
        
        
      
		
    }
}