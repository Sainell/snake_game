using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class FlashlightController : BaseController
    {
        private FlashlightModel _model;
       

        private void Awake()
        {
            _model = FindObjectOfType<FlashlightModel>();
            Off();
        }

        public override void Off()
        {
            base.Off();
            _model.Off();
        }

        public override void On()
        {
            base.On();
            _model.On();
        }

        public void Switch()
        {
            if (IsEnabled)
                Off();
            else
                On();
        }
        public void BatteryCheck()
        {
            if (_model.IsOn)
            
            {
                _model.FlashBattery = _model.FlashBattery - (1 * Time.deltaTime);
                if (_model.FlashBattery <= 0) Off();
            }
            else if (_model.FlashBattery < _model.BatteryMax)
            {

                _model.FlashBattery = _model.FlashBattery + 1 * (Time.deltaTime);
            }
        }
        public void Update()
        {

            BatteryCheck();
        }
    }
}