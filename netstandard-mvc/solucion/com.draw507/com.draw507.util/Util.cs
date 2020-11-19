using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace com.draw507.util
{
    public static class Util
    {
        public static bool HasValue(this string value)
        {
            if (value == null) return false;

            return !string.IsNullOrEmpty(value.Trim());
        }

        public static string ToDateFormat(this DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        public static string ToDateFormat(this DateTime? date)
        {
            return date == null ? string.Empty : date.Value.ToString("yyyy-MM-dd");
        }

        public static bool AnyElements<T>(this IEnumerable<T> source) where T : class
        {
            if (source != null && source.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static IDictionary<string, object> UtilToDictionary(this object source)
        {
            return source.UtilToDictionary<object>();
        }

        public static IDictionary<string, T> UtilToDictionary<T>(this object source)
        {
            if (source == null) ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(source))
            {
                object value = property.GetValue(source);
                if (IsOfType<T>(value) || value == null)
                {
                    dictionary.Add(property.Name, (T)value);
                }
            }
            return dictionary;
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new NullReferenceException("Unable to convert anonymous object to a dictionary. The source anonymous object is null.");
        }

        public static bool IsValidEmail(this string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
