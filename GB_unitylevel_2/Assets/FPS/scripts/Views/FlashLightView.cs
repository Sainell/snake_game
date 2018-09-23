using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPS
{
    public class FlashLightView : MonoBehaviour {
    
    private FlashlightModel _model;
        public Texture2D icon1;
        public Texture2D icon2;
        public Texture2D icon3;
        public Texture2D icon4;

        void Start() {
            _model = FindObjectOfType<FlashlightModel>();

        }

   
    void Update() {

    }
        private void OnGUI()
        {
            GUI.BeginGroup(new Rect(0, 0, 500, 100));
            if (_model.FlashBattery > 0)
            {
                if (_model.FlashBattery > _model.BatteryMax*0.2)
                { GUI.Label(new Rect(0, 0, 100, 100), icon1); }
                if (_model.FlashBattery > _model.BatteryMax * 0.4)
                { GUI.Label(new Rect(30, 0, 100, 100), icon2); }
                if (_model.FlashBattery > _model.BatteryMax * 0.6)
                { GUI.Label(new Rect(60, 0, 100, 100), icon3); }
                if (_model.FlashBattery > _model.BatteryMax * 0.8)
                { GUI.Label(new Rect(90, 0, 100, 100), icon4); }
                
            }

            GUI.EndGroup();
        }
    }
}
