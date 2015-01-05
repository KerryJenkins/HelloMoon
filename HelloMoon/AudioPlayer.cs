using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace HelloMoon
{
    public class AudioPlayer : Java.Lang.Object, MediaPlayer.IOnCompletionListener
    {
        private MediaPlayer _player;

        public void Stop()
        {
            if (_player != null)
            {
                _player.Release();
                _player = null;
            }
        }

        public void Play(Context c)
        {
            Stop();

            _player = MediaPlayer.Create(c, Resource.Raw.one_small_step);

            _player.SetOnCompletionListener(this);

            _player.Start();
        }

    
        void MediaPlayer.IOnCompletionListener.OnCompletion(MediaPlayer mp)
        {
            Stop();
        }
    }
}