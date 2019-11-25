﻿using Caliburn.Micro;
using System;

namespace Notifications.Wpf.Core.Caliburn.Micro.Sample.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private readonly INotificationManager _manager;

        public ShellViewModel(INotificationManager manager)
        {
            _manager = manager;
        }

        public void Show()
        {
            var content = new NotificationViewModel(_manager)
            {
                Title = "Custom notification.",
                Message = "Click on buttons!"
            };

            _manager.Show(content, expirationTime: TimeSpan.FromSeconds(30));
        }

        public void ShowInWindow()
        {
            _manager.Show(new NotificationContent { Title = "Message", Message = "Message in window" }, areaName: "WindowArea");
        }
    }
}
