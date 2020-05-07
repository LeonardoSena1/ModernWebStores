using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStores.SharedKernel.Events
{
    public class DomainNotification
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOccurrent { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value; 
            this.DateOccurrent = DateTime.Now;
        }

    }
}
