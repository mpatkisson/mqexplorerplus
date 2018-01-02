﻿#region copyright
//  
// Copyright (c) DOT Consulting scrl. All rights reserved.  
// Licensed under the provided EULA. See EULA file in the solution root for full license information.  
//
#endregion
using System;
using System.Globalization;
using System.Windows.Data;
using Dotc.MQ.Websphere;

namespace Dotc.MQExplorerPlus.Converters
{
    public class WsQueueTypeNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = (int)value;
            var name = WsQueueType.GetName(type);
            var s = parameter as string;
            if (s != null)
            {
                return string.Format(CultureInfo.InvariantCulture, s, name);
            }
            return name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
