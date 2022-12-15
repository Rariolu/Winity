using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinityEditorLib
{
    public class WriterUtil
    {
        Dictionary<Type, int> componentTypeCounts = new Dictionary<Type, int>();
        public int GetTypeCount(Type t, bool increment = true)
        {
            if (componentTypeCounts.ContainsKey(t))
            {
                return increment ? ++componentTypeCounts[t] : componentTypeCounts[t];
            }
            componentTypeCounts.Add(t, 0);
            return 0;
        }
        public void ResetComponentTypeCounts()
        {
            componentTypeCounts.Clear();
        }
    }
}