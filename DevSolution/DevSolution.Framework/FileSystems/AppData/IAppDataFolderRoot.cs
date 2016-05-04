﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace DevSolution.FileSystems.AppData
{
    /// <summary>
    /// Abstraction over the root location of "~/App_Data", mainly to enable
    /// unit testing of AppDataFolder.
    /// </summary>
    public interface IAppDataFolderRoot : ISingletonDependency
    {
        /// <summary>
        /// Virtual path of root ("~/App_Data")
        /// </summary>
        string RootPath { get; }

        /// <summary>
        /// Physical path of root (typically: MapPath(RootPath))
        /// </summary>
        string RootFolder { get; }
    }

    public class AppDataFolderRoot : IAppDataFolderRoot
    {
        public string RootPath
        {
            get { return "~/App_Data"; }
        }

        public string RootFolder
        {
            get { return HostingEnvironment.MapPath(RootPath); }
        }
    }
}