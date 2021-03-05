using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Entities
{
    public class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            var logRecordOther = obj as LogRecord;
            return UserName.Equals(logRecordOther.UserName);
        }
    }
}
