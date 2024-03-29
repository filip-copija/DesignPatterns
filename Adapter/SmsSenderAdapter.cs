﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();
        public void SendNotification(int userId, Notification notification)
        {
            string userNumber = null; // based on userId
            _smsSender.SendSms(userNumber, $"{notification.Title} {notification.Body}");
        }
    }
}
