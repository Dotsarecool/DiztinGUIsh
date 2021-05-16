﻿using System;
using System.Collections.Generic;
using Diz.Controllers.controllers;
using Diz.Core.util;

namespace Diz.Controllers.interfaces
{
    public interface IViewer
    {

    }

    public interface IFormViewer : IViewer, ICloseHandler
    {

    }

    public interface ICloseable
    {
        void Close();
    }

    public interface IModalDialog
    {
        /// <summary>
        /// Show the dialog to the user and wait for them to complete
        /// the steps on the view
        /// </summary>
        /// <returns>True if steps were completed and we have a valid result</returns>
        bool PromptDialog();
    }
    
    public interface IProgressView : ICloseable, IModalDialog, IProgress<int> {
        public bool IsMarquee { get; set; }
        public string TextOverride { get; set; }
        bool Visible { get; set; }
        
        /// <summary>
        /// Signal that a job (potentially running in another task/thread) has completed.
        /// CAUTION: Implementers should use thread-safety measures, this may be called
        /// from a different thread than any other calls 
        /// </summary>
        void SignalJobIsDone();
    }

    public interface IMarkManyView : IViewer, IModalDialog
    {
        int Property { get; }
        int Column { set; } // TODO: make enum with different types supported.
        object GetFinalValue();
    }

    public interface IBytesGridViewer<TByteItem> : IViewer
    {
        // get the number base that will be used to display certain items in the grid
        public Util.NumberBase NumberBaseToShow { get; }
        TByteItem SelectedByteOffset { get; }
        public List<TByteItem> DataSource { get; set; }
        int TargetNumberOfRowsToShow { get; }

        void SelectRow(int row);
        

        void BeginEditingSelectionComment();
        void BeginEditingSelectionLabel();
        
        public class SelectedOffsetChangedEventArgs : EventArgs
        {
            public TByteItem Row { get; init; }
            public int RowIndex { get; init; }
        }

        public delegate void SelectedOffsetChange(object sender, SelectedOffsetChangedEventArgs e);

        public event SelectedOffsetChange SelectedOffsetChanged;
    }
    
    public interface ILabelEditorView
    {
        string PromptForCsvFilename();
        void RepopulateFromData();
        void ShowLineItemError(string exMessage, int errLine);
    }
    
    
    public interface IImportRomDialogView
    {
        bool PromptToConfirmAction(string msg);
        bool ShowAndWaitForUserToConfirmSettings();
        ImportRomDialogController Controller { get; set; }
        bool GetVectorValue(int i, int j);
        void RefreshUi();
    }
    
    public interface IDataGridEditorForm : IFormViewer, IProjectView
    {
        
    }
}