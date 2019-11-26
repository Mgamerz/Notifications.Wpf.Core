﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Notifications.Wpf.Core
{
    public interface INotificationManager
    {
        Task ShowAsync(object content, string areaName = "", TimeSpan? expirationTime = null, Action? onClick = null, Action? onClose = null,
                CancellationToken token = default);
    }
}