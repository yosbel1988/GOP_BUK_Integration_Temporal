using System;
using System.Linq;
using System.Configuration;
using GOP_BUK_Bll;
using Serilog;
using Serilog.Sinks.File;
using Serilog.Sinks.SystemConsole;

namespace GOP_BUK_Integration
{
    //class Program_old
    //{
    //    static void Main(string[] args)
    //    {
    //        string sftpPathBackup, apiBasePath, token, sftpHost, sftpUserName, sftpPassword, sftpPath, excelFilePath, logsPath;
    //        int sftpPort;

    //        if (args.Length == 8)
    //        {
    //            apiBasePath = args[0];
    //            token = args[1];
    //            sftpHost = args[2];
    //            sftpPort = int.Parse(args[3]);
    //            sftpUserName = args[4];
    //            sftpPassword = args[5];
    //            sftpPath = args[6];
    //            logsPath = args[7];
    //        }
    //        else
    //        {
    //            apiBasePath = ConfigurationManager.AppSettings.Get("apiBasePath");
    //            token = ConfigurationManager.AppSettings.Get("token");
    //            sftpHost = ConfigurationManager.AppSettings.Get("sftpHost");
    //            sftpPort = (ConfigurationManager.AppSettings.Get("sftpPort") != null) ? int.Parse(ConfigurationManager.AppSettings.Get("sftpPort")) : 22;
    //            sftpUserName = ConfigurationManager.AppSettings.Get("sftpUserName");
    //            sftpPassword = ConfigurationManager.AppSettings.Get("sftpPassword");
    //            sftpPath = ConfigurationManager.AppSettings.Get("sftpPath");
    //            logsPath = @ConfigurationManager.AppSettings.Get("logsFullPath");
    //        }

    //        sftpPathBackup = sftpPath + "\\Respaldo";

    //        try
    //        {
    //            if (string.IsNullOrEmpty(logsPath))
    //            {
    //                logsPath = "Logs.txt";
    //            }

    //            Log.Logger = new LoggerConfiguration()
    //                .MinimumLevel.Debug()
    //                .WriteTo.Console()
    //                .WriteTo.File(logsPath, rollingInterval: RollingInterval.Day)
    //                .CreateLogger();

    //            Log.Information("------------------------------------------------");

    //            Log.Information("Starting the app");

    //            excelFilePath = @Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_Importador_Personas.xlsx";

    //            var txtFilePath = @Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_Monitoreo.txt";

    //            var data = BukApiClient.GetEntities(apiBasePath, token);

    //            var countOfEntities = 0;

    //            var info = new LogInfo();

    //            if (data.Any())
    //            {
    //                countOfEntities = GopReportManager.WriteExcelToSftp(excelFilePath, data.ToArray());

    //                SftpManager.Send(excelFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPath);

    //                info.CountOfRows = countOfEntities;
    //                info.NameOfFile = excelFilePath;
    //                info.State = "Procesado";
    //            }
    //            else
    //            {
    //                info.CountOfRows = 0;
    //                info.NameOfFile = string.Empty;
    //                info.State = "No Procesado";
    //            }

    //            GopReportManager.GenerateLogMonitorFile(txtFilePath, info);

    //            SftpManager.Send(txtFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPath);

    //            if (countOfEntities > 0)
    //            {
    //                SftpManager.Send(excelFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPathBackup);
    //                SftpManager.Send(txtFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPathBackup);
    //            }
    //            else
    //            {
    //                SftpManager.Send(txtFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPathBackup);
    //            }

    //            Log.Information("End the app. Review logs.");
    //        }
    //        catch (Exception ex)
    //        {
    //            Log.Error(ex, ex.Message);

    //            Log.Information("End the app whit errors. Review errors, fix its and retry.");

    //            Log.Information("------------------------------------------------");

    //            var info = new LogInfo
    //            {
    //                CountOfRows = 0,
    //                NameOfFile = string.Empty,
    //                State = "No Procesado"
    //            };

    //            var txtFilePath = @Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMMdd") + "_Monitoreo.txt";
    //            GopReportManager.GenerateLogMonitorFile(txtFilePath, info);
    //            SftpManager.Send(txtFilePath, sftpHost, sftpPort, sftpUserName, sftpPassword, sftpPathBackup);
    //        }
    //        finally
    //        {
    //            Log.CloseAndFlush();
    //        }
    //    }
    //}
}