﻿using FakeBand.Utils;
using Microsoft.Band.Sensors;
using System;
using System.Collections.Generic;

namespace FakeBand.Fakes
{
    public class FakeSkinTemperatureSensor : FakeBandSensor<IBandSkinTemperatureReading>
    {
        internal FakeSkinTemperatureSensor(BandTypeConstants bandType) :
            base(new List<BandType>
        {
            BandType.Cargo,
            BandType.Envoy
        }, new Dictionary<TimeSpan, SubscriptionType>
        {
            {
                TimeSpan.FromMinutes(1.0),
                SubscriptionType.SkinTemperature
            }
        }, bandType)
        {
        }

        Random _rand = new Random();

        public override IBandSensorReading CreateReading()
        {
            return new FakeBandSkinTemperatureReading(_rand.Next(35, 160));
        }
    }
}