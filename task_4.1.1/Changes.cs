using System;
using System.Collections.Generic;
using System.IO;

namespace task_4._1._1
{
    class Changes
    {
        public DateTime ChangeTime { get; private set; }
        public string ChangeType { get; private set; }
        public string Path { get; private set; }
        public string OldPath { get; private set; }

        public Changes(string time, string changeType, string path)
        {
            ChangeTime = DateTime.Parse(time);
            ChangeType = changeType;
            Path = path;
        }

        public Changes(string time, string changeType, string path, string oldPath)
            : this(time, changeType, path)
        {
            OldPath = oldPath;
        }

        public static List<Changes> ListLogInfo(DateTime date)
        {
            List<Changes> items = new List<Changes> { };
            using (StreamReader reader = File.OpenText(ProgramPaths.LogFilePath))
            {
                string logLine;
                while ((logLine = reader.ReadLine()) != null)
                {
                    var item = LogInfo(logLine);
                    if (item.ChangeTime < date)
                    {
                        items.Add(item);
                    }

                }
            }
            return items;
        }

        private static Changes LogInfo(string logLine)
        {
            string[] str = logLine.Split('$');
            string changeTime = str[0];
            string changeType = str[1];

            if (changeType == "Created" || changeType == "Deleted" || changeType == "Changed")
            {
                string path = str[2];
                return new Changes(changeTime, changeType, path);
            }
            else
            {
                string oldPath = str[3];
                string path = str[2];
                return new Changes(changeTime, changeType, path, oldPath);
            }
        }

    }
}
