using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Bilbana.Annotations;

namespace Bilbana.BaseClasses
{
	public abstract class ViewModelBase:INotifyPropertyChanged, IDisposable
	{
		public string  DisplayName { get; set; }
		public event PropertyChangedEventHandler PropertyChanged;
		private bool ThrowOnInvalidPropertyName { get; set; }

		protected virtual void OnPropertyChanged(string propertyName)
		{
			VerifyPropertyName(propertyName); 
			var handler = PropertyChanged;
			if (handler == null) 
				return;

			var e = new PropertyChangedEventArgs(propertyName); 
			handler(this, e);
		} 
		
		[Conditional("DEBUG")] 
		[DebuggerStepThrough]
		private void VerifyPropertyName(string propertyName) 
		{ 
			// Verify that the property name matches a real, 
			// public, instance property on this object. 
			if (TypeDescriptor.GetProperties(this)[propertyName] == null)
			{
				var msg = "Invalid property name: " + propertyName; 
				if (ThrowOnInvalidPropertyName) 
					throw new Exception(msg);
				Debug.Fail(msg);
			} 
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}