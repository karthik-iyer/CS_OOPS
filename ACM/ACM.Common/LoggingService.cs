using System;
using System.Collections.Generic;
using ACM.BL;

namespace ACM.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILog> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                Console.WriteLine(item.Log() + Environment.NewLine);
            }
        }
    }
}