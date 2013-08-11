﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using JSNet;

namespace SkypeFx
{
    class Program
    {
        bool customerFeedbackOptIn = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program p = new Program();
            p.Run();
            RITeardown();   
        }

        public void Run()
        {
            customerFeedbackOptIn = Properties.Settings.Default.CustomerFeedbackOptIn;
            RISetup();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Compose();
            Application.Run(MainWindow);
        }
        
        /// <summary>
        /// use managed extensibility framework to discover effects and load them into the main form
        /// </summary>
        private void Compose()
        {
            var catalog = new AggregatingComposablePartCatalog();
            var mainAssemblyCatalog = new AttributedAssemblyPartCatalog(this.GetType().Assembly);
            var jsNetCatalog = new AttributedAssemblyPartCatalog(typeof(Effect).Assembly);            
            //var addInEffects = new DirectoryPartCatalog("Effects"); 

            catalog.Catalogs.Add(mainAssemblyCatalog);
            catalog.Catalogs.Add(jsNetCatalog);
            //catalog.Catalogs.Add(addInEffects);
            var container = new CompositionContainer(catalog);
            
            container.AddPart(this);
            container.Compose();
        }

        [Import(typeof(MainForm))]
        public Form MainWindow { get; set; }

        private void RISetup()
        {
        }

        private static void RITeardown()
        {
        }

    }
}
