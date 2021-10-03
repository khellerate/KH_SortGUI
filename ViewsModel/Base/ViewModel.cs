using System;
using System.ComponentModel;

namespace KHSortGUI.ViewsModel.Base
{
	internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
	{
		#region Назначение свойств
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string property = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}

		protected virtual bool Set<T>(ref T field, T value, string property = null)
		{
			if (Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(property);
			return true;
		}
		#endregion

		#region Диструктор
		public void Dispose()
		{
			Dispose(true);
		}

		private bool _disposed;
		protected virtual void Dispose(bool disposing)
		{
			if (!disposing || _disposed) return;
			_disposed = true;
			//Тут освобождаем ресурсы
		}
		#endregion
	}
}
