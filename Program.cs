﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA.Presentation;
using FISCA;

namespace ExportExample
{
    public class Program
    {
        [MainMethod]
        static public void Main()
        {
            MenuButton rbItemExport1 = K12.Presentation.NLDPanels.Student.RibbonBarItems["資料統計"]["匯出"]["學務相關匯出"];
            rbItemExport1["匯出文字評量"].Enable = Permissions.匯出範例權限;
            rbItemExport1["匯出文字評量"].Click += delegate
            {
                SmartSchool.API.PlugIn.Export.Exporter exporter = new ExportMoralScore();
                ExportMoralScoreUI wizard = new ExportMoralScoreUI(exporter.Text, exporter.Image);
                exporter.InitializeExport(wizard);
                wizard.ShowDialog();
            };
        }
    }
}
