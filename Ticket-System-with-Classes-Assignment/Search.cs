using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using NLog.Web;

namespace Ticketing_System
{
    public class Search
    {
        public TicketFile ticketFile;
        public EnhancementFile enhancementFile;
        public TaskFile taskFile;
        private static NLog.Logger logger = NLogBuilder.ConfigureNLog(Directory.GetCurrentDirectory() + "\\nlog.config").GetCurrentClassLogger();
        public Search(){
            string ticketFilePath = Directory.GetCurrentDirectory() + "\\tickets.csv";
            ticketFile = new TicketFile(ticketFilePath);

            string enhancementFilePath = Directory.GetCurrentDirectory() + "\\enhancements.csv";
            enhancementFile = new EnhancementFile(enhancementFilePath);

            string taskFilePath = Directory.GetCurrentDirectory() + "\\task.csv";
            taskFile = new TaskFile(taskFilePath);
        }

    }
}