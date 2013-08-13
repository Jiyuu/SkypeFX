﻿using NAudio.Wave;
// This effect Copyright (C) 2004 and later Cockos Incorporated
// License: GPL - http://www.gnu.org/licenses/gpl.html
// Ported to .NET by Mark Heath
using System;
using System.ComponentModel.Composition;
using System.IO;

namespace JSNet
{
    [Export(typeof(Effect))]    
    public class Monitor : Effect
    {
        //FileStream fs;
        //WaveFileWriter wf;
        //WaveBuffer bf;
        BufferedWaveProvider bwp;
        NAudio.Wave.IWavePlayer o;
        public Monitor()
        {
            AddSlider(6, 0, 200, 1, "BOOKI (ms)");
            //fs= File.Create();
            //bf = new WaveBuffer(20000);

            
             //wf= new WaveFileWriter("c:\\DEV\\in"+DateTime.Now.ToShortTimeString().Replace(":","")+".wav", WaveFormat.CreateIeeeFloatWaveFormat(16000, 1));
        }

        //float odelay;
        //float delaylen;
        //float wetmix;
        //float wetmix2;
        //float drymix2;
        //float dppossc;
        //float dpbacksc;
        //float dppos;
        //float dpback;
        //float dpint;
        //float delaypos;
        //float[] buffer = new float[500000];

        public override string Name
        {
            get { return "Monitor"; }
        }

        public override void Init()
        {
            NAudio.CoreAudioApi.MMDeviceEnumerator a = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var dev = a.GetDefaultAudioEndpoint(NAudio.CoreAudioApi.DataFlow.Render, NAudio.CoreAudioApi.Role.Multimedia);
            o = new WasapiOut(dev,NAudio.CoreAudioApi.AudioClientShareMode.Shared,false, 50);
             
            //o = new WaveOut();
            bwp = new BufferedWaveProvider(WaveFormat.CreateIeeeFloatWaveFormat(16000, 1));
            bwp.BufferDuration = TimeSpan.FromMilliseconds(2000);
            bwp.DiscardOnBufferOverflow = true;
            o.Init(bwp);
            o.Play();
            //delaypos = 0;
        }

        public override void Slider()
        {
            //odelay = delaylen;
            //delaylen = Math.Min(slider1 * SampleRate / 1000,500000);
            ////if (odelay != delaylen) freembuf(delaylen*2);

            //wetmix = pow(2, slider2 / 6);
            //wetmix2 = pow(2, slider3 / 6);
            //drymix2 = pow(2, slider4 / 6);
            //dppossc = 2 * PI * slider5 / SampleRate;
            //dpbacksc = delaylen * 0.5f - 1;
        }

        public override void Sample(ref float spl0, ref float spl1)
        {
            bwp.AddSamples(BitConverter.GetBytes(spl0), 0, 4);
            //if (o.PlaybackState != PlaybackState.Playing)
            //    o.Play();
            //wf.WriteSample(spl0);
            //dppos = dppos+dppossc;
            //dpback = (sin(dppos)+1)*dpbacksc;
            //dpint = delaypos-dpback-1;
            //if(dpint < 0) dpint += delaylen;

            //dpint *= 2;

            //float os1 = buffer[(int)dpint+0];
            //float os2 = buffer[(int)dpint+1];

            //dpint = delaypos*2;

            //buffer[(int)dpint+0] = spl0 + os1*wetmix;
            //buffer[(int)dpint+1] = spl1 + os2*wetmix;
            //delaypos+=1;
            //if(delaypos >= delaylen) delaypos=0;

            //spl0=spl0*drymix2 + os1*wetmix2;
            //spl1=spl1*drymix2 + os2*wetmix2;
        }
    }
}
