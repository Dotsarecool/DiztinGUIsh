﻿using System;
using Diz.Core.model;
using Diz.Core.util;
using Equin.ApplicationFramework;

namespace DiztinGUIsh.window2
{
    public interface IViewer
    {

    }

    public interface IFormViewer : IViewer
    {
        public event EventHandler Closed;
    }
    
    public interface IBytesGridViewer<TByteItem> : IViewer
    {
        // get the number base that will be used to display certain items in the grid
        public Util.NumberBase DataGridNumberBase { get; }
        TByteItem SelectedRomByteRow { get; }
        public BindingListView<TByteItem> DataSource { get; set; }
    }

    public interface IBytesFormViewer : IFormViewer
    {

    }
    
    
    
    // --------------------------------
    
    
    

    public interface IController
    {
        IViewer View { get; }

        public event EventHandler Closed;
    }

    public interface IDataController : IController
    {
        Data Data { get; }
    }
    
    public interface IBytesGridViewerDataController<TByteItem> : IDataController
    {
        IBytesGridViewer<TByteItem> ViewGrid { get; set; }
    }
}