﻿using System;
using System.Windows.Forms;

namespace WaitWindow
{
    public partial class Window : Form
    {

        public event EventHandler CancelPressed;
        private readonly Timer _timer;
        private readonly Form _ownerForm;
        public Window(Form parentForm,
            Action<Event.WaitSimpleEvent> eventFinished, Action<Event.WaitSimpleEvent> eventCancelled,
            int timeout = 0,bool supportsCancellation = false)
        {
            InitializeComponent();
            button1.Visible = supportsCancellation;

            eventFinished(EventFinished);
            eventCancelled(EventCancelled);

            if (timeout == 0)
            {
                ShowDialog(parentForm);
                return;
            }
            _ownerForm = parentForm;
            _timer = new Timer {Interval = timeout};
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _timer.Stop();
            ShowDialog(_ownerForm);
            
        }


        public void EventFinished()
        {
            Close();
        }

        public void EventCancelled()
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CancelPressed != null)
                CancelPressed(sender,e);
        }
    }
}