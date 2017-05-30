using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace Geo.Web.Business.Configuration
{
    public abstract class ConfigurationBase
    {
        private readonly NameValueCollection _appSettings;

        protected ConfigurationBase()
        {
            _appSettings = ConfigurationManager.AppSettings;
        }

        protected T GetConfigSetting<T>(string name)
        {
            var setting = _appSettings[name];
            return ChangeType<T>(setting);
        }

        protected T ChangeType<T>(object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
        
        protected IEnumerable<T> GetEnumerableConfigSetting<T>(string key, char separator = ',') => GetConfigSetting<string>(key).Split(separator).Select(ChangeType<T>);
        
        protected T GetNullableSetting<T>(string key)
        {
            var setting = _appSettings[key];

            if (string.IsNullOrWhiteSpace(setting))
            {
                return default(T);
            }

            var thetype = typeof(T);
            var underlyingType = Nullable.GetUnderlyingType(thetype) ?? thetype;

            return (T)Convert.ChangeType(setting, underlyingType);
        }

    }
}
