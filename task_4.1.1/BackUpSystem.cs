﻿using System;
using System.Collections.Generic;
using System.IO;

namespace task_4._1._1
{
    static class BackUpSystem
    {
        public static void StartRecovery(DateTime dateTime, string sourceDir, string sourceDirCopy)
        {
            if (Directory.Exists(sourceDir))
            {
                Directory.Delete(sourceDir, true);
            }

            Directory.CreateDirectory(sourceDir);
            Observer.DirCopyTxt(sourceDirCopy, sourceDir);
            List<Changes> changesInfos = Changes.ListLogInfo(dateTime);

            foreach (var item in changesInfos)
            {
                switch (item.ChangeType)
                {
                    case "Changed":
                        if (!Directory.Exists(Path.GetDirectoryName(item.Path)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(item.Path));
                        }

                        string tempFile = GetTempFile(item);
                        File.Copy(tempFile, item.Path, true);
                        break;

                    case "Created":
                        if (item.Path.EndsWith(".txt"))
                        {
                            File.Create(item.Path).Close();
                            break;
                        }
                        else
                        {
                            Directory.CreateDirectory(item.Path);
                            break;
                        }

                    case "Deleted":
                        if (item.Path.EndsWith(".txt"))
                        {
                            if (File.Exists(item.Path))
                            {
                                File.Delete(item.Path);
                            }

                            break;
                        }
                        else
                        {
                            if (Directory.Exists(item.Path))
                            {
                                Directory.Delete(item.Path, true);
                            }

                            break;
                        }

                    case "Renamed":
                        if (item.Path.EndsWith(".txt"))
                        {
                            File.Move(item.OldPath, item.Path);
                            break;
                        }
                        else
                        {
                            Directory.Move(item.OldPath, item.Path);
                            break;
                        }


                }
            }
        }

        private static string GetTempFile(Changes info)
        {
            string path = info.Path.Replace(ProgramPaths.WatchedDir, ProgramPaths.TempDir).Replace(Path.GetFileName(info.Path), "");
            path = Path.Combine(path, $"#{Log.DateFormatLog(info.ChangeTime)}#{Path.GetFileName(info.Path)}");
            return path;

        }
    }
}
