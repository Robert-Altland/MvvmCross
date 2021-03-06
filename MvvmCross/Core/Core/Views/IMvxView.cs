// IMvxView.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Core;

namespace MvvmCross.Core.Views
{
    public interface IMvxView
        : IMvxDataConsumer
    {
        IMvxViewModel ViewModel { get; set; }
    }

    public interface IMvxView<TViewModel>
        : IMvxView where TViewModel : class, IMvxViewModel
    {
        new TViewModel ViewModel { get; set; }
    }
}