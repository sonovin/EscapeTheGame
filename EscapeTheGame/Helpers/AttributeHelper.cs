using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheGame.Helpers
{
    public class AttributeHelper
    {
        public List<Attributes> UpdateStatus(List<Attributes> statusList, Attributes.Attribute targetStatus, int duration)
        {
            var found = false;
            for (int i = 0; i < statusList.Count; i++)
            {
                var status = statusList[i];
                if (status.Effect == targetStatus)
                {
                    status.Duration += duration;
                    statusList[i] = status;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                statusList.Add(new Attributes(targetStatus,duration));
            }
            return statusList;
        }
    }
}
