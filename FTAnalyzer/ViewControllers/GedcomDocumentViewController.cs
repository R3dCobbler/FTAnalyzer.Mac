﻿using System;

using AppKit;
using Foundation;
using FTAnalyzer.Utilities;

namespace FTAnalyzer
{
    public partial class GedcomDocumentViewController : NSViewController
    {
        AppDelegate App => (AppDelegate)NSApplication.SharedApplication.Delegate;

        public IProgress<string> Messages { get; private set; }
        public IProgress<int> Sources { get; private set; }
        public IProgress<int> Individuals { get; private set; }
        public IProgress<int> Families { get; private set; }
        public IProgress<int> Relationships { get; private set; }

        public GedcomDocumentViewController(IntPtr handle) : base(handle)
        {
            Messages = new Progress<string>(AppendMessage);
            Sources = new Progress<int>(percent => SetProgress(_sourcesProgress, percent));
            Individuals = new Progress<int>(percent => SetProgress(_individualsProgress, percent));
            Families = new Progress<int>(percent => SetProgress(_familiesProgress, percent));
        	Relationships = new Progress<int>(percent => SetProgress(_relationshipsProgress, percent));
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Do any additional setup after loading the view.
            _titleLabel.Font = NSFont.FromFontName("Kunstler Script", 72.0f);
            AppendMessage("Use the File menu to open a GEDCOM file copy of your tree. See website documentation on how to generate a GEDCOM if you are unsure.\n\n");
        }

        #region Computed Properties
        /// <summary>
        /// Returns the delegate of the current running application
        /// </summary>
        /// <value>The this app.</value>
        public AppDelegate ThisApp => (AppDelegate)NSApplication.SharedApplication.Delegate;
        #endregion

        public override NSObject RepresentedObject => base.RepresentedObject;

        public void ClearAllProgress()
        {
            if (!NSThread.IsMain)
            {
                InvokeOnMainThread(ClearAllProgress);
                return;
            }
            _statusTextView.Value = string.Empty;
            _sourcesProgress.DoubleValue = 0;
            _individualsProgress.DoubleValue = 0;
            _familiesProgress.DoubleValue = 0;
            _relationshipsProgress.DoubleValue = 0;
            //Messages.Report(string.Empty);
            //Sources.Report(0);
            //Individuals.Report(0);
            //Families.Report(0);
            //Relationships.Report(0);
        }

        void AppendMessage(string message)
        {
            if (!NSThread.IsMain)
            {
                InvokeOnMainThread(() => AppendMessage(message));
                return;
            }
            if (_statusTextView.Value == null)
                _statusTextView.Value = message;
            else
                _statusTextView.Value += message;
        }

        void SetProgress(NSProgressIndicator progressBar, int percent)
        {
            if (!NSThread.IsMain)
            {
                InvokeOnMainThread(() => SetProgress(progressBar, percent));
                return;
            }
            progressBar.DoubleValue = percent;
        }
    }
}
