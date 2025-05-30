﻿using Syncfusion.Maui.Core;
using System.Globalization;

namespace EssentialMAUIUIKit.Converters
{
    /// <summary>
    /// This class have methods to convert the availability-status of chat message recipients from string to Syncfusion.XForms.BadgeView.BadgeIcon.
    /// </summary>
    public class StringToBadgeIconConverter : IValueConverter
    {
        /// <summary>
        /// This method is used to convert the string to badge icon.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Return the badge icon.</returns>
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return BadgeIcon.None;
            }

            return (string)value == "Available" ? BadgeIcon.Dot : BadgeIcon.None;
        }

        /// <summary>
        /// This method is used to convert the color to badge icon.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns null.</returns>
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}