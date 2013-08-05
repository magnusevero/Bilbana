using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bilbana.Annotations;

namespace Bilbana.BaseClasses
{
	public abstract class ViewModelBase:INotifyPropertyChanged, IDisposable
	{
		public string  DisplayName { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}