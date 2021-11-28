using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LoggingService
    {           /// <summary>
    /// allows us to use each object in the list through its Iloggable interface
    /// </summary>
    /// <param name="itemsToLog"></param>
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log());
            }
        }

    }
}
