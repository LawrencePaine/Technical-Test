using System;
using System.Collections.Generic;

namespace Technical_Test
{
    public class AlertService
    {
        private readonly AlertDAO storage = new AlertDAO();

        public Guid RaiseAlert()
        {
            return this.storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return this.storage.GetAlert(id);
        }
    }

    public class AlertDAO : IAlertDAO
    {

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }
    }

    interface IAlertDAO
    {
       readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();
        void AddAlert();
        void GetAlert();
    }
}
