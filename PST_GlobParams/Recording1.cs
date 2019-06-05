﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PST_GlobParams
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("5cda1aa1-8d72-4dc1-a54a-32319e0e9952", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PST_GlobParamsRepository repository.
        /// </summary>
        public static PST_GlobParamsRepository repo = PST_GlobParamsRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Recording1_Open_browser();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EdgewordsShopECommerceDemoSiteFor.InputTagS' at 62;19.", repo.EdgewordsShopECommerceDemoSiteFor.InputTagSInfo, new RecordItemIndex(1));
            repo.EdgewordsShopECommerceDemoSiteFor.InputTagS.Click("62;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'cap{Return}' with focus on 'EdgewordsShopECommerceDemoSiteFor.InputTagS'.", repo.EdgewordsShopECommerceDemoSiteFor.InputTagSInfo, new RecordItemIndex(2));
            repo.EdgewordsShopECommerceDemoSiteFor.InputTagS.PressKeys("cap{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'EdgewordsShopECommerceDemoSiteFor'.", repo.EdgewordsShopECommerceDemoSiteFor.SelfInfo, new RecordItemIndex(3));
            Host.Current.CloseApplication(repo.EdgewordsShopECommerceDemoSiteFor.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Test Complete", new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
