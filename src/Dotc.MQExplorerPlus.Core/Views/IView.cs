﻿#region copyright
//  
// Copyright (c) DOT Consulting scrl. All rights reserved.  
// Licensed under the provided EULA. See EULA file in the solution root for full license information.  
//
#endregion
namespace Dotc.MQExplorerPlus.Core.Views
{
    public interface IView
    {
        object DataContext { get; set; }
        double Height { get; set; }
        double Width { get; set; }

        double ActualWidth { get; }
        double ActualHeight { get; }
    }
}
