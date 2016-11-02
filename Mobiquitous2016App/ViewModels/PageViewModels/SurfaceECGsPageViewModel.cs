﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Livet;
using Livet.Commands;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.EventListeners;
using Livet.Messaging.Windows;

using Mobiquitous2016App.Models;
using Mobiquitous2016App.Models.GraphModels;
using Mobiquitous2016App.ViewModels.WindowViewModels;

namespace Mobiquitous2016App.ViewModels.PageViewModels
{
    // ReSharper disable once InconsistentNaming
    public class SurfaceECGsPageViewModel : ViewModel
    {
        private readonly GraphWindowViewModel _parentViewModel;

        #region GraphData変更通知プロパティ
        private IList<GraphDatum> _GraphData;

        public IList<GraphDatum> GraphData
        {
            get
            { return _GraphData; }
            set
            {
                if (_GraphData == value)
                    return;
                _GraphData = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        public SurfaceECGsPageViewModel(GraphWindowViewModel parentViewModel)
        {
            _parentViewModel = parentViewModel;
        }

        public void Initialize()
        {
            GraphData = _parentViewModel.GraphDataList;
        }
    }
}