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

namespace Scenario4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("d78c6dd1-424e-48f3-b103-8afdb5cff978", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Scenario4Repository repository.
        /// </summary>
        public static Scenario4Repository repo = Scenario4Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            NewVariable = "trendyol.com";
            NewVariable1 = "trendyol.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewVariable;

        /// <summary>
        /// Gets or sets the value of variable NewVariable.
        /// </summary>
        [TestVariable("f3c18ffb-6982-4003-9171-2e71f30f3551")]
        public string NewVariable
        {
            get { return _NewVariable; }
            set { _NewVariable = value; }
        }

        string _NewVariable1;

        /// <summary>
        /// Gets or sets the value of variable NewVariable1.
        /// </summary>
        [TestVariable("9d66b7f4-27df-4da4-bf21-2f4130ac4e66")]
        public string NewVariable1
        {
            get { return _NewVariable1; }
            set { _NewVariable1 = value; }
        }

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
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Text' at 38;18.", repo.ApplicationUnderTest.TextInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Text.Click("38;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'nk3285507' with focus on 'ApplicationUnderTest.Text'.", repo.ApplicationUnderTest.TextInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Text.PressKeys("nk3285507");
            Delay.Milliseconds(16010);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SearchIcon' at 9;9.", repo.ApplicationUnderTest.SearchIconInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.SearchIcon.Click("9;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 101;4.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.SepeteEkle.Click("101;4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.DivTag1'.", repo.ApplicationUnderTest.DivTag1Info, new RecordItemIndex(4));
            Validate.Exists(repo.ApplicationUnderTest.DivTag1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SepeteEkle' at 112;8.", repo.ApplicationUnderTest.SepeteEkleInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.SepeteEkle.Click("112;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.DivTag2'.", repo.ApplicationUnderTest.DivTag2Info, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.DivTag2Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}