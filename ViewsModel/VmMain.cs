using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KHSortGUI.ViewsModel
{
	internal class VmMain : Base.ViewModel
	{
		private const string TEST = "sdasds";



		#region Заголовок окна
		///<summary>Заголовок окна</summary>
		private string _title = TEST;
		public string Title
		{
			get => _title;
			set => Set(ref _title, value);
		}
		#endregion
	}
}
