using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace HelloMoon
{
    public class HelloMoonFragment : Fragment
    {
        private AudioPlayer _player = new AudioPlayer();
        private Button _playButton;
        private Button _stopButton;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.fragment_hello_moon, container, false);

            _playButton = v.FindViewById<Button>(Resource.Id.hellomoon_playButton);
            _playButton.Click += _playButton_Click;

            _stopButton = v.FindViewById<Button>(Resource.Id.hellomoon_stopButton);
            _stopButton.Click += _stopButton_Click;

            return v;
        }

        void _stopButton_Click(object sender, EventArgs e)
        {
            _player.Stop();
        }

        void _playButton_Click(object sender, EventArgs e)
        {
            _player.Play(Activity);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            _player.Stop();
        }
    }
}